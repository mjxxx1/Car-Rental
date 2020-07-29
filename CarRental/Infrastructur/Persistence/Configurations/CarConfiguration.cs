using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Infrastructur.Persistence.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(c => c.CarID);
            builder.Property(d => d.VIN).IsRequired(true)
                                        .HasColumnType("char(17)");
            builder.Property(d => d.IsDeleted).HasDefaultValue(false);
        }
    }
}
