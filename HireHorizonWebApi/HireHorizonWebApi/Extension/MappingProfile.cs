using AutoMapper;
using Domain.Models;
using Domain.Service.Admin.DTOs;
using Domain.Service.Job.DTOs;
using Domain.Service.JobProvider.Dtos;
using Domain.Service.SignUp.DTOs;
using Domain.Services.Admin.DTOs;
using Domain.Services.Login.Dto;
using HireHorizonWebApi.API.JobProvider.RequestObjects;

namespace HireHorizonWebApi.Extension
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<JobSeekerDto, JobSeeker>().ReverseMap();
            CreateMap<CategoryDto, JobCategory>().ReverseMap();
            CreateMap<IndustryDto, Industry>().ReverseMap();
            CreateMap<Joblist, JobPost>().ReverseMap();
            CreateMap<JobProviderDto, CompanyUser>().ReverseMap();
            CreateMap<LocationDto, Location>().ReverseMap();
            CreateMap<PostedSkillDTO, Skill>().ReverseMap();
            CreateMap<JobProviderSignupRequestDto, SignUpRequest>().ReverseMap();
            CreateMap<AuthUser, JobProviderLoginDto>().ReverseMap();
            CreateMap<SignUpRequest, AuthUser>().ReverseMap();
            CreateMap<AuthUser, CompanyUser>().ReverseMap();
            CreateMap<JobPost, JobPostsDtos>().ReverseMap();
            CreateMap<JobProviderSignUpRequest, JobProviderSignupRequestDto>().ReverseMap();
            CreateMap<AddCompanyRequest, CompanyRegistrationDtos>().ReverseMap();
            CreateMap<CompanyRegistrationDtos, JobProviderCompany>().ReverseMap();
            CreateMap<JobProviderCompany, GetCompanyDetailsDto>().ReverseMap();
            CreateMap<JobPostRequest, JobPost>().ReverseMap();
        }
    }
}
