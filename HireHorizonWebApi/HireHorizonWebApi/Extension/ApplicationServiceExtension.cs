using Domain.Service.Authuser.Interfaces;
using Domain.Service.Authuser;
using Domain.Services.Email;
using Microsoft.EntityFrameworkCore;
using System;
using Domain.Models;
using Domain.Services.Login.Interface;
using Domain.Services.Login;
using Domain.Services.SignUp.Interface;
using Domain.Services.SignUp;
using Domain.Service.Profile.Interface;
using Domain.Service.Profile;
using Domain.Services.Profile;
using Domain.Services.Job.Interfaces;
using Domain.Services.Job;
using Domain.Service.JobSeekers.Interfaces;
using Domain.Service.JobSeekers;
using Microsoft.AspNetCore.Http.Features;

namespace HireHorizonWebApi.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration config)
        {
           // services.AddDbContext<HireHorizonApiDbContext>(options =>
           //options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddTransient<IEmailService, EmailService>();
            services.AddScoped<IJobSeekerLoginService, JobSeekerLoginService>();
            services.AddScoped<IJobSeekerLoginRepository, JobSeekerLoginRepository>();
            services.AddScoped<IJobSeekerSignUpRepository, JobSeekerSignUpRepository>();
            services.AddScoped<IJobseekerSignupService, JobSeekerSignUpService>();
            services.AddScoped<IAuthUserRepository, AuthUserRepository>();
            services.AddScoped<IAuthUserService, AuthUserService>();
            services.AddScoped<IJobSeekerProfileRepository,Jobseekerprofilerepository>();
            services.AddScoped<IJobSeekerProfileService,JobSeekerProfileService>();
            services.AddScoped<IJobseekerJobRepository,JobSeekerJobRepository>();
            services.AddScoped<IJobseekerJobService,JobSeekerJobService>();
            services.AddScoped<IJobSeekerRepository,JobSeekerRepository>();
            services.AddScoped<IJobSeeekerService,JobSeekerService>();


            services.AddAutoMapper(typeof(AutoMapperProfile));
            services.AddHttpContextAccessor();


            return services;
        }
    }
}
