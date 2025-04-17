using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

public partial class AuthUser : SystemUser
{
    [Key]
    [ForeignKey("SystemUser")]  
    public Guid Id { get; set; }

    public string Password { get; set; } = null!;

    public virtual SystemUser SystemUser { get; set; } = null!;

}
