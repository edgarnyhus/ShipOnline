namespace ShipOnline.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("category")]
    public partial class Category
    {
        [StringLength(3)]
        public string ID { get; set; }

        [StringLength(31)]
        public string DESCRIPTION { get; set; }

        public double? PRIS { get; set; }

        [StringLength(3)]
        public string INTERNET { get; set; }

        [StringLength(20)]
        public string MAIN_AREA { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}
