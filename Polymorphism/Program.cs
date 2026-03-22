using System;
using Polymorphism;


////Without Polymorphism
//var vehicles = new List<object>();

//vehicles.Add(new Car { Brand = "Toyata", Model = "Canary", Year = 2020, NumberofDoors = 4 });
//vehicles.Add(new Bike { Brand = "Royal Enfield", Model = "Himalyan", Year = 2023 });

////Vehicle Inspection
//foreach (var vehicle in vehicles)
//{
//    if (vehicle is Car)
//    {
//        var car = (Car)vehicle;
//        car.Start();
//    }
//    else if (vehicle is Bike)
//    {
//        var bike = (Bike)vehicle;
//        bike.Start();
//    }
//}



//With Polymorphism

var vehicles = new List<Vehicle>();

vehicles.Add(new Car { Brand = "Toyata", Model = "Canary", Year = 2020, NumberofDoors = 4 });
vehicles.Add(new Bike { Brand = "Royal Enfield", Model = "Himalyan", Year = 2023 });

//Vehicle Inspection
foreach (var vehicle in vehicles)
{
    vehicle.Start();
    vehicle.Stop();
}