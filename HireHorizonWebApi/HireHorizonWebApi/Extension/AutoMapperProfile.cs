using AutoMapper;
using Domain.Helpers;
using Domain.Models;
using Domain.Service.Admin.DTOs;
using Domain.Service.Login.DTOs;
using Domain.Services.Admin.DTOs;
using HireHorizonWebApi.API.Admin.RequestObjects;

namespace HireHorizonWebApi.Extension
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AddSkillRequest, PostedSkillDTO>().ReverseMap();
            CreateMap<CategoryRequest, CategoryDto>().ReverseMap();
            CreateMap<LocationRequest, LocationDto>().ReverseMap();
            CreateMap<IndustryRequest, IndustryDto>().ReverseMap();
            CreateMap<JobSeekerDto, JobSeeker>().ReverseMap();
            CreateMap<CategoryDto, JobCategory>().ReverseMap();
            CreateMap<IndustryDto, Industry>().ReverseMap();
            CreateMap<Joblist, JobPost>().ReverseMap();
            CreateMap<JobProviderDto, CompanyUser>().ReverseMap();
            CreateMap<JobProviderCompany, JobProviderDto>().ReverseMap();
            CreateMap<LocationDto, Location>().ReverseMap();
            CreateMap<PostedSkillDTO, Skill>().ReverseMap();
            CreateMap<AuthUser, AdminLoginDTO>().ReverseMap();

        }
    }
}
