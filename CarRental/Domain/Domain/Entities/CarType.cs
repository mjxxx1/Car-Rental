using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Domain
{
    public class CarType
    {
        public CarType()
        {
            CarModels = new HashSet<CarModel>();
        }

        public int CarTypeID { get; set; }
        public string CarTypeName { get; set; }

        //Relation with CarModel
        public ICollection<CarModel> CarModels { get; set; }
    }
}
