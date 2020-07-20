using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Domain
{
    public class AirConditioning
    {
        public AirConditioning()
        {
            CarVersions = new HashSet<CarVersion>();
        }
        [Key]
        public int AirConditioningID { get; set; }
        public string  AirConditioningType { get; set; }
        public ICollection <CarVersion> CarVersions { get; set; }
    }
}
