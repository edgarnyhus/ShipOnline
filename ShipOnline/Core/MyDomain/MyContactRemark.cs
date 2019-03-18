namespace ShipOnline.Core.MyDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mycontactremark")]
    public partial class MyContactRemark
    {
        [StringLength(50)]
        public string userid { get; set; }

        public long? rekno { get; set; }

        public long? mycontactid { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long remarkid { get; set; }

        [Column(TypeName = "date")]
        public DateTime? regdate { get; set; }

        [StringLength(50)]
        public string description { get; set; }

        public string remarks { get; set; }
    }
}
