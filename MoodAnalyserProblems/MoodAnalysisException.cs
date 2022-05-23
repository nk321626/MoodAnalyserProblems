﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblems
{
    /// <summary>
    /// In case of NULL or Empty Mood throwing Custom Exception MoodAnalysisException UC3.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class MoodAnalysisException : Exception
    {
        //Declaring exception type 
        public ExceptionTypes type;
        //Using enum to differentiate the mood analysis errors(UC3)
        public enum ExceptionTypes
        {
            NULL_MOOD_EXCEPTION,
            EMPTY_MOOD_EXCEPTION
        }
        //Constructor to initialize the enum exception types(UC3)
        public MoodAnalysisException(ExceptionTypes type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
