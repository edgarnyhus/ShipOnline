namespace ShipOnline.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("shiptype")]
    public partial class ShipType
    {
        public short? NO { get; set; }

        [StringLength(25)]
        public string ID { get; set; }

        [StringLength(25)]
        public string SHIPCAT { get; set; }

        [StringLength(10)]
        public string LR_TYPE { get; set; }

        [StringLength(40)]
        public string LR_DESCRIPTION { get; set; }

        [StringLength(30)]
        public string LR_REMARKS { get; set; }

        [StringLength(10)]
        public string TYPE_CODE { get; set; }
    }
}
