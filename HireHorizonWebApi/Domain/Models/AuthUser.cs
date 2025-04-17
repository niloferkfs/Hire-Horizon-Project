using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

<<<<<<< HEAD
public partial class AuthUser : SystemUser
=======
public partial class AuthUser:SystemUser
>>>>>>> 1019875f1cd5d1f28b552c6df0b924478a2aef62
{
    [Key]
   
    [ForeignKey("SystemUser")]  
    public Guid Id { get; set; }

    public string Password { get; set; } = null!;



    public virtual SystemUser SystemUser { get; set; } = null!;

}
