using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Services.Login.Dto;

namespace Domain.Services.Login.Interface
{
   public interface IJobProviderLoginService
    {
        JobProviderLoginDto login(string email, string password);
    }
}
