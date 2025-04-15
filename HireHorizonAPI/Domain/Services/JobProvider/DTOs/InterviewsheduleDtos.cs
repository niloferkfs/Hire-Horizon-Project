using Domain.Models;
using HireHorizonAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.JobProvider.Dtos
{
	public class InterviewsheduleDtos
	{
		public Guid? ApplicationId { get; set; }
		public DateTime? Date { get; set; }
		public JobPost Job { get; set; }
		public JobProviderCompany Company { get; set; }
		public HireHorizonAPI.Models.JobSeeker Jobseeker { get; set; }
		public virtual CompanyUser? CompanyUser { get; set; }


	}
}
