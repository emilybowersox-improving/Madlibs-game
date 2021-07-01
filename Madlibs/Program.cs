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
            List<QuestionAnswer> qa = new List<QuestionAnswer> {

                new QuestionAnswer { Question = "Give me a noun: ", Answer = "" },
                new QuestionAnswer { Question = "Give me an adjective: ", Answer = "" },
                new QuestionAnswer { Question = "Give me another noun: ", Answer = "" },
                new QuestionAnswer { Question = "Give me an adverb: ", Answer = "" },
                new QuestionAnswer { Question = "Give me the name of a friend: ", Answer = ""},
                new QuestionAnswer { Question = "Give me a final adjective: ", Answer = "" }

            };

            Console.WriteLine("Welcome to Madlibs! The game of silly stories and twisty tales!");
            Console.ReadLine();

            foreach (QuestionAnswer i in qa)
            {
                Console.WriteLine(i.Question);
                i.Answer = Console.ReadLine();
            }

            Console.WriteLine($"\nMy Last Meal, \nby You. \n\nFor my last meal, I ate a {qa[0].Answer}. It was {qa[1].Answer}. For my seasoning, I put {qa[2].Answer} on it and ate it {qa[3].Answer}. " +
                $"\nI was so happy with it, I shared it with my friend {qa[4].Answer}. They thought it was the best \nfood that they had ever tasted and was {qa[5].Answer} about it.");
            Console.ReadLine();

            Console.WriteLine("Hope you enjoyed your story! Press enter to finish the game");
            Console.ReadLine();
        }
    }
}




// how/should this be done in a dictionary instead of a list? 
//dictionary of QuestionAnswer with key-value pair being question-answer

//How to make a Dictionary from object properties in a class?
/*Dictionary<string, string> qaDictionary = new Dictionary<string, string>();
openWith.Add(new QuestionAnswer { Question = "Give me a noun: ", Answer = "" });*/

/* Dictionary<QuestionAnswer, QuestionAnswer> pairs = new Dictionary<QuestionAnswer.Question, QuestionAnswer.Answer> { new QuestionAnswer { Question = "Give me a noun: ", Answer = "" } };*/
/*
            foreach (KeyValuePair<string, string> kvp in pairs)
            {
                Console.WriteLine(kvp.Key);
                kvp.Value = Console.ReadLine();
            }*/
