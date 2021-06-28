using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madlibs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Madlibs! The game of silly stories and twisty tales!");
            Console.ReadLine();

            Console.Write("Give me a noun: ");
            String noun = Console.ReadLine();

            Console.Write("Give me an adjective: ");
            String adjective = Console.ReadLine();

            Console.Write("Give me another noun: ");
            String nounTwo = Console.ReadLine();

            Console.Write("Give me an adverb: ");
            String adverb = Console.ReadLine();

            Console.Write("Give me the name of a friend: ");
            String friend = Console.ReadLine();

            Console.Write("Give me a final adjective: ");
            String adjectiveTwo = Console.ReadLine();
            

            Console.WriteLine("\nMy Last Meal, \nby You. \n\nFor my last meal, I ate a " + noun + ". It was " + adjective + ". For my seasoning, " +
                "I put " + nounTwo + " on it and ate it " + adverb + ". \nI was so happy with it, I shared it with my friend " + friend + ". " +
                "They thought it was the best \nfood that they had ever tasted and was " + adjectiveTwo + " about it.");
            Console.ReadLine();
       
            Console.WriteLine("Hope you enjoyed your story! Press enter to finish the game");
            Console.ReadLine();
        }
    }
}
