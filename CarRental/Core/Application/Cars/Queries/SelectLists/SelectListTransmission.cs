using CarRental.Core.Application.Cars.Queries.GetCarsList;
using CarRental.Core.Common.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Core.Application.Cars.Queries.SelectLists
{
    public class SelectListTransmission : SelectListBase
    {
        private readonly IApplicationDBContext _context;
        public SelectListTransmission(IApplicationDBContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            options = new SelectList(_context.CarVersions, nameof(CarVersion.TransmissionType), nameof(CarVersion.TransmissionType));
        }
    }
}
