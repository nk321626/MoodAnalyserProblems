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
        //Default Constructor(UC4)
        public MoodAnalyser()
        {
            Console.WriteLine("Default Constructor");
        }
        //Constructor to initialize Message Refactor.
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
                //Handling exception if user provide null or Empty value UC2 nd UC3
                try
                {
                    //In case of null or empty mood throw custom exception MoodAnaltsisException UC3.
                    if (this.message.Equals(null))
                    {
                        throw new MoodAnalysisException(MoodAnalysisException.ExceptionTypes.NULL_MOOD_EXCEPTION, "Message should not be null");
                    }
                    else if (this.message.Equals(string.Empty))
                    {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionTypes.EMPTY_MOOD_EXCEPTION, "Message should not be empty");
                    }
                    else if (message.ToLower().Contains("Sad"))
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