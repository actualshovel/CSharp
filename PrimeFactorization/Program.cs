/* console app to accept user input as int,
 * and output the prime factorization of that int
 */

using System;
using System.Collections.Generic;

namespace factoring
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNum;
            do
            {
                userNum = 1;
                while(userNum == 1)
                {
                    Console.WriteLine("Enter a number to be factored. Press 0 to exit...");
                    //considering creating a method for user input with additional code implementing TryParse
                    try {
                        userNum = Convert.ToInt32(Console.ReadLine()); }
                    catch (OverflowException) {
                        Console.WriteLine("That number is out of range. Use anything from {0:0,0} to {1:0,0}\n", Int32.MinValue, Int32.MaxValue); }
                    catch (FormatException) {
                        Console.WriteLine("That is not in the correct format.\n"); }
                }

                //is {userNum} already prime?
                if (IsPrime(userNum))
                {
                    Console.WriteLine("{0} is already a prime number.\n", userNum);
                }
                else
                {
                    //display the prime factorization
                    Console.Write("Prime factorization of " + userNum + " is: ");
                    Console.WriteLine("{0}", string.Join(", ", PrimeFactors(userNum)) + "\n");
                }
            } while (userNum !=0);
        }

        private static int[] PrimeFactors(int number)
        {
            //create list to store factors
            List<int> factors = new List<int>();
            
            for (int i = 2; i < number; i++)
            {
                //does {i} evenly divide into {number}? does it divide again? loop until it doesn't
                while(number % i == 0)
                {
                    if( number % i == 0)
                    {
                        //yes {i} is a factor, but is it prime? well...
                        if (IsPrime(i) == true)
                        {
                            factors.Add(i);
                            number /= i;
                        }
                        //when {number} has been divided until it becomes a prime,
                        //add to list and break out of loop, there can't be anymore factors
                        if (IsPrime(number))
                        {
                            factors.Add(number);
                            break;
                        }

                    }
                }//end while loop
            }//end for loop
            return factors.ToArray();
        }//end PrimeFactors

        
        /*dividing only by prime numbers would work,  and would shorten forloop iterations here
         * how do i count by primes, starting from 2 up to {x}?
         * if i can do that, would it be more efficient to only iterate until i == x
         */
        private static bool IsPrime(int x)
        {
            int numFactors = 0;
            for (int i = 1; i <= x; i++)
            {
                //if a number evenly divides into 'x', it is a factor of 'x'
                if(x % i == 0)
                {
                    numFactors++;
                }
                if (numFactors >= 3)
                    break; //no need to continue loop, we have enough proof at 3 factors!
            }
            //if there are more than 2 factors, x is NOT prime!
            if (numFactors > 2)
                return false;
            else
                return true;
        }
    }
}
