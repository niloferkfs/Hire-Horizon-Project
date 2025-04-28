using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Services.Login.Interface;

namespace Domain.Services.Login
{
    public class JobSeekerLoginRepository : IJobSeekerLoginRepository
    {
        private readonly HireHorizonApiDbContext _context;

        public JobSeekerLoginRepository(HireHorizonApiDbContext context)
        {
            _context = context;
        }

        public AuthUser GetUserByEmail(string email)
        {
            var user=_context.AuthUsers.FirstOrDefault(u => u.Email == email);
            return user;
        }

        public AuthUser GetUserByEmailPassword(string email, string password)
        {
            var user= _context.AuthUsers.FirstOrDefault(e => e.Email == email && e.Password== password);
            return user;
        }
    }
}
