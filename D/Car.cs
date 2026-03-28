using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    public class Car
    {
        private IEnginee enginee;

        public Car(IEnginee enginee)
        {
            this.enginee = enginee;
        }

        public void Start()
        {
            enginee.Start();
        }
    }
}
