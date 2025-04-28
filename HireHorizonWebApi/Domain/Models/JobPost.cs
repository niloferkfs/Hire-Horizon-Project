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
<<<<<<< HEAD


    public Guid? CompanyId { get; set; }

    public Guid? CategoryId { get; set; }

    public Guid? IndustryId { get; set; }
=======
    public Guid? CompanyId { get; set; }
    public Guid? CategoryId { get; set; }
    public Guid? IndustryId { get; set; }
    public Guid? PostedById { get; set; }
>>>>>>> 37ea8e62c569e5fd8a8074250fc69e1452ed11b3

    public Guid? PostedBy { get; set; }
    public DateTime PostedDate { get; set; }

<<<<<<< HEAD
    public virtual Location? LocationNavigation { get; set; } = null!;
    public virtual Industry? IndustryNavigation { get; set; } = null!;
    [ForeignKey(nameof(CompanyId))]
    public virtual JobProviderCompany? CompanyNavigstion { get; set; } = null!;

    public virtual ICollection<JobResponsibility> JobResponsibilities { get; set; } = new List<JobResponsibility>();
    [ForeignKey(nameof(PostedBy))]

    public virtual CompanyUser? PostedByNavigation { get; set; } = null!;
    [ForeignKey(nameof(CategoryId))]
    public virtual JobCategory? CategoryNavigation { get; set; } = null!;
=======

    public virtual Location LocationNavigation { get; set; } = null!;


    public virtual Industry IndustryNavigation { get; set; } = null!;

    [ForeignKey(nameof(CompanyId))]
    public virtual JobProviderCompany CompanyNavigation { get; set; } = null!;

    [ForeignKey(nameof(CategoryId))]
    public virtual JobCategory CategoryNavigation { get; set; } = null!;

    [ForeignKey(nameof(PostedById))]
    public virtual CompanyUser PostedByNavigation { get; set; } = null!;

    public virtual ICollection<JobResponsibility> JobResponsibilities { get; set; } = new List<JobResponsibility>();
>>>>>>> 37ea8e62c569e5fd8a8074250fc69e1452ed11b3
}
