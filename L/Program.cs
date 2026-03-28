// Liskov Substitution Principle (LSP)

//Objects of a superclass should be replaceable with objects of its subclass without affecting the correctness of the program.


using L;
using System;

//var rect = new Square();
//rect.Height = 10;
//rect.Width  = 5;

//System.Console.WriteLine("Expected area = 10*5 = 50");
//System.Console.WriteLine("Calculated area = 25");

Shape rectangle = new Rectangle {Height = 10 , Width = 5};
Console.WriteLine($"Area of the rectangle {rectangle.Area}");

Shape square = new Square {SideLength = 5};
Console.WriteLine($"Area of the square {square.Area}");