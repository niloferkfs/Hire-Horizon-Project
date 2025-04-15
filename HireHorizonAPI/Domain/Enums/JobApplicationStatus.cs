using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum JobApplicationStatus
    {
        SUBMITTED,
        SHORTLISTED_BY_EMPLOYER,
        INTERVIEW_SCHEDULED,
        INTERVIEW_CONDUCTED,
        OFFERED,
        REJECTED_BY_EMPLOYER,
        HIRED,
        REJECTED_BY_JOB_SEEKER,
        ON_HOLD
    }
}
