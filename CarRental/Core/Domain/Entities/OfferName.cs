using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental
{
    public class OfferName
    {
        public OfferName()
        {
            Pricelists = new HashSet<Pricelist>();
            CarVersions = new HashSet<CarVersion>();
        }
        [Key]
        public int OfferNameID { get; set; }

        public string Name { get; set; }
        public byte[] Image { get; set; }

        //relation with Pricelist
        public ICollection<Pricelist> Pricelists { get; set; }
        //relation with CarVersion
        public ICollection<CarVersion> CarVersions { get; set; }
    }
}
