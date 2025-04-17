using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Models;

public partial class CompanyUser
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string? LastName { get; set; }
    [Required]
    public Enums.Roles Roles { get; set; }
    public string? UserName { get; set; }   
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;
    [ForeignKey(nameof(CompanyNavigation))] 

    public Guid? Company { get; set; }
    [JsonIgnore]
    public virtual JobProviderCompany? CompanyNavigation { get; set; }

    public virtual ICollection<JobPost> JobPosts { get; set; } = new List<JobPost>();
}
