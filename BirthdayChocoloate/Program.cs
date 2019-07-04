using System.Collections.Generic;
using System.Linq;
using System;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
        // s: an array of integers, the numbers on each of the squares of chocolate
        // d: an integer, Ron's birth day
        // m: an integer, Ron's birth month
        // sum of d = 3 out of m = 2 squares

            int[] s = { 2, 5, 1, 3, 4, 4, 3, 5, 1, 1, 2, 1, 4, 1, 3, 3, 4, 2, 1 }; // expected output: 3
            int d = 18, m = 7;

            Console.WriteLine("Sample input: " + String.Join(",", s));
            Console.WriteLine("d = {0}, m = {1}", d, m);
            Console.WriteLine("How many ways can we use {0} squares to get a sum of {1}?", m, d);

            Console.WriteLine(Birthday(s.ToList(), d, m));
        }

        static int Birthday(List<int> s, int d, int m)
        {
            int count = 0;
            // check if the List contains one or less values
            // if that one value != d, then return zero
            if (s.Count < 2)
            {
                count = s[0] == d ? 1 : 0;
            }
            else
            {
                // starting at 0, iterate through array leaving room to count the next m values
                // so if m = 7, stop iterating 7 values from the end of array to avoid out of bounds exception
                for (int i = 0; i < s.Count - (m - 1); i++)
                {
                    // add up the next m values
                    int current = 0;
                    for (int j = 0; j < m; j++)
                    {
                        current += s[i + j];
                    }

                    // if the sum of the next m values == d, then we have found a possible solution
                    if (current == d)
                    {
                        count++;
                    }
                    current = 0;
                } // end of outer loop with i variable
            }
            
            return count;
        } // end of Birthday()
    }
}