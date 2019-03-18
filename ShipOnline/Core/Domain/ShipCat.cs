namespace ShipOnline.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("shipcat")]
    public partial class ShipCat
    {
        [StringLength(25)]
        public string ID { get; set; }

        [StringLength(1)]
        public string PUB_INTERNET { get; set; }
    }
}
