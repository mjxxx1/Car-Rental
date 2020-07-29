using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Infrastructur.Persistence.Configurations
{
    public class CarVersionConfiguration : IEntityTypeConfiguration<CarVersion>
    {
        public void Configure(EntityTypeBuilder<CarVersion> builder)
        {
            builder.HasKey(c => c.CarVersionID);

            builder.Property(d => d.IsDeleted).HasDefaultValue(false);

            builder.Property(e => e.AirConditioningType)
            .HasConversion(x => (int)x, x => (AirConditioningType)x);

            builder.Property(e => e.TransmissionType)
            .HasConversion(x => (int)x, x => (TransmissionType)x);

            builder.Property(e => e.FuelType)
            .HasConversion(x => (int)x, x => (FuelType)x);
        }
    }
}
