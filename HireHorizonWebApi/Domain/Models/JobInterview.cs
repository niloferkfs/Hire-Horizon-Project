using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;


namespace Domain.Models
{
    public class JobInterview
    {
        public Guid Id { get; set; }

        public JobPost? Job { get; set; }
        public Guid? JobId { get; set; }

        public JobSeeker Interviewee { get; set; }
        public Guid IntervieweeId { get; set; }

        public JobApplication? JobApplication { get; set; }
        public Guid? JobApplicationId { get; set; }

        public CompanyUser ScheduledBy { get; set; }
        public Guid ScheduledById { get; set; }

        public DateTime DateScheduled { get; set; }
        public JobInterviewStatus Status { get; set; }
    }
}
