using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models.ViewModels
{
    public class OfferNamesWithDetails
    {
        private ApplicationDBContext context;

        public List<OfferNameDetails> offerNameDet;

        public IQueryable<Car> Cars => context.Cars
            .Include(o => o.Version)
            .ThenInclude(q => q.OfferName);

    public OfferNamesWithDetails(ApplicationDBContext ctx)
        {
            context = ctx;
        }

        public List<OfferNameDetails> OfferNamesFromExMethod()
        {
            List<OfferNameDetails> result= new List<OfferNameDetails>();
            OfferNameDetails row = new OfferNameDetails();

            foreach (Car c in Cars)
            {
                row.offerName = c.Version.OfferName.Name;
                if (c.Version.TransmissionType.ToString() == "manual")
                {
                    row.manualTransmission = true;
                }

                if (c.Version.TransmissionType.ToString() == "automatic")
                {
                    row.automatTransmission = true;
                }

                row.segment = c.Version.Segment;

                row.Image = c.Version.OfferName.Image;

                result.Add(row);
            }

            result = result.Distinct().ToList();
            return result;
        }
    }
}
