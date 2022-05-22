using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblems;
namespace MoodAnalyserTestProject
{
    /// <summary>
    /// Different Test Cases For Analysing Mood
    /// </summary>
    [TestClass]
    public class MoodAnalyserTestClass
    {
        /// <summary>
        /// TC 1.1: Given?I am in Sad Mood? message Should Return SAD.
        /// </summary>
        [TestMethod]
        public void GivenSadMessageReturnSadMood()
        {
            ///AAA
            //Arrange
            string message = "I am in SAD Mood";
            string expected = "sad";
            MoodAnalyser mood = new MoodAnalyser(message);
            //Act
            string actual = mood.AnalyserMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 1.2: Given?I am in Happy Mood? message Should Return HAPPY.
        /// </summary>
        [TestMethod]
        public void GivenHappyMessageReturnHappyMood()
        {
            ///AAA
            //Arrange
            string message = "I am in HAPPY Mood";
            string expected = "happy";
            MoodAnalyser mood = new MoodAnalyser(message);
            //Act
            string actual = mood.AnalyserMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
