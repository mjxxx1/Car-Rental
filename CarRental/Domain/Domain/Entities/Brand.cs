using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Domain
{
    public class Brand
    {
        public Brand()
        {
            CarModels = new HashSet<CarModel>();
        }

        public int BrandID { get; set; }
        public string BrandName { get; set; }

        //Relation with CarModel
        public ICollection<CarModel> CarModels {get; set;}
    }
}
