using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Core.Application.Cars.Queries.GetCarsList
{
    public class FilterParameters : PageModel
    {
        public string TransmissionType { get; set; }
        public string AirConditionerType { get; set; }
        public string Passengers { get; set; }
        public string Segment { get; set; }
        public string FuelType { get; set; }
        public string Doors { get; set; }
    }
}
