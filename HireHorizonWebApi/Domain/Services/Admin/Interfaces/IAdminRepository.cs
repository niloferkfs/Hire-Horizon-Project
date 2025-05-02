using Domain.Helpers;
using Domain.Models;
using Domain.Service.Admin.DTOs;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Admin.Interfaces
{
    public interface IAdminRepository
    {


        public Task<List<Domain.Models.JobSeeker>> GetJobSeekers();

        public Task<List<JobProviderCompany>> GetCompanies();

        public Task<List<JobPost>> GetAllJobs();

        public Task<List<Location>> GetLocations();

        public Task<Location> AddLocation(Location location);

        public Task<bool> DeleteLocationById(Guid id);

        public Task<Skill> AddSkill(Skill skill);

        public Task<bool> DeleteSkill(Guid skillId);

        public Task<JobCategory> AddCategory(JobCategory category);

        public Task<bool> DeleteCategoryById(Guid CategoryId);
        public Task<Industry> AddIndustry(Industry industry);
        public Task<bool> DeleteIndustryById(Guid IndustryId);

        public int GetJobProviderCount();
        public int GetCompanyCount();
        public int GetJobCount();

        public Task<List<JobPost>> GetJobsbyTitle(string JobTitle);
        public Task<List<JobProviderCompany>> SearchCompanies(string name);









    }

}
