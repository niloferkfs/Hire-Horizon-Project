using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Helpers;
using Domain.Models;
using Domain.Service.JobProvider.DTOs;

namespace Domain.Services.JobProvider.Interfaces
{
  public interface ICompanyRepository
    {
        Task AddCompany(JobProviderCompany data, Guid UserId);
        JobProviderCompany GetCompany(Guid companyId);
        Task<JobProviderCompany> updateCompanyAsync(JobProviderCompany company);
        Task<PagedList<CompanyUser>> memberListing(Guid companyId, CompanyMemberListParam param);
        bool memberDeleteById(Guid id);

        Task<CompanyMemberDtos> AddMemberAsync(CompanyMemberDtos companyMember, Guid companyId);
    }
}
