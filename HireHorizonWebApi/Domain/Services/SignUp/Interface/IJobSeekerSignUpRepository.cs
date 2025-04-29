using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Services.SignUp.Interface
{
    public interface IJobSeekerSignUpRepository
    {
        Task AddJobSeekerAsync(JobSeeker jobseeker);
        Guid AddSignupRequest(SignUpRequest signUpRequest);
        Task<SignUpRequest> GetSignupRequestByIdAsync(Guid jobSeekerSignupRequestId);
        void UpdateSignupRequest(SignUpRequest signUpRequest);
    }
}
