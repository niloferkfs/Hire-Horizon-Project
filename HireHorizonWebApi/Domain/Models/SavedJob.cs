using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Models
{
    public class SavedJob
    {
        public Guid Id { get; set; }

        public JobPost JobPost { get; set; }
        public Guid JobPostId { get; set; }

        public JobSeeker SavedBy { get; set; }
        public Guid SavedById { get; set; }

        public DateTime DateSaved { get; set; }
    }
}
