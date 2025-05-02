using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Enums;
using Domain.Helpers;
using Domain.Models;
using Domain.Service.Authuser.Interfaces;
using Domain.Service.JobSeekers;
using Domain.Service.SignUp.DTOs;
using Domain.Services.Email;
using Domain.Services.SignUp.Interface;

namespace Domain.Services.SignUp
{
    public class JobSeekerSignUpService : IJobseekerSignupService
    {
        IAuthUserRepository authUserRepository;
        IMapper mapper;
        IEmailService emailService;
        IJobSeekerSignUpRepository _jobSeekerSignUpRepository;

        public JobSeekerSignUpService(IAuthUserRepository authUserRepository, IMapper mapper, IEmailService emailService, IJobSeekerSignUpRepository jobSeekerSignUpRepository)
        {
            this.authUserRepository = authUserRepository;
            this.mapper = mapper;
            this.emailService = emailService;
            _jobSeekerSignUpRepository = jobSeekerSignUpRepository;
        }

        public async Task CreateJobseeker(Guid jobSeekerSignupRequestId, string password)
        {
            try
            {
                SignUpRequest signUpRequest = await _jobSeekerSignUpRepository.GetSignupRequestByIdAsync(jobSeekerSignupRequestId);


                if (signUpRequest.Status == Status.VERIFIED)
                {
                    Domain.Models.AuthUser authUser = mapper.Map<Domain.Models.AuthUser>(signUpRequest);
                    authUser.Password = password;

                    authUser = await authUserRepository.AddAuthUserJb(authUser);
                    signUpRequest.Status = Status.CREATED;
                    _jobSeekerSignUpRepository.UpdateSignupRequest(signUpRequest);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async void CreateSignupRequest(JobSeekerSignupRequestDto data)
        {
            var signUpRequest = mapper.Map<SignUpRequest>(data);
            var signUpId = _jobSeekerSignUpRepository.AddSignupRequest(signUpRequest);
            MailRequest mailRequest = new MailRequest();

            mailRequest.Subject = "HireMeNow SignUp Verification";
            mailRequest.Body = "Hello" + signUpId.ToString();
            mailRequest.ToEmail = signUpRequest.Email;
            await emailService.SendEmailAsync(mailRequest);
        }

        public async Task<bool> VerifyEmailAsync(Guid jobSeekerSignupRequestId)
        {
            SignUpRequest signUpRequest = await _jobSeekerSignUpRepository.GetSignupRequestByIdAsync(jobSeekerSignupRequestId);
            if (signUpRequest != null)
            {
                signUpRequest.Status = Status.VERIFIED;
                _jobSeekerSignUpRepository.UpdateSignupRequest(signUpRequest);
                return true;
            }
            return false;
        }
    }
}

