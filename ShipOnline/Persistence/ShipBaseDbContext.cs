using ShipOnline.Core.Domain;

namespace ShipOnline.Persistence
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ShipBaseDbContext : DbContext
    {
        public ShipBaseDbContext()
            : base("name=ShipBaseDbContext")
        {
        }

        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Nydept> Nydepts { get; set; }
        public virtual DbSet<ShipCat> ShipCats { get; set; }
        public virtual DbSet<SysDiagram> SysDiagrams { get; set; }
        public virtual DbSet<CompNo> CompNos { get; set; }
        public virtual DbSet<County> Counties { get; set; }
        public virtual DbSet<Nation> Nations { get; set; }
        public virtual DbSet<Nyinsu> Nyinsus { get; set; }
        public virtual DbSet<Place> Places { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Ship> Ships { get; set; }
        public virtual DbSet<ShipComp> ShipComps { get; set; }
        public virtual DbSet<ShipType> ShipTypes { get; set; }
        public virtual DbSet<Shire> Shires { get; set; }
        public virtual DbSet<TeleType> TeleTypes { get; set; }
        public virtual DbSet<Undept> Undepts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Area>()
                .Property(e => e.ID)
                .IsFixedLength();

            modelBuilder.Entity<Area>()
                .HasMany(e => e.myships)
                .WithOptional(e => e.area)
                .HasForeignKey(e => new { e.area_id, e.nation_id });

            modelBuilder.Entity<Category>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<Company>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<Company>()
                .HasMany(e => e.CompNos)
                .WithRequired(e => e.company)
                .HasForeignKey(e => e.COMPANY_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Nydepts)
                .WithOptional(e => e.company)
                .HasForeignKey(e => e.COMPANY_ID);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.ShipComps)
                .WithRequired(e => e.company)
                .HasForeignKey(e => e.COMPANY_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nydept>()
                .Property(e => e.BETDATO)
                .HasPrecision(0);

            modelBuilder.Entity<Nydept>()
                .Property(e => e.AB_FRA_DATO)
                .HasPrecision(0);

            modelBuilder.Entity<Nydept>()
                .Property(e => e.AB_TIL_DATO)
                .HasPrecision(0);

            modelBuilder.Entity<Nydept>()
                .Property(e => e.EXPIRES_DATE)
                .HasPrecision(0);

            modelBuilder.Entity<Nydept>()
                .Property(e => e.EXPIRES_TIME)
                .HasPrecision(0);

            modelBuilder.Entity<Nydept>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<Nydept>()
                .HasMany(e => e.undepts)
                .WithOptional(e => e.nydept)
                .HasForeignKey(e => e.USER_NO);

            modelBuilder.Entity<Nation>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<Nyinsu>()
                .Property(e => e.LAST_LOGIN_DATE)
                .HasPrecision(0);

            modelBuilder.Entity<Nyinsu>()
                .Property(e => e.LAST_LOGIN_TIME)
                .HasPrecision(0);

            modelBuilder.Entity<Nyinsu>()
                .Property(e => e.EXPIRES_DATE)
                .HasPrecision(0);

            modelBuilder.Entity<Nyinsu>()
                .Property(e => e.EXPIRES_TIME)
                .HasPrecision(0);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.shipcomps)
                .WithRequired(e => e.role)
                .HasForeignKey(e => e.ROLE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ship>()
                .Property(e => e.PHOTO_DATE)
                .HasPrecision(0);

            modelBuilder.Entity<Ship>()
                .Property(e => e.DRAWING_DATE)
                .HasPrecision(0);

            modelBuilder.Entity<Ship>()
                .Property(e => e.BUILT_DATE)
                .HasPrecision(0);

            modelBuilder.Entity<Ship>()
                .Property(e => e.CHANGE_DATE)
                .HasPrecision(0);

            modelBuilder.Entity<Ship>()
                .Property(e => e.ISPS_NO_DATE_FROM)
                .HasPrecision(0);

            modelBuilder.Entity<Ship>()
                .Property(e => e.ISPS_NO_DATE_TO)
                .HasPrecision(0);

            modelBuilder.Entity<Ship>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();
        }
    }
}
