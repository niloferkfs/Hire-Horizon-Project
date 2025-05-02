using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Service.Authuser.DTOs;
using Domain.Service.Profile.DTOs;
using Domain.Service.Profile.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services.Profile
{
    public class Jobseekerprofilerepository : IJobSeekerProfileRepository
    {
        protected readonly HireHorizonApiDbContext _context;
        public Jobseekerprofilerepository(HireHorizonApiDbContext context)
        {
            _context = context;
        }

        public async Task AddProfileAsync(JobSeekerProfile profile)
        {
            profile.Id = Guid.NewGuid();
            _context.JobSeekerProfiles.Add(profile);
            await _context.SaveChangesAsync();
        }

        public async Task AddQualificationsToProfile(Guid profileId, Qualification qualification)
        {

            qualification.JobseekerProfileId = profileId;
            _context.Qualifications.Add(qualification);
            await _context.SaveChangesAsync();

        }



        public async Task<JobSeekerProfile?> GetJobSeekerProfileByIds(Guid jobseekerId, Guid profileId)
        {
            return await _context.JobSeekerProfiles
             .FirstOrDefaultAsync(profile => profile.JobSeekerId == jobseekerId && profile.Id == profileId);
        }

        public List<JobSeekerProfileDTo> GetProfile(Guid jobseekerId)
        {
            var jobSeekerProfile = _context.JobSeekerProfiles
           .Include(profile => profile.JobSeeker)
           .FirstOrDefault(profile => profile.JobSeekerId == jobseekerId);

            if (jobSeekerProfile == null)
            {

                return new List<JobSeekerProfileDTo>();
            }

            var jobSeekerProfileDTO = new JobSeekerProfileDTo
            {
                UserName = jobSeekerProfile.JobSeeker.UserName,
                FirstName = jobSeekerProfile.JobSeeker.FirstName,
                LastName = jobSeekerProfile.JobSeeker.LastName,
                Phone = jobSeekerProfile.JobSeeker.Phone,
                Email = jobSeekerProfile.JobSeeker.Email
                //Role = jobSeekerProfile.JobSeeker.Role

            };


            return new List<JobSeekerProfileDTo> { jobSeekerProfileDTO };
        }


        public List<Qualification> GetQualification(Guid profileId)
        {
            return _context.Qualifications
                .Where(qualification => qualification.JobseekerProfileId == profileId)
                .ToList();
        }

        public async Task<AuthUserDTO> UpdateProfile(AuthUserDTO updatedProfile)
        {
            var existingProfile = _context.AuthUsers.FirstOrDefault(e => e.Id == updatedProfile.JobseekerId);
            var existingProfile2 = _context.JobSeekers.FirstOrDefault(e => e.Id == updatedProfile.JobseekerId);

            if (existingProfile == null || existingProfile2 == null)
            {
                return null;
            }

         
            if (!string.IsNullOrEmpty(updatedProfile.FirstName))
            {
                existingProfile.FirstName = updatedProfile.FirstName;
                existingProfile2.FirstName = updatedProfile.FirstName;
            }

            if (!string.IsNullOrEmpty(updatedProfile.LastName))
            {
                existingProfile.LastName = updatedProfile.LastName;
                existingProfile2.LastName = updatedProfile.LastName;
            }

            if (!string.IsNullOrEmpty(updatedProfile.Phone))
            {
                existingProfile.Phone = updatedProfile.Phone;
                existingProfile2.Phone = updatedProfile.Phone;
            }

            if (!string.IsNullOrEmpty(updatedProfile.Password))
            {
               // existingProfile.Password = updatedProfile.Password;
            }

            if (!string.IsNullOrEmpty(updatedProfile.UserName))
            {
                existingProfile.UserName = updatedProfile.UserName;
                existingProfile2.UserName = updatedProfile.UserName;
            }

            await _context.SaveChangesAsync();

            return updatedProfile;
        }




    }
}

