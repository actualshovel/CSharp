using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllMyShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();

            Console.ReadLine();
        }
        
        private static double getNumbersFromString(string input)
        {
            double success = 0;
            if (double.TryParse(input, out success))
                return success;
            else
                return 4;
            // 4 is returned in this case so we can stay in the DOWHILE loop within MainMenu()
        }

        public static void MainMenu()
        {
            //loop until user inputs '0'
            bool b = true;
            do
            {
                Console.WriteLine("\nSelect a shape");
                //change to string input. parse later
                Console.Write("1) Square\n2) Circle\n3) Rectangle\n0) Quit\n>");
                double select = getNumbersFromString(Console.ReadLine());
                //use the correct menu based on what shape the user selects
                if (select.Equals(1))
                    SquareMenu();
                else if (select.Equals(2))
                    CircleMenu();
                else if (select.Equals(3))
                    RectangleMenu();
                else if (select.Equals(0))
                {
                    Console.WriteLine("Goodbye!");
                    b = false;
                }
                else
                    Console.WriteLine("\ninvalid selection, try again.");
            } while (b); //end menu loop
        }

        public static void SquareMenu()
        {
            Console.Write("Enter the value of the sides: ");
            double side = getNumbersFromString(Console.ReadLine());

            //compute the area
            Square s = new Square(side);

            //display result
            Console.WriteLine("Area of the square = {0:N2}", s.Area);
            Console.WriteLine("Perimeter of the square = {0}", s.Perimeter);
        }

        public static void CircleMenu()
        {
            //only the radius is needed to find the rest of the circle's properties
            Console.Write("Enter the radius of the circle: ");
            double radius = getNumbersFromString(Console.ReadLine());

            Circle cir = new Circle(radius);
            Console.WriteLine("Circle diameter: {0:N2}", cir.Diameter);
            Console.WriteLine("Circle area: {0:N2}", cir.Area);
            Console.WriteLine("Circle circumfrence: {0:N2}", cir.Circumfrence);
        }

        public static void RectangleMenu()
        {
            //ask user for rectangle values
            Console.Write("Enter the length: ");
            double length = getNumbersFromString(Console.ReadLine());
            Console.Write("Enter the width: ");
            double width = getNumbersFromString(Console.ReadLine());
            //new instance passes user input to rectangle properties
            Rectangle rec = new Rectangle(length, width);
            //display rectangle
            Console.WriteLine("Rectangle area: {0}", rec.Area);
            Console.WriteLine("Rectangle perimeter: {0}", rec.Perimeter);
        }
    }
}//end namespace
