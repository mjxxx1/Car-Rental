using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Domain
{
    public class CarSegment
    {
        public CarSegment()
        {
            CarModels = new HashSet<CarModel>();
        }

        public int CarSegmentID { get; set; }
        public string CarSegmentName { get; set; }

        //Relation with CarModel
        public ICollection<CarModel> CarModels { get; set; }
    }
}
