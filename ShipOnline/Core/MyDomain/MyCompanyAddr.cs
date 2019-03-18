namespace ShipOnline.Core.MyDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MyCompanyAdr")]
    public partial class MyCompanyAddr
    {
        [StringLength(10)]
        public string inscompanyid { get; set; }

        [Key]
        [StringLength(10)]
        public string intid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? adresstype { get; set; }

        [StringLength(50)]
        public string adress { get; set; }

        [StringLength(10)]
        public string Nation_id { get; set; }

        [StringLength(10)]
        public string postnr { get; set; }

        public long mycompanyid { get; set; }

        public virtual MyAddressType MyAddressType { get; set; }
    }
}
