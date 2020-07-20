using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models.ViewModels
{
    public class OfferNameDetails
    {
        public string offerName { get; set; }
        public bool automatTransmission { get; set; }
        public bool manualTransmission { get; set; }
        public string segment { get; set; }
        public string actualBase { get; set; }
        public byte[] Image { get; set; }
    }
}
