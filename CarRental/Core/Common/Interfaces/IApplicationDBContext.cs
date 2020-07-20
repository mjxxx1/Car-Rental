using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Core.Common.Interfaces
{
    public interface IApplicationDBContext
    {
        DbSet<Car> Cars { get; set; }
        DbSet<CarVersion> CarVersions { get; set; }
        DbSet<Pricelist> Pricelists { get; set; }
        DbSet<OfferName> offerNames { get; set; }
    }
}
