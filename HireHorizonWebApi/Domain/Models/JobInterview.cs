﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;
using static System.Net.Mime.MediaTypeNames;


namespace Domain.Models
{
    public class JobInterview
    {
        public Guid Id { get; set; }
        [ForeignKey(nameof(Job))]
        public Guid? JobId { get; set; }
        [ForeignKey(nameof(Jobseeker))]
        public Guid? interviewee { get; set; }
        [ForeignKey(nameof(Application))]
        public Guid? ApplicationId { get; set; }

        public DateTime? Date { get; set; }


        public JobInterviewStatus Status { get; set; }
        [ForeignKey(nameof(CompanyUser))]
        public Guid? SheduledBy { get; set; }

        public virtual CompanyUser? CompanyUser { get; set; }

        public virtual JobPost? Job { get; set; }
        public virtual JobSeeker? Jobseeker { get; set; }
        public virtual JobApplication? Application { get; set; }
        [ForeignKey(nameof(Company))]
        public Guid CompanyId { get; set; }
        public virtual JobProviderCompany Company { get; set; }

    }
}