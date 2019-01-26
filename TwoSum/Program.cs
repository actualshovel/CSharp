using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //test case
            int[] myNumbers = new int[] { 2, 7, 11, 15 };

            //test target will be 9
            TwoSum(myNumbers, 9);

            Console.ReadLine();
        }

        //public static int[] TwoSum(int[] nums, int target)
        public static void TwoSum(int[] nums, int target)
        {
            int[] answer = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        answer[0] = i;
                        answer[1] = j;
                    }
                }
            }
            //return answer;
            //just to show which indices were selected
            Console.WriteLine(answer[0] + "\n" + answer[1]);
        }
    }
}