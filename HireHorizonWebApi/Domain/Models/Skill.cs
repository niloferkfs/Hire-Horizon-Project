using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Skill
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<JobSeekerProfile> JobSeekerProfiles { get; set; } = new List<JobSeekerProfile>();
<<<<<<< HEAD
=======

   
>>>>>>> 37ea8e62c569e5fd8a8074250fc69e1452ed11b3
}
