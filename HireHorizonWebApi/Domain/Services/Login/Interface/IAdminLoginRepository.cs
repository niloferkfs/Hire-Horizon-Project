using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Services.Login.Interface
{
    public interface IAdminLoginRepository
    {
        AuthUser GetUserByEmail(string email);
    }
}
