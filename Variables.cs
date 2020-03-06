using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Variables
    {
        static void Main(string[] args)
        {
            int intVal = 1;
            char charVal = 'a';
            string stringValue = "string!";
            double doubleValue = 3.65465465;
            float floatValue = 165.64654f;
            byte byteValue = 100;

            Console.WriteLine(intVal);
            Console.WriteLine(charVal);
            Console.WriteLine(stringValue);
            Console.WriteLine(doubleValue);
            Console.WriteLine(floatValue);
            Console.WriteLine(byteValue);

            int[] intArrayValues = {21,654,68,15,6 };
            char[] charArrayValues = { 'M', 'i', 'k', 'e', 's' };
            string[] stringArrayValues = { "chocolate", "vanilla" , "strawberry", "fudge swril", "neopolitan" };
            double[] doubleArrayValues = { 21.54654, 654.54645, 68.6546, 15.1564, 6.72610 };
            float[] floatArrayValues = { 21.5654f, 654.564f, 68.16546f, 15.4564f, 6.1657f };
            byte[] byteArrayValues = { 21, 78, 61, 74, 9 };

            foreach (int intArrayValue in intArrayValues)
            {
                Console.WriteLine(intArrayValue);
            }

            foreach (char charArrayValue in charArrayValues)
            {
                Console.WriteLine(charArrayValue);
            }

            foreach (var stringArrayValue in stringArrayValues)
            {
                Console.WriteLine(stringArrayValue);
            }

            foreach (double doubleArrayValue in doubleArrayValues)
            {
                Console.WriteLine(doubleArrayValue);
            }

            foreach (float floatArrayValue in floatArrayValues)
            {
                Console.WriteLine(floatArrayValue);
            }

            foreach (byte byteArrayValue in byteArrayValues)
            {
                Console.WriteLine(byteArrayValue);
            }

            byte counter = 0;
            while (counter <=100)
            {
                Console.WriteLine(counter);
                counter += 2;
            }
            counter = 0;
            do
            {
                Console.WriteLine(counter);
                counter+=2;
            } while (counter <= 100);
            counter = 0;

            for (byte i = 0; i <= 100; i+=2)
            {
                counter = i;
                Console.WriteLine(counter);

            }

        }
    }
}
