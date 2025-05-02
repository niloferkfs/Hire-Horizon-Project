
using AutoMapper;
using Domain.Models;
using Domain.Service.JobSeekers.Interfaces;
using Domain.Services.JobSeekers.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.JobSeekers
{
	public class JobSeekerRepository:IJobSeekerRepository
	{
		private readonly HireHorizonApiDbContext _context;
		private readonly IMapper _mapper;

		public JobSeekerRepository(HireHorizonApiDbContext context,IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public async Task AddResumeAsync(Resume resume)
		{
			await _context.Resumes.AddAsync(resume);
			await _context.SaveChangesAsync();
		}

		public async Task<Resume> GetResumeByIdAsync(Guid id)
		{
			return await _context.Resumes.FindAsync(id);
		}

        public async Task<bool> AddWorkExperienceAsync(WorkExperienceDto dto)
        {
            var workExperience = _mapper.Map<WorkExperience>(dto);
            await _context.WorkExperiences.AddAsync(workExperience);
            var result = await _context.SaveChangesAsync();
			return true;
        }

    }
}
