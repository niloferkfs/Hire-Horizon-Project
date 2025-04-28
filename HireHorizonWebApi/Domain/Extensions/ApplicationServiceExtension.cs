using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Helpers;
using Domain.Service.Admin.Interfaces;
using Domain.Service.Admin;
using Domain.Service.Authuser.Interfaces;
using Domain.Service.Authuser;

using Domain.Services.Email;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Domain.Services.Login.Interface;
using Domain.Services.Login;

namespace Domain.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<HireHorizonApiDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

<<<<<<< HEAD
            //services.AddTransient<IEmailService, EmailService>();
=======
            services.AddTransient<IEmailService, EmailService>();

            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IAdminServices, AdminServices>();
            services.AddScoped<IAdminLoginRepository, AdminLoginRepository>();
            services.AddScoped<IAdminLoginService, AdminLoginService>();
            services.AddScoped<IAuthUserRepository, AuthUserRepository>();
            services.AddScoped<IAuthUserService, AuthUserService>();
            
>>>>>>> 37ea8e62c569e5fd8a8074250fc69e1452ed11b3
            


            

            return services;
        }
    }
}
