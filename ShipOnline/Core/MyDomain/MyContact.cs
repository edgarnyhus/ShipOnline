namespace ShipOnline.Core.MyDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MyContact
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long unikid { get; set; }

        [StringLength(50)]
        public string userid { get; set; }

        [StringLength(50)]
        public string rekno { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long mycompanyid { get; set; }

        [StringLength(50)]
        public string contactname { get; set; }

        [StringLength(50)]
        public string mobphone { get; set; }

        [StringLength(50)]
        public string telephone { get; set; }

        [StringLength(100)]
        public string email { get; set; }
    }
}
