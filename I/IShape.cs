using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I
{
    //public interface IShape
    //{
    //    double Area();
    //    double Volume();
    //}

    public interface IShape2D
    {
        double Area();
    }

    public interface IShape3D
    {
        double Volume();
    }
}
