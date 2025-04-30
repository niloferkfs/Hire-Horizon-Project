using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Service.SignUp.DTOs;

namespace Domain.Services.SignUp.Interface
{
    internal interface IJobProviderSignUpService
    {
        Task CreateJobProvider(Guid jobProviderSignupRequestId, string password);

        //Task<Guid> AddJobseekerSignUpRequest(JobSeekerSignupRequest jobseekerCreateRequest);
        void CreateSignupRequest(JobProviderSignupRequestDto data);

        Task<bool> VerifyEmailAsync(Guid jobSeekerSignupRequestId);
    }
}
