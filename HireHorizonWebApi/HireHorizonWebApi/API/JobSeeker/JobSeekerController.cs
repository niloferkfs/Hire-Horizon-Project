using AutoMapper;
using Domain.Service.Authuser.DTOs;
using Domain.Service.Job.DTOs;
using Domain.Service.JobSeekers;
using Domain.Service.JobSeekers.DTOs;
using Domain.Service.JobSeekers.Interfaces;
using Domain.Service.Profile.DTOs;
using Domain.Service.Profile.Interface;
using Domain.Service.SignUp.DTOs;
using Domain.Services.Job.DTOs;
using Domain.Services.Job.Interfaces;
using Domain.Services.JobSeekers.DTOs;
using Domain.Services.Login.Interface;
using Domain.Services.SignUp;
using Domain.Services.SignUp.Interface;
using HireHorizonAPI.API.JobSeeker.RequestObjects;
using HireHorizonWebApi.API.JobSeeker.RequestObjects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HireHorizonAPI.API.JobSeeker
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobSeekerController : ControllerBase
    {
        public IJobseekerSignupService _signupservice { get; set; }
        public IJobSeekerLoginService _loginService { get; set; }
        public IMapper _mapper { get; set; }

        public readonly IJobSeekerProfileService _profileService;

        public readonly IJobseekerJobService _jobservice;

        public readonly IJobSeeekerService _resumeservice;

        public JobSeekerController(IJobseekerSignupService signupservice, IJobSeekerLoginService loginService, IMapper mapper, IJobSeekerProfileService profileService, IJobseekerJobService jobservice, IJobSeeekerService resumeservice)
        {
            _signupservice = signupservice;
            _loginService = loginService;
            _mapper = mapper;
            _profileService = profileService;
            _jobservice = jobservice;
            _resumeservice = resumeservice;
        }

        [HttpPost]
        [Route("Jobseeker/SignUp")]
        public async Task<ActionResult> CreateJobSeekerSignUpRequest(JobSeekerSignUpRequest data)
        {
            var jobseekerrequest = _mapper.Map<JobSeekerSignupRequestDto>(data);
            _signupservice.CreateSignupRequest(jobseekerrequest);
            return Ok(jobseekerrequest);
        }

        [HttpGet]
        [Route("Jobseeker/SignUp/{jobSeekerSignupRequestId}/Verify-Email")]
        public async Task<ActionResult> VerifyJobSeekerEmail(Guid jobSeekerSignupRequestId)
        {
            var verify = await _signupservice.VerifyEmailAsync(jobSeekerSignupRequestId);
            if (verify)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost]
        [Route("Jobseeker/SignUp/{jobSeekerSignupRequestId}/Set-Password")]
        public async Task<ActionResult> createJobSeekerSignupRequest(Guid jobSeekerSignupRequestId, [FromBody] string password)
        {
            await _signupservice.CreateJobseeker(jobSeekerSignupRequestId,password);
            return Ok("Password Set Successfully");
        }

        [HttpPost]
        [Route("JobSeeker/Login")]
        public async Task<ActionResult> Login(JobSeekerLoginRequest data)
        {
            var user=_loginService.Login(data.Email,data.Password);
            if(user == null)
            {
                return BadRequest("Login Failed!!");
            }
            return Ok(user);
        }


        [HttpPost]
        [Route("Jobseeker/AddProfile")]
        [Authorize(Roles = "JOBSEEKER")]
        public async Task<IActionResult> AddProfile([FromBody] ProfileDTO profiledto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var result=await _profileService.AddProfileAsync(profiledto);
            return Ok("profile added successfully");
        }

        [HttpPost]
        [Route("Jobseeker/AddQualification")]
        [Authorize(Roles = "JOBSEEKER")]
        public async Task<IActionResult> AddQualificationProfile(Guid jobseekerId, Guid profileId, [FromBody] JobseekerQualificationDTo qualificationDto)
        {
            try
            {
                await _profileService.AddQualificationToProfileAsync(jobseekerId, profileId, qualificationDto);
                return Ok("Qualification added");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }

        [HttpGet]
        [Route("Jobseeker/GetProfile/{jobseekerId}")]
        [Authorize(Roles = "JOBSEEKER")]
        public IActionResult GetProfile(Guid jobseekerId)
        {
            var profiles=_profileService.GetProfile(jobseekerId);
            return Ok(profiles);
        }

        [HttpGet]
        [Route("Jobseeker/GetQualification")]
        [Authorize(Roles = "JOBSEEKER")]

        public IActionResult GetQualifications(Guid profileId)
        {
            var qualifications = _profileService.GetQualification(profileId);
            return Ok(qualifications);
        }


        [HttpPut]
        [Route("Jobseeker/UpdateProfile")]
        [Authorize(Roles = "JOBSEEKER")]
        public async Task<IActionResult> UpdateProfile([FromBody] AuthUserDTO updatedProfile)
        {
            try
            {
                var result = await _profileService.UpdateJobSeekerProfile(updatedProfile);


                if (result != null)
                {
                    return Ok(result);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        //job
        [HttpPost]
        [Route("jobseeker/ApplyJob")]
        [Authorize(Roles = "JOBSEEKER")]
        public async Task<IActionResult> ApplyForJobs(ApplyJobRequest applyJobRequest)
        {
            var jobDto = _mapper.Map<ApplyJobDto>(applyJobRequest);
            return await _jobservice.ApplyForJobAsync(jobDto);
        }

        [HttpPost]
        [Route("jobseeker/SaveJob")]
        [Authorize(Roles = "JOBSEEKER")]
        public async Task<IActionResult> SaveJobs(SaveJobRequest saveJobRequest)
        {
            var job = _mapper.Map<SavedJobsDtos>(saveJobRequest);
            return await _jobservice.SavedJobAsync(job);
        }

        [HttpDelete]
        [Route("jobseeker/Remove SavedJobs")]
        [Authorize(Roles = "JOBSEEKER")]
        public async Task<IActionResult> RemoveSavedJobs([FromBody] SavedJobsDtos savedJobsDtos)
        {
            var result = await _jobservice.RemoveSavedJobAsync(savedJobsDtos);

            if (!result)
                return NotFound("Saved job not found!!");

            return Ok("Saved job removed successfully.");
        }


        [HttpDelete]
        [Route("jobseeker/Remove AppliedJobs")]
        [Authorize(Roles = "JOBSEEKER")]
        public async Task<IActionResult> RemoveAppliedJobs(RemoveJobApplicationRequest removeJobApplicationRequest)
        {
            var dto = _mapper.Map<ApplyJobDto>(removeJobApplicationRequest);
            var result = await _jobservice.RemoveAppliedJobAsync(dto);
            if (!result)
                return NotFound("Applied job not found.");

            return Ok("Applied job removed successfully.");
        }

        [HttpGet]
        [Route("jobseeker/GetAppliedJobs/{applicantid}")]
        [Authorize(Roles = "JOBSEEKER")]
        public async Task<IActionResult> GetAppliedJobs(Guid applicantid)
        {
            return Ok(await _jobservice.GetAppliedJobsAsync(applicantid));
        }

        [HttpGet]
        [Route("jobseeker/GetSavedJobs/{saveid}")]
        [Authorize(Roles = "JOBSEEKER")]
        public async Task<IActionResult> GetSavedJobs(Guid saveid)
        {
            return Ok(await _jobservice.GetSavedJobsAsync(saveid));
        }

        //[HttpPost]
        //[Route("jobseeker/AddResume")]
        //[Authorize(Roles = "JOBSEEKER")]
        //public async Task<IActionResult> AddNewResume([FromBody] resumeDto resumeDto)
        //{
        //    var resume=await _resumeservice.AddResumeAsync(resumeDto);
        //    return Ok(resume);
        //}
        [HttpPost]
        [Route("jobseeker/UploadResume")]
        [Authorize(Roles = "JOBSEEKER")]
        public async Task<IActionResult> UploadResume([FromForm] ResumeUploadRequest resumeRequest)
        {
     

            
            using var ms = new MemoryStream();
            await resumeRequest.File.CopyToAsync(ms);
            var fileBytes = ms.ToArray();

        
            var resumeDto = new resumeDto
            {
                Id = Guid.NewGuid(),
                Title = resumeRequest.Title,
                File = fileBytes
            };

           
            await _resumeservice.AddResumeAsync(resumeDto);
            return Ok("Resume uploaded successfully.");
        }
        //[HttpGet]
        //[Route("jobseeker/ViewResume")]
        //[Authorize(Roles = "JOBSEEKER")]
        //public async Task<IActionResult> GetResume(Guid id)
        //{
        //    var resume=await _resumeservice.GetResumeByIdAsync(id);
        //    if (resume == null) return NotFound("resume not found");

        //    return Ok(resume);
        //}
        [HttpGet]
        [Route("jobseeker/DownloadResume")]
        [Authorize(Roles = "JOBSEEKER")]
        public async Task<IActionResult> DownloadResume(Guid id)
        {
            var resume = await _resumeservice.GetResumeByIdAsync(id);
            if (resume == null) return NotFound("Resume not found");

            return File(resume.File, "application/octet-stream", $"{resume.Title}.pdf");
        }

        [HttpPost]
        [Route("jobseeker/AddWorkExperience")]
        [Authorize(Roles = "JOBSEEKER")]
        public async Task<IActionResult> AddWorkExperience([FromBody] WorkExperienceDto dto)
        {
            var success = await _resumeservice.AddWorkExperienceAsync(dto);
            if (!success)
                return BadRequest("Failed to add work experience.");

            return Ok("Work experience added successfully.");
        }

    }
}
