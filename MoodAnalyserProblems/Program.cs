// See https://aka.ms/new-console-template for more information
using System;
namespace MoodAnalyserProblems
{
    /// <summary>
    /// Mood analyser program to analyse the mood
    /// </summary>
    class program
    {
        public static string msg = null;

        //Entry point to the program
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser Problem Program");
            //Calling the mood analyser object(UC1)
            MoodAnalyser mood = new MoodAnalyser(msg);
            string reMood = mood.AnalyserMood();
            Console.WriteLine(reMood);
            Console.ReadLine();
        }
    }
}
