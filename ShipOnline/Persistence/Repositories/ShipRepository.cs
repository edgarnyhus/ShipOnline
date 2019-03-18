using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShipOnline.Core.Domain;
using ShipOnline.Core.Repositories;

namespace ShipOnline.Persistence.Repositories
{
    public class ShipRepository : Repository<Ship>, IShipRepository
    {
        public ShipRepository(ShipBaseDbContext context) : base(context)
        {
        }

        public List<Ship> GetShips()
        {
            return GetAll().ToList();
        }

        public ShipBaseDbContext ShipBaseDbContext {
            get { return Context as ShipBaseDbContext; }
        }
    }
}