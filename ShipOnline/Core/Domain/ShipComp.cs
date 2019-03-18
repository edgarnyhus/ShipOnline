namespace ShipOnline.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("shipcomp")]
    public partial class ShipComp
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string COMPANY_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(7)]
        public string SHIP_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string ROLE_ID { get; set; }

        [StringLength(50)]
        public string SHIP_NAME { get; set; }

        public virtual Company company { get; set; }

        public virtual Role role { get; set; }
    }
}
