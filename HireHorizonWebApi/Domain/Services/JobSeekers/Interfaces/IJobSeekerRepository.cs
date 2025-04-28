using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Services.JobSeekers.DTOs;

namespace Domain.Service.JobSeekers.Interfaces
{
	public interface IJobSeekerRepository
	{
		Task AddResumeAsync(Resume resume);
		Task<Resume> GetResumeByIdAsync(Guid id);
		Task<bool> AddWorkExperienceAsync(WorkExperienceDto dto);
    }
}
