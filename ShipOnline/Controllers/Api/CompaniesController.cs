using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShipOnline.Core;
using ShipOnline.Core.Domain;
using ShipOnline.Persistence;

namespace ShipOnline.Controllers.Api
{
    public class CompaniesController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public CompaniesController()
        {
            _unitOfWork = new UnitOfWork(new ShipBaseDbContext());
        }
        public CompaniesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET /api/companies
        public IEnumerable<Company> GetCompanies()
        {
            return _unitOfWork.Companies.GetAll().ToList();
        }

        // GET /api/companies/1
        public Company GetCompany(string id)
        {
            Company company = _unitOfWork.Companies.SingleOrDefault(c => c.ID == id);
            if (company == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return company;
        }

        // POST /api/companies
        [HttpPost]
        public Company CreateCompany(Company company)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _unitOfWork.Companies.Add(company);
            _unitOfWork.Complete();
            return company;
        }

        // PUT /api/companies/1
        [HttpPut]
        public void UpdateCompany(string id, Company company)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            Company result = _unitOfWork.Companies.SingleOrDefault((c => c.ID == id));
            if (result == null)
                throw  new HttpResponseException(HttpStatusCode.NotFound);

            // Use Automaper to update result

            _unitOfWork.Complete();
        }

        // PUT /api/companies/1
        [HttpDelete]
        public void DeleteCompany(Company company)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            // Check if companu exists
            Company result = _unitOfWork.Companies.SingleOrDefault((c => c.ID == company.ID));
            if (result == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _unitOfWork.Companies.Remove(company);
            _unitOfWork.Complete();
        }

    }
}
 