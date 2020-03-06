using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Grades
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many scores would you like to grade?");
            int numberOfScores = Convert.ToInt32(Console.ReadLine());
            int score = 1;
            int gradeNumber = 0;
            int[] userScores = new int[numberOfScores+1];
            Console.WriteLine($"Enter {numberOfScores} scores, then a negative score to exit");
            do
            {                
                Console.Write("Please enter a score: ");
                score = Convert.ToInt32(Console.ReadLine());
                userScores[gradeNumber] = score;
                gradeNumber++;
            } while (score > 0);
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int f = 0;
            for (int i =0; i <= numberOfScores-1; i++)
            {                
                if (userScores[i] >= 90)
                {
                    a += 1;
                }
                else if (userScores[i] >= 80)
                {
                    b += 1;
                }
                else if (userScores[i] >= 70)
                {
                    c += 1;
                }
                else if (userScores[i] >= 60)
                {
                    d += 1;
                }
                else
                {
                    f += 1;
                }
            }

            Console.WriteLine($"The number of A's: {a}\nThe number of B's: {b}\nThe number of C's: {c}\nThe number of D's: {d}\nThe number of F's: {f}");


        }
    }
}
