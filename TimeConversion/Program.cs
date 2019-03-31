using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            string testCase = "07:05:45PM";
            string testCase2 = "01:15:00AM";
            string testCase3 = "11:59:10PM";
            string testNoon = "12:45:00PM";
            string testMidnight = "12:32:00AM";




            Console.WriteLine("{0} (converts to) {1}", testNoon, timeConversion(testNoon));
            Console.WriteLine("{0} (converts to) {1}", testMidnight, timeConversion(testMidnight));
            Console.WriteLine("{0} (converts to) {1}", testCase, timeConversion(testCase));
            Console.WriteLine("{0} (converts to) {1}", testCase2, timeConversion(testCase2));
            Console.WriteLine("{0} (converts to) {1}", testCase3, timeConversion(testCase3));
            Console.ReadLine();
        }


        static string timeConversion(string s)
        {
            //convert hours to int for addition later
            int hours = int.Parse(s.Substring(0, 2));

            StringBuilder sb = new StringBuilder(s);
            // remove AM or PM, that won't be needed regardless of conversion outcome
            sb.Remove(s.Length - 2, 2);

            // if its PM, add 12. replace first 2 chars with sum of hours + 12
            // i use .ElementAt and not .Contains("PM") so i can go directly to the index i need,
            // instead of searching the whole array until it finds "PM"
            if(s.ElementAt(s.Length-2) == 'P')
            {
                sb.Remove(0, 2);
                hours += 12;
                if (hours > 23)
                {
                    hours = 12;
                }
                sb.Insert(0, hours.ToString());
            }
            // if its the midnight hour, replace with 00
            else if(hours == 12)
            {
                sb.Remove(0, 2);
                sb.Insert(0, "00");
            }

            return sb.ToString();
        }
    }
}
