using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Infrastructur.Persistence.Configurations
{
    public class OfferNameConfiguration : IEntityTypeConfiguration<OfferName>
    {
        public void Configure(EntityTypeBuilder<OfferName> builder)
        {
            builder.HasKey(c => c.OfferNameID);
            builder.Property(d => d.Name).IsRequired(true);
        }
    }
}
