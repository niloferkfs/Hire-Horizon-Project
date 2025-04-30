using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Authuser.Interfaces
{
    public interface IAuthUserRepository
    {

       Task<AuthUser> AddAuthUserJobProvider(AuthUser authUser);
        string? CreateToken(AuthUser user);
        CompanyUser GetUser(Guid userid);
        Task AddUserConnectionIdAsync(string email, string Connectionid);  
       
        Task<AuthUser> GetAuthUserByUserEmail(string user);
      
        Task<AuthUser> GetAuthUserByUserId(Guid value);

       

    }

}

