using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShipOnline.Core.Domain;

namespace ShipOnline.ViewModels
{
    public class CompanyViewModel
    {
        public List<Company> Companies { get; set; }
        public List<Ship> Ships { get; set; }

    }
}