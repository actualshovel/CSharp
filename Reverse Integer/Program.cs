using System;
using System.Text;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to be reversed: ");
            int number = Convert.ToInt32( Console.ReadLine() );
            
            Console.WriteLine( Reverse(number) );
            Console.ReadLine();
        }

        public static int Reverse(int x)
        {   
            //will need StringBuilder here
            StringBuilder sb = new StringBuilder("");
            //add parameter to sb
            sb.Append(x.ToString());

            //check for '-' char
            if (sb.ToString().Contains("-") )
            {
                sb.Remove(0, 1);
                sb.Append('-');
            }
            
            string answer = "";
            //decrement from last index to reverse string
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                answer += sb[i];
            }
            //need to return as int
            int result;
            try {
                result = int.Parse(answer, System.Globalization.NumberStyles.AllowLeadingSign); }
            catch(OverflowException e) {
                return 0;
            }
            return result;
            }
    }
}