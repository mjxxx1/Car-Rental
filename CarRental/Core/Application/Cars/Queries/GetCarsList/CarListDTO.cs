using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Core.Application.Cars.Queries.GetCarsList
{
    public class CarListDTO
    {
        public List<OfferNamesList> offerNames { get; set; }

        public List<string> transmissionType { get; set; }
        public List<string> airConditionerType { get; set; }
        public List<string> noOfPassengers { get; set; }
        public List<string> segment { get; set; }
        public List<string> fuelType { get; set; }
        public List<string> baseCity { get; set; }
        public FilterParameters selectedParameters { get; set; }

    }
}
