namespace HireHorizonWebApi.API.JobSeeker.RequestObjects
{
    public class RemoveJobApplicationRequest
    {
        public Guid JobPostId { get; set; }
        public Guid ApplicantId { get; set; }
    }
}
