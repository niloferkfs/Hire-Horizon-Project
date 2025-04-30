using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Helpers;
using Domain.Models;
using Domain.Service.JobProvider.Dtos;

namespace Domain.Services.JobProvider.Interfaces
{
   public interface IInterviewService
    {
        JobInterview sheduleinterview(InterviewsheduleDtos interview, CompanyUser userId);
        Task<PagedList<JobInterview>> sheduledInterviewList(Guid companyid, InterviewParams param);

        bool removeInterview(Guid id);

    }
}
