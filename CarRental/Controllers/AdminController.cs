using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class AdminController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListOfCars()
        {
            IEnumerable<Car> cars = new List<Car>();
            return View(cars);
        }
    }
}