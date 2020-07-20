# Car Rental
##### Car Rental is my pet web-application built in order to learn and find job as .NET junior developer.  

## Table of contents
* [General info](#general-info)
* [Technologies](#technologies)
* [Features](#features)

## General info
Car Rental is application designed for virtual-company renting vehicles. It makes for presentating and inform about technical details of vehicles and allows customers book them. Furthemore - it has a panel designing for manage.

## Technologies: 
ASP .NET Core 2.1 + MS SQL Server 2014 + HTML/CSS \
Frameworks: Entity Framework Core, MediatR, \
design patterns: MVC, Dependency Injection, CQRS, \
unit tests: xUnit, AutoFixture \
Frontend: based on Admin LTE (https://adminlte.io/) + Gaas (https://colorlib.com/) 

## Features
* retrieve cars from database and based on it display list of offer names (i.e. Skoda Citigo, Peugeot 208, Volkswagen Golf GTI, Toyota Auris electric etc), 
* allow filter this list - using air conditioning, transmission, segment, type of fuel, number of passengers
![](CarRental/wwwroot/img/App screens/CarsList.png?raw=true)
#### In progress:
* Authorisation - 3 types of users: \
-client - he is allow to rent vahicles \
-base manager - he is allow to manage vehicles in his base \
-administrator - he is allow to manage vehicles in all localizations, 
*


[CarsListForCustomers]: "CarRental/wwwroot/img/App%20screens/CarsList.png "CarsListForCustomers"
