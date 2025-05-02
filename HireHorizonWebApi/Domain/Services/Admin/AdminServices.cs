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

        public async Task<bool> DeleteLocationById(Guid id)
        {
            return await adminRepository.DeleteLocationById(id);
        }

        public async Task<bool> DeleteSkill(Guid skillId)
        {
            return await adminRepository.DeleteSkill(skillId);
        }

        public async Task<List<Joblist>> GetAllJobs()
        {
            var jobs = await adminRepository.GetAllJobs();
            return mapper.Map<List<Joblist>>(jobs);
        }

        public async Task<List<JobProviderCompany>> GetCompanies()
        {
            var companies = await adminRepository.GetCompanies();
            return mapper.Map<List<JobProviderCompany>>(companies);
        }

        public int GetCompanyCount()
        {
            return adminRepository.GetCompanyCount();
        }

        public int GetJobCount()
        {
            return adminRepository.GetJobCount();
        }

        public int GetJobProviderCount()
        {
            return adminRepository.GetJobProviderCount();
        }

        public async Task<List<Joblist>> GetJobsByTitle(string JobTitle)
        {
            var jobs = await adminRepository.GetJobsbyTitle(JobTitle);
            return mapper.Map<List<Joblist>>(jobs);
        }

        public async Task<List<JobSeekerDto>> GetJobSeekers()
        {
            var jobseekers = await adminRepository.GetJobSeekers();
            return mapper.Map<List<JobSeekerDto>>(jobseekers);
        }

        public async Task<List<LocationDto>> GetLocations()
        {
            var locations = await adminRepository.GetLocations();
            return mapper.Map<List<LocationDto>>(locations);
        }

        public async Task<List<JobProviderCompany>> SearchCompanies(string name)
        {
            return await adminRepository.SearchCompanies(name);

        }
    }
}
