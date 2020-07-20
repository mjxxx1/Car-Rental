using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using CarRental.Models;
using CarRental.Core.Common.Interfaces;

namespace CarRental
{
    public class ApplicationDBContext : DbContext, IApplicationDBContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<CarVersion> CarVersions { get; set; }
        public virtual DbSet<Pricelist> Pricelists { get; set; }
        public virtual DbSet<OfferName> offerNames { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PricelistConfiguration());

            modelBuilder.Entity<CarVersion>(entity =>
            {
                entity.Property(e => e.CarVersionID).IsRequired();
            });

            //modelBuilder.Entity<CarVersion>(entity =>
            //{
            //    entity.HasOne<AirConditioning>(p => p.AirConditioning)
            //          .WithMany(q => q.CarVersions)
            //          .HasForeignKey(r => r.AirConditioningID);
                
            //});

            //modelBuilder.Entity<Car>(entity =>
            //{
            //    entity.HasOne(d => d.Version)
            //        .WithMany(p => p.Cars)
            //        .HasForeignKey(d => d.CarVersionID);
            //});

            //modelBuilder.Entity<Transmission>(entity =>
            //{
            //    entity.Property(e => e.TransmissionID).IsRequired();
            //});

            //modelBuilder.Entity<Fuel>(entity =>
            //{
            //    entity.Property(e => e.FuelTypeID).IsRequired();
            //});

            //modelBuilder.Entity<AirConditioning>(entity =>
            //{
            //    entity.Property(e => e.AirConditioningID).IsRequired();
            //});

            //modelBuilder.Entity<Post>().HasQueryFilter(c => c.BlogId != 3);           -ustawia filtry
            // .IgnoreQuweryFilters                                                     -ignoruje filtry
        }
    }
}
