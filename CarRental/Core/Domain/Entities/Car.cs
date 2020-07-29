using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental
{
    public class Car
    {
        public int CarID { get; set; }
        public string VIN { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime? DateOfFirstRegistration { get; set; }
        public DateTime? DateOfPurchase { get; set; }
        public string Color { get; set; }
        public string Status { get; set; }
        public bool IsDeleted { get; set; }
        //relation with CarVersion
        public CarVersion Version { get; set; }
        public int CarVersionID { get; set; }
    }
}
