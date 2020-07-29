using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using CarRental.Core.Common.Interfaces;
using CarRental.Infrastructur.Persistence.Configurations;

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
            modelBuilder.ApplyConfiguration(new CarVersionConfiguration());
            modelBuilder.ApplyConfiguration(new OfferNameConfiguration());
            modelBuilder.ApplyConfiguration(new CarConfiguration());

            //modelBuilder.Entity<Post>().HasQueryFilter(c => c.BlogId != 3);           -ustawia filtry
            // .IgnoreQuweryFilters                                                     -ignoruje filtry
        }
    }
}
