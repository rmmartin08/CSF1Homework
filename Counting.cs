using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Counting
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 26; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            for (int i = 25; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            for (int i = 0; i < 51; i+=2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            for (double i = 1; i < 10.5; i+=.5)
            {
                Console.WriteLine(i);
            }


        }

        
    }
}
