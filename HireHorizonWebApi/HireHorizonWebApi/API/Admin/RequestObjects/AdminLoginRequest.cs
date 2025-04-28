using System.ComponentModel.DataAnnotations;

namespace HireHorizonWebApi.API.Admin.RequestObjects
{
    public class AdminLoginRequest
    {

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
