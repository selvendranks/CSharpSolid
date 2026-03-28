using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    public class Car
    {
        Enginee enginee = new Enginee();
        Wheel wheel = new Wheel();

        public void Start()
        {
            enginee.Start();
            wheel.Rotate();
        }
    }
}
