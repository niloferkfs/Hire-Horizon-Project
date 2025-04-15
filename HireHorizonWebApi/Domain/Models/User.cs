﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
   public class User
    {
       
            public Guid UserId { get; set; } 
            public string FullName { get; set; } 
            public string Email { get; set; } 
            public string PasswordHash { get; set; } 
            public string PhoneNumber { get; set; } 
            public string Role { get; set; } 
            public bool IsEmailVerified { get; set; }
        }
    }

