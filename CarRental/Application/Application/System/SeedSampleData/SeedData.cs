using CarRental.Domain;
using CarRental.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CarRental
{
    public static class SeedData
    {
        public static void EnsurePopulatedOfferName(IApplicationBuilder app)
        {
            ApplicationDBContext context = app.ApplicationServices.GetRequiredService<ApplicationDBContext>();
            context.Database.Migrate();

            if (!context.offerNames.Any())
            {
                context.offerNames.AddRange(
                    new OfferName
                    {
                        Name = "Fiat 500"
                    },

                    new OfferName
                    {
                        Name = "Kia Picanto"
                    },

                    new OfferName
                    {
                        Name = "Mini Convertible"
                    },

                    new OfferName
                    {
                        Name = "Opel Corsa"
                    },

                    new OfferName
                    {
                        Name = "Peugeot 208"
                    },

                    new OfferName
                    {
                        Name = "Peugeot 208 electric"
                    },

                    new OfferName
                    {
                        Name = "Dacia Sandero"
                    },

                    new OfferName
                    {
                        Name = "Skoda Citigo"
                    },

                    new OfferName
                    {
                        Name = "Volkswagen Polo"
                    },

                    new OfferName
                    {
                        Name = "Mazda 3"
                    },

                    new OfferName
                    {
                        Name = "Toyota Auris"
                    },

                    new OfferName
                    {
                        Name = "Toyota Auris hybrid"
                    },

                    new OfferName
                    {
                        Name = "Renault Twingo"
                    },

                    new OfferName
                    {
                        Name = "Skoda Citigo electric"
                    }
                    );

                context.SaveChanges();
            }
        }
        //******************************************************************************************************


        public static void EnsurePopulatedPricelist(IApplicationBuilder app)
        {
            ApplicationDBContext context = app.ApplicationServices.GetRequiredService<ApplicationDBContext>();
            context.Database.Migrate();

            if (!context.Pricelists.Any())
            {
                context.Pricelists.AddRange(
                    new Pricelist
                    {
                        LoanTimeFrom = 1,
                        LoanTimeTo = 3,
                        BasePricePerDay = 89,
                        IsDeleted = false,
                        OfferNameID = 1
                    },

                    new Pricelist
                    {
                        LoanTimeFrom = 4,
                        LoanTimeTo = 7,
                        BasePricePerDay = 79,
                        IsDeleted = false,
                        OfferNameID = 1
                    },

                    new Pricelist
                    {
                        LoanTimeFrom = 8,
                        LoanTimeTo = 30,
                        BasePricePerDay = 69,
                        IsDeleted = false,
                        OfferNameID = 1
                    },

                    new Pricelist
                    {
                        LoanTimeFrom = 31,
                        LoanTimeTo = 999,
                        BasePricePerDay = 49,
                        IsDeleted = false,
                        OfferNameID = 1
                    },

                    new Pricelist
                    {
                        LoanTimeFrom = 1,
                        LoanTimeTo = 3,
                        BasePricePerDay = 89,
                        IsDeleted = false,
                        OfferNameID = 2
                    },

                    new Pricelist
                    {
                        LoanTimeFrom = 4,
                        LoanTimeTo = 7,
                        BasePricePerDay = 79,
                        IsDeleted = false,
                        OfferNameID = 2
                    },

                    new Pricelist
                    {
                        LoanTimeFrom = 8,
                        LoanTimeTo = 30,
                        BasePricePerDay = 69,
                        IsDeleted = false,
                        OfferNameID = 2
                    },

                    new Pricelist
                    {
                        LoanTimeFrom = 31,
                        LoanTimeTo = 999,
                        BasePricePerDay = 49,
                        IsDeleted = false,
                        OfferNameID = 2
                    },

                    new Pricelist
                    {
                        LoanTimeFrom = 1,
                        LoanTimeTo = 3,
                        BasePricePerDay = 109,
                        IsDeleted = false,
                        OfferNameID = 3
                    },

                    new Pricelist
                    {
                        LoanTimeFrom = 4,
                        LoanTimeTo = 7,
                        BasePricePerDay = 99,
                        IsDeleted = false,
                        OfferNameID = 3
                    },

                    new Pricelist
                    {
                        LoanTimeFrom = 8,
                        LoanTimeTo = 30,
                        BasePricePerDay = 89,
                        IsDeleted = false,
                        OfferNameID = 3
                    },

                    new Pricelist
                    {
                        LoanTimeFrom = 31,
                        LoanTimeTo = 999,
                        BasePricePerDay = 69,
                        IsDeleted = false,
                        OfferNameID = 3
                    },

                    new Pricelist
                    {
                        LoanTimeFrom = 1,
                        LoanTimeTo = 3,
                        BasePricePerDay = 89,
                        IsDeleted = false,
                        OfferNameID = 4
                    },

                    new Pricelist
                    {
                        LoanTimeFrom = 4,
                        LoanTimeTo = 7,
                        BasePricePerDay = 79,
                        IsDeleted = false,
                        OfferNameID = 4
                    },

                    new Pricelist
                    {
                        LoanTimeFrom = 8,
                        LoanTimeTo = 30,
                        BasePricePerDay = 69,
                        IsDeleted = false,
                        OfferNameID = 4
                    },

                    new Pricelist
                    {
                        LoanTimeFrom = 31,
                        LoanTimeTo = 999,
                        BasePricePerDay = 49,
                        IsDeleted = false,
                        OfferNameID = 4
                    },

                    new Pricelist
                    {
                        LoanTimeFrom = 1,
                        LoanTimeTo = 3,
                        BasePricePerDay = 89,
                        IsDeleted = false,
                        OfferNameID = 5
                    },

                    new Pricelist
                    {
                        LoanTimeFrom = 4,
                        LoanTimeTo = 7,
                        BasePricePerDay = 79,
                        IsDeleted = false,
                        OfferNameID = 5
                    },

                    new Pricelist
                    {
                        LoanTimeFrom = 8,
                        LoanTimeTo = 30,
                        BasePricePerDay = 69,
                        IsDeleted = false,
                        OfferNameID = 5
                    },

                    new Pricelist
                    {
                        LoanTimeFrom = 31,
                        LoanTimeTo = 999,
                        BasePricePerDay = 49,
                        IsDeleted = false,
                        OfferNameID = 5
                    },

                    new Pricelist
                    {
                        LoanTimeFrom = 1,
                        LoanTimeTo = 3,
                        BasePricePerDay = 109,
                        IsDeleted = false,
                        OfferNameID = 6
                    },

                    new Pricelist
                    {
                        LoanTimeFrom = 4,
                        LoanTimeTo = 7,
                        BasePricePerDay = 99,
                        IsDeleted = false,
                        OfferNameID = 6
                    },

                    new Pricelist
                    {
                        LoanTimeFrom = 8,
                        LoanTimeTo = 30,
                        BasePricePerDay = 89,
                        IsDeleted = false,
                        OfferNameID = 6
                    },

                    new Pricelist
                    {
                        LoanTimeFrom = 31,
                        LoanTimeTo = 999,
                        BasePricePerDay = 69,
                        IsDeleted = false,
                        OfferNameID = 6
                    }
                    );


                context.SaveChanges();
            }
        }
        //******************************************************************************************************

        public static void EnsurePopulatedAirConditionings(IApplicationBuilder app)
    {
        ApplicationDBContext context = app.ApplicationServices.GetRequiredService<ApplicationDBContext>();
        context.Database.Migrate();

        if (!context.AirConditionings.Any())
        {
            context.AirConditionings.AddRange(
                new AirConditioning
                {
                    AirConditioningType = "manual"
                },

                new AirConditioning
                {
                    AirConditioningType = "automatic"
                },

                new AirConditioning
                {
                    AirConditioningType = "none"
                });
            context.SaveChanges();
        }
    }
        //******************************************************************************************************

        public static void EnsurePopulatedTransmissions(IApplicationBuilder app)
        {
            ApplicationDBContext context = app.ApplicationServices.GetRequiredService<ApplicationDBContext>();
            context.Database.Migrate();

            if (!context.Transmissions.Any())
            {
                context.Transmissions.AddRange(
                    new Transmission
                    {
                        TransmissionType = "manual"
                    },

                    new Transmission
                    {
                        TransmissionType = "automatic"
                    });
                context.SaveChanges();
            }
        }

        //******************************************************************************************************

        public static void EnsurePopulatedFuelTypes(IApplicationBuilder app)
        {
            ApplicationDBContext context = app.ApplicationServices.GetRequiredService<ApplicationDBContext>();
            context.Database.Migrate();

            if (!context.FuelTypes.Any())
            {
                context.FuelTypes.AddRange(
                    new Fuel
                    {
                        FuelType = "diesel"
                    },

                    new Fuel
                    {
                        FuelType = "gasoline"
                    },

                    new Fuel
                    {
                        FuelType = "electric"
                    },

                    new Fuel
                    {
                        FuelType = "LPG"
                    },

                    new Fuel
                    {
                        FuelType = "hybrid"
                    });
                context.SaveChanges();
            }
        }


        //******************************************************************************************************

        public static void EnsurePopulatedBrands(IApplicationBuilder app)
        {
            ApplicationDBContext context = app.ApplicationServices.GetRequiredService<ApplicationDBContext>();
            context.Database.Migrate();

            if (!context.Brands.Any())
            {
                context.Brands.AddRange(
                    new Brand
                    {
                        BrandName = "Fiat"
                    },

                    new Brand
                    {
                        BrandName = "Kia"
                    },

                    new Brand
                    {
                        BrandName = "Mini"
                    },

                    new Brand
                    {
                        BrandName = "Opel"
                    },

                    new Brand
                    {
                        BrandName = "Peugeot"
                    },

                    new Brand
                    {
                        BrandName = "Renault"
                    },

                    new Brand
                    {
                        BrandName = "Skoda"
                    },

                    new Brand
                    {
                        BrandName = "Volkswagen"
                    },

                    new Brand
                    {
                        BrandName = "Mazda"
                    },

                    new Brand
                    {
                        BrandName = "Toyota"
                    },

                    new Brand
                    {
                        BrandName = "Volvo"
                    },

                    new Brand
                    {
                        BrandName = "Dacia"
                    }
                    );
                context.SaveChanges();
            }
        }

        //******************************************************************************************************

        public static void EnsurePopulatedCarTypes(IApplicationBuilder app)
        {
            ApplicationDBContext context = app.ApplicationServices.GetRequiredService<ApplicationDBContext>();
            context.Database.Migrate();

            if (!context.CarTypes.Any())
            {
                context.CarTypes.AddRange(
                    new CarType
                    {
                        CarTypeName = "Personal car"
                    },

                    new CarType
                    {
                        CarTypeName = "Truck"
                    }
                    );
                context.SaveChanges();
            }
        }

        //******************************************************************************************************

        public static void EnsurePopulatedCarSegments(IApplicationBuilder app)
        {
            ApplicationDBContext context = app.ApplicationServices.GetRequiredService<ApplicationDBContext>();
            context.Database.Migrate();

            if (!context.CarSegments.Any())
            {
                context.CarSegments.AddRange(
                    new CarSegment
                    {
                        CarSegmentName = "small"
                    },

                    new CarSegment
                    {
                        CarSegmentName = "medium"
                    },

                    new CarSegment
                    {
                        CarSegmentName = "large"
                    },

                    new CarSegment
                    {
                        CarSegmentName = "van"
                    },

                    new CarSegment
                    {
                        CarSegmentName = "SUV"
                    },

                    new CarSegment
                    {
                        CarSegmentName = "wagon"
                    },

                    new CarSegment
                    {
                        CarSegmentName = "luxury"
                    },

                    new CarSegment
                    {
                        CarSegmentName = "convertible"
                    }
                    );
                context.SaveChanges();
            }
        }

        //******************************************************************************************************


        public static void EnsurePopulatedCarModels(IApplicationBuilder app)
        {
            ApplicationDBContext context = app.ApplicationServices.GetRequiredService<ApplicationDBContext>();
            context.Database.Migrate();

            if (!context.Models.Any())
            {
                context.Models.AddRange(
                    new CarModel                          //Fiat 500
                    {
                        BrandID = 1,
                        CarModelName="500",
                        CarTypeID = 1,
                        CarSegmentID = 1
                    },

                    new CarModel                          //Kia Picanto
                    {
                        BrandID = 2,
                        CarModelName = "Picanto",
                        CarTypeID = 1,
                        CarSegmentID = 1
                    },

                    new CarModel                          //Mini Convertible
                    {
                        BrandID = 3,
                        CarModelName = "Convertible",
                        CarTypeID = 1,
                        CarSegmentID = 1
                    },

                    new CarModel                          //Opel Corsa
                    {
                        BrandID = 4,
                        CarModelName = "Corsa",
                        CarTypeID = 1,
                        CarSegmentID = 1
                    },

                    new CarModel                          //Peugeot 208
                    {
                        BrandID = 5,
                        CarModelName = "208",
                        CarTypeID = 1,
                        CarSegmentID = 1
                    },

                    new CarModel                          //Dacia Sandero
                    {
                        BrandID = 12,
                        CarModelName = "Sandero",
                        CarTypeID = 1,
                        CarSegmentID = 1
                    },

                    new CarModel                          //Renault Twingo
                    {
                        BrandID = 6,
                        CarModelName = "Twingo",
                        CarTypeID = 1,
                        CarSegmentID = 1
                    },

                    new CarModel                          //Skoda Citigo
                    {
                        BrandID = 7,
                        CarModelName = "Citigo",
                        CarTypeID = 1,
                        CarSegmentID = 1
                    },

                    new CarModel                          //Volkswagen Polo
                    {
                        BrandID = 8,
                        CarModelName = "Polo",
                        CarTypeID = 1,
                        CarSegmentID = 1
                    },

                    new CarModel                          //Mazda 3
                    {
                        BrandID = 9,
                        CarModelName = "3",
                        CarTypeID = 1,
                        CarSegmentID = 1
                    },

                    new CarModel                          //Toyota Auris 
                    {
                        BrandID = 10,
                        CarModelName = "Auris",
                        CarTypeID = 1,
                        CarSegmentID = 1
                    }
                    );
                context.SaveChanges();
            }
        }

        //******************************************************************************************************

        public static void EnsurePopulatedCarVersions(IApplicationBuilder app)
    {
        ApplicationDBContext context = app.ApplicationServices.GetRequiredService<ApplicationDBContext>();
        context.Database.Migrate();

        if (!context.CarVersions.Any())
        {
                    context.CarVersions.AddRange(
                        new CarVersion                          //Fiat 500
                        {
                            CarModelID = 1,
                            OfferNameID = 1,
                            Passengers = 5,
                            Doors = 3,
                            BootCapacity = 185,
                            EnginePower = 85,
                            FuelConsumptionPer100km = 3.8f,
                            EngineSize = 875,
                            IsDeleted = false,
                            AirConditioningID = 2,
                            TransmissionID = 1,
                            FuelTypeID = 2,

                        },

                        new CarVersion                          //Kia Picanto
                        {
                            CarModelID = 2,
                            OfferNameID = 2,
                            Passengers = 5,
                            Doors = 5,
                            BootCapacity = 255,
                            EnginePower = 84,
                            FuelConsumptionPer100km = 4.6f,
                            EngineSize = 1248,
                            IsDeleted = false,
                            AirConditioningID = 2,
                            TransmissionID = 1,
                            FuelTypeID = 2
                        },

                        new CarVersion                          //Mini Convertible
                        {
                            CarModelID = 3,
                            OfferNameID = 3,
                            Passengers = 4,
                            Doors = 2,
                            BootCapacity = 160,
                            EnginePower = 192,
                            FuelConsumptionPer100km = 6f,
                            EngineSize = 1998,
                            IsDeleted = false,
                            AirConditioningID = 2,
                            TransmissionID = 1,
                            FuelTypeID = 2
                        },

                        new CarVersion                          //Mini Convertible
                        {
                            CarModelID = 3,
                            OfferNameID = 3,
                            Passengers = 4,
                            Doors = 2,
                            BootCapacity = 160,
                            EnginePower = 116,
                            FuelConsumptionPer100km = 3.8f,
                            EngineSize = 1496,
                            IsDeleted = false,
                            AirConditioningID = 2,
                            TransmissionID = 1,
                            FuelTypeID = 1
                        },

                        new CarVersion                          //Mini Convertible
                        {
                            CarModelID = 3,
                            OfferNameID = 3,
                            Passengers = 4,
                            Doors = 2,
                            BootCapacity = 160,
                            EnginePower = 136,
                            FuelConsumptionPer100km = 5.1f,
                            EngineSize = 1499,
                            IsDeleted = false,
                            AirConditioningID = 2,
                            TransmissionID = 2,
                            FuelTypeID = 2
                        },

                        new CarVersion                          //Opel Corsa
                        {
                            CarModelID = 4,
                            OfferNameID = 4,
                            Passengers = 5,
                            Doors = 3,
                            BootCapacity = 280,
                            EnginePower = 90,
                            FuelConsumptionPer100km = 6.1f,
                            EngineSize = 1398,
                            IsDeleted = false,
                            AirConditioningID = 1,
                            TransmissionID = 1,
                            FuelTypeID = 4
                        },

                        new CarVersion                          //Opel Corsa
                        {
                            CarModelID = 4,
                            OfferNameID = 4,
                            Passengers = 5,
                            Doors = 3,
                            BootCapacity = 280,
                            EnginePower = 90,
                            FuelConsumptionPer100km = 4.9f,
                            EngineSize = 999,
                            IsDeleted = false,
                            AirConditioningID = 1,
                            TransmissionID = 1,
                            FuelTypeID = 2
                        },

                        new CarVersion                          //Opel Corsa
                        {
                            CarModelID = 4,
                            OfferNameID = 4,
                            Passengers = 5,
                            Doors = 3,
                            BootCapacity = 280,
                            EnginePower = 95,
                            FuelConsumptionPer100km = 3.3f,
                            EngineSize = 1248,
                            IsDeleted = false,
                            AirConditioningID = 2,
                            TransmissionID = 1,
                            FuelTypeID = 1
                        },

                        new CarVersion                          //Opel Corsa
                        {
                            CarModelID = 4,
                            OfferNameID = 4,
                            Passengers = 5,
                            Doors = 3,
                            BootCapacity = 280,
                            EnginePower = 75,
                            FuelConsumptionPer100km = 5.8f,
                            EngineSize = 1398,
                            IsDeleted = false,
                            AirConditioningID = 1,
                            TransmissionID = 1,
                            FuelTypeID = 2
                        },

                        new CarVersion                          //Opel Corsa
                        {
                            CarModelID = 4,
                            OfferNameID = 4,
                            Passengers = 5,
                            Doors = 3,
                            BootCapacity = 280,
                            EnginePower = 90,
                            FuelConsumptionPer100km = 6.5f,
                            EngineSize = 1398,
                            IsDeleted = false,
                            AirConditioningID = 2,
                            TransmissionID = 2,
                            FuelTypeID = 2
                        },

                        new CarVersion                          //Opel Corsa
                        {
                            CarModelID = 4,
                            OfferNameID = 4,
                            Passengers = 5,
                            Doors = 3,
                            BootCapacity = 280,
                            EnginePower = 95,
                            FuelConsumptionPer100km = 3.3f,
                            EngineSize = 1248,
                            IsDeleted = false,
                            AirConditioningID = 1,
                            TransmissionID = 1,
                            FuelTypeID = 1
                        },

                        new CarVersion                          //Peugeot 208
                        {
                            CarModelID = 5,
                            OfferNameID = 5,
                            Passengers = 5,
                            Doors = 3,
                            BootCapacity = 285,
                            EnginePower = 68,
                            FuelConsumptionPer100km = 4.3f,
                            EngineSize = 999,
                            IsDeleted = false,
                            AirConditioningID = 1,
                            TransmissionID = 1,
                            FuelTypeID = 2
                        },

                        new CarVersion                          //Peugeot 208
                        {
                            CarModelID = 5,
                            OfferNameID = 5,
                            Passengers = 5,
                            Doors = 3,
                            BootCapacity = 285,
                            EnginePower = 110,
                            FuelConsumptionPer100km = 4.6f,
                            EngineSize = 1199,
                            IsDeleted = false,
                            AirConditioningID = 2,
                            TransmissionID = 1,
                            FuelTypeID = 2
                        },

                        new CarVersion                          //Peugeot 208
                        {
                            CarModelID = 5,
                            OfferNameID = 5,
                            Passengers = 5,
                            Doors = 3,
                            BootCapacity = 285,
                            EnginePower = 110,
                            FuelConsumptionPer100km = 4.8f,
                            EngineSize = 1199,
                            IsDeleted = false,
                            AirConditioningID = 1,
                            TransmissionID = 2,
                            FuelTypeID = 2
                        },

                        new CarVersion                          //Peugeot 208
                        {
                            CarModelID = 5,
                            OfferNameID = 5,
                            Passengers = 5,
                            Doors = 5,
                            BootCapacity = 285,
                            EnginePower = 82,
                            FuelConsumptionPer100km = 4.5f,
                            EngineSize = 1199,
                            IsDeleted = false,
                            AirConditioningID = 1,
                            TransmissionID = 1,
                            FuelTypeID = 2
                        },

                        new CarVersion                          //Peugeot 208
                        {
                            CarModelID = 5,
                            OfferNameID = 5,
                            Passengers = 5,
                            Doors = 5,
                            BootCapacity = 285,
                            EnginePower = 82,
                            FuelConsumptionPer100km = 4.1f,
                            EngineSize = 1199,
                            IsDeleted = false,
                            AirConditioningID = 2,
                            TransmissionID = 2,
                            FuelTypeID = 2
                        },

                        new CarVersion                          //Peugeot 208
                        {
                            CarModelID = 5,
                            OfferNameID = 5,
                            Passengers = 5,
                            Doors = 5,
                            BootCapacity = 285,
                            EnginePower = 102,
                            FuelConsumptionPer100km = 3.7f,
                            EngineSize = 1499,
                            IsDeleted = false,
                            AirConditioningID = 1,
                            TransmissionID = 1,
                            FuelTypeID = 1
                        },

                        new CarVersion                          //Peugeot 208
                        {
                            CarModelID = 5,
                            OfferNameID = 5,
                            Passengers = 5,
                            Doors = 5,
                            BootCapacity = 285,
                            EnginePower = 100,
                            FuelConsumptionPer100km = 4.3f,
                            EngineSize = 1560,
                            IsDeleted = false,
                            AirConditioningID = 2,
                            TransmissionID = 1,
                            FuelTypeID = 1
                        },

                        new CarVersion                          //Peugeot 208
                        {
                            CarModelID = 5,
                            OfferNameID = 6,
                            Passengers = 5,
                            Doors = 5,
                            BootCapacity = 285,
                            EnginePower = 136,
                            FuelConsumptionPer100km = 16.1f,
                            EngineSize = null,
                            IsDeleted = false,
                            AirConditioningID = 2,
                            TransmissionID = 2,
                            FuelTypeID = 3
                        },

                        new CarVersion                          //Dacia Sandero
                        {
                            CarModelID = 6,
                            OfferNameID = 7,
                            Passengers = 5,
                            Doors = 5,
                            BootCapacity = 320,
                            EnginePower = 90,
                            FuelConsumptionPer100km = 4.9f,
                            EngineSize = 898,
                            IsDeleted = false,
                            AirConditioningID = 1,
                            TransmissionID = 1,
                            FuelTypeID = 4
                        },

                        new CarVersion                          //Dacia Sandero
                        {
                            CarModelID = 6,
                            OfferNameID = 7,
                            Passengers = 5,
                            Doors = 5,
                            BootCapacity = 320,
                            EnginePower = 73,
                            FuelConsumptionPer100km = 5.2f,
                            EngineSize = 1000,
                            IsDeleted = false,
                            AirConditioningID = 1,
                            TransmissionID = 1,
                            FuelTypeID = 2
                        },

                        new CarVersion                          //Dacia Sandero
                        {
                            CarModelID = 6,
                            OfferNameID = 7,
                            Passengers = 5,
                            Doors = 5,
                            BootCapacity = 320,
                            EnginePower = 75,
                            FuelConsumptionPer100km = 3.5f,
                            EngineSize = 1461,
                            IsDeleted = false,
                            AirConditioningID = 1,
                            TransmissionID = 1,
                            FuelTypeID = 1
                        },

                        new CarVersion                          //Renault Twingo
                        {
                            CarModelID = 7,
                            OfferNameID = 13,
                            Passengers = 4,
                            Doors = 5,
                            BootCapacity = 219,
                            EnginePower = 70,
                            FuelConsumptionPer100km = 5.5f,
                            EngineSize = 999,
                            IsDeleted = false,
                            AirConditioningID = 1,
                            TransmissionID = 1,
                            FuelTypeID = 2
                        },

                        new CarVersion                          //Renault Twingo
                        {
                            CarModelID = 7,
                            OfferNameID = 13,
                            Passengers = 4,
                            Doors = 5,
                            BootCapacity = 219,
                            EnginePower = 90,
                            FuelConsumptionPer100km = 4.9f,
                            EngineSize = 898,
                            IsDeleted = false,
                            AirConditioningID = 1,
                            TransmissionID = 1,
                            FuelTypeID = 2
                        },

                        new CarVersion                          //Renault Twingo
                        {
                            CarModelID = 7,
                            OfferNameID = 13,
                            Passengers = 4,
                            Doors = 5,
                            BootCapacity = 219,
                            EnginePower = 110,
                            FuelConsumptionPer100km = 5.6f,
                            EngineSize = 898,
                            IsDeleted = false,
                            AirConditioningID = 2,
                            TransmissionID = 1,
                            FuelTypeID = 2
                        },

                        new CarVersion                          //Renault Twingo
                        {
                            CarModelID = 7,
                            OfferNameID = 13,
                            Passengers = 4,
                            Doors = 5,
                            BootCapacity = 219,
                            EnginePower = 110,
                            FuelConsumptionPer100km = 5.8f,
                            EngineSize = 898,
                            IsDeleted = false,
                            AirConditioningID = 2,
                            TransmissionID = 2,
                            FuelTypeID = 2
                        },

                        new CarVersion                          //Skoda Citigo electric
                        {
                            CarModelID = 8,
                            OfferNameID = 14,
                            Passengers = 4,
                            Doors = 5,
                            BootCapacity = 250,
                            EnginePower = 83,
                            FuelConsumptionPer100km = 16.4f,
                            EngineSize = null,
                            IsDeleted = false,
                            AirConditioningID = 2,
                            TransmissionID = 2,
                            FuelTypeID = 3
                        },

                        new CarVersion                          //Skoda Citigo
                        {
                            CarModelID = 8,
                            OfferNameID = 8,
                            Passengers = 4,
                            Doors = 3,
                            BootCapacity = 251,
                            EnginePower = 60,
                            FuelConsumptionPer100km = 4.5f,
                            EngineSize = 999,
                            IsDeleted = false,
                            AirConditioningID = 1,
                            TransmissionID = 1,
                            FuelTypeID = 2
                        },

                        new CarVersion                          //Skoda Citigo
                        {
                            CarModelID = 8,
                            OfferNameID = 8,
                            Passengers = 4,
                            Doors = 3,
                            BootCapacity = 251,
                            EnginePower = 75,
                            FuelConsumptionPer100km = 4.6f,
                            EngineSize = 999,
                            IsDeleted = false,
                            AirConditioningID = 1,
                            TransmissionID = 1,
                            FuelTypeID = 2
                        },

                        new CarVersion                          //Skoda Citigo
                        {
                            CarModelID = 8,
                            OfferNameID = 8,
                            Passengers = 4,
                            Doors = 3,
                            BootCapacity = 251,
                            EnginePower = 75,
                            FuelConsumptionPer100km = 4.5f,
                            EngineSize = 999,
                            IsDeleted = false,
                            AirConditioningID = 1,
                            TransmissionID = 2,
                            FuelTypeID = 2
                        },

                        new CarVersion                          //Skoda Citigo
                        {
                            CarModelID = 8,
                            OfferNameID = 8,
                            Passengers = 5,
                            Doors = 5,
                            BootCapacity = 251,
                            EnginePower = 75,
                            FuelConsumptionPer100km = 4.6f,
                            EngineSize = 999,
                            IsDeleted = false,
                            AirConditioningID = 1,
                            TransmissionID = 1,
                            FuelTypeID = 2
                        },

                        new CarVersion                          //Volkswagen Polo
                        {
                            CarModelID = 9,
                            OfferNameID = 9,
                            Passengers = 5,
                            Doors = 5,
                            BootCapacity = 351,
                            EnginePower = 75,
                            FuelConsumptionPer100km = 5.1f,
                            EngineSize = 999,
                            IsDeleted = false,
                            AirConditioningID = 1,
                            TransmissionID = 1,
                            FuelTypeID = 2
                        },

                        new CarVersion                          //Volkswagen Polo
                        {
                            CarModelID = 9,
                            OfferNameID = 9,
                            Passengers = 5,
                            Doors = 5,
                            BootCapacity = 351,
                            EnginePower = 95,
                            FuelConsumptionPer100km = 4.1f,
                            EngineSize = 999,
                            IsDeleted = false,
                            AirConditioningID = 1,
                            TransmissionID = 1,
                            FuelTypeID = 2
                        },

                        new CarVersion                          //Volkswagen Polo
                        {
                            CarModelID = 9,
                            OfferNameID = 9,
                            Passengers = 5,
                            Doors = 5,
                            BootCapacity = 351,
                            EnginePower = 95,
                            FuelConsumptionPer100km = 4.2f,
                            EngineSize = 999,
                            IsDeleted = false,
                            AirConditioningID = 1,
                            TransmissionID = 2,
                            FuelTypeID = 2
                        },

                        new CarVersion                          //Volkswagen Polo
                        {
                            CarModelID = 9,
                            OfferNameID = 9,
                            Passengers = 5,
                            Doors = 5,
                            BootCapacity = 351,
                            EnginePower = 80,
                            FuelConsumptionPer100km = 3.7f,
                            EngineSize = 1598,
                            IsDeleted = false,
                            AirConditioningID = 1,
                            TransmissionID = 1,
                            FuelTypeID = 1
                        },

                        new CarVersion                          //Volkswagen Polo
                        {
                            CarModelID = 9,
                            OfferNameID = 9,
                            Passengers = 5,
                            Doors = 5,
                            BootCapacity = 351,
                            EnginePower = 95,
                            FuelConsumptionPer100km = 4.6f,
                            EngineSize = 1598,
                            IsDeleted = false,
                            AirConditioningID = 1,
                            TransmissionID = 2,
                            FuelTypeID = 1
                        },

                        new CarVersion                          //Mazda 3
                        {
                            CarModelID = 10,
                            OfferNameID = 10,
                            Passengers = 5,
                            Doors = 4,
                            BootCapacity = 444,
                            EnginePower = 150,
                            FuelConsumptionPer100km = 6f,
                            EngineSize = 1998,
                            IsDeleted = false,
                            AirConditioningID = 2,
                            TransmissionID = 1,
                            FuelTypeID = 2
                        },

                        new CarVersion                          //Mazda 3
                        {
                            CarModelID = 10,
                            OfferNameID = 10,
                            Passengers = 5,
                            Doors = 4,
                            BootCapacity = 444,
                            EnginePower = 150,
                            FuelConsumptionPer100km = 6.4f,
                            EngineSize = 1998,
                            IsDeleted = false,
                            AirConditioningID = 1,
                            TransmissionID = 2,
                            FuelTypeID = 2
                        },

                        new CarVersion                          //Mazda 3
                        {
                            CarModelID = 10,
                            OfferNameID = 10,
                            Passengers = 5,
                            Doors = 4,
                            BootCapacity = 444,
                            EnginePower = 120,
                            FuelConsumptionPer100km = 6.1f,
                            EngineSize = 1998,
                            IsDeleted = false,
                            AirConditioningID = 2,
                            TransmissionID = 1,
                            FuelTypeID = 2
                        },

                        new CarVersion                          //Mazda 3
                        {
                            CarModelID = 10,
                            OfferNameID = 10,
                            Passengers = 5,
                            Doors = 4,
                            BootCapacity = 444,
                            EnginePower = 120,
                            FuelConsumptionPer100km = 6.6f,
                            EngineSize = 1998,
                            IsDeleted = false,
                            AirConditioningID = 2,
                            TransmissionID = 2,
                            FuelTypeID = 2
                        },

                        new CarVersion                          //Toyota Auris hybrid
                        {
                            CarModelID = 11,
                            OfferNameID = 12,
                            Passengers = 5,
                            Doors = 5,
                            BootCapacity = 428,
                            EnginePower = 136,
                            FuelConsumptionPer100km = 3.5f,
                            EngineSize = 1798,
                            IsDeleted = false,
                            AirConditioningID = 2,
                            TransmissionID = 2,
                            FuelTypeID = 5
                        },

                        new CarVersion                          //Toyota Auris
                        {
                            CarModelID = 11,
                            OfferNameID = 11,
                            Passengers = 5,
                            Doors = 5,
                            BootCapacity = 428,
                            EnginePower = 112,
                            FuelConsumptionPer100km = 4.2f,
                            EngineSize = 1598,
                            IsDeleted = false,
                            AirConditioningID = 1,
                            TransmissionID = 1,
                            FuelTypeID = 1
                        },

                        new CarVersion                          //Toyota Auris
                        {
                            CarModelID = 11,
                            OfferNameID = 11,
                            Passengers = 5,
                            Doors = 5,
                            BootCapacity = 428,
                            EnginePower = 99,
                            FuelConsumptionPer100km = 5.5f,
                            EngineSize = 1329,
                            IsDeleted = false,
                            AirConditioningID = 2,
                            TransmissionID = 1,
                            FuelTypeID = 2
                        }
                        );
                    context.SaveChanges();
            }
    }

    //******************************************************************************************************

    public static void EnsurePopulatedCars(IApplicationBuilder app)
    {
        ApplicationDBContext context = app.ApplicationServices.GetRequiredService<ApplicationDBContext>();
        context.Database.Migrate();

        if (!context.Cars.Any())
        {
                context.Cars.AddRange(

            new Car
            {
                VIN = "1FMCU0J96EUB98206",
                RegistrationNumber = "XF95477",
                DateOfFirstRegistration = new DateTime(2019, 12, 23),
                DateOfPurchase = new DateTime(2019, 12, 21),
                Color = "Green",
                IsInUse = true,
                IsDeleted = false,
                CarVersionID = 1
            },

            new Car
            {
                VIN = "1GNDX03E31D222764",
                RegistrationNumber = "XWL95667",
                DateOfFirstRegistration = new DateTime(2016, 4, 30),
                DateOfPurchase = new DateTime(2020, 2, 14),
                Color = "Red metalic",
                IsInUse = false,
                IsDeleted = false,
                CarVersionID = 2
            },

            new Car
            {
                VIN = "1FAHP3H22CL168947",
                RegistrationNumber = "XF03860",
                DateOfFirstRegistration = new DateTime(2016, 11, 15),
                DateOfPurchase = new DateTime(2017, 7, 11),
                Color = "White",
                IsInUse = true,
                IsDeleted = false,
                CarVersionID = 3
            },

            new Car
            {
                VIN = "1FTFW1ET4EKE21085",
                RegistrationNumber = "XF73969",
                DateOfFirstRegistration = new DateTime(2019, 1, 9),
                DateOfPurchase = new DateTime(2019, 1, 7),
                Color = "Red",
                IsInUse = true,
                IsDeleted = false,
                CarVersionID = 4
            },

            new Car
            {
                VIN = "3N1AB7AP8DL723707",
                RegistrationNumber = "XF39787",
                DateOfFirstRegistration = new DateTime(2018, 12, 5),
                DateOfPurchase = new DateTime(2020, 1, 10),
                Color = "Dark blue",
                IsInUse = true,
                IsDeleted = false,
                CarVersionID = 5
            },

            new Car
            {
                VIN = "1J4FJ68S1WL266175",
                RegistrationNumber = "XF19471",
                DateOfFirstRegistration = new DateTime(2017, 11, 14),
                DateOfPurchase = new DateTime(2019, 7, 29),
                Color = "Yellow",
                IsInUse = true,
                IsDeleted = false,
                CarVersionID = 7
            },

            new Car
            {
                VIN = "KNDJP3A54E7040222",
                RegistrationNumber = "XF85725",
                DateOfFirstRegistration = new DateTime(2018, 1, 9),
                DateOfPurchase = new DateTime(2018, 1, 4),
                Color = "White",
                IsInUse = true,
                IsDeleted = false,
                CarVersionID = 8
            },

            new Car
            {
                VIN = "2B3LA73W88H241557",
                RegistrationNumber = "XF88709",
                DateOfFirstRegistration = new DateTime(2020, 3, 6),
                DateOfPurchase = new DateTime(2020, 3, 4),
                Color = "Brown",
                IsInUse = true,
                IsDeleted = false,
                CarVersionID = 9
            },

            new Car
            {
                VIN = "3N1AB61E57L620726",
                RegistrationNumber = "XF47154",
                DateOfFirstRegistration = new DateTime(2016, 12, 2),
                DateOfPurchase = new DateTime(2019, 10, 2),
                Color = "Red",
                IsInUse = true,
                IsDeleted = false,
                CarVersionID = 10
            },

            new Car
            {
                VIN = "1C3EJ56H4XN608232",
                RegistrationNumber = "XF48201",
                DateOfFirstRegistration = new DateTime(2016, 9, 11),
                DateOfPurchase = new DateTime(2019, 5, 4),
                Color = "Green",
                IsInUse = true,
                IsDeleted = false,
                CarVersionID =11
            },

            new Car
            {
                VIN = "1FT8W3BT8CEB65201",
                RegistrationNumber = "XF48371",
                DateOfFirstRegistration = new DateTime(2017, 6, 5),
                DateOfPurchase = new DateTime(2018, 7, 24),
                Color = "Black",
                IsInUse = true,
                IsDeleted = false,
                CarVersionID = 12
            },

            new Car
            {
                VIN = "WBSBL93433JR41453",
                RegistrationNumber = "XF06930",
                DateOfFirstRegistration = new DateTime(2015, 8, 1),
                DateOfPurchase = new DateTime(2018, 4, 21),
                Color = "White",
                IsInUse = true,
                IsDeleted = false,
                CarVersionID = 13
            },

            new Car
            {
                VIN = "KMHGC4DD1CU178924",
                RegistrationNumber = "XF82654",
                DateOfFirstRegistration = new DateTime(2017, 1, 15),
                DateOfPurchase = new DateTime(2017, 1, 14),
                Color = "Red",
                IsInUse = true,
                IsDeleted = false,
                CarVersionID = 14
            },

            new Car
            {
                VIN = "1FTYS90L0NVA66005",
                RegistrationNumber = "XF12958",
                DateOfFirstRegistration = new DateTime(2019, 10, 28),
                DateOfPurchase = new DateTime(2019, 10, 23),
                Color = "Green",
                IsInUse = true,
                IsDeleted = false,
                CarVersionID = 15
            },

            new Car
            {
                VIN = "1J4GR48KX5C537251",
                RegistrationNumber = "XF73809",
                DateOfFirstRegistration = new DateTime(2016, 11, 7),
                DateOfPurchase = new DateTime(2020, 1, 23),
                Color = "Silver",
                IsInUse = true,
                IsDeleted = false,
                CarVersionID = 16
            },

            new Car
            {
                VIN = "YV4CZ852561295432",
                RegistrationNumber = "XF61956",
                DateOfFirstRegistration = new DateTime(2018, 6, 29),
                DateOfPurchase = new DateTime(2019, 8, 11),
                Color = "Grey",
                IsInUse = true,
                IsDeleted = false,
                CarVersionID = 17
            },

            new Car
            {
                VIN = "1G6EL12Y1YB740231",
                RegistrationNumber = "XF48371",
                DateOfFirstRegistration = new DateTime(2014, 1, 30),
                DateOfPurchase = new DateTime(2019, 8, 7),
                Color = "",
                IsInUse = true,
                IsDeleted = false,
                CarVersionID = 18
            },

            new Car
            {
                VIN = "1FDKF37GXVEB11107",
                RegistrationNumber = "XF90574",
                DateOfFirstRegistration = new DateTime(2016, 5, 1),
                DateOfPurchase = new DateTime(2017, 12, 28),
                Color = "Red",
                IsInUse = true,
                IsDeleted = false,
                CarVersionID = 19
            },

            new Car
            {
                VIN = "3N1BC13E68L396403",
                RegistrationNumber = "XF84960",
                DateOfFirstRegistration = new DateTime(2017, 11, 26),
                DateOfPurchase = new DateTime(2017, 11, 23),
                Color = "Silver",
                IsInUse = true,
                IsDeleted = false,
                CarVersionID = 20
            },

            new Car
            {
                VIN = "2T1BU4EE1DC924225",
                RegistrationNumber = "XF36104",
                DateOfFirstRegistration = new DateTime(2018, 1, 14),
                DateOfPurchase = new DateTime(2019, 5, 7),
                Color = "White",
                IsInUse = true,
                IsDeleted = false,
                CarVersionID = 21
            }
            );
                context.SaveChanges();
            }
    }




    }
}
