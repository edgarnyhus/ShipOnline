using ShipOnline.Core.MyDomain;

namespace ShipOnline.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("area")]
    public partial class Area
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Area()
        {
            myships = new HashSet<MyShip>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string ID { get; set; }

        [Required]
        [StringLength(40)]
        public string NAME { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string NATION_ID { get; set; }

        [StringLength(4)]
        public string COUNTY_ID { get; set; }

        [StringLength(30)]
        public string SHIRE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MyShip> myships { get; set; }
    }
}
