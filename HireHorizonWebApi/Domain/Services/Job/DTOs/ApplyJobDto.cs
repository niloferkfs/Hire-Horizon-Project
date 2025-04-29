using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Job.DTOs
{
    public class ApplyJobDto
    {
        public Guid JobPostId { get; set; } 
        public Guid ApplicantId { get; set; } 
        public Guid ResumeId { get; set; } 
        public string CoverLetter { get; set; } 
        public DateTime DateSubmitted { get; set; } = DateTime.Now;
    }
}
