using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

[Table("AuthUser")]
public partial class AuthUser:SystemUser
{
    
<<<<<<< HEAD

=======
>>>>>>> 37ea8e62c569e5fd8a8074250fc69e1452ed11b3
    public string Password { get; set; } = null!;



<<<<<<< HEAD
  
=======
   
>>>>>>> 37ea8e62c569e5fd8a8074250fc69e1452ed11b3

}
