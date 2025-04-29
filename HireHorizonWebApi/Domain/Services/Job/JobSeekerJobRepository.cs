using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;
using Domain.Models;
using Domain.Service.Job.DTOs;
using Domain.Services.Job.DTOs;
using Domain.Services.Job.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services.Job
{
    public class JobSeekerJobRepository : IJobseekerJobRepository
    {
        private readonly HireHorizonApiDbContext _context;

        public JobSeekerJobRepository(HireHorizonApiDbContext context)
        {
            _context = context;
        }

        public async Task SaveJobAsync(SavedJobsDtos savedJobDto)
        {
            var savedjobs = new SavedJob
            {
                Id = Guid.NewGuid(),
                JobPostId = savedJobDto.JobPostId,
                SavedById = savedJobDto.SavedById,
                DateSaved = DateTime.Now
            };
            _context.SavedJobs.Add(savedjobs);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> JobExistsAsync(Guid jobPostId)
        {
            return await _context.JobPosts.AnyAsync(x => x.Id == jobPostId);
        }

        public async Task ApplyForJobAsync(ApplyJobDto applyJobDto)
        {
            var jobApplication = new JobApplication
            {
                Id = Guid.NewGuid(),
                JobPostId = applyJobDto.JobPostId,
                ApplicantId = applyJobDto.ApplicantId,
                ResumeId = applyJobDto.ResumeId,
                CoverLetter = applyJobDto.CoverLetter,
                DateSubmitted = DateTime.Now,
                Status = JobApplicationStatus.SUBMITTED,
            };

            _context.JobApplications.Add(jobApplication);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> RemoveSavedJobAsync(SavedJobsDtos dto)
        {
            var savedJob = await _context.SavedJobs.FirstOrDefaultAsync(j => j.JobPostId == dto.JobPostId && j.SavedById == dto.SavedById);

            if (savedJob == null)
                return false;

            _context.SavedJobs.Remove(savedJob);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> RemoveAppliedJobAsync(ApplyJobDto dto)
        {
            var job = await _context.JobApplications.FirstOrDefaultAsync(a => a.JobPostId == dto.JobPostId && a.ApplicantId == dto.ApplicantId);

            if (job == null)
                return false;

            _context.JobApplications.Remove(job);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<JobApplication>> GetAppliedJobsAsync(Guid applicantId)
        {
            return await _context.JobApplications.Include(j=>j.JobPost).Where(j=>j.ApplicantId==applicantId).ToListAsync();

        }
        public async Task<List<SavedJob>> GetSavedJobsAsync(Guid savedById)
        {
            return await _context.SavedJobs.Include(j=>j.JobPost).Where(s=>s.SavedById==savedById).ToListAsync();
        }
    }
}
