using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllMyShapes
{
    abstract class Shape
    {
        //general properties that can apply to all shapes that inherit this class
        public abstract double Area
        {
            get;
            set;
        }
    }
}
