// See https://aka.ms/new-console-template for more information
using System;
namespace MoodAnalyserProblems
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser Problem Program");
            //Calling the mood analyser object(UC1)
            MoodAnalyser mood = new MoodAnalyser("Today I am Happy");
            string reMood = mood.AnalyserMood();
            Console.WriteLine("The Mood is {0}", reMood);
            Console.ReadLine();
        }
    }
}
