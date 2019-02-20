//Unit Converter(temp, currency, volume, mass and more) - 
//Converts various units between one another.The user enters the type of unit being entered, 
//the type of unit they want to convert to and then the value.The program will then make the conversion.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: create conversion class
//TODO: get a full, working temperature conversion
//user will enter a falue in ferenheight and get celcius
//allow this operation to happen both ways

namespace UnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: wrap within a loop
            string firstUnit;
            //user enters type of unit to be converted
            Console.WriteLine("What unit are you converting from?");
            Console.WriteLine("ex: temp, currency, volume, mass");
            firstUnit = Console.ReadLine();

            //TODO: instantiate objects based on selection
            if (firstUnit.ToLower().Equals("temp"))
                TempConversion();
            else if (firstUnit.ToLower().Equals("weight"))
                WeightConversion();
            else if (firstUnit.ToLower().Equals("currency"))
                else
                Console.WriteLine("incorrect entry")


            //convert type
            //then value

        }
    }
}
