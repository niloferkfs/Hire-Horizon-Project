namespace HireHorizonWebApi.API.JobProvider.RequestObjects
{
    public class AddCompanyUserRequest
    {
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;

        public string Password { get; set; }
    }
}
