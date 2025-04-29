using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Models
{
    public class SavedJob
    {

        public Guid Id { get; set; }
        
        [ForeignKey(nameof(JobPost))]
        public Guid JobPostId { get; set; }
        [Required]
        [ForeignKey(nameof(JobSeeker))]
        public Guid SavedById { get; set; }
        public DateTime DateSaved { get; set; }
        public virtual JobPost JobPost { get; set; }
        public virtual JobSeeker JobSeeker { get; set; }

       
    }
}
