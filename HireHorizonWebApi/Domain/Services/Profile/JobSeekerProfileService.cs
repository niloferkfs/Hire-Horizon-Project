using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Models;
using Domain.Service.Authuser.DTOs;
using Domain.Service.Profile.DTOs;
using Domain.Service.Profile.Interface;

namespace Domain.Services.Profile
{
    public class JobSeekerProfileService : IJobSeekerProfileService
    {
        public readonly IJobSeekerProfileRepository _profileRepository;
        IMapper mapper;
        public JobSeekerProfileService(IJobSeekerProfileRepository profileRepository, IMapper _mapper)
        {
            mapper = _mapper;
            _profileRepository = profileRepository;
        }

        public async Task<bool> AddProfileAsync(ProfileDTO addProfileDto)
        {
            var profile = mapper.Map<JobSeekerProfile>(addProfileDto);
            await _profileRepository.AddProfileAsync(profile);
            return true;
        }



        public Task AddQualificationToProfileAsync(Guid jobseekerId, Guid profileId, JobseekerQualificationDTo jobseekerQualificationDTo)
        {
            var profile = _profileRepository.GetJobSeekerProfileByIds(jobseekerId, profileId);
            if (profile != null)
            {
                var Qualification = mapper.Map<Qualification>(jobseekerQualificationDTo);
                return _profileRepository.AddQualificationsToProfile(profileId, Qualification);

            }
            else
            {
                throw new Exception("Profile not found");
            }
        }



        



        public List<JobSeekerProfileDTo> GetProfile(Guid jobseekerId)
        {
            return _profileRepository.GetProfile(jobseekerId);
        }




       

        public List<JobseekerQualificationDTo> GetQualification(Guid profileId)
        {

            var Qualifications = _profileRepository.GetQualification(profileId);
            var QualificationDtos = mapper.Map<List<JobseekerQualificationDTo>>(Qualifications);

            return QualificationDtos;

        }



        public async Task<AuthUserDTO> UpdateJobSeekerProfile(AuthUserDTO updatedProfile)
        {
            
            var result = await _profileRepository.UpdateProfile(updatedProfile);

            return result;
        }
    }
}
