using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            string userInput;
            int userInt;
            double userDub;
            bool overFifty;

            Console.WriteLine("Multiply");
            userInput = Console.ReadLine();
            userInt = Convert.ToInt32(userInput);
            userInt = (50 * userInt);
            Console.WriteLine(userInt);

            Console.WriteLine("Addition");
            userInput = Console.ReadLine();
            userInt = Convert.ToInt32(userInput);
            userInt += 25;
            Console.WriteLine(userInt);

            Console.WriteLine("Division");
            userInput = Console.ReadLine();
            userDub = Convert.ToDouble(userInput);
            userDub = (userDub / 12.5);
            Console.WriteLine(userDub);

            Console.WriteLine("Greater than 50?");
            userInput = Console.ReadLine();
            userInt = Convert.ToInt32(userInput);
            overFifty = (userInt > 50);
            Console.WriteLine(overFifty);

            Console.WriteLine("Remainders");
            userInput = Console.ReadLine();
            userInt = Convert.ToInt32(userInput);
            userInt = (userInt % 7);
            Console.WriteLine(userInt);

            Console.ReadLine();


        }
    }
}
