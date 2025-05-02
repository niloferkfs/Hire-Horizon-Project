using Domain.Helpers;
using Domain.Models;
using Domain.Service.Profile.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Service.Admin.DTOs;
using Domain.Services.Admin.DTOs;

namespace Domain.Service.Admin.Interfaces
{
    public interface IAdminServices
    {
        public Task<List<JobSeekerDto>> GetJobSeekers();

        public Task<List<JobProviderCompany>> GetCompanies();

        public Task<List<Joblist>> GetAllJobs();

        public Task<List<LocationDto>> GetLocations();

        public Task<LocationDto> AddLocation(LocationDto location);

        public Task<bool> DeleteLocationById(Guid id);

        public Task<PostedSkillDTO> AddSkill(PostedSkillDTO skill);

        public Task<bool> DeleteSkill(Guid skillId);

        public Task<CategoryDto> AddCategory(CategoryDto category);

        public Task<bool> DeleteCategoryById(Guid CategoryId);
        public Task<IndustryDto> AddIndustry(IndustryDto industry);
        public Task<bool> DeleteIndustryById(Guid IndustryId);

        public int GetJobProviderCount();
        public int GetCompanyCount();
        public int GetJobCount();

        public Task<List<Joblist>> GetJobsByTitle(string JobTitle);

        public Task<List<JobProviderCompany>> SearchCompanies(string name);


    }

}
