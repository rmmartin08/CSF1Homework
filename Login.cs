using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Login
    {
        static void Main(string[] args)
        {
            
            bool access = false;
            int accessCounter = 0;
            int pwAccessCounter = 0;
            Console.WriteLine("What is your username?");
            string username = Console.ReadLine().ToLower();
            do
            {
                string correctusername = "appdesign20";
                if (username == correctusername)
                {
                    Console.WriteLine("What is your password?");
                    string password = Console.ReadLine().ToLower();
                    string correctpassword = "therecanbeonly1!";                    
                    if (password == correctpassword)
                    {
                        Console.WriteLine("Welcome, you have access!");
                        access = true;
                    }
                    else
                    {
                        Console.WriteLine("Access Denied!");
                        pwAccessCounter++;
                    }

                    if (pwAccessCounter == 3)
                    {
                        break;
                    }

                }
                else
                {
                    accessCounter++;
                    Console.WriteLine("Access Denied!");
                    Console.WriteLine("What is your username?");
                    username = Console.ReadLine().ToLower();                    
                }

                if (accessCounter == 2)
                {
                    break;
                }
            } while (access == false);
            
                
        }
    }
}
