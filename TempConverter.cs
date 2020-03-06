using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TempConverter
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            do
            {                
                Console.WriteLine("Would you like to convert to Celcius (C) or Fahrenheit (F)?");
                string userchoice = Console.ReadLine().ToLower();

                if (userchoice == "celsius" || userchoice == "c")
                {
                    Console.WriteLine("Please enter a temperature in Celsius:");
                    double userCel = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"That is {(((userCel * 9) / 5) + 32)} degrees in Farenheit.");
                }
                if (userchoice == "fahrenheit" || userchoice == "f")
                {
                    Console.WriteLine("Please enter a temperature in Fahrenheit:");
                    double userFah = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"That is {((userFah - 32) / (1.8))} degrees in Celcius.");
                }

                Console.WriteLine("Would you like to do another conversion? (Y/N)");
                string againQuestion = Console.ReadLine().ToLower();

                if (againQuestion == "no" || againQuestion == "n")
                {
                    repeat = false;
                }
            } while (repeat);           
            
        }
    }
}
