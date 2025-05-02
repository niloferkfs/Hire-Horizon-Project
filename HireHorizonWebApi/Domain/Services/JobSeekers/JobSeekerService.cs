using AutoMapper;
using Domain.Models;
using Domain.Service.Job.Interfaces;
using Domain.Service.JobSeekers.DTOs;
using Domain.Service.JobSeekers.Interfaces;
using Domain.Services.JobSeekers.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.JobSeekers
{
	public class JobSeekerService:IJobSeeekerService
	{
		private readonly IJobSeekerRepository _jobSeekerRepository;
		private readonly IMapper _mapper;

		public JobSeekerService(IJobSeekerRepository jobSeekerRepository, IMapper mapper)
		{
			_jobSeekerRepository = jobSeekerRepository;
			_mapper = mapper;
		}

        public async Task<string> AddResumeAsync(resumeDto resumeDto)
        {
            var resume = _mapper.Map<Resume>(resumeDto);
            resume.Id = Guid.NewGuid(); 
            await _jobSeekerRepository.AddResumeAsync(resume);
            return "Resume uploaded successfully.";
        }


        public async Task<resumeDto> GetResumeByIdAsync(Guid id)
		{
			var resume=await _jobSeekerRepository.GetResumeByIdAsync(id);
			return _mapper.Map<resumeDto>(resume);
		}
        public async Task<bool> AddWorkExperienceAsync(WorkExperienceDto dto)
        {
            return await _jobSeekerRepository.AddWorkExperienceAsync(dto);
        }

    }
}
