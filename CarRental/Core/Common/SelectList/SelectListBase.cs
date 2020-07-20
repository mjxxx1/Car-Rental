using CarRental.Core.Common.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Core.Application.Cars.Queries.GetCarsList
{
    public abstract class SelectListBase
    {
        private readonly IApplicationDBContext _context;

        public SelectList options { get; set; }
        public void OnGet()
        {

        }
    }
}
