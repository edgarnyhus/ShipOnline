namespace ShipOnline.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shire
    {
        [Key]
        [StringLength(30)]
        public string SHIRE_NAME { get; set; }

        [StringLength(3)]
        public string NATION_ID { get; set; }
    }
}
