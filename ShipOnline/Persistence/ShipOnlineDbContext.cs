using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using ShipOnline.Core.MyDomain;

namespace ShipOnline.Persistence
{
    public class ShipOnlineDbContext
    {

        public partial class ShipBaseDbContext : DbContext
        {
            public ShipBaseDbContext()
                : base("name=ShipOnlineDbContext")
            {
            }

            public virtual DbSet<MyAddressType> myAdressTypes { get; set; }
            public virtual DbSet<MyCompanyAddr> myCompanyAddrs { get; set; }
            public virtual DbSet<MyShip> myShips { get; set; }
            public virtual DbSet<MyComanyRemark> myComanyRemarks { get; set; }
            public virtual DbSet<MyCompany> myCompanies { get; set; }
            public virtual DbSet<MyCompNo> myCompNos { get; set; }
            public virtual DbSet<MyContactRemark> myContactRemarks { get; set; }
            public virtual DbSet<MyContact> myContacts { get; set; }
            public virtual DbSet<MyShipContact> myShipContacts { get; set; }
            public virtual DbSet<MyShipRemark> myShipRemarks { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Entity<MyAddressType>()
                    .Property(e => e.myadresstype1)
                    .HasPrecision(18, 0);

                modelBuilder.Entity<MyAddressType>()
                    .HasMany(e => e.MyCompanyAdrs)
                    .WithOptional(e => e.MyAddressType)
                    .HasForeignKey(e => e.adresstype);

                modelBuilder.Entity<MyCompanyAddr>()
                    .Property(e => e.inscompanyid)
                    .IsFixedLength();

                modelBuilder.Entity<MyCompanyAddr>()
                    .Property(e => e.intid)
                    .IsFixedLength();

                modelBuilder.Entity<MyCompanyAddr>()
                    .Property(e => e.adresstype)
                    .HasPrecision(18, 0);

                modelBuilder.Entity<MyCompanyAddr>()
                    .Property(e => e.Nation_id)
                    .IsFixedLength();

                modelBuilder.Entity<MyCompanyAddr>()
                    .Property(e => e.postnr)
                    .IsFixedLength();

                modelBuilder.Entity<MyShip>()
                    .Property(e => e.area_id)
                    .IsFixedLength();

                modelBuilder.Entity<MyShip>()
                    .Property(e => e.merke_nr)
                    .IsFixedLength();

                modelBuilder.Entity<MyShip>()
                    .HasMany(e => e.myshipcontacts)
                    .WithRequired(e => e.MyShip)
                    .HasForeignKey(e => e.shipid)
                    .WillCascadeOnDelete(false);

                modelBuilder.Entity<MyShip>()
                    .HasMany(e => e.myshipremarks)
                    .WithRequired(e => e.MyShip)
                    .HasForeignKey(e => e.shipid)
                    .WillCascadeOnDelete(false);

                modelBuilder.Entity<MyContact>()
                    .Property(e => e.email)
                    .IsUnicode(false);

            }
        }
    }
}
