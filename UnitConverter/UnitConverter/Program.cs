//Unit Converter(temp, currency, volume, mass and more) - 
//Converts various units between one another.The user enters the type of unit being entered, 
//the type of unit they want to convert to and then the value.The program will then make the conversion.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    class Program
    {
        //TODO: main program will loop
        static void Main(string[] args)
        {
            //TODO: improve design of menus and output text
            //select what kind of conversions to be made
            Console.WriteLine("1) Temperature\n" +
                              "2) Weight\n" +
                              "3) Distance");

            //user needs to only choose 1, 2, or 3
            //so a switch statement is enough here to execute the single
            //line of code that takes care of the desired conversion
            int unitChoice = int.Parse(Console.ReadLine());
            switch(unitChoice)
            {
                case 1:
                    TempMenu();
                    break;
                case 2:
                    WeightMenu();
                    break;
                default:
                    break;
                //TODO: add features - distances (feet, inches, yards, etc)
            }
            Console.ReadLine();
        }

        public static void TempMenu()
        {
            Console.WriteLine("Choose a conversion: ");
            Console.WriteLine("1) Fahrenheit to Celsius");
            Console.WriteLine("2) Celsius to Fahrenheit");
            //TODO: validate user input
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter temperature: ");
            double userTemp = double.Parse(Console.ReadLine());

            Temperature temp = new Temperature();
            if (choice == 1)
            {
                temp.Fahrenheit = userTemp;
                temp.GetCelsius();
            }
            else if (choice == 2)
            {
                temp.Celsius = userTemp;
                temp.GetFahrenheit();
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
            

        }

        //TODO weight conversions of all types
        public static void WeightMenu()
        {
            int userWeight;
        }
    }
}
