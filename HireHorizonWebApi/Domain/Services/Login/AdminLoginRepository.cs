using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Services.Login.Interface;

namespace Domain.Services.Login
{
    public class AdminLoginRepository : IAdminLoginRepository
    {
        private readonly HireHorizonApiDbContext _context;

        public AdminLoginRepository(HireHorizonApiDbContext context)
        {
            _context = context;
        }

        public AuthUser GetUserByEmail(string email)
        {
            var user = _context.AuthUsers.FirstOrDefault(e => e.Email == email);
            return user;
        }
    }
}
