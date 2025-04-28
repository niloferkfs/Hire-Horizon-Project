using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

public partial class JobPost
{
    public Guid Id { get; set; }

    public string JobTitle { get; set; } = null!;
    public string JobSummary { get; set; } = null!;

    public Guid? LocationId { get; set; }
    public Guid? CompanyId { get; set; }
    public Guid? CategoryId { get; set; }
    public Guid? IndustryId { get; set; }
    public Guid? PostedById { get; set; }

    public DateTime PostedDate { get; set; }


    public virtual Location LocationNavigation { get; set; } = null!;


    public virtual Industry IndustryNavigation { get; set; } = null!;

    [ForeignKey(nameof(CompanyId))]
    public virtual JobProviderCompany CompanyNavigation { get; set; } = null!;

    [ForeignKey(nameof(CategoryId))]
    public virtual JobCategory CategoryNavigation { get; set; } = null!;

    [ForeignKey(nameof(PostedById))]
    public virtual CompanyUser PostedByNavigation { get; set; } = null!;

    public virtual ICollection<JobResponsibility> JobResponsibilities { get; set; } = new List<JobResponsibility>();
}
