using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Interest
    {
        static void Main(string[] args)
        {
            Console.Write("Please input your beginning balance: ");
            decimal userBalance = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Please input your interest rate: ");
            decimal userRate = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Please input the number of years to compound: ");
            decimal userYears = Convert.ToDecimal(Console.ReadLine());            
            for (int i = 0; i < userYears; i++)
            {
                decimal interest = 0;
                interest = (userBalance * userRate);
                userBalance += interest;
            }
            Console.WriteLine($"The amount you will have in {userYears} is {userBalance}");



        }
    }
}
