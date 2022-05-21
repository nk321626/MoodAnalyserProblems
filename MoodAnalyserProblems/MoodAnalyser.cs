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
        //Declearing Variables.
        public string message;
        //Parameterized Constructors.
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        /// <summary>
        /// Creating Method for Happy Or Sad Mood.
        /// <summary>
        /// <return>
        public string AnalyserMood()
        {
            if(this.message.ToLower().Contains("sad"))
            {
                return "sad";
            }
            else
            {
                return "happy";
            }
        }

        internal string AnalyseMood()
        {
            throw new NotImplementedException();
        }
    }
}