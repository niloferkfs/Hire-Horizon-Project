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

using Domain.Services.JobProvider.Interfaces;
using Domain.Services.JobProvider;
using Domain.Services.Login.Interface;
using Domain.Services.Login;
using Domain.Services.SignUp;
using Domain.Services.SignUp.Interface;
using Domain.Service.JobProvider;
using Domain.Service.User;
using Domain.Service.User.Interface;
using Domain.Service.Job;
using Domain.Service.Job.Interfaces;

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

            services.AddTransient<IEmailService, EmailService>();
            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IAuthUserRepository, AuthUserRepository>();
            services.AddScoped<IAuthUserService, AuthUserService>();
            services.AddScoped<IJobServices, JobServices>();
            services.AddScoped<ICompanyRepository,CompanyRepository>();
            services.AddScoped<ICompanyService, Companyservice>();
            services.AddScoped<IInterviewRepository, InterviewRepository>();
            services.AddScoped<IInterviewService, InterviewService>();
            services.AddScoped<IJobProviderRepository, JobProviderRepository>();    
            services.AddScoped<IJobProviderService, JobProviderService>();
            services.AddScoped<IJobProviderLoginRepository, JobProviderLoginRepository>();
            services.AddScoped<IJobProviderLoginService, JobProviderLoginService>();
            services.AddScoped<IJobProviderSignUpRepository, JobProviderSignUpRepository>();
            services.AddScoped<IJobProviderSignUpService, JobProviderSignUpService>();
            services.AddScoped<IUserService, UserServices>();


            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IAdminServices, AdminServices>();
            services.AddScoped<IAdminLoginRepository, AdminLoginRepository>();
            services.AddScoped<IAdminLoginService, AdminLoginService>();
            services.AddScoped<IAuthUserRepository, AuthUserRepository>();
            services.AddScoped<IAuthUserService, AuthUserService>();
            
            return services;
        }
    }
}
