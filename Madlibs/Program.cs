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
            // Next steps:
            // 1. Support multiple madlibs
            // 2. Can you use some sort of string replace in the body so you wouldn't be tied to the actual array
            // 3. Separate data from logic. Part of this would be breaking out things into a Madlib class to hold the data
            // 4. Make this data-driven. Store the madlibs in either json files or a database.


            // (ultimately have story text one string with one variable where userInput goes- and split on that variable to then populate, forEach, the Storys in List<Story>)


            List<QuestionAnswer> qa = new List<QuestionAnswer> {

                new QuestionAnswer { Question = "Give me a noun: ", Answer = "" },
                new QuestionAnswer { Question = "Give me an adjective: ", Answer = "" },
                new QuestionAnswer { Question = "Give me another noun: ", Answer = "" },
                new QuestionAnswer { Question = "Give me an adverb: ", Answer = "" },
                new QuestionAnswer { Question = "Give me the name of a friend: ", Answer = ""},
                new QuestionAnswer { Question = "Give me a final adjective: ", Answer = "" }

            };

            List<Story> completeStory = new List<Story>
            {
                new Story { storySegment = "\nMy Last Meal, \nby You. \n\nFor my last meal, I ate a ", userInput = "input"},
                new Story { storySegment = ". It was ", userInput = "input" },
                new Story { storySegment = ". For my seasoning, I put ", userInput = "input"},
                new Story { storySegment = " on it and ate it ", userInput = "input"},
                new Story { storySegment = ". I was so happy with it, I shared it with my friend ", userInput = "input"},
                new Story { storySegment = ". They thought it was the best \nfood that they had ever tasted and was ", userInput = "input"},
                new Story { storySegment = " about it.", userInput = "input"}
                        };

            Console.WriteLine("Welcome to Madlibs! The game of silly stories and twisty tales!");
            Console.ReadLine();


            foreach (QuestionAnswer i in qa)
            {
                Console.WriteLine(i.Question);
                i.Answer = Console.ReadLine();
            }


            for (int i = 0; i < 6; i++)
            {
                completeStory[i].userInput = completeStory[i].userInput.Replace("input", qa[i].Answer);
            }



            Console.WriteLine($"\nMy Last Meal, \nby You. \n\nFor my last meal, I ate a {completeStory[0].userInput}. It was {qa[1].Answer}. For my seasoning, I put {qa[2].Answer} on it and ate it {qa[3].Answer}. " +
                $"\nI was so happy with it, I shared it with my friend {qa[4].Answer}. They thought it was the best \nfood that they had ever tasted and was {qa[5].Answer} about it.");
            Console.ReadLine();

            Console.WriteLine("Hope you enjoyed your story! Press enter to finish the game");
            Console.ReadLine();
        }



        }
    }





