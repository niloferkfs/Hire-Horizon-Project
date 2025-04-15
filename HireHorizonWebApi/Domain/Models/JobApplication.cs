using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;
using HireHorizonAPI.Models;

namespace Domain.Models
{
    public class JobApplication
    {
       
            public Guid Id { get; set; }

            public JobPost JobPost { get; set; }
            public Guid JobPostId { get; set; }

            public JobSeeker Applicant { get; set; }
            public Guid ApplicantId { get; set; }

            public Resume Resume { get; set; }
            public Guid ResumeId { get; set; }

            public string CoverLetter { get; set; }
            public DateTime DateSubmitted { get; set; }
            public JobApplicationStatus Status { get; set; }
        

    }
}
