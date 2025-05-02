using AutoMapper;
using Domain.Models;
using Domain.Service.Admin.DTOs;
using Domain.Service.Authuser.DTOs;
using Domain.Service.Job.DTOs;
using Domain.Service.JobProvider.Dtos;
using Domain.Service.JobProvider.DTOs;
using Domain.Service.JobSeekers.DTOs;
using Domain.Service.Login.DTOs;
using Domain.Service.Profile.DTOs;
using Domain.Service.SignUp.DTOs;
using Domain.Services.Admin.DTOs;
using Domain.Services.Job.DTOs;
using Domain.Services.JobSeekers.DTOs;
using Domain.Services.Login.Dto;
using HireHorizonAPI.API.JobSeeker.RequestObjects;
using HireHorizonWebApi.API.Admin.RequestObjects;
using HireHorizonWebApi.API.JobProvider.RequestObjects;
using HireHorizonWebApi.API.JobSeeker.RequestObjects;

namespace HireHorizonWebApi.Extension
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            //jobseeker
            CreateMap<AuthUser, JobSeeker>().ReverseMap();
            CreateMap<AuthUser, SystemUser>().ReverseMap();
            CreateMap<SignUpRequest, SystemUser>().ReverseMap();
            
            //.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<JobSeekerLoginDto, AuthUser>().ReverseMap();
            CreateMap<SignUpRequest, AuthUser>().ReverseMap();
            CreateMap<JobSeekerSignUpRequest, JobSeekerSignupRequestDto>().ReverseMap();
            CreateMap<JobSeekerSignupRequestDto, SignUpRequest>().ReverseMap();

            CreateMap<ProfileDTO, JobSeekerProfile>().ReverseMap();
            CreateMap<JobseekerQualificationDTo, Qualification>().ReverseMap();
            CreateMap<JobSeekerProfileDTo, JobSeekerProfile>().ReverseMap();

            CreateMap<ApplyJobDto,JobApplication>().ReverseMap();
            CreateMap<SavedJobsDtos, SavedJob>().ReverseMap();
            CreateMap<ApplyJobRequest, ApplyJobDto>().ReverseMap();
            CreateMap<SaveJobRequest, SavedJobsDtos>().ReverseMap();
            CreateMap<RemoveJobApplicationRequest, ApplyJobDto>().ReverseMap();

            CreateMap<resumeDto,Resume>().ReverseMap();
            CreateMap<WorkExperienceDto, WorkExperience>().ReverseMap();




            //
            CreateMap<AddSkillRequest, PostedSkillDTO>().ReverseMap();
            CreateMap<CategoryRequest, CategoryDto>().ReverseMap();
            CreateMap<LocationRequest, LocationDto>().ReverseMap();
            CreateMap<IndustryRequest, IndustryDto>().ReverseMap();

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
            CreateMap<AddCompanyUserRequest, CompanyMemberDtos>().ReverseMap();
            CreateMap<CompanyMemberDtos, CompanyUser>().ReverseMap();
            CreateMap<CompanyMemberDtos, AuthUser>().ReverseMap();
            CreateMap<CompanyMemberListDtos, CompanyUser>().ReverseMap();
            CreateMap<JobProviderDtos, CompanyUser>().ReverseMap();
            CreateMap<JobProviderCompany, JobProviderDtos>().ReverseMap();
            CreateMap<LocationDto, Location>().ReverseMap();
            CreateMap<PostedSkillDTO, Skill>().ReverseMap();
            CreateMap<AuthUser, AdminLoginDTO>().ReverseMap();

        }
    }
}
