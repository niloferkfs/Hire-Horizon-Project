using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

public partial class JobSeekerProfile
{
    public Guid Id { get; set; }

    [ForeignKey(nameof(JobSeeker))]
<<<<<<< HEAD
    public Guid JobSeekerId { get; set; }    
=======
    public Guid JobSeekerId { get; set; }
>>>>>>> 37ea8e62c569e5fd8a8074250fc69e1452ed11b3
    public Guid? ResumeId { get; set; }

    public string? ProfileName { get; set; }

    public string? ProfileSummary { get; set; }

<<<<<<< HEAD
    public virtual Resume? Resume { get; set; } 

    public virtual ICollection<WorkExperience> WorkExperiences { get; set; } = new List<WorkExperience>();
    public virtual JobSeeker JobSeeker { get; set; }   

    
    
=======
    public virtual Resume? Resume { get; set; }

    public virtual ICollection<WorkExperience> WorkExperiences { get; set; } = new List<WorkExperience>();
    public virtual JobSeeker JobSeeker { get; set; }
>>>>>>> 37ea8e62c569e5fd8a8074250fc69e1452ed11b3
}
