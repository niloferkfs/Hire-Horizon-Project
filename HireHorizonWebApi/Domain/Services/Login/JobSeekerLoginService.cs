using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Service.Authuser.Interfaces;
using Domain.Service.JobSeekers;
using Domain.Service.Login.DTOs;
using Domain.Services.Login.Interface;

namespace Domain.Services.Login
{
    public class JobSeekerLoginService : IJobSeekerLoginService
    {
        IJobSeekerLoginRepository jobSeekerLoginRepository;
        IAuthUserRepository authUserRepository;
        IMapper mapper;

        public JobSeekerLoginService(IJobSeekerLoginRepository _jobSeekerLoginRepository, IAuthUserRepository _AuthUserRepository,IMapper _mapper)
        {
            this.mapper = _mapper;
            this.jobSeekerLoginRepository = _jobSeekerLoginRepository;
            this.authUserRepository = _AuthUserRepository;
        }

        public JobSeekerLoginDto Login(string email, string password)
        {
            var user = jobSeekerLoginRepository.GetUserByEmailPassword(email, password);
            if (user == null)
            {
                return null;
            }

            var userReturn = mapper.Map<JobSeekerLoginDto>(user);
            userReturn.Token = authUserRepository.CreateToken(user);
            return userReturn;

        }
    }
}
