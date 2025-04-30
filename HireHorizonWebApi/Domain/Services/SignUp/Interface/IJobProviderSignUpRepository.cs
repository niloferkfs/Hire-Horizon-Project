using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Services.SignUp.Interface
{
 public interface IJobProviderSignUpRepository
    {
        Task AddJobProviderAsync(Models.JobProviderCompany jobprovider);
        Guid AddSignupRequest(SignUpRequest signUpRequest);
        Task<SignUpRequest> GetSignupRequestByIdAsync(Guid jobProviderSignupRequestId);
        void UpdateSignupRequest(SignUpRequest signUpRequest);
    }
}
