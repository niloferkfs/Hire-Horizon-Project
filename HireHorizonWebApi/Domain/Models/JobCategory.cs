using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class JobCategory
{
    public Guid Id { get; set; }

    public string? Name { get; set; } = null!;
<<<<<<< HEAD

    public string? Description { get; set; } = null!;
    public virtual ICollection<JobPost> JobPosts { get; set; }=new List<JobPost>();

=======

    public string? Description { get; set; } = null!;

    public virtual ICollection<JobPost> JobPosts { get; set; } = new List<JobPost>();
>>>>>>> 37ea8e62c569e5fd8a8074250fc69e1452ed11b3
}
