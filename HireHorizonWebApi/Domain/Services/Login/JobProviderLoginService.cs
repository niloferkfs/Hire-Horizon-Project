using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Service.Authuser;
using Domain.Service.Authuser.Interfaces;
using Domain.Service.Login.DTOs;
using Domain.Services.Login.Dto;
using Domain.Services.Login.Interface;

namespace Domain.Services.Login
{
   public class JobProviderLoginService : IJobProviderLoginService
    {
        IJobProviderLoginRepository _jobProviderLoginRepository;
        IAuthUserRepository _authUserRepository;
        IMapper _mapper;

        public JobProviderLoginService(IJobProviderLoginRepository jobProviderLoginRepository, IAuthUserRepository authUserRepository, IMapper mapper)
        {
            _jobProviderLoginRepository = jobProviderLoginRepository;
            _authUserRepository = authUserRepository;
            _mapper = mapper;
        }
        public JobProviderLoginDto login(string email, string password)
        {
            var user = _jobProviderLoginRepository.GetUserByEmailpassword(email, password);
            if (user == null)
            {
                return null;
            }
            
                    var userReturn = _mapper.Map<JobProviderLoginDto>(user);
            if (_authUserRepository == null)
            {
                throw new NullReferenceException("AuthUserRepository is not injected properly.");
            }
            userReturn.Token = _authUserRepository.CreateToken(user);
                    return userReturn;
                }
               
            }
        }
    

