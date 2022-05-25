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
        public void TestCustomNullException()
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
        public void TestCustomEmptyException()
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
        //Method to test so moodanalyser class return moodanalyser objects(UC4-TC4.1)
        [TestCategory("REFLECTION")]
        [TestMethod]
        [DataRow("MoodAnalyserProblems.Customer", "Customer")]
        [DataRow("MoodAnalyserProblems.MoodAnalyser", "MoodAnalyser")]
        public void ReturnDefaultConstructor(string className, string constructor)
        {
            MoodAnalyser expected = new MoodAnalyser();
            object obj = null;
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                obj = factory.CreateMoodAnalyserObject(className, constructor);

            }
            catch (MoodAnalysisException ex)
            {
                throw new Exception(ex.Message);
            }
            expected.Equals(obj);
        }
        //Method to test so mood analyser with diff class to return no class found(UC4-TC4.2)
        [TestCategory("REFLECTION")]
        [TestMethod]
        [DataRow("MoodAnalyserProblems.Linklist", "Linklist", "The Given Class IS Not Found")]
        [DataRow("MoodAnalyserProblems.Stack", "Stack", "The Given Class IS Not Found")]
        public void ReturnDefaultConstructorNoClassFound(string className, string constructor, string expected)
        {
            object obj = null;
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                obj = factory.CreateMoodAnalyserObject(className, constructor);

            }
            catch (MoodAnalysisException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }
        }
        //Method to test so mood analyser class return  contructor not found(UC4-TC4.3)
        [TestCategory("REFLECTION")]
        [TestMethod]
        [DataRow("MoodAnalyserProblems.MoodAnalyser", "Linklist", "The Given Constructor Is Not Found")]
        [DataRow("MoodAnalyserProblems.MoodAnalyser", "Customer", "The Given Constructor Is Not Found")]
        public void ReturnDefaultConstructorNoConstructorFound(string className, string constructor, string expected)
        {
            object obj = null;
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                obj = factory.CreateMoodAnalyserObject(className, constructor);

            }
            catch (MoodAnalysisException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }
        }
        //Method to test moodanalyser class with parameter costructor to check if two object are equal(UC5-TC5.1)
        [TestCategory("REFLECTION")]
        [TestMethod]
        [DataRow("I am in Happy mood")]
        [DataRow("I am in SAD mood")]
        [DataRow("I am in ANY mood")]
        public void GivenMessageReturnParameterizedConstructor(string message)
        {
            MoodAnalyser expected = new MoodAnalyser(message);
            Object obj = null;
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                obj = factory.CreateMoodAnalyserParameterizedObject("MoodAnalyser", "MoodAnalyser", message);
            }
            catch (MissingMethodException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }
            obj.Equals(expected);
        }
        //Method to test moodanalyser with diff class with parameter constructor to throw error(UC5-TC5.2)
        [TestCategory("REFLECTION")]
        [TestMethod]
        [DataRow("MoodAnalyser.Queues", "I am in Happy mood", "No Such Class")]
        [DataRow("MoodAnalyser.Linkedlist", "I am in Sad mood", "No Such Class")]
        [DataRow("MoodAnalyser.Stack", "I am in Any mood", "No Such Class")]
        public void GivenMessageReturnParameterizedClassNotFound(string className, string message, string exextedError)
        {
            MoodAnalyser expected = new MoodAnalyser(message);
            object obj = null;
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                obj = factory.CreateMoodAnalyserParameterizedObject(className, "MoodAnalyser", message);
            }
            catch (MoodAnalysisException actual)
            {
                Assert.AreEqual(exextedError, actual.Message);
            }
        }
        //Method to test moodanalyser with diff constructor with parameter constructor to throw error(UC5-TC5.3)
        [TestCategory("REFLECTION")]
        [TestMethod]
        [DataRow("Customer", "I am in Happy mood", "No Such Constructor")]
        [DataRow("Linkedlist", "I am in Sad mood", "No Such Constructor")]
        [DataRow("Stack", "I am in any mood", "No Such Constructor")]
        public void GivenMessageReturnParameterizedConstructorNotFound(string constructor, string message, string expextedError)
        {
            MoodAnalyser expected = new MoodAnalyser(message);
            object obj = null;
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                obj = factory.CreateMoodAnalyserParameterizedObject("MoodAnalyser", constructor, message);
            }
            catch (MoodAnalysisException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }
        }
    }
}
