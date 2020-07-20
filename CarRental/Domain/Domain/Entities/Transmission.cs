using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Domain
{
    public class Transmission
    {
        public Transmission()
        {
            CarVersions = new HashSet<CarVersion>();
        }
        [Key]
        public int TransmissionID { get; set; }
        public string TransmissionType { get; set; }
        public ICollection<CarVersion> CarVersions { get; set; }
    }
}
