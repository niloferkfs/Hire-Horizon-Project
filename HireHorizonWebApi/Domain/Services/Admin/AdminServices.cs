using AutoMapper;
using Domain.Helpers;
using Domain.Models;
using Domain.Service.Admin.Interfaces;
using Domain.Service.Job.DTOs;
using Domain.Service.Profile.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Service.Admin.DTOs;
using Domain.Services.Admin.DTOs;

namespace Domain.Service.Admin
{
    public class AdminServices : IAdminServices
    {
        private readonly IAdminRepository adminRepository;
        IMapper mapper;

        public AdminServices(IAdminRepository adminRepository, IMapper mapper)
        {
            this.adminRepository = adminRepository;
            this.mapper = mapper;
        }

        public Task<CategoryDto> AddCategory(CategoryDto category)
        {
            throw new NotImplementedException();
        }

        public Task<IndustryDto> AddIndustry(IndustryDto industry)
        {
            throw new NotImplementedException();
        }

        public Task<LocationDto> AddLocation(LocationDto location)
        {
            throw new NotImplementedException();
        }

        public Task<PostedSkillDTO> AddSkill(PostedSkillDTO skill)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCategoryById(Guid CategoryId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteIndustryById(Guid IndustryId)
        {
            throw new NotImplementedException();
        }

        public void DeleteLocationById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSkill(Guid skillId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Joblist>> GetAllJobs()
        {
            throw new NotImplementedException();
        }

        public Task<List<JobProviderCompany>> GetCompanies()
        {
            throw new NotImplementedException();
        }

        public int GetCompanyCount()
        {
            throw new NotImplementedException();
        }

        public int GetJobCount()
        {
            throw new NotImplementedException();
        }

        public int GetJobProviderCount()
        {
            throw new NotImplementedException();
        }

        public Task<List<JobSeekerDto>> GetJobSeekers()
        {
            throw new NotImplementedException();
        }

        public Task<List<LocationDto>> GetLocations()
        {
            throw new NotImplementedException();
        }

        public Task<List<JobProviderCompany>> SearchCompanies(string name)
        {
            throw new NotImplementedException();
        }
    }
}
