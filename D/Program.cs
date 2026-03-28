//Dependancy Inversion Principle 

// High-level module should not depend on low level module , both should depend on abstraction

using System;
using D;

Car evCar = new Car(new ElectricEnginee());
evCar.Start();

Car dieselCar = new Car(new DieselEnginee());
dieselCar.Start();