using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Service.Authuser.Interfaces;
using Domain.Service.Login.DTOs;
using Domain.Services.Login.Interface;

namespace Domain.Services.Login
{
    public class AdminLoginService:IAdminLoginService
    {
        IAdminLoginRepository adminLoginRepository;
        IAuthUserRepository authUserRepository;
        IMapper mapper;

        public AdminLoginService(IAdminLoginRepository adminLoginRepository, IAuthUserRepository authUserRepository, IMapper mapper)
        {
            this.adminLoginRepository = adminLoginRepository;
            this.authUserRepository = authUserRepository;
            this.mapper = mapper;
        }

        

        public AdminLoginDTO Adminlogin(string email, string password)
        {

            var user = adminLoginRepository.GetUserByEmail(email);

            if (user == null)
            {
                return null;
            }
            else
            {
                if (password == user.Password)
                {
                    var userReturn = mapper.Map<AdminLoginDTO>(user);
                    userReturn.Token = authUserRepository.CreateToken(user);
                    return userReturn;
                }

                return null;
            }
        }
    }
}
