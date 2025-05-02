using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Services.Login.Interface
{
    public interface IJobSeekerLoginRepository
    {
        AuthUser GetUserByEmail(string email);

        AuthUser GetUserByEmailPassword(string email, string password);
    }
}
