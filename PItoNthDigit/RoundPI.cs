//Enter a number and have the program generate PI up to that many decimal places.
using System;

namespace PItothNthDigit
{
    class RoundPI
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number, and I will generate PI up to that decimal place!\n> ");
            int digit = int.Parse(Console.ReadLine() );

            Console.WriteLine(PIdigits(digit));

            Console.ReadLine();
        }

        private static double PIdigits(int x)
        {
            double result = 0;
            if (x < 16) {
            result = Math.PI;
            Math.Round(result, x); }
            return result;
        }
    }
}