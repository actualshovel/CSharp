using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllMyShapes
{
    class Square : Shape
    {
        private double side;

        public Square() { }//constructor

        public Square(double s) //constructor
        {
            //give local variable SIDE a value that we get from the parameter
            side = s;
        }

        /*
         *properties to override the abstract property in the Shape class
         *get will return the area, given the side
         *set will set the value of side, when area is known
         */
        public override double Area
        {
            get { return side * side; }
            set{ side = System.Math.Sqrt(value); }
        }

        public double Perimeter
        {
            get { return side * 4; }
            set { side = (value / 4); }
        }

    }
}