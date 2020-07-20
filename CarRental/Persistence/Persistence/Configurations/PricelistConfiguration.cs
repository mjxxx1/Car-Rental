using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Persistence
{
    public class PricelistConfiguration : IEntityTypeConfiguration<Pricelist>
    {
        public void Configure(EntityTypeBuilder<Pricelist> builder)
        {
            builder.HasKey(c => c.PriceID);
            builder.Property(d => d.BasePricePerDay).IsRequired(true)
                                                    .HasColumnType("decimal(9, 2)");
            //builder.Property(c => c.Name).HasMaxLength(200);
        }
    }
}
