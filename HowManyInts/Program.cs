//How many integers between 1 and 1000
//are NEITHER multiples of 2 NOR multiples of 5?
using System;
namespace HowManyInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            //count from 1 to 1000
            for (int i = 1; i <= 1000; i++)
            {
                //if (i modulo 2 == 0), then i is a multiple of 2, so i'll use the inequality != operator
                //to find NON-multiples. same for 5
                if ( (i % 2 != 0) && (i % 5 != 0) )
                {
                    //when a number is found, i want to count it
                    counter++;
                    Console.WriteLine(i);
                }
            }
            Console.Write("Integers between 1 and 1000 that are not multiples of 2 or 5: " + counter);
            //answer is 400
            Console.ReadLine();
        }
    }
}