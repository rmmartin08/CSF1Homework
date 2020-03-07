using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a number");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= userNumber; i++)
            {
                Console.Write(i);
                if (i >1 && i%3 == 0)
                {
                    Console.Write("Fizz");
                }
                if (i>5 && i%5 == 0)
                {
                    Console.Write("Buzz");
                }
                if (i!=userNumber)
                {
                    Console.Write(", ");
                }

            }
            Console.WriteLine();



        }
    }
}
