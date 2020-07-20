using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Domain
{
    public class Fuel
    {
        public Fuel()
        {
            CarVersions = new HashSet<CarVersion>();
        }
        [Key]
        public int FuelTypeID { get; set; }
        public string FuelType { get; set; }
        public ICollection <CarVersion> CarVersions { get; set; }
    }
}
