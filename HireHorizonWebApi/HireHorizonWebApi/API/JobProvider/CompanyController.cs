using AutoMapper;
using Domain.Helpers;
using Domain.Service.Authuser.Interfaces;
using Domain.Service.JobProvider.Dtos;
using Domain.Service.JobProvider.DTOs;
using Domain.Services.JobProvider;
using Domain.Services.JobProvider.Interfaces;
using HireHorizonWebApi.API.JobProvider.RequestObjects;
using HireHorizonWebApi.API.JobProvider.RequestObjects;
using HireHorizonWebApi.API.JobProvider.RequestObjects;
using HireHorizonWebApi.API.JobProvider.RequestObjects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HireHorizonWebApi.API.JobProvider
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "JOBPROVIDER")]
    public class CompanyController : ControllerBase
    {
        public CompanyController(IMapper _mapper, ICompanyService _companyService, IAuthUserService _authUserService)
        {
            mapper = _mapper;
            companyService = _companyService;
            authUserService = _authUserService;
        }

        public IMapper mapper { get; set; }
        public ICompanyService companyService { get; set; }
        public IAuthUserService authUserService { get; set; }

        [HttpPost]
        [Route("job-provider/{jobproviderId}/company")]

        public async Task<ActionResult> AddCompany(Guid jobproviderId, AddCompanyRequest data)
        {
            var UserId = authUserService.GetUserId();
            var companyRegistrationDtos = mapper.Map<CompanyRegistrationDtos>(data);

            var company = await companyService.AddCompany(companyRegistrationDtos, new Guid(UserId));
            return Ok(company);

        }

        [AllowAnonymous]
        [HttpGet]
        [Route("job-provider/company/{companyId}")]
        public async Task<ActionResult> getCompany(Guid companyId)
        {
            var company = companyService.GetCompany(companyId);
            if (company == null)
            {
                return BadRequest("Company Not found");

            }
            else
            {
                return Ok(company);
            }


        }
        [AllowAnonymous]
        [HttpPut]
        [Route("job-provider/company/{companyId}")]
        public async Task<ActionResult> UpdateCompany(Guid companyId, CompanyupdateRequest comapny)
        {
            if (companyId == null)
            {
                return BadRequest("Id is Required");
            }
            comapny.Id = companyId;
            var companyUpdateDtos = mapper.Map<CompanyUpdateDtos>(comapny);
            var updatedCompany = await companyService.UpdateAsync(companyUpdateDtos);
           
            if (updatedCompany == null)
            {
                return BadRequest("Company Not found");

            }
            else
            {
                return Ok(updatedCompany);
            }

        }


        [AllowAnonymous]
        [HttpPost]
        [Route("job-provider/company/{companyId}/addcompanymember")]
        public async Task<ActionResult> AddCompanyMember(AddCompanyUserRequest request, Guid companyId)
        {
            try
            {
                var companyMemberDtos = mapper.Map<CompanyMemberDtos>(request);
                var member = await companyService.addMember(companyMemberDtos, companyId);
                return Ok(member);
            }
            catch (Exception exe)
            {
                return BadRequest(exe.Message);
            }
        }

        

        [AllowAnonymous]
        [HttpGet]
        [Route("job-provider/company/{companyId}/listcompanymember")]
        public async Task<ActionResult> ListCompanyMember(Guid companyId, [FromQuery] CompanyMemberListParam param)

        {

            if (companyId == null)
            {
                return BadRequest("Id is Required");
            }

            var CompanyMembers = await companyService.memberListing(companyId, param);

            PagedList<CompanyMemberListDtos> companyMemberList = mapper.Map<PagedList<CompanyMemberListDtos>>(CompanyMembers);
            if (CompanyMembers == null)
            {
                return BadRequest("No Company Members");

            }
            else
            {
                return Ok(CompanyMembers);
            }

        }
        [AllowAnonymous]
        [HttpDelete]
        [Route("job-provider/company/{companyMemberId}/RemoveCompanyMember")]
        public IActionResult memberDelete(Guid companyMemberId)
        {
            var result = companyService.memberDeleteById(companyMemberId);
            if (result == true)
            {
                return Ok("Success fully remove the companyMember");

            }
            else
            {
                return BadRequest();
            }
        }


    }
}
