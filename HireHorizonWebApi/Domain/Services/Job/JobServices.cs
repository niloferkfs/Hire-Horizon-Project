
using Domain.Models;
using Domain.Service.Job.Interfaces;
using Domain.Service.JobSeekers.Interfaces;

using AutoMapper;
using Domain.Helpers;
using Domain.Models;
using Domain.Service.Job.DTOs;


using Microsoft.EntityFrameworkCore;


using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Job
{
    public class JobServices : IJobServices
    {
        private IJobRepository _jobrepository;
        private IMapper _mapper;

        public JobServices(IJobRepository jobrepository, IMapper mapper)
        {
            _jobrepository = jobrepository;
            _mapper = mapper;
        }
        public async Task<List<JobPostsDtos>> GetJobs(Guid userId)
        {
            var notApplied = await _jobrepository.GetJobs(userId);
            var dtoList = _mapper.Map<List<JobPost>, List<JobPostsDtos>>(notApplied);

            foreach (var job in dtoList)
            {
                job.Saved = _jobrepository.SavedJobs(job, userId);
            }

            return dtoList;
        }
        public async Task<List<JobPostsDtos>> GetJobs()
        {
            var notApplied = await _jobrepository.GetJobs();
            var dtoList = _mapper.Map<List<JobPostsDtos>>(notApplied);
            return dtoList;


        }

        public async Task<List<JobPost>> GetJobsByCompany(Guid companyId)
        {
            return await _jobrepository.GetJobsByCompany(companyId);
        }

        public async Task<List<JobPost>> GetJobsById(Guid companyId, Guid jobId)
        {
            return await _jobrepository.GetJobsById(companyId, jobId);
        }
    }

}
