using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Helpers;
using Domain.Models;
using Domain.Service.Authuser;
using Domain.Service.Authuser.Interfaces;
using Domain.Service.JobSeeker;
using Domain.Service.JobSeeker.Interfaces;
using Domain.Service.SignUp.DTOs;
using Domain.Services.Email;
using Domain.Services.SignUp.Interface;

namespace Domain.Services.SignUp
{
   public class JobProviderSignUpService : IJobProviderSignUpService
    {
        IJobProviderSignUpRepository _jobprovidersignuprepo;
        IAuthUserRepository _authuserrepo;
        IMapper _mapper;
        IEmailService _emailservice;

        public JobProviderSignUpService(IJobProviderSignUpRepository jobprovidersignuprepo, IAuthUserRepository authuserrepo, IMapper mapper, IEmailService emailservice)
        {
            _jobprovidersignuprepo = jobprovidersignuprepo;
            _authuserrepo = authuserrepo;
            _mapper = mapper;
            _emailservice = emailservice;
        }
        public async Task CreateJobProvider(Guid jobProviderSignupRequestId, string password)
        {
            try
            {
                SignUpRequest signUpRequest = await _jobprovidersignuprepo.GetSignupRequestByIdAsync(jobProviderSignupRequestId);
                //AuthUser authUser = mapper.Map<AuthUser>(signUpRequest);
               
                if (signUpRequest.Status == Enums.Status.VERIFIED)
                {
                    //need to change this code by using Automapper 
                    Domain.Models.AuthUser authUser = _mapper.Map<Domain.Models.AuthUser>(signUpRequest);
                        authUser.Password = password;

                   
                    authUser = await _authuserrepo.AddAuthUserJobProvider(authUser);
                    signUpRequest.Status = Enums.Status.CREATED;
                    _jobprovidersignuprepo.UpdateSignupRequest(signUpRequest);
                }
               

                //await jobSeekerRepository.AddJobSeekerAsync(jobseeker);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public async void CreateSignupRequest(JobProviderSignupRequestDto data)
        {

            var signUpRequest = _mapper.Map<SignUpRequest>(data);
            var signUpId = _jobprovidersignuprepo.AddSignupRequest(signUpRequest);
            MailRequest mailRequest = new MailRequest();
            mailRequest.Subject = "HireMeNow SignUp Verification";
            mailRequest.Body = "Hello" + signUpId.ToString();
            mailRequest.ToEmail = signUpRequest.Email;
            await _emailservice.SendEmailAsync(mailRequest);
        }
        public async Task<bool> VerifyEmailAsync(Guid jobProviderSignupRequestId)
        {

            SignUpRequest signUpRequest = await _jobprovidersignuprepo.GetSignupRequestByIdAsync(jobProviderSignupRequestId);
            if (signUpRequest != null)
            {
                signUpRequest.Status = Enums.Status.VERIFIED;
                _jobprovidersignuprepo.UpdateSignupRequest(signUpRequest);
                return true;
            }
            return false;
        }
    }
}

    
