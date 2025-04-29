namespace HireHorizonWebApi.API.JobSeeker.RequestObjects
{
    public class ResumeUploadRequest
    {
        public string? Title { get; set; }
        public IFormFile? File { get; set; }
    }
}
