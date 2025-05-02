﻿
using AutoMapper;
using Domain.Enums;
using Domain.Models;
using Domain.Services.JobProvider.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.Service.JobProvider.JobProviderRepository;

namespace Domain.Service.JobProvider
{
    public class JobProviderRepository :IJobProviderRepository
    {
        
            private List<JobPost> jobs = new();

            private readonly List<JobPost> _jobs;
            HireHorizonApiDbContext _context;
            IMapper _mapper;

            public JobProviderRepository(HireHorizonApiDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }
            public async Task<List<JobPost>> GetJobs(Guid companyId)
            {
                return await _context.JobPosts.Where(e => e.CompanyId == companyId).ToListAsync();
            }

            public async Task<List<JobPost>> GetAllJobsByProvider(Guid companyId, Guid jobproviderId)
            {
                return await _context.JobPosts.Where(e => e.CompanyId == companyId && e.PostedBy == jobproviderId).ToListAsync();
            }

            public async Task<List<JobApplication>> GetAllJobApplicants(Guid jobproviderId)
            {
                var companyUser = await _context.CompanyUsers
                .Where(e => e.Id == jobproviderId)
                .FirstOrDefaultAsync();

                Guid? companyId = companyUser.Company;

                var jobPosts = await _context.JobPosts.Where(e => e.CompanyId == companyId).ToListAsync();

                var jobPostIds = jobPosts.Select(jp => jp.Id).ToList();

                // Fetch job applications based on the extracted JobPostIds
                /*    var jobApplications = await _context.JobApplications
                        .Where(ja => jobPostIds.Contains(ja.JobPost_id))
                        .ToListAsync();*/

                var jobApplications = await _context.JobApplications
                .Include(ja => ja.Resume)
                .Include(ja => ja.Seeker)
                .Include(ja => ja.JobPost)
                .Where(ja => jobPostIds.Contains(ja.JobPostId))
                .ToListAsync();

                return jobApplications;
            }


            public async Task<List<JobProviderCompany>> GetCompany(Guid jobproviderId)
            {
                var companyUser = await _context.CompanyUsers
                .Where(e => e.Id == jobproviderId)
                .FirstOrDefaultAsync();

                Guid? companyId = companyUser.Company;

                /*var company = await _context.JobProviderCompanies
            .Where(e => e.Id == companyId)
            .FirstOrDefaultAsync();*/

                var companies = await _context.JobProviderCompanies
          .Where(e => e.Id == companyId)
          .ToListAsync();


                return companies;
            }

            public async Task<Guid> Create(JobPost job)
            {
                job.Id = Guid.NewGuid();
                await _context.JobPosts.AddAsync(job);
                _context.SaveChanges();
                return job.Id;
            }



            public async Task<JobPost> UpdateAsync(JobPost Updatedjob, Guid id)
            {
                var jobToUpdate = await _context.JobPosts.FirstOrDefaultAsync(e => e.Id == id);


                if (jobToUpdate != null)
                {
                    jobToUpdate.JobTitle = Updatedjob.JobTitle;
                    jobToUpdate.JobSummary = Updatedjob.JobSummary;
                    jobToUpdate.LocationId = Updatedjob.LocationId;
                    jobToUpdate.CompanyId = Updatedjob.CompanyId;
                    jobToUpdate.CategoryId = Updatedjob.CategoryId;
                    jobToUpdate.IndustryId = Updatedjob.IndustryId;

                    _context.JobPosts.Update(jobToUpdate);
                    await _context.SaveChangesAsync();

                    return jobToUpdate;
                }

                // Handle the case where no job with the specified id is found.
                return null;
            }

            public void DeleteJob(Guid id)
            {
                var item = _context.JobPosts.Where(e => e.Id == id).FirstOrDefault();
                if (item != null)
                {
                    _context.JobPosts.Remove(item);
                    _context.SaveChanges();
                }
            }
            public Task<JobPost> GetJobById(Guid jobId)
            {
                throw new NotImplementedException();
            }

            public Guid AddSignupRequest(SignUpRequest signUpRequest)
            {
                signUpRequest.Status = Status.PENDING;
                _context.SignUpRequests.AddAsync(signUpRequest);
                _context.SaveChanges();
                return signUpRequest.Id;
            }

            public async Task<SignUpRequest> GetSignupRequestByIdAsync(Guid jobProviderSignupRequestId)
            {
                return await _context.SignUpRequests.FindAsync(jobProviderSignupRequestId);
            }

            public void UpdateSignupRequest(SignUpRequest signUpRequest)
            {
                _context.SignUpRequests.Update(signUpRequest);
                _context.SaveChanges();
            }

        }
}
