using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Service.Admin.DTOs;
using Domain.Service.Authuser.DTOs;
using Domain.Service.Profile.DTOs;

namespace Domain.Service.Profile.Interface
{
    public interface IJobSeekerProfileRepository
    {

        Task<JobSeekerProfile?> GetJobSeekerProfileByIds(Guid jobseekerId, Guid profileId);
        Task AddQualificationsToProfile(Guid profileId, Qualification qualification);
        List<Qualification> GetQualification(Guid profileId);
        List<JobSeekerProfileDTo> GetProfile(Guid jobseekerId);
        //Task<AuthUserDTO> UpdateProfile(AuthUserDTO updatedProfile);
        Task<AuthUserDTO> UpdateProfile(AuthUserDTO updatedProfile);
      
        Task AddProfileAsync(JobSeekerProfile profile);
     
    }
}
