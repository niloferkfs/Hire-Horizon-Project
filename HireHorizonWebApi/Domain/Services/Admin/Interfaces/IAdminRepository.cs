using Domain.Helpers;
using Domain.Models;
using Domain.Service.Admin.DTOs;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Admin.Interfaces
{
    public interface IAdminRepository
    {


        public List<Domain.Models.JobSeeker> GetJobSeekers();


      

    }

}
