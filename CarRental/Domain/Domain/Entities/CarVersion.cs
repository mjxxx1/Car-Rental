using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Domain
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
        public int Doors { get; set; }
        public int? BootCapacity { get; set; }
        public int? EnginePower { get; set; }
        public float? FuelConsumptionPer100km { get; set; }
        public int? EngineSize { get; set; }
        public bool IsDeleted { get; set; }


        //relation with Car
        public ICollection<Car> Cars {get; set; }

        //relation with CarModel
        public CarModel CarModel { get; set; }
        public int CarModelID { get; set; }

        //relation with AirConditioning 
        public AirConditioning AirConditioning { get; set; }
        public int AirConditioningID { get; set; }

        //relation with Transmission
        public Transmission Transmission { get; set; }
        public int TransmissionID { get; set; }

        //relation with FuelType
        public Fuel Fuel { get; set; }
        public int FuelTypeID { get; set; }

        //relation with OfferName
        public OfferName OfferName { get; set; }
        public int OfferNameID { get; set; }
    }
}
