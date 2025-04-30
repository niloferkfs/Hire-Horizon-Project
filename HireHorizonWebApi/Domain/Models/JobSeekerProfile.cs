using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

public partial class JobSeekerProfile
{
    public Guid Id { get; set; }

    [ForeignKey(nameof(JobSeeker))]
    public Guid JobSeekerId { get; set; }
    public Guid? ResumeId { get; set; }

    public string? ProfileName { get; set; }

    public string? ProfileSummary { get; set; }

    public virtual Resume? Resume { get; set; }

    public virtual ICollection<WorkExperience> WorkExperiences { get; set; } = new List<WorkExperience>();
    public virtual JobSeeker JobSeeker { get; set; }
}
