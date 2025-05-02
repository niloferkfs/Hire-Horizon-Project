using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;
using Domain.Models;
using Domain.Services.SignUp.Interface;

namespace Domain.Services.SignUp
{
    internal class JobProviderSignUpRepository:IJobProviderSignUpRepository
    {
        protected readonly HireHorizonApiDbContext _context;
        public JobProviderSignUpRepository(HireHorizonApiDbContext context)
        {
            _context = context;
        }
        public async Task AddJobProviderAsync(Models.JobProviderCompany jobprovider)
        {
            await _context.JobProviderCompanies.AddAsync(jobprovider);
            _context.SaveChanges();

        }
        public Guid AddSignupRequest(SignUpRequest signUpRequest)
        {
            signUpRequest.Status = Status.PENDING;
            _context.SignUpRequests.AddAsync(signUpRequest);
            _context.SaveChanges();
            return signUpRequest.Id;
        }
        public async Task<SignUpRequest> GetSignupRequestByIdAsync(Guid jobProviderSignupRequestId)
        {
            return await _context.SignUpRequests.FindAsync(jobProviderSignupRequestId);
        }

        public void UpdateSignupRequest(SignUpRequest signUpRequest)
        {
            _context.SignUpRequests.Update(signUpRequest);
            _context.SaveChanges();
        }
    }
}
