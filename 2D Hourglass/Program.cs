using System;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6x6 2D array
            int[][] input =
            {
                new int[] {1, 1, 1, 0, 0, 0},
                new int[] {0, 1, 0, 0, 0, 0},
                new int[] {1, 1, 1, 0, 0, 0},
                new int[] {0, 0, 2, 4, 4, 0},
                new int[] {0, 0, 0, 2, 0, 0},
                new int[] {0, 0, 1, 2, 4, 0}
            };

            Console.WriteLine(hourglassSum(input)); // output : 19
        }


        static int hourglassSum(int[][] arr)
        {
            int sum = 0;
            // some of the test cases may have a negative integer as the max
            int maxSum = int.MinValue;

            // nested loop , [i] for first value, [j] for second value ( myArray[i][j] )
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = 0; j < arr.Length - 2; j++)
                {
                    sum = ((arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2]));

                    // need to check if the sum is the new max here before moving forward
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
            } // end of i loop
            return maxSum;
        }
    }
}
