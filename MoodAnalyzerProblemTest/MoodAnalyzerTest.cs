namespace MoodAnalyzerProblemTest
{
    public class MoodAnalyzerTest
    {
        [Test] //T-1.1
        public void GivenSadMood_WhenAnalyze_ShouldReturnSad()
        {
            MoodAnalyzer analyzer = new MoodAnalyzer(); //Arrange
            string result = analyzer.AnalyzeMood("I am in Sad Mood"); //Act
            Assert.AreEqual(result, "Sad"); //Assert
        }
        [Test] //T-1.2
        public void GivenAnyMood_WhenAnalyze_ShouldReturnHappy()
        {
            MoodAnalyzer analyzer = new MoodAnalyzer(); //Arrange
            string result = analyzer.AnalyzeMood("I am in Any Mood"); //Act
            Assert.AreEqual(result, "Happy"); //Assert
        }
    }
}