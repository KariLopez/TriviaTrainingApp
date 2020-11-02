

using TriviaTrainingApp.Classes;
using Xunit;

namespace TriviaTrainingApp.Tests
{
    public class GameTests
    {
        [Fact]
        public void PrintQuestion()
        {
            string [] incorrect = new string[] { "Grand Rapids", "Detroit", "Traverse City" };
            string correct = "Lansing";
            string questionText = "What is the capital of Michigan";
            QuestionClass question = new QuestionClass(questionText, incorrect, correct);
            Game game = new Game();
            var expected = questionText;
            var actual = game.PrintQuestion(question);
            Assert.Equal(expected, actual);
        }
    }
}
