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
<<<<<<< HEAD
       Task<AuthUser> AddAuthUserJobProvider(AuthUser authUser);
        string? CreateToken(AuthUser user);
        CompanyUser GetUser(Guid userid);
        Task AddUserConnectionIdAsync(string email, string Connectionid);  
        AuthUser GetUserByConnectionId(string connectionId);
        Task<AuthUser> GetAuthUserByUserEmail(string user);
        void DisconnectUserByConnectionId(string connectionId);
        Task<AuthUser> GetAuthUserByUserId(Guid value);

=======
        string? CreateToken(AuthUser user);
>>>>>>> 1019875f1cd5d1f28b552c6df0b924478a2aef62
    }

}

