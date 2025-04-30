using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Services.JobProvider.Interfaces;
using Domain.Services.Login.Interface;

namespace Domain.Services.Login
{
   public class JobProviderLoginRepository : IJobProviderLoginRepository
    {
        protected readonly HireHorizonApiDbContext _context;

        public JobProviderLoginRepository(HireHorizonApiDbContext context)
        {
            _context = context;
        }
        public AuthUser GetUserByEmail(string email)
        {
            var user = _context.AuthUsers.FirstOrDefault(e => e.Email == email);
            return user;
        }
        public AuthUser GetUserByEmailpassword(string email, string password)
        {
            var user = _context.AuthUsers.FirstOrDefault(e => e.Email == email && e.Password == password);
            return user;
        }
    }
}
