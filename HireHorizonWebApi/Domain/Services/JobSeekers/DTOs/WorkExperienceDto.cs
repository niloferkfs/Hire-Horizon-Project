using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.JobSeekers.DTOs
{
    public class WorkExperienceDto
    {

        public Guid JobSeekerProfileId { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string Summary { get; set; }
        public DateTime ServiceStart { get; set; }
        public DateTime ServiceEnd { get; set; }
    }
}
