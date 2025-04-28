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
using Domain.Service.Job.Interfaces;
using Domain.Service.Job;
using Domain.Service.JobProvider;
using Domain.Service.Profile.Interface;
using Domain.Service.Profile;
using Domain.Service.User.Interface;
using Domain.Service.User;
using Domain.Services.Email;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<HireHorizonApiDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            //services.AddTransient<IEmailService, EmailService>();
            


            

            return services;
        }
    }
}
