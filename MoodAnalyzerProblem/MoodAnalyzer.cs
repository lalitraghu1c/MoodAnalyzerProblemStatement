using System;
namespace MoodAnalyzerProblemTest
{
    public class MoodAnalyzer
    {
        public string AnalyzeMood(string message)
        {
            if (message.Contains("Sad"))
                return "Sad";
            else
                return "Happy";
        }
    }
}