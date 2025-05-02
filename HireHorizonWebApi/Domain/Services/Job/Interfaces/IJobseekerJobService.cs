using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Service.Job.DTOs;
using Domain.Services.Job.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Domain.Services.Job.Interfaces
{
    public interface IJobseekerJobService
    {
        Task<IActionResult> ApplyForJobAsync(ApplyJobDto applyJobDto);
        Task<IActionResult> SavedJobAsync(SavedJobsDtos savedJobsDtos);

        Task<bool> RemoveSavedJobAsync(SavedJobsDtos dto);
        Task<bool> RemoveAppliedJobAsync(ApplyJobDto dto);
        Task<List<JobApplication>> GetAppliedJobsAsync(Guid applicantId);
        Task<List<SavedJob>> GetSavedJobsAsync(Guid savedById);
    }
}
