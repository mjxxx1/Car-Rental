using System;
using System.Collections.Generic;
using System.Text;
using CarRental.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using CarRental.Core.Application.Cars.Queries.GetCarsList;
using Microsoft.IdentityModel.Tokens;
using CarRental.Core.Common.Interfaces;

namespace CarRental
{
    class GetCarsListQueryHandler : IRequestHandler<GetFilterCarsListQuery, CarListDTO>
    {
        private readonly IApplicationDBContext _context;

        public GetCarsListQueryHandler(IApplicationDBContext context)
        {
            _context = context;
        }
        private IQueryable<OfferName> offerNamesList => _context.offerNames
            .Include(o => o.CarVersions)
            .Include(s => s.Pricelists);

        public async Task<CarListDTO> Handle(GetFilterCarsListQuery request, CancellationToken cancellationToken)
        {
            CarListDTO carListDTO = new CarListDTO();
            List<OfferNamesList> DTOsList = new List<OfferNamesList>();
            IQueryable<OfferName> ListToModify = offerNamesList;

            if (request.parameters.AirConditionerType != null)
            {
                ListToModify = FilterOfferNames(request.parameters, offerNamesList);
            }

            foreach (OfferName on in ListToModify)
            {
                OfferNamesList temp = new OfferNamesList();
                temp.OfferName = on.Name;
                temp.NoOfPassengers = ReturnRangeOfPassengersForSpecifiedOfferName(on);
                temp.ExapmlePrice = ReturnExamplePrice(on);
                temp.Image = RetrieveImageFromDatabase(on);
                temp.AirConditionerType = ReturnAirConditioningType(on);
                temp.TransmissionType = ReturnTransmissionType(on);
                temp.NoOfDoors = ReturnRangeOfDoorsForSpecifiedOfferName(on);

                DTOsList.Add(temp);
            }
            carListDTO.offerNames = DTOsList;

            assignDataFromDBToListBoxes(ref carListDTO);

            carListDTO.selectedParameters = request.parameters;

            return carListDTO;
        }

        private void assignDataFromDBToListBoxes(ref CarListDTO cLDTO)
        {
            cLDTO.transmissionType = _context.CarVersions
             .OrderBy(p => p.TransmissionType)
             .Select(p => p.TransmissionType.ToString())
             .Distinct()
             .ToList();
            cLDTO.transmissionType.Insert(0, "all");

            cLDTO.airConditionerType = _context.CarVersions
                .OrderBy(p => p.AirConditioningType)
                .Select(p => p.AirConditioningType.ToString())
                .Distinct()
                .ToList();
            cLDTO.airConditionerType.Insert(0, "all");

            cLDTO.noOfPassengers = _context.CarVersions
                .OrderBy(p => p.Passengers)
                .Select(p => p.Passengers.ToString())
                .Distinct()
                .ToList();
            cLDTO.noOfPassengers.Insert(0, "all");

            cLDTO.segment = _context.CarVersions
                .OrderBy(p => p.Segment)
                .Select(p => p.Segment)
                .Distinct()
                .ToList();
            cLDTO.segment.Insert(0, "all");


            cLDTO.fuelType = _context.CarVersions
                 .OrderByDescending(p => p.FuelType)
                 .Select(p => p.FuelType.ToString())
                 .Distinct()
                 .ToList();
            cLDTO.fuelType.Insert(0, "all");

            //TODO - add Bases (Warsa, Gdansk etc.)
            //cLDTO.FuelType = _context.FuelTypes
            //     .Select(p => p.FuelType)
            //     .Distinct()
            //     .ToList();
            //cLDTO.transmissionType.Insert(0, "all").Insert(0, "all");
        }

        private static IQueryable<OfferName> FilterOfferNames(FilterParameters parameters, IQueryable<OfferName> rowList)
        {
            IQueryable<OfferName> FilteredOfferNamesList = rowList
                .Where(p => p.CarVersions.Any(q => (q.TransmissionType.ToString() == parameters.TransmissionType || parameters.TransmissionType == "all")))
                .Where(p => p.CarVersions.Any(q => (q.AirConditioningType.ToString() == parameters.AirConditionerType || parameters.AirConditionerType == "all")))
                .Where(p => p.CarVersions.Any(q => (q.Passengers.ToString() == parameters.Passengers || parameters.Passengers == "all")))
                .Where(p => p.CarVersions.Any(q => (q.Segment == parameters.Segment || parameters.Segment == "all")))
                .Where(p => p.CarVersions.Any(q => (q.FuelType.ToString() == parameters.FuelType || parameters.FuelType == "all")));
            //TODO Add Base
            //.Where(p => p.CarVersions.Any(q => (q.Fuel.FuelType == parameters.FuelType || parameters.FuelType == "all")))
            return FilteredOfferNamesList;
        }

        private byte[] RetrieveImageFromDatabase(OfferName on)
        {
            OfferName offerName = _context.offerNames
                .FirstOrDefault(q => q.Name == "DefaultImage");

            byte[] image = on.Image ?? offerName.Image;
            return image;
        }

        private string ReturnExamplePrice(OfferName on)
        {
            try
            {
                decimal exPrice = on.Pricelists.Min(o => o.BasePricePerDay);
                return string.Format("From {0}zł per day", exPrice);
            }
            catch
            {
                return null;
            }
        }

        private string ReturnRangeOfDoorsForSpecifiedOfferName(OfferName ON)
        {
            try
            {
                int? MaxNoOfDoors = ON.CarVersions.Max(o => o.Doors);
                int? MinNoOfDoors = ON.CarVersions.Min(o => o.Doors);
                string answer = MaxNoOfDoors == MinNoOfDoors ? MaxNoOfDoors.ToString() : string.Format("{0}-{1}", MinNoOfDoors, MaxNoOfDoors);
                return answer;
            }
            catch
            {
                return null;
            }
        }

        private string ReturnRangeOfPassengersForSpecifiedOfferName(OfferName ON)
        {
            try
            {
                int? MaxNoOfPaseengers = ON.CarVersions.Max(o => o.Passengers);
                int? MinNoOfPassengers = ON.CarVersions.Min(o => o.Passengers);
                string answer = MaxNoOfPaseengers == MinNoOfPassengers ? MaxNoOfPaseengers.ToString() : string.Format("{0}-{1}", MinNoOfPassengers, MaxNoOfPaseengers);
                return answer;
            }
            catch
            {
                return null;
            }
        }

        private string ReturnTransmissionType(OfferName ON)
        {
            bool HaveCarsManual = ON.CarVersions.Any(o => o.TransmissionType.ToString() == "manual");
            bool HaveCarsAutomatic = ON.CarVersions.Any(o => o.TransmissionType.ToString() == "automatic");
            string answer = HaveCarsAutomatic ? "automatic" : (HaveCarsManual ? "manual" : null);
            answer = (HaveCarsManual && HaveCarsAutomatic) ? "manual / automatic" : answer;
            return answer;
        }

        private string ReturnAirConditioningType(OfferName ON)
        {
            bool HaveCarsManual = ON.CarVersions.Any(o => o.AirConditioningType.ToString() == "manual");
            bool HaveCarsAutomatic = ON.CarVersions.Any(o => o.AirConditioningType.ToString() == "automatic");
            string answer = HaveCarsManual ? "manual" : "automatic";
            answer = (HaveCarsManual && HaveCarsAutomatic) ? "manual / automatic" : answer;
            return answer;
        }

    }
}
