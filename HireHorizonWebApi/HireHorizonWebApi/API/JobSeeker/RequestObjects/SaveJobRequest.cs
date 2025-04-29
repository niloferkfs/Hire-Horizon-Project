namespace HireHorizonAPI.API.JobSeeker.RequestObjects
{
    public class SaveJobRequest
    {
        public Guid JobPostId { get; set; }
        public Guid SavedById { get; set; }
    }
}
