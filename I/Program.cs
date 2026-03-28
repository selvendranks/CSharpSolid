// Interface Segregation Principle

//Clients should not be forced to depend on interfaces they do not use.

using I;
using System;

Circle circle = new Circle {Radius = 5 };
Console.WriteLine(circle.Area());
//Console.WriteLine(circle.Volume());

