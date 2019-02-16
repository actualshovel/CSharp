using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllMyShapes
{
    class Rectangle : Shape
    {
        private double length, width;

        public Rectangle() { }

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        public override double Area
        {
            get { return length * width; }
            set { }
        }

        public double Perimeter
        {
            get { return 2 * (length + width); }
        }

        
    }
}
