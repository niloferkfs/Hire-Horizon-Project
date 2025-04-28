﻿using System.ComponentModel.DataAnnotations;

namespace HireHorizonAPI.API.JobSeeker.RequestObjects
{
    public class JobSeekerLoginRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
