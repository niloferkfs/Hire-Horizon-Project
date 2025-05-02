using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Service.Job.DTOs
{
	public class SavedJobsDtos
	{

        public Guid JobPostId { get; set; } 
        public Guid SavedById { get; set; } 
        public DateTime DateSaved { get; set; } = DateTime.Now;


    }
}
