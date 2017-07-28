using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Basic Console I/O With a little Numerical Formatting";

            //Sets and retrieves Data input by the user
            GetUserData();

            //Spacer
            Console.WriteLine();

            //Show a set of static formated numerical data
            FormatingNumericalData();

            Console.ReadLine();

        }

        private static void GetUserData()
        {

            //Get user name and age
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter your age");
            string userAge = Console.ReadLine();

            //Changing the echo color for funziez
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Echo user data to the console
            Console.WriteLine("Hello {0} you are {1} years old!!", userName, userAge);

            //Restore foreground to previous color
            Console.ForegroundColor = prevColor;

        }

        static void FormatingNumericalData()
        {

            //Changing the echo color for funziez
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("The value 9999999 in various formats:");

            //Spacer
            Console.WriteLine();

            //Currency format. Prefix the local currency symbol
            Console.WriteLine("c format: {0:c}", 9999999);

            //Decimal format. Specifies 9 digits of padding
            Console.WriteLine("d format: {0:d9}", 9999999);

            //Exponential notation. Little e
            Console.WriteLine("e format: {0:e}", 9999999);

            //Exponential notation. Big E
            Console.WriteLine("E format: {0:E}");

            //Fixed-point format. Specifies 3 digits of padding
            Console.WriteLine("f format: {0:f3}", 9999999);

            //Numerical Format (now with commas!)
            Console.WriteLine("n format: {0:n}", 9999999);

            //Hexadecimal Format. Little x
            Console.WriteLine("x format: {0:x}", 9999999);

            //Hexadecimal Format. Big X
            Console.WriteLine("X format: {0:X}", 9999999);

        }
    }
}
