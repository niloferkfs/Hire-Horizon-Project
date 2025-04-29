using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Service.SignUp.DTOs;

namespace Domain.Services.SignUp.Interface
{
    public interface IJobseekerSignupService
    {
        Task CreateJobseeker(Guid jobSeekerSignupRequestId, string password);


        void CreateSignupRequest(JobSeekerSignupRequestDto data);

        Task<bool> VerifyEmailAsync(Guid jobSeekerSignupRequestId);
    }
}
