using System;
using System.Collections.Generic;
using Domain.Enums;

namespace Domain.Models;

public partial class JobSeeker
{
    public Guid Id { get; set; }

    public string? UserName { get; set; }

    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

<<<<<<< HEAD
    public Roles Role { get; set; }  //changed 
=======
    public Roles Role { get; set; }
>>>>>>> 37ea8e62c569e5fd8a8074250fc69e1452ed11b3

   
}
