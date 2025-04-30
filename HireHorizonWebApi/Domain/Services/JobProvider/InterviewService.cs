using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Helpers;
using Domain.Models;
using Domain.Service.JobProvider.Dtos;
using Domain.Services.JobProvider.Interfaces;

namespace Domain.Services.JobProvider
{
  public class InterviewService : IInterviewService
    {
        public InterviewService(IInterviewRepository _interviewRepository)
        {
            interviewRepository = _interviewRepository;
        }
        public IInterviewRepository interviewRepository { get; set; }
        public JobInterview sheduleinterview(InterviewsheduleDtos interview, CompanyUser userId)
        {
            return interviewRepository.shduleInterview(interview, userId);
        }
        public async Task<PagedList<JobInterview>> sheduledInterviewList(Guid companyid, InterviewParams param)
        {
            return await interviewRepository.sheduledInterviewList(companyid, param);
        }
        public bool removeInterview(Guid id)
        {
            return interviewRepository.removeInterview(id);
        }
    }
}
