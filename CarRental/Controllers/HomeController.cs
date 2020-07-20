using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.BannerContent = "DefaultBanner";
            return View();
            
        }

        public IActionResult FAQ()
        {
            ViewBag.BannerContent = "DefaultBanner";
            return View();
        }

        public IActionResult AboutUs()
        {
            ViewBag.BannerContent = "DefaultBanner";
            return View();
        }
    }
}