using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Domain
{
    public class FuelType
    {
        public FuelType()
        {
            CarVersions = new HashSet<CarVersion>();
        }

        [Key]
        public int FuelID { get; set; }
        public string Fuel { get; set; }

        public ICollection<CarVersion> CarVersions { get; set; }
    }

}
