/*roll two 6 sided die
 * display the results and the number they add up to
 * option given to roll again*/

using System;
namespace Jan
{
    class Program {
        static void Main(string[] args)
        {
            char again = 'n';
            do
            {
                int dice1, dice2;
                Random rand = new Random();
                //give each die a number 1-6
                dice1 = rand.Next(1, 7);
                dice2 = rand.Next(1, 7);

                Console.WriteLine("You got " + dice1 + " and " + dice2);
                Console.WriteLine("The total is {0}", dice1 + dice2);

                Console.WriteLine("Would you like to roll again? y/n");
                Console.Write(">");
               again = Console.ReadKey().KeyChar;
            } while (again == 'y');
        }
    }
}
