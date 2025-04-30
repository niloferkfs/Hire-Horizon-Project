
using AutoMapper;
using Domain.Helpers;
using Domain.Models;
using Domain.Service.Job.DTOs;
using Domain.Service.Job.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Domain.Service.Job
{
    public class JobRepository : IJobRepository
    {
        HireHorizonApiDbContext _context;
        IMapper _mapper;
        static List<JobPost> joblist;

        public JobRepository(HireHorizonApiDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<JobPost>> GetJobs(Guid userId)
        {

            try
            {

                List<JobPost> jobs = await _context.JobPosts.Include(e => e.LocationId).Include(e => e.IndustryId).Include(e => e.CompanyId).Include(e => e.PostedByNavigation).Include(e => e.CategoryId).ToListAsync();

                List<JobPost> applied = await _context.JobApplications.Where(e => e.ApplicantId == userId).Select(e => e.JobPost).ToListAsync();

                List<JobPost> notApplied = jobs.Except(applied).ToList();

                return notApplied;


            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public async Task<List<JobPost>> GetJobs()
        {

            try
            {
                var jobs = await _context.JobPosts.Include(e => e.LocationId).Include(e => e.IndustryId).Include(e => e.CompanyId).Include(e => e.PostedByNavigation).Include(e => e.CategoryId).ToListAsync();
                return jobs;
            }



            catch (Exception ex)
            {
                throw ex;

            }
        }
        public async Task<List<JobPost>> GetJobsByCompany(Guid companyId)
        {
          
            return await _context.JobPosts.Where(e => e.CompanyId == companyId).ToListAsync();
        }


        public async Task<List<JobPost>> GetJobsById(Guid companyId, Guid jobId)
        {
            return await _context.JobPosts.Where(e => e.CompanyId == companyId && e.Id == jobId).ToListAsync();
        }
        public bool SavedJobs(JobPostsDtos job, Guid userId)
        {
            // Assuming JobPostsDtos has an Id property
            bool isJobSaved = _context.SavedJobs.Any(e => e.JobPostId == job.Id && e.SavedById                                                                                                                                                                                                                                                                                                                                  == userId);
            return isJobSaved;
        }
    }

}

