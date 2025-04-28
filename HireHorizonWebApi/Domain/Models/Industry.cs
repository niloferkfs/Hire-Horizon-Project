using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Industry
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

<<<<<<< HEAD
    public virtual ICollection<JobPost> JobPosts { get; set; }=new List<JobPost>();
    public virtual ICollection<JobProviderCompany> JobProviderCompanies { get; set; }=new List<JobProviderCompany>();
=======
    public virtual ICollection<JobPost> JobPosts { get; set; } = new List<JobPost>();

    public virtual ICollection<JobProviderCompany> JobProviderCompanies { get; set; } = new List<JobProviderCompany>();
>>>>>>> 37ea8e62c569e5fd8a8074250fc69e1452ed11b3
}
