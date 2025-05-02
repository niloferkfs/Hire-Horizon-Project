using AutoMapper;
using Domain.Models;
using Domain.Service.Job.DTOs;
using Domain.Service.JobProvider.DTOs;
using Domain.Service.SignUp.DTOs;
using Domain.Services.JobProvider.Interfaces;
using Domain.Services.Login.Interface;
using HireHorizonWebApi.API.JobProvider.RequestObjects;
using HireHorizonWebApi.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HireHorizonAPI.API.JobProvider
{
    //[Route("api/[controller]")]
    [ApiController]
   
        public class JobProviderController : BaseApiController<JobProviderController>
        {
            private readonly IJobProviderService _jobProviderService;
            private readonly IMapper _mapper;
            IJobProviderRepository _jobrepository;

            public IJobProviderLoginService _jobproviderloginservice { get; set; }
            public JobProviderController(IJobProviderService jobProviderService, IMapper mapper, IJobProviderRepository jobrepository, IJobProviderLoginService loginService)
            {
                _jobProviderService = jobProviderService;
                _mapper = mapper;
                _jobrepository = jobrepository;
                _jobproviderloginservice = loginService;
            }
            [HttpPost]
            [Route("job-provider/signup")]
            [AllowAnonymous]

            public async Task<ActionResult> createJobProviderSignupRequest(JobProviderSignUpRequest data)
            {
                var jobprovidersignupRequestDto = _mapper.Map<JobProviderSignupRequestDto>(data);
                _jobProviderService.CreateSignupRequest(jobprovidersignupRequestDto);
                return Ok(data);
            }

            [HttpGet]
            [Route("job-provider/signup/{sighupRequestId}/verify-email")]
            [AllowAnonymous]
            public async Task<ActionResult> VerifyJobProviderEmail(Guid sighupRequestId)
            {
                var isVerified = await _jobProviderService.VerifyEmailAsync(sighupRequestId);
                if (isVerified)
                {
                    return Ok();
                }
                return BadRequest();
            }

            [HttpPost]
            [Route("job-provider/signup/{jobProviderSighupRequestId}/set-password")]
            [AllowAnonymous]
            public async Task<ActionResult> createJobProviderSignupRequest(Guid jobProviderSighupRequestId, [FromBody] string password)
            {
                await _jobProviderService.CreateJobProvider(jobProviderSighupRequestId, password);
                return Ok("Password Set Sucessfully");
            }

            [AllowAnonymous]
            [HttpPost]
            [Route("job-provider/login")]
            public async Task<ActionResult> Login(JobProviderLoginRequest logdata)
            {
                var user = _jobproviderloginservice.login(logdata.Email, logdata.Password);
                if (user == null)
                {
                    return BadRequest("Login Failed");
                }
                return Ok(user);
            }

            [AllowAnonymous]
            [HttpGet]
            [Route("company/companyId")]
            public async Task<ActionResult> GetAllJobs(Guid companyId)
            {
                try
                {
                    List<JobPost> jobPosts = await _jobProviderService.GetJobs(companyId);
                    return Ok(_mapper.Map<List<JobPostsDtos>>(jobPosts));
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            [AllowAnonymous]
            [HttpGet]
            [Route("company/{companyId}/job-provider/{jobproviderId}/job")]
            public async Task<IActionResult> GetAllJobsByProvider(Guid companyId, Guid jobproviderId)
            {
                try
                {
                    List<JobPost> jobposts = await _jobProviderService.GetAllJobsByProvider(companyId, jobproviderId);
                    return Ok(_mapper.Map<List<JobPostsDtos>>(jobposts));
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }

            [AllowAnonymous]
            [HttpPost]
            [Route("company/{companyId}/job-provider/{jobproviderId}/job")]
            public async Task<IActionResult> PostJob(JobPostRequest request)
            {
                var job = _mapper.Map<JobPost>(request);
                Guid id = await _jobProviderService.PostJob(job);
                return Ok("The job id for the posted job is" + id);
            }
            [AllowAnonymous]
            [HttpPut]
            [Route("company/{companyId}/job-provider/{jobproviderId}/job/{id}")]
            public async Task<IActionResult> UpdateJob(JobPostRequest request, Guid id)
            {
                try
                {
                    var job = _mapper.Map<JobPost>(request);
                    var jobupdated = await _jobProviderService.Update(job, id);
                    return Ok(request);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }

            }
            [AllowAnonymous]
            [HttpDelete]
            [Route("company/{companyId}/job-provider/{jobproviderId}/job/{id}")]
            public async Task<IActionResult> DeleteJob(Guid id)
            {
                try
                {
                    _jobProviderService.DeleteJob(id);
                    return NoContent();
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            [AllowAnonymous]
            [HttpGet]
            [Route("job-provider/{jobproviderId}/getJobApplicants")]
            public async Task<IActionResult> GetAllJobApplicants(Guid jobproviderId)
            {
                try
                {
                    List<JobApplication> jobapplications = await _jobProviderService.GetAllJobApplicants(jobproviderId);
                    return Ok(_mapper.Map<List<JobApplicationDto>>(jobapplications));

                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            [AllowAnonymous]
            [HttpGet]
            [Route("job-provider/{jobproviderId}/getCompany")]
            public async Task<IActionResult> GetCompany(Guid jobproviderId)
            {
                try
                {
                    List<JobProviderCompany> jobapplications = await _jobProviderService.GetCompany(jobproviderId);
                    return Ok(_mapper.Map<List<Domain.Service.Admin.DTOs.JobProviderDto>>(jobapplications));
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }

        }
    }
