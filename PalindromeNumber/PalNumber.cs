using System;
using System.Collections.Generic;

namespace Leetcode
{
    class PalNumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(1230321));
            Console.ReadLine();
        }

        public static bool IsPalindrome(int x)
        {
            // i know what zero will be. all negative numbers will be false
            if (x == 0)
                return true;
            if (x < 1)
                return false;

            int temp = x;
            int last = 0;
            int reversed = 0;

            // enqueue the last digit of temp, then remove the last digit of temp
            // until there are no more digits
            Queue<int> q = new Queue<int>();
            // integers will not start with zero in any case, it is not a string
            while (temp > 0)
            {
                last = temp % 10;
                q.Enqueue(last);
                temp /= 10;
            }

            while (q.Count > 0)
            {
                reversed += q.Dequeue();
                if (q.Count > 0)
                    reversed *= 10;
            }

            // if an integer is a palindrome, it will be the same value forwards or backwards
            if (reversed == x)
                return true;

            return false;
        }
    }
}
