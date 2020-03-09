using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Powers
    {
        static void Main(string[] args)
        {
            long counter = 2;
            for (int i = 1; i < 51; i++)
            {
                counter *= 2;
                Console.WriteLine((counter));
            }
        }
    }
}
