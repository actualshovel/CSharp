//Unit Converter(temp, currency, volume, mass and more)
using System;
namespace UnitConverter
{
    class Program
    {
        //TODO: main program will loop
        static void Main(string[] args)
        {
            // Overall design, how could you write a menu function
            // that would allow you to re-use your menu?
            // Example would be, your main menu and temperature
            // menu would use the exact same calls...

            // Super common use of the 'menu' loop, which is a while loop
            // You know a menu is going to be presented at least once
            // no matter the circumststance, so execute the block
            // and check what the user selected after doing it at
            // least once. By adding the selection 'q'
            // I'm relying on the user for exit conditions

            //TODO: improve design of menus and output text
            //select what kind of conversions to be made
            // Add a writeline for description
            // Add a third option, 'q' for quit to exit program
            // Add a description of what to do, similar to TempMenu()
            Console.WriteLine("1) Temperature\n" +
                              "2) Weight\n" +
                              "3) Distance");

            //user needs to only choose 1, 2, or 3
            //so a switch statement is enough here to execute the single
            //line of code that takes care of the desired conversion
            // Add your quit case to exit the program
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

        //a main menu for temperatures
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

            // Why not user your switch here?
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
