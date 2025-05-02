using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Service.Login.DTOs;

namespace Domain.Services.Login.Interface
{
    public interface IJobSeekerLoginService
    {
        JobSeekerLoginDto Login(string email, string password);
    }
}
