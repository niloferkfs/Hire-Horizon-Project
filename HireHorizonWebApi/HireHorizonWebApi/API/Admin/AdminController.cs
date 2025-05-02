using AutoMapper;
using Domain.Service.Admin.DTOs;
using Domain.Service.Admin.Interfaces;
using Domain.Services.Admin.DTOs;
using Domain.Services.Login.Interface;
using HireHorizonAPI.API.Admin.RequestObjects;
using HireHorizonWebApi.API.Admin.RequestObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HireHorizonAPI.API.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {

        private readonly IAdminServices adminServices;
        private readonly IMapper mapper;
        private readonly IAdminLoginService adminLoginService;

        public AdminController(IAdminServices adminServices, IMapper mapper, IAdminLoginService adminLoginService)
        {
            this.adminServices = adminServices;
            this.mapper = mapper;
            this.adminLoginService = adminLoginService;
        }

        [HttpPost]
        [Route("Admin/Login")]
       
        public async Task<ActionResult> Login(AdminLoginRequest loginData)
        {
            var user = adminLoginService.Adminlogin(loginData.Email, loginData.Password);

            if(user == null)
            {
                return BadRequest("Login Failed");
            }

            return Ok(user);
        }

        [HttpGet]
        [Route("admin/GetJobSeekers")]
        //[Authorize(Roles = "ADMIN")]
        public async Task<IActionResult> GetJobSeekers()
        {
            try
            {
                var jobSeekers = await adminServices.GetJobSeekers();

                return Ok(jobSeekers);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("skillAdd")]
        //[Authorize(Roles = "ADMIN")]
        public async Task<IActionResult> AddSkill(AddSkillRequest skill)
        {
            
            var Skill = mapper.Map<PostedSkillDTO>(skill);

           
            var result = await adminServices.AddSkill(Skill);

            if (result==null)
            {
                return BadRequest("Skill already exists");
            }
            else
            {

                return Ok(result);
            }
        }

        [HttpDelete("skillRemove/{skillId}")]
        //[Authorize(Roles = "ADMIN")]
        
        public async Task<IActionResult> RemoveSkill(Guid skillId)
        {
           
            var result = await adminServices.DeleteSkill(skillId);

            if (result)
            {
                return Ok("Skill deleted successfully");
            }
            else
            {
                return NotFound("Skill not found or failed to delete");
            }
        }

        [HttpGet]
        [Route("admin/GetCompanies")]
        //[Authorize(Roles = "ADMIN")]
        public async Task<IActionResult> GetCompanies()
        {

            try
            {
                var jobProviders = await adminServices.GetCompanies();
                return Ok(mapper.Map<List<JobProviderDto>>(jobProviders));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpGet]
        [Route("admin/SearchCompanies")]
        //[Authorize(Roles = "ADMIN")]
        public async Task<IActionResult> SearchCompanies(string name)
        {
            try
            {
                var companies = await adminServices.SearchCompanies(name);
                return Ok(mapper.Map<List<JobProviderDto>>(companies));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpGet]
        [Route("admin/jobsbyTitle")]
        //[Authorize(Roles = "ADMIN")]
        public async Task<IActionResult> GetjobsbyTitle(string Title)
        {

            try
            {
                var jobs = await adminServices.GetJobsByTitle(Title);
                return Ok(jobs);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpGet]
        [Route("Alljobs")]
        public async Task<IActionResult> GetAlljobs()
        {

            try
            {
                var jobs = await adminServices.GetAllJobs();
                return Ok(jobs);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }





        [HttpGet]
        [Route("admin/GetJobProviderCount")]
        //[Authorize(Roles = "ADMIN")]
        public IActionResult GetJobProviderCount()
        {
            try
            {
                var count = adminServices.GetJobProviderCount();
                return Ok(new { Count = count });
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpGet]
        [Route("admin/GetJobCount")]
        //[Authorize(Roles = "ADMIN")]
        public IActionResult GetJobCount()
        {
            try
            {
                var count = adminServices.GetJobCount();
                return Ok(new { Count = count });
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }


       [HttpPost("AddLocation")]
        //[Authorize(Roles = "ADMIN")]
        public async Task<IActionResult> AddLocation(LocationRequest location)
        {
            var Location = mapper.Map<LocationDto>(location);
            var result = await adminServices.AddLocation(Location);

            return Ok(result);
        }

        [HttpPost("AddCategory")]
        //[Authorize(Roles = "ADMIN")]

        public async Task<IActionResult> AddCategory(CategoryRequest category)
        {
            var Categorydto = mapper.Map<CategoryDto>(category);
            var result = await adminServices.AddCategory(Categorydto);

            return Ok(result);
        }

        [HttpPost("AddIndustry")]
        //[Authorize(Roles = "ADMIN")]
        public async Task<IActionResult> AddIndustry(IndustryRequest industry)
        {
            var Industrydto = mapper.Map<IndustryDto>(industry);
            var result = await adminServices.AddIndustry(Industrydto);

            return Ok(result);
        }

        [HttpDelete("RemoveLocation/{LocationId}")]
        public async Task<IActionResult> RemoveLocation(Guid LocationId)
        {

            var result = await adminServices.DeleteLocationById(LocationId);

            if (result)
            {
                return Ok("Location deleted successfully");
            }
            else
            {
                return NotFound("Location not found or failed to delete");
            }
        }

        [HttpDelete("RemoveCategory/{CategoryId}")]
        //[Authorize(Roles = "ADMIN")]
        public async Task<IActionResult> RemoveCategory(Guid CategoryId)
        {

            var result = await adminServices.DeleteCategoryById(CategoryId);

            if (result)
            {
                return Ok("Category deleted successfully");
            }
            else
            {
                return NotFound("Category not found or failed to delete");
            }
        }

        [HttpDelete("RemoveIndustry/{IndustryId}")]
        //[Authorize(Roles = "ADMIN")]
        public async Task<IActionResult> RemoveIndustry(Guid IndustryId)
        {

            var result = await adminServices.DeleteIndustryById(IndustryId);

            if (result)
            {
                return Ok("Industry deleted successfully");
            }
            else
            {
                return NotFound("Industry not found or failed to delete");
            }
        }





        [HttpGet("GetLocations")]
        //[Authorize(Roles = "ADMIN")]
        public async Task<IActionResult> GetLocations()
        {

            try
            {
                var locations = await adminServices.GetLocations();
                return Ok(mapper.Map<List<LocationDto>>(locations));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }


       
    }
}
