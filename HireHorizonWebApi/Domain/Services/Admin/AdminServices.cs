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

        public async Task<CategoryDto> AddCategory(CategoryDto categoryDto)
        {
            var category = mapper.Map<JobCategory>(categoryDto);
            await adminRepository.AddCategory(category);
            return categoryDto;

        }

        public async Task<IndustryDto> AddIndustry(IndustryDto industryDto)
        {
            var industry = mapper.Map<Industry>(industryDto);
            await adminRepository.AddIndustry(industry);
            return industryDto;

        }

        public async Task<LocationDto> AddLocation(LocationDto locationDto)
        {
            var location = mapper.Map<Location>(locationDto);
            await adminRepository.AddLocation(location);
            return locationDto;
        }

        public async Task<PostedSkillDTO> AddSkill(PostedSkillDTO skillDto)
        {
         var skill = mapper.Map<Skill>(skillDto);
            await adminRepository.AddSkill(skill);
            return skillDto;
        }

        public async Task<bool> DeleteCategoryById(Guid CategoryId)
        {
            return await adminRepository.DeleteCategoryById(CategoryId);
        }

        public async Task<bool> DeleteIndustryById(Guid IndustryId)
        {
            return await adminRepository.DeleteIndustryById(IndustryId);
        }

        public void DeleteLocationById(Guid id)
        {
            adminRepository.DeleteLocationById(id);
        }

        public async Task<bool> DeleteSkill(Guid skillId)
        {
            return await adminRepository.DeleteSkill(skillId);
        }

        public async Task<List<Joblist>> GetAllJobs()
        {
            var jobs= await adminRepository.GetAllJobs();
            return mapper.Map<Joblist>(jobs);
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
