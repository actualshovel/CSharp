using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    class Temperature
    {
        private double _celsius;
        private double _fahrenheit;

        public Temperature() { }
        public Temperature(string temp)
        {
            if (temp.Contains("F"))
            {
                temp = temp.Remove(temp.Length-1);
                _fahrenheit = double.Parse(temp);
            }
            if (temp.Contains("C"))
            {
                temp = temp.Remove(temp.Length-1);
                _celsius = double.Parse(temp);
            }
        }
        public double Celsius
        {
            get { return _celsius; }
            set { FahrenheitToCelsius(); }
        }
        public double Fahrenheit
        {
            get { return _fahrenheit; }
            set { CelsiusToFahreheit(); }
        }

        //C to F (cel * (9/5) + 32);
        //F to C (((fah - 32) * 5) / 9);

        public double FahrenheitToCelsius()
        {
            _celsius = (_fahrenheit - 32) * (5 / 9);
            return _celsius;
        }

        public double CelsiusToFahreheit()
        {
            _fahrenheit = _celsius * (9/5) + 32;
            return _fahrenheit;
        }


        static string CheckUnitType(string unit)
        {
            string lastString = unit.Substring(unit.Length-1);
            return lastString;


        }
    }
}
