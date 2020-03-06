using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FruitLoops
    {
        static void Main(string[] args)
        {
            string[] theFruits = { "banana", "cherry", "blueberry", "lemon", "grape", "watermelon" };
            byte counter = 0;
            while (counter < 6)
            {
                Console.WriteLine(theFruits[counter]);
                counter++;
            }

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(theFruits[i]);
            }

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(theFruits[i]);
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }
        }
        
    }
}
