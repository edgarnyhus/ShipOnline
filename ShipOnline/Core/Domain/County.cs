namespace ShipOnline.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("county")]
    public partial class County
    {
        [StringLength(4)]
        public string ID { get; set; }

        [StringLength(30)]
        public string NAME { get; set; }

        [StringLength(30)]
        public string SHIRE { get; set; }
    }
}
