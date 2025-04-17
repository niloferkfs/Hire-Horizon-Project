using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Service.Admin.DTOs;
using Domain.Models;
using AutoMapper;
using Domain.Services.Admin.DTOs;

namespace Domain.Helpers
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<JobSeekerDto, JobSeeker>().ReverseMap();
            CreateMap<CategoryDto, JobCategory>().ReverseMap();
            CreateMap<IndustryDto, Industry>().ReverseMap();
            CreateMap<Joblist, JobPost>().ReverseMap();
            CreateMap<JobProviderDto, CompanyUser>().ReverseMap();
            CreateMap<LocationDto, Location>().ReverseMap();
            CreateMap<PostedSkillDTO, Skill>().ReverseMap();
        }
    }
}
