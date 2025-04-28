using Microsoft.AspNetCore.Http;

namespace Domain.Service.Authuser.DTOs
{
    public class AuthUserDTO
    {
        public Guid JobseekerId { get; set; }
        public string? UserName { get; set; }

        public string? FirstName { get; set; } = null!;

        public string? LastName { get; set; }
        
        public string? Phone { get; set; }

        public string? Password { get; set; }
    }
}
