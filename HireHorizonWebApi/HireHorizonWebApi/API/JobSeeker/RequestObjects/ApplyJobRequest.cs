namespace HireHorizonAPI.API.JobSeeker.RequestObjects
{
    public class ApplyJobRequest
    {
        public Guid JobPostId { get; set; }
        public Guid ApplicantId { get; set; }
        public Guid ResumeId { get; set; }
       
    }
}
