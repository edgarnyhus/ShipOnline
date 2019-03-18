using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ShipOnline.Core.Domain;
using ShipOnline.Core.Repositories;

namespace ShipOnline.Persistence.Repositories
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(ShipBaseDbContext context) : base(context)
        {
        }

        public Company GetCompanyWithShips(string id)
        {
            Company result = ShipBaseDbContext.Companies.Where(u => u.ID == id).SingleOrDefault();
            return result;
        }

        public ShipBaseDbContext ShipBaseDbContext {
            get { return Context as ShipBaseDbContext; }
        }
    }
}