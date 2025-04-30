using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class JobProviderCompany
{
    [Key]
  
    public Guid Id { get; set; }

    public string LegalName { get; set; } = null!;
    public string Summary { get; set; } = null!;
    public string Email { get; set; } = null!;
    public long Phone { get; set; }
    public string Address { get; set; } = null!;
    public string Website { get; set; } = null!;

    public Guid IndustryId { get; set; }
   
    public virtual Industry IndustryNavigation { get; set; } = null!;

    public Guid LocationId { get; set; }
   
    public virtual Location LocationNavigation { get; set; } = null!;

    public virtual ICollection<CompanyUser> CompanyUsers { get; set; } = new List<CompanyUser>();
}
