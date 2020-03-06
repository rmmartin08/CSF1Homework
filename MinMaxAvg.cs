using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MinMaxAvg
    {
        static void Main(string[] args)
        {
            int[] userNumbers = new int[5];
            Console.WriteLine("Please enter 5 numbers:");
            for (int i = 0; i < 5; i++)
            {
                userNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(userNumbers);
            Console.WriteLine("The lowest number is: "+ userNumbers.Min());
            Console.WriteLine("The highest number is: " +userNumbers.Max());
            Console.WriteLine("The average number is: " + userNumbers.Average());


        }
    }
}
