// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MoodAnalyserProblems
{
    /// <summary>
    /// Mood analyser program to analyse the mood
    /// </summary>
    public class program
    {
        public static string msg = null;

        //Entry point to the program
        static void Main(string[] args)
        {
            //Displaying the Welcome Message.
            Console.WriteLine("Welcome to Mood Analyser Problem Program");
            //Calling the mood analyser object(UC1)
            //MoodAnalyser mood = new MoodAnalyser(msg);
            //string resMood = mood.AnalyseMood();
            //Console.WriteLine(resMood);
            Customer customer = new Customer();
            customer.Name = "Niraj";
            Console.ReadLine();
        }
    }
}
