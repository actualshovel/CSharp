using System;
using System.Collections.Generic;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {   // U is uphill
            // D is downhill
            // Hike starts and ends at sea level
            string test1 = "UDDDUDUU";
            string test2 = "UUUUDDDD";
            string test3 = "DUDUDUUD";
            string test4 = "DDDDDUDUUUUDUUUD";


            countingValleys(8, test1);
            countingValleys(8, test2);
            countingValleys(8, test3);
            countingValleys(16, test4);
        }

        // Return integer denoting number of valleys traversed
        static void countingValleys(int n, string s)
        {
            // I need a key value pair. Key being a char from the path description, s
            // Value being what that means, UP, DOWN, or SEA LEVEL

            // Down = -1, Up = 1
            Dictionary<char, int> stepsTraveled = new Dictionary<char, int>()
            {
                {'U', 1 },
                {'D', -1 }
            };
            
            int count = 0; // When hiker has been in a valley and returns to sea level, this is what I want to know
            int currentLevel = 0;
            bool belowSeaLevel = false; 

            // Go over each step, figure out the path by adding values based off of keys from my dictionary
            for (int i = 0; i < n; i++)
            {
                currentLevel += stepsTraveled[ s[i] ];

                // I only care if the hiker is in a valley, that is, if they have walked below sea level
                if (currentLevel < 0)
                    belowSeaLevel = true;

                // If the hiker is below sea level, COUNT when they return to sea level, or ZERO. 
                while (belowSeaLevel)
                {
                    if (currentLevel != 0)
                        break;
                    else
                    {
                        count++;
                        belowSeaLevel = false;
                    }
                }
            }
            Console.WriteLine("Number of valleys reached from {0} is: {1}", s, count);
        }
    }
}
