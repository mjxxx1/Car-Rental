using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental
{
    public class CarVersion
    {
        public CarVersion()
        {
                Cars = new HashSet<Car>();
        }

        [Key]
        public int CarVersionID { get; set; }
        public int Passengers { get; set; }
        public string Transmission { get; set; }
        public string AirConditioning { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Segment { get; set; }
        public string Type { get; set; }
        public string Fuel { get; set; }
        public int Doors { get; set; }
        public int? BootCapacity { get; set; }
        public int? EnginePower { get; set; }
        public float? FuelConsumptionPer100km { get; set; }
        public int? EngineSize { get; set; }
        public bool IsDeleted { get; set; }


        //relation with Car
        public ICollection<Car> Cars {get; set; }
        //relation with OfferName
        public OfferName OfferName { get; set; }
        public int OfferNameID { get; set; }
    }
}
