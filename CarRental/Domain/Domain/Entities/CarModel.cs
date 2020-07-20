using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Domain
{
    public class CarModel
    {
        public CarModel()
        {
            CarVersions = new HashSet<CarVersion>();
        }

        [Key]
        public int CarModelID { get; set; }
        public string CarModelName { get; set; }
        public byte[] Image { get; set; }



        //Relation with CarVersion
        public ICollection<CarVersion> CarVersions { get; set; }

        //Relation with Brand
        public Brand brand { get; set; }
        public int BrandID { get; set; }

        //Relation with CarType
        public CarType carType { get; set; }
        public int CarTypeID { get; set; }

        //Relation with CarSegment
        public CarSegment carSegment { get; set; }
        public int CarSegmentID { get; set; }
    }
}
