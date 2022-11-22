﻿using ORM.Dtos;
using ORM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORM.Contracts
{
    public interface ICompanyRepository
    {
		public Task<IEnumerable<Company>> GetCompanies();
        public Task<Company> GetCompany(int id);
        public Task<Company> CreateCompany(CompanyDTO company);
        //public Task UpdateCompany(int id, CompanyForUpdateDto company);
        //public Task DeleteCompany(int id);
        //public Task<Company> GetCompanyByEmployeeId(int id);
        public Task<Company> GetCompanyEmployeesMultipleResults(int id);
        public Task<List<Company>> GetCompaniesEmployeesMultipleMapping();
        //public Task CreateMultipleCompanies(List<CompanyForCreationDto> companies);
    }
}
