using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L
{

    //public class Square : Rectangle
    //{
    //    public override double Width
    //    {
    //        get => base.Width;
    //        set => base.Width = base.Height = value;
    //    }

    //    public override double Height
    //    {
    //        get => base.Height;
    //        set => base.Height = base.Width = value;
    //    }
    //}


    public class Rectangle : Shape
    {
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }

        public override double Area => Width * Height;
    }
}
