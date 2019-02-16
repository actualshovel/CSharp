using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllMyShapes
{
    class Circle : Shape
    {
        private double radius;

        public Circle() { }
        public Circle(double r)
        {
            radius = r;
        }

        public override double Area
        {
            get { return Math.PI * Math.Pow(radius, 2); }
            set { }
        }

        public double Circumfrence
        {
            get { return Math.PI * (radius * 2); }
        }

        public double Diameter
        {
            get { return radius * 2; }
        }
    }
}
