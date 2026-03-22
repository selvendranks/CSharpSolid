using Inheritance;
using System;

var car = new Car();

car.Brand = "Ford";
car.NumberofDoors = 2;
car.NumberofWheels = 3;
car.Start();
car.Stop();

var bike = new Bike();

bike.Brand = "Royal Enfield";
bike.NumberOfWheels = 2;
bike.Start();
bike.Stop();

