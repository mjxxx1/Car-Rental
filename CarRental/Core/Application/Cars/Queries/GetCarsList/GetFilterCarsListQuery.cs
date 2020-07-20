using System;
using System.Collections.Generic;
using System.Text;
using CarRental.Core.Application.Cars.Queries.GetCarsList;
using MediatR;

namespace CarRental
{
    public class GetFilterCarsListQuery : IRequest<CarListDTO>
    {
        public GetFilterCarsListQuery(FilterParameters parameters)
        {
            this.parameters = parameters;
        }

        public FilterParameters parameters { get; }
    }
}