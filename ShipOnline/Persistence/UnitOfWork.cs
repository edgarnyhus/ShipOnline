using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShipOnline.Core;
using ShipOnline.Core.Repositories;
using ShipOnline.Persistence.Repositories;

namespace ShipOnline.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ShipBaseDbContext _context;

        public UnitOfWork(ShipBaseDbContext context)
        {
            _context = context;
            Companies = new CompanyRepository(_context);
            Ships = new ShipRepository(_context);
        }

        public ICompanyRepository Companies { get; private set; }
        public IShipRepository Ships { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
