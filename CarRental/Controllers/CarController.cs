using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MediatR;
using CarRental.Core.Application.Cars.Queries.GetCarsList;
using CarRental.Core.Application.Cars.Queries.SelectLists;
using System.Dynamic;

namespace CarRental.Controllers
{
    public class CarController : BaseController
    {
        public async Task<ViewResult> List()
        {
            //Question 1 
            //Czy ten kontroler nie jest zbyt rozbudowany? 
            //Czy można w jakiś sposób napisać test jednostkowy, który sprawdzi poprawność pobierania parametrów z widoku?
            //Mam wrażenie, że nie powienienem przechwytywać parametrów z widoku w ten sposób, ale nie mam pomysłu jak to zrobić prosćiej.

            FilterParameters parameters = new FilterParameters();

            if (HttpContext.Request.Method == "POST")
            {
                parameters.TransmissionType = Request.Form["TransmissionType"].ToString();
                parameters.AirConditionerType = Request.Form["airConditionerType"].ToString();
                parameters.Passengers = Request.Form["noOfPassengers"].ToString();
                parameters.Segment = Request.Form["Segment"].ToString();
                parameters.FuelType = Request.Form["FuelType"].ToString();
                //TODO Actualize - base
                //parameters.TransmissionType = Request.Form["TransmissionType"].ToString();
            }
            var vm = await Mediator.Send(new GetFilterCarsListQuery(parameters));
            ViewBag.BannerContent = "BannerCarsList";
            return View(vm);
        }
    }
}