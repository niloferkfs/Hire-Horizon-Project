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
    public class JobSeekerSignUpRepository : IJobSeekerSignUpRepository
    {
        protected readonly HireHorizonApiDbContext _context;

        public JobSeekerSignUpRepository(HireHorizonApiDbContext context)
        {
            _context = context;
        }

        public async Task AddJobSeekerAsync(JobSeeker jobseeker)
        {
            await _context.JobSeekers.AddAsync(jobseeker);
            await _context.SaveChangesAsync();
        }

        public Guid AddSignupRequest(SignUpRequest signUpRequest)
        {
            signUpRequest.Status = Status.PENDING;
            _context.SignUpRequests.AddAsync(signUpRequest);
            _context.SaveChanges();
            return signUpRequest.Id;
        }

        public async Task<SignUpRequest> GetSignupRequestByIdAsync(Guid jobSeekerSignupRequestId)
        {
            return await _context.SignUpRequests.FindAsync(jobSeekerSignupRequestId);
        }

        public void UpdateSignupRequest(SignUpRequest signUpRequest)
        {
            _context.SignUpRequests.Update(signUpRequest);
            _context.SaveChanges();
        }
    }
}

