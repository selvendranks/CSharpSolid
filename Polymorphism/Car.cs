using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Car : Vehicle
    {
        public int NumberofDoors { get; set; }
        public int NumberofWheels { get; set; }

        public override void Start()
        {
            Console.WriteLine("Car is starting");
        }

        public override void Stop()
        {
            Console.WriteLine("Car is stopping");
        }
    }
}
