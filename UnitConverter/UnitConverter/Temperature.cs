using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    class Temperature
    {
        private double celsius;
        public double ToCelsius
        {
            get { return celsius; }
            set { celsius = (((fahrenheit - 32) * 5) / 9); }
        }

        private double fahrenheit;
        public double ToFahrenheit
        {
            get { return fahrenheit; }
            set { fahrenheit = (celsius * (9/5) + 32); ; }
        }


        public Temperature() { }
        
        //take another look at why i was getting
        //a format exception previously
        public Temperature(string temp) {
            if (CheckUnitType(temp).Equals('F'))
                fahrenheit = double.Parse(temp);
            if (CheckUnitType(temp) == "C")
                celsius = double.Parse(temp);
        }

        







        //public double ToFn(double cel)
        //{
        //    double fah = (cel * (9/5) + 32);
        //    return fah;
        //}

        //public double ToCel()
        //{
        //    celsius = (((fahrenheit - 32) * 5) / 9);


        //    //Deduct 32, then multiply by 5, then divide by 9
        //    double cel = (((fah - 32) * 5) / 9);
        //    return cel;

        //}


        static string CheckUnitType(string unit)
        {
            string lastString = unit.Substring(unit.Length-1);
            return lastString;


        }
    }
}
