using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Service.Job.DTOs
{

    public class JobPostsDtos
    {
        public Guid Id { get; set; }

        public string JobTitle { get; set; } = null!;

        public string JobSummary { get; set; } = null!;

      
        public string LocationName { get; set; } = string.Empty;
        public string IndustryName { get; set; } = string.Empty;
        public string JobCategoryName { get; set; } = string.Empty;
        public string PostedByNavigationFirstName { get; set; } = string.Empty;

        public DateTime PostedDate { get; set; }

        public bool Saved { get; set; } = false;

        public Location? LocationNavigation { get; set; }
        public Industry? IndustryNavigation { get; set; }
        public JobCategory? CategoryNavigation { get; set; }
        public CompanyUser? PostedByNavigation { get; set; }

       

      
    }
}


