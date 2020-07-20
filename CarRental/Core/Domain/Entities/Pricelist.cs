using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental
{
    public class Pricelist
    {
        public int PriceID { get; set; }
        public short LoanTimeFrom { get; set; }
        public short LoanTimeTo { get; set; }
        public decimal BasePricePerDay { get; set; }
        public bool IsDeleted { get; set; }

        //relation with OfferName
        public OfferName OfferName { get; set; }
        public int OfferNameID { get; set; }
    }
}
