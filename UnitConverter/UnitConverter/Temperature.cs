using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    //use of this class requires instantiation.
    //user will then enter a temperature to be converted by the appropriate method
    class Temperature
    {
        private double _fahrenheit;
        public double Fahrenheit { get; set; }

        private double _celsius;
        public double Celsius { get; set; }

        //formula to get fahrenheit given celsius
        public void GetFahrenheit()
        {
            Fahrenheit = (Celsius * (9/5) + 32);
            Console.WriteLine("{0}C is equal to {1}F", Celsius, Fahrenheit);
        }

        //formula to get celsius given fahrenheit
        public void GetCelsius()
        {
            Celsius = (Fahrenheit - 32) * 5 / 9;
            Console.WriteLine("{0}F is equal to {1}C", Fahrenheit, Celsius);
        }


        //C to F (cel * (9/5) + 32);
        //F to C (((fah - 32) * 5) / 9);
    }
}
