using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MadLib
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some information below to do this Mad Lib, Unless otherwise specified, verbs (like 'soon' or often ending in 'ly', like 'swiftly'). Adjectives are words that descriptive nouns (like 'green' or 'descriptive').");
            Console.WriteLine("Noun:");
            string noun = Console.ReadLine();
            Console.WriteLine("Verb:");
            string verb = Console.ReadLine();
            Console.WriteLine("Adjective:");
            string adjective = Console.ReadLine();
            Console.WriteLine("Noun:");
            string noun2 = Console.ReadLine();
            Console.WriteLine("Verb ending in 'ing':");
            string ingVerb = Console.ReadLine();
            Console.WriteLine("Adjective:");
            string adjecteive2 = Console.ReadLine();
            Console.WriteLine("Adverb:");
            string adverb = Console.ReadLine();
            Console.WriteLine("Exclamation:");
            string exclamation = Console.ReadLine();
            Console.WriteLine("City:");
            string city = Console.ReadLine();
            Console.WriteLine("A Time:");
            string time = Console.ReadLine();
            Console.WriteLine($"One day there was a {noun} that didn't want to {verb} anymore. And so, like any good {adjective} {noun2}, the {noun} decided to go {ingVerb}.\nBut sometimes the universe is a {adjecteive2} mistress, and " +
                $"destiny {adverb} called. After that, the {noun} exclaimed '{exclamation}', and they heard it all the way in {city}! And the {noun} vowed to not return until {time}.");
        }
    }
}
