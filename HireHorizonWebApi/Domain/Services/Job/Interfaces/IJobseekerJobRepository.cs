using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Service.Job.DTOs;
using Domain.Services.Job.DTOs;

namespace Domain.Services.Job.Interfaces
{
    public interface IJobseekerJobRepository
    {
        Task SaveJobAsync(SavedJobsDtos savedJobDto);
        Task<bool> JobExistsAsync(Guid jobPostId);

        Task ApplyForJobAsync(ApplyJobDto applyJobDto);

        Task<bool> RemoveSavedJobAsync(SavedJobsDtos dto);
        Task<bool> RemoveAppliedJobAsync(ApplyJobDto dto);

        Task<List<JobApplication>> GetAppliedJobsAsync(Guid applicantId);
        Task<List<SavedJob>> GetSavedJobsAsync(Guid savedById);

    }
}
