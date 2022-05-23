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
        [TestCategory("SAD MESSAGE")]
        [TestMethod]
        public void GivenSadMessageReturnSadMood()
        {
            ///AAA
            //Arrange
            string message = "I am in SAD Mood";
            string expected = "sad";
            MoodAnalyser mood = new MoodAnalyser(message);
            //Act
            string actual = mood.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //Method to test happy message(UC1-TC1.2)
        [TestCategory("HAPPY MESSAGE")]
        [TestMethod]
        public void GivenHappyMessageReturnHappyMood()
        {
            ///AAA
            //Arrange
            string message = "I am in HAPPY Mood";
            string expected = "happy";
            MoodAnalyser mood = new MoodAnalyser(message);
            //Act
            string actual = mood.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //Method to test happy message(UC2-TC2.1)
        [TestCategory("NULL EXCEPTION")]
        [TestMethod]
        public void GivenNullMessageException()
        {
            ///AAA
            ///Arange
            string msg = null;
            string expected = "happy";
            MoodAnalyser mood = new MoodAnalyser(msg);
            //Act
            string actual = mood.AnalyseMood();
            ///Asert
            Assert.AreEqual(expected, actual);
        }
        //Method to test custom exception message(UC3-TC3.1)
        [TestCategory("CUSTOM EXCEPTION")]
        [TestMethod]
        public void GivenCustomNullException()
        {
            ///AAA
            ///Arange
            string msg = null;
            string expected = "Message should not be null";
            MoodAnalyser mood = new MoodAnalyser(msg);
            try
            {
                ///Act
                string actual = mood.AnalyseMood();
            }
            catch (MoodAnalysisException e)
            {
                ///Asert
                Assert.AreEqual(expected, e.Message);
            }
        }
        //Method to test custom exception message(UC3-TC3.2)
        [TestCategory("CUSTOM EXCEPTION")]
        [TestMethod]
        public void GivenCustomEmptyException()
        {
            ///AAA
            ///Arange
            string msg = "";
            string expected = "Message should not be empty";
            MoodAnalyser mood = new MoodAnalyser(msg);
            try
            {
                ///Act
                string actual = mood.AnalyseMood();
            }
            catch (MoodAnalysisException e)
            {
                ///Asert
                Assert.AreEqual(expected, e.Message);
            }
        }
    }
}
