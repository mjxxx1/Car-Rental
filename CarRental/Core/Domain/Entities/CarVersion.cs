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

        public int CarVersionID { get; set; }
        public int Passengers { get; set; }
        public TransmissionType TransmissionType { get; set; }
        public AirConditioningType AirConditioningType { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Segment { get; set; }
        public string Type { get; set; }
        public FuelType FuelType { get; set; }
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

    public enum TransmissionType
    {
        manual = 1,
        automatic = 2
    }

    public enum AirConditioningType
    {
        manual = 1,
        automatic = 2
    }

    public enum FuelType
    {
        diesel = 1,
        gasoline = 2,
        electric = 3,
        LPG = 4, 
        hybrid = 5
    }
}
