using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblems;
namespace MoodAnalyserTestProject
{
    /// <summary>
    /// Different Test Cases For Analysing Mood
    /// </summary>
    [TestClass]
    public class TestingMood
    {
        //Method to test sad message(UC1-TC1.1)
        [TestCategory("SAD Message")]
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
        //Method to test happy message(UC1-TC1.2)
        [TestCategory("HAPPY Message")]
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
        //Method to test happy message(UC2-TC2.1)
        [TestCategory("Null Exception")]
        [TestMethod]
        public void GivenNullMessageException()
        {
            ///AAA
            ///Arange
            string msg = null;
            string expected = "happy";
            MoodAnalyser mood = new MoodAnalyser(msg);
            //Act
            string actual = mood.AnalyserMood();
            ///Asert
            Assert.AreEqual(expected, actual);
        }
    }
}
