using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Models;
using Domain.Service.Job.DTOs;
using Domain.Services.Job.DTOs;
using Domain.Services.Job.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Domain.Services.Job
{
    public class JobSeekerJobService : IJobseekerJobService
    {
        private readonly IJobseekerJobRepository _jobSeekerJobRepository;
        private readonly IMapper _mapper;

        public JobSeekerJobService(IJobseekerJobRepository jobSeekerJobRepository, IMapper mapper)
        {
            _jobSeekerJobRepository = jobSeekerJobRepository;
            _mapper = mapper;
        }

        public async Task<IActionResult> ApplyForJobAsync(ApplyJobDto applyJobDto)
        {
            var jobexists = await _jobSeekerJobRepository.JobExistsAsync(applyJobDto.JobPostId);
            if (!jobexists)
            {
                return new NotFoundObjectResult("Job not found");

            }

            await _jobSeekerJobRepository.ApplyForJobAsync(applyJobDto);
            return new OkObjectResult("Job applied successfully");
        }

        public async Task<IActionResult> SavedJobAsync(SavedJobsDtos savedJobsDtos)
        {
            var jobexits = await _jobSeekerJobRepository.JobExistsAsync(savedJobsDtos.JobPostId);
            if (!jobexits)
            {
                return new NotFoundObjectResult("Job not found");
            }

            await _jobSeekerJobRepository.SaveJobAsync(savedJobsDtos);
            return new OkObjectResult("Job saved successfully");
        }

        public async Task<bool> RemoveSavedJobAsync(SavedJobsDtos dto)
        {
            return await _jobSeekerJobRepository.RemoveSavedJobAsync(dto);
        }

        public async Task<bool> RemoveAppliedJobAsync(ApplyJobDto dto)
        {
            return await _jobSeekerJobRepository.RemoveAppliedJobAsync(dto);
        }


        public async Task<List<JobApplication>> GetAppliedJobsAsync(Guid applicantId)
        {
            return await _jobSeekerJobRepository.GetAppliedJobsAsync(applicantId);
        }
        public async Task<List<SavedJob>> GetSavedJobsAsync(Guid savedById)
        {
            return await _jobSeekerJobRepository.GetSavedJobsAsync(savedById);
        }
    }
}
