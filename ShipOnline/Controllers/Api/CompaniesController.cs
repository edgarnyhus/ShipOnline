using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Configuration;
using System.Web.Http;
using AutoMapper;
using ShipOnline.Core;
using ShipOnline.Core.Domain;
using ShipOnline.Persistence;
using ShipOnline.Dtos;

namespace ShipOnline.Controllers.Api
{
    public class CompaniesController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        // Using Data Transfer Object

        //public CompaniesController()
        //{
        //    _unitOfWork = new UnitOfWork(new ShipBaseDbContext());
        //}
        public CompaniesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET /api/companies
        [HttpGet]
        public IEnumerable<CompanyDto> GetCompanies()
        {
            List<Company> result = _unitOfWork.Companies.GetAll().ToList();
            return result.Select(Mapper.Map<Company, CompanyDto>);
        }

        // Return Data Transfer Object
        [HttpGet]
        public CompanyDto GetCompany(string id)
        {
            var company = _unitOfWork.Companies.SingleOrDefault(c => c.ID == id);
            if (company == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return Mapper.Map<Company, CompanyDto>(company);
        }

        // POST /api/companies
        [HttpPost]
        public CompanyDto CreateCompany(CompanyDto companyDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var company = Mapper.Map<CompanyDto, Company>(companyDto);
            _unitOfWork.Companies.Add(company);
            _unitOfWork.Complete();

            companyDto.ID = company.ID;
            return companyDto;
        }

        // PUT /api/companies/1
        [HttpPut]
        public void UpdateCompany(string id, CompanyDto companyDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            Company result = _unitOfWork.Companies.SingleOrDefault((c => c.ID == id));
            if (result == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            // Use Automaper to update result
            //var company = Mapper.Map<CompanyDto, Company>(companyDto, result);
            var company = Mapper.Map(companyDto, result);

            _unitOfWork.Complete();
        }

        // PUT /api/companies/1
        [HttpDelete]
        public void DeleteCompany(CompanyDto companyDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            // Check if companu exists
            Company company = _unitOfWork.Companies.SingleOrDefault((c => c.ID == companyDto.ID));
            if (company == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(companyDto, company);

            _unitOfWork.Companies.Remove(company);
            _unitOfWork.Complete();
        }
    }
}
 