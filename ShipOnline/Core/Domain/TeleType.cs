namespace ShipOnline.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("teletype")]
    public partial class TeleType
    {
        [StringLength(10)]
        public string TYPE { get; set; }

        [Key]
        [StringLength(30)]
        public string BETEGNELSE { get; set; }

        public short? SEQUENCE { get; set; }

        [StringLength(1)]
        public string USE_PREFIX { get; set; }

        [StringLength(20)]
        public string CAPTION_NOR { get; set; }

        [StringLength(20)]
        public string CAPTION_ENG { get; set; }

        [StringLength(4)]
        public string FORMAT { get; set; }
    }
}
