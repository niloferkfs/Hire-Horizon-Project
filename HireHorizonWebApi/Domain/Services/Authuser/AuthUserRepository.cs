using AutoMapper;
using Domain.Models;
using Domain.Service.Authuser.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Authuser
{
<<<<<<< HEAD
    public class AuthUserRepository : IAuthUserRepository
    {
        protected readonly HireHorizonApiDbContext _context;
        protected readonly IConfiguration _configuration;
        IMapper _mapper;
        public AuthUserRepository(HireHorizonApiDbContext context, IConfiguration configuration, IMapper mapper)
        {
            _context = context;
            _configuration = configuration;
            _mapper = mapper;
        }
        public async Task<AuthUser> AddAuthUserJobProvider(AuthUser authUser)
        {
            authUser.Role = Enums.Roles.JOBPROVIDER;
            await _context.AuthUsers.AddAsync(authUser);
            Models.CompanyUser jobProvider = _mapper.Map<Models.CompanyUser>(authUser);
            await _context.CompanyUsers.AddAsync(jobProvider);
            _context.SaveChanges();
            return authUser;

=======
    public class AuthUserRepository:IAuthUserRepository
    {
        private readonly HireHorizonApiDbContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public AuthUserRepository(HireHorizonApiDbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
>>>>>>> 1019875f1cd5d1f28b552c6df0b924478a2aef62
        }

        public string? CreateToken(AuthUser user)
        {
            if (user == null)
            {
<<<<<<< HEAD
                throw new ArgumentNullException(nameof(user));
=======
                
                throw new ArgumentNullException(nameof(user), "User object cannot be null.");
>>>>>>> 1019875f1cd5d1f28b552c6df0b924478a2aef62
            }
            string tokenSecret = _configuration.GetSection("AuthSettings:Token").Value;
            if (string.IsNullOrEmpty(tokenSecret))
            {
<<<<<<< HEAD

                throw new InvalidOperationException("Token secret is missing or empty in configuration.");
            }
=======
                
                throw new InvalidOperationException("Token secret is missing or empty in configuration.");
            }

>>>>>>> 1019875f1cd5d1f28b552c6df0b924478a2aef62
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.FirstName),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Sid, user.Id.ToString()),
                new Claim(ClaimTypes.Role, user.Role.ToString())
            };
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                _configuration.GetSection("AuthSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
<<<<<<< HEAD
        public CompanyUser GetUser(Guid userid)
        {
            return _context.CompanyUsers.Where(e=>e.Id == userid).FirstOrDefault();
        }
        public async Task AddUserConnectionIdAsync(string email, string Connectionid)
        {

        }
        }
    }
=======

       
    }
}
>>>>>>> 1019875f1cd5d1f28b552c6df0b924478a2aef62
