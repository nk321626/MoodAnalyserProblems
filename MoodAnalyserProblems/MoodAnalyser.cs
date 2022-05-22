using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblems
{
    /// <summary>
    /// Creating Mood Analyser class.
    /// </summary>
    public class MoodAnalyser
    {
        //Declearing Variables Refactor.
        public string message;
        //Constructor to initialize Message Refactor.
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        /// <summary>
        /// Creating Method for Happy Or Sad Mood.
        /// <summary>
        /// <return>
        //Method to analyse the mood from the given message UC1
        public string AnalyserMood()
        {
            //Handling exception if user provide null value UC2
            try
            {

                if (message.ToLower().Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }
            }
            catch (NullReferenceException)
            {
                return "happy";
            }
        }
    }
}