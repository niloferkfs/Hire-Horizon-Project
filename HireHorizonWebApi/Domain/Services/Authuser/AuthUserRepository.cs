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
    public class AuthUserRepository : IAuthUserRepository
    {
        private readonly HireHorizonApiDbContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public AuthUserRepository(HireHorizonApiDbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;

        }

        public async Task<AuthUser> AddAuthUserJobProvider(AuthUser authUser)
        {
            authUser.Role = Enums.Roles.JOBPROVIDER;
            await _context.AuthUsers.AddAsync(authUser);
            Models.CompanyUser jobProvider = _mapper.Map<Models.CompanyUser>(authUser);
            await _context.CompanyUsers.AddAsync(jobProvider);
            _context.SaveChanges();
            return authUser;
        }
        public string? CreateToken(AuthUser user)
        {
            if (user == null)
            {

                throw new ArgumentNullException(nameof(user), "User object cannot be null.");
            }
            string tokenSecret = _configuration.GetSection("AuthSettings:Token").Value;
            if (string.IsNullOrEmpty(tokenSecret))
            {

                throw new InvalidOperationException("Token secret is missing or empty in configuration.");
            }


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

        public CompanyUser GetUser(Guid userid)
        {
            return _context.CompanyUsers.Where(e => e.Id == userid).FirstOrDefault();
        }
        public async Task AddUserConnectionIdAsync(string email, string Connectionid)
        {
            
        }
        public async Task<AuthUser> GetAuthUserByUserEmail(string email)
        {
            ;
            return await _context.AuthUsers.Where(x => x.Email == email).FirstOrDefaultAsync();
        }
        public async Task<AuthUser> GetAuthUserByUserId(Guid authUserId)
        {
            var authuser = await _context.AuthUsers.Where(e => e.Id == authUserId).FirstOrDefaultAsync();
            return authuser;
        }
    }
}

