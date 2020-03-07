using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number you would like to go up to:");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int numberOne = 0;
            int numberTwo = 1;
            int buffer;
            Console.Write($"{numberOne}, ");
            do
            {
                Console.Write($"{numberTwo}");
                if (numberTwo < userInput)
                {

                    buffer = numberOne;
                    numberOne = numberTwo;
                    numberTwo += buffer;
                }
                if (numberTwo < userInput)
                {
                    Console.Write(", ");
                }

            } while (numberTwo < userInput);
            Console.WriteLine();
        }
    }
}
