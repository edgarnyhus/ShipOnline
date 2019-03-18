namespace ShipOnline.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("place")]
    public partial class Place
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string NATION_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string ID { get; set; }

        [StringLength(30)]
        public string NAME { get; set; }

        [StringLength(4)]
        public string COUNTY_ID { get; set; }
    }
}
