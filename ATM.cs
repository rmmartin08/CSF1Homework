using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ATM
    {
        static void Main(string[] args)
        {
            bool access = false;
            int accessCounter = 0;
            double balance = 0;
            int pinAccessCounter = 0;
            int moreTransaction = 1;
            Console.WriteLine("What is your account number?");
            string accountNumber = Console.ReadLine();
            string correctAccountNumber = "894651654";
            do
            {
                if (accountNumber == correctAccountNumber)
                {
                    Console.WriteLine("What is your PIN?");
                    string pIN = Console.ReadLine().ToLower();
                    string correctPIN = "7852";
                    if (pIN == correctPIN)
                    {
                        Console.WriteLine("Welcome!");
                        access = true;
                        Console.WriteLine("Would you like to:\n1) Make a Deposit\n2) Make a Withdrawal\n3) Check Balance\n4) Exit");
                        int userMenuChoice = Convert.ToInt32(Console.ReadLine());
                        do
                        {
                            if (userMenuChoice == 1)
                            {
                                Console.WriteLine("Make a Deposit");
                                Console.WriteLine("What is the amount you would like to deposit?");
                                double deposit = Convert.ToDouble(Console.ReadLine());
                                balance += deposit;
                                Console.WriteLine($"${deposit} has been deposited into account {correctAccountNumber}");
                                Console.WriteLine($"Your balance is now: ${balance}");
                            }
                            if (userMenuChoice == 2)
                            {
                                Console.WriteLine("Make a Withdrawal");
                                Console.WriteLine("What is the amount you would like to withdrawal?");
                                double withdrawal = Convert.ToDouble(Console.ReadLine());
                                balance -= withdrawal;
                                Console.WriteLine($"${withdrawal} has been withdrawn from account {correctAccountNumber}");
                                Console.WriteLine($"Your balance is now: ${balance}");
                            }
                            if (userMenuChoice == 3)
                            {
                                Console.WriteLine($"Your balance is: ${balance}");
                            }
                            Console.WriteLine("Would you like to make another transaction? (Y/N)");
                            string anotherChoice = Console.ReadLine().ToLower();
                            if (anotherChoice == "n" || anotherChoice == "n")
                            {
                                moreTransaction = 0;
                            }
                            else
                            {
                                Console.WriteLine("Would you like to:\n1) Make a Deposit\n2) Make a Withdrawal\n3) Check Balance\n4) Exit");
                                userMenuChoice = Convert.ToInt32(Console.ReadLine());
                            }


                        } while (moreTransaction > 0);

                    }
                    else
                    {
                        Console.WriteLine("Access Denied!");
                        pinAccessCounter++;
                    }

                    if (pinAccessCounter == 3)
                    {
                        Console.WriteLine("Your account has been locked!");
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("Access Denied!");
                    Console.WriteLine("What is your account number?");
                    accountNumber = Console.ReadLine();
                    accessCounter++;
                }

                if (accessCounter == 3)
                {
                    Console.WriteLine("Your account has been locked!");
                    break;
                }
            } while (access == false);

            


        }
    }
}





