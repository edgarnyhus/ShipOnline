namespace ShipOnline.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("compnos")]
    public partial class CompNo
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string COMPANY_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string DESCRIPTION { get; set; }

        [StringLength(20)]
        public string NUMBER { get; set; }

        public virtual Company company { get; set; }
    }
}
