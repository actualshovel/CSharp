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
            string selectUnit = "";
            string userValue = "";
            string answer = "";

            //user enters type of unit to be converted
            Console.WriteLine("What unit are you converting from?");
            Console.WriteLine("ex: temp, currency, volume, mass");
            selectUnit = Console.ReadLine();
            
            //20FEB2019
            //WHAT I NEED
            //allow user to type (ex. "68F" to represent 68 degrees fahrenheit
            //determine if there is an F or a C
            //convert depending on which (char? substring?) is used
            if (selectUnit.ToLower().Equals("temp"))
            {
                
                Console.WriteLine("Enter the temp followed by a 'C' for celsius or an 'F' for fahrenheit:");
                userValue = Console.ReadLine();
                Temperature tmp = new Temperature(userValue);
                answer = tmp.ToFahrenheit.ToString();

            }
            
            Console.WriteLine("Converted {0} to {1}!", userValue, answer);

            Console.ReadLine();
        }



        //static string CheckType(string unit)
        //{
        //    string temp = unit.Substring(unit.Length-1);
        //    return temp;
        //}
    }
}
