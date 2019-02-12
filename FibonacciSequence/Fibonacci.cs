//Enter a number and have the program generate the Fibonacci sequence to that number or to the Nth number.
using System;

namespace FibonacciSequence
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number\n>");
            int userInput = int.Parse(Console.ReadLine());

            TheSequence(userInput);

            Console.ReadLine();
        }

        private static void TheSequence(int x)
        {
            int result = 0;
            int a = 0, b = 1, c = 1;
            while (result < x)
            {
                Console.Write(c + ", ");
                result = b+c;
                a=b;
                b=c;
                c=result;
            }
        }
    }
}