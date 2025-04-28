using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Service.JobSeekers.DTOs;
using Domain.Services.JobSeekers.DTOs;

namespace Domain.Service.JobSeekers.Interfaces
{
	public interface IJobSeeekerService
	{
		Task<string> AddResumeAsync(resumeDto resumeDto);
        Task<resumeDto> GetResumeByIdAsync(Guid id);
        Task<bool> AddWorkExperienceAsync(WorkExperienceDto dto);
    }
}
