//Unit Converter(temp, currency, volume, mass and more) - 
//Converts various units between one another.The user enters the type of unit being entered, 
//the type of unit they want to convert to and then the value.The program will then make the conversion.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: create conversion class
//allow this operation to happen both ways

namespace UnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: wrap within a loop
            double userTemperature = 0;
            string userChoice;
            string answer = "";

            //user enters type of unit to be converted
            Console.WriteLine("What unit are you converting from?");
            Console.WriteLine("ex: temp, currency, volume, mass");
            userChoice = Console.ReadLine();

            if (userChoice.ToLower().Equals("temp"))
            {
                
                Console.WriteLine("Enter the temperature:");
                answer = Console.ReadLine();
                Temperature tmp = new Temperature(answer);

                Console.WriteLine(tmp.FahrenheitToCelsius());
                

            }
            Console.ReadLine();
        }
    }
}
