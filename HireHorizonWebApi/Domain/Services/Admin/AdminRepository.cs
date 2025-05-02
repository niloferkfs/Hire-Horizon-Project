using AutoMapper;
using Domain.Helpers;
using Domain.Models;
using Domain.Service.Admin.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Service.Admin
{
    public class AdminRepository : IAdminRepository

    {
        private readonly HireHorizonApiDbContext _context;

        public AdminRepository(HireHorizonApiDbContext context)
        {
            _context = context;
        }

        public async Task<JobCategory> AddCategory(JobCategory category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }
            if (_context.JobCategories.Any(c => c.Name == category.Name))
            {
                return null;
            }
            _context.JobCategories.Add(category);
            await _context.SaveChangesAsync();

            return category;
        }

        public async Task<Industry> AddIndustry(Industry industry)
        {
            if (industry == null)
            {
                throw new ArgumentNullException(nameof(industry));
            }
            if (_context.Industries.Any(c => c.Name == industry.Name))
            {
                return null;
            }
            _context.Industries.Add(industry);
            await _context.SaveChangesAsync();

            return industry;
        }

        public async Task<Location> AddLocation(Location location)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (_context.Locations.Any(c => c.Name == location.Name))
            {
                return null;
            }
            _context.Locations.Add(location);
            await _context.SaveChangesAsync();

            return location;
        }

        public async Task<Skill> AddSkill(Skill skill)
        {
            if (skill == null)
            {
                throw new ArgumentNullException(nameof(skill));
            }
            if (_context.Skills.Any(c => c.Name == skill.Name))
            {
                return null;
            }
            _context.Skills.Add(skill);
            await _context.SaveChangesAsync();

            return skill;
        }

        public async Task<bool> DeleteCategoryById(Guid CategoryId)
        {
            var CategoryToRemove = await _context.JobCategories.FindAsync(CategoryId);
            if (CategoryToRemove == null)
            {
                return false;
            }

            _context.JobCategories.Remove(CategoryToRemove);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteIndustryById(Guid IndustryId)
        {
            var IndustryToRemove = await _context.Industries.FindAsync(IndustryId);
            if (IndustryToRemove == null)
            {
                return false;
            }

            _context.Industries.Remove(IndustryToRemove);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteLocationById(Guid locationId)
        {
            var LocationToRemove = await _context.Locations.FindAsync(locationId);
            if (LocationToRemove == null)
            {
                return false;
            }

            _context.Locations.Remove(LocationToRemove);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteSkill(Guid skillId)
        {
            var SkillToRemove = await _context.Skills.FindAsync(skillId);
            if (SkillToRemove == null)
            {
                return false;
            }

            _context.Skills.Remove(SkillToRemove);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<List<JobPost>> GetAllJobs()
        {
            return await _context.JobPosts.ToListAsync();
        }

        public async Task<List<JobProviderCompany>> GetCompanies()
        {
            return await _context.JobProviderCompanies.ToListAsync();
        }

        public int GetCompanyCount()
        {
            return _context.JobProviderCompanies.Count();
        }

        public int GetJobCount()
        {
            return _context.JobPosts.Count();
        }

        public int GetJobProviderCount()
        {
            return _context.CompanyUsers.Count();
        }

        public async Task<List<Models.JobSeeker>> GetJobSeekers()
        {
            return await _context.JobSeekers.ToListAsync();
        }

        public async Task<List<Location>> GetLocations()
        {
            return await _context.Locations.ToListAsync();
        }

        public async Task<List<JobPost>> GetJobsbyTitle(string JobTitle)
        {
            return await _context.JobPosts.Where(e => e.JobTitle.Contains(JobTitle)).ToListAsync();
        }

        public async Task<List<JobProviderCompany>> SearchCompanies(string name)
        {
            var filteredCompanies = await _context.JobProviderCompanies
           .Where(company => company.LegalName.Contains(name))
           .ToListAsync();

            return filteredCompanies;
        }
    }
}
