//Open/Closed Principle(OCP) Open for extension but closed for modifications.

using O;
using System;

Circle circle = new Circle();
circle.Radius = 5;
Console.WriteLine(circle.CalculateArea());

Rectangle rectangle = new Rectangle();
rectangle.Width = 4;
rectangle.Length = 6;
Console.WriteLine(rectangle.CalculateArea());