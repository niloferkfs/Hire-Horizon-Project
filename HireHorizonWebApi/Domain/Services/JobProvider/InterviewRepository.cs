using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Enums;
using Domain.Helpers;
using Domain.Models;
using Domain.Service.JobProvider.Dtos;
using Domain.Services.JobProvider.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services.JobProvider
{
    public class InterviewRepository : IInterviewRepository
    {
       HireHorizonApiDbContext context;
        public IMapper mapper { get; set; }

        public InterviewRepository(HireHorizonApiDbContext context, IMapper _mapper)
        {
            this.context = context;
            mapper = _mapper;
        }
        public JobInterview shduleInterview(InterviewsheduleDtos interview, CompanyUser user)

        {
            try
            {
                JobApplication applicaction = context.JobApplications.Where(a => a.Id == interview.ApplicationId).Include(e => e.JobPost).FirstOrDefault();
                var interviewtoshedule = mapper.Map<JobInterview>(interview);
                interviewtoshedule.JobId = applicaction.JobPostId;
                interviewtoshedule.ApplicationId = applicaction.Id;
                interviewtoshedule.Status = JobInterviewStatus.SCHEDULED;
                interviewtoshedule.SheduledBy = user.Id;
                interviewtoshedule.interviewee = applicaction.ApplicantId;
                interviewtoshedule.CompanyId = (Guid)user.Company;


                context.JobInterviews.AddAsync(interviewtoshedule);
                context.SaveChanges();
                return interviewtoshedule;

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public async Task<PagedList<JobInterview>> sheduledInterviewList(Guid companyid, InterviewParams param)
        {
            var query = context.JobInterviews
               .OrderByDescending(c => c.Date).Where(e => e.CompanyId == companyid).Include(e => e.Job).Include(e => e.Jobseeker).Include(e => e.Application).Include(e => e.Company).Include(e => e.CompanyUser)
               .AsQueryable();
            return await PagedList<JobInterview>.CreateAsync(query,
                    param.PageNumber, param.PageSize);


        }
        public bool removeInterview(Guid id)
        {
            JobInterview interview = context.JobInterviews.FirstOrDefault(e => e.Id == id);
            if (interview != null)
            {
                context.JobInterviews.Remove(interview);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
