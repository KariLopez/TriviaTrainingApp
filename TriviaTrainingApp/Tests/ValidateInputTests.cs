using TriviaTrainingApp.Classes;
using Xunit;

namespace TriviaTrainingApp.Tests
{
    public class ValidateInputTests
    {
        [Fact]
        public void ValidateUserQuestionEntryBadInputTest()
        {
            string input = "onethirty";
            bool isInt = false;
            int index = 0;
            ValidateInput validInput = new ValidateInput();
            validInput.ValidateUserQuestionEntry(input, out isInt, out index);
            Assert.False(isInt);

        }
        [Fact]
        public void ValidateUserQuestionEntryCorrectInputTest()
        {
            string input = "2";
            bool isInt = true;
            int index = 0;
            ValidateInput validInput = new ValidateInput();
            validInput.ValidateUserQuestionEntry(input, out isInt, out index);
            Assert.True(isInt);
        }
        [Fact]
        public void ValidatePlayAgainWrongInputTest()
        {
            string invalidInput = "K";
            bool expected = false;
            ValidateInput validInput = new ValidateInput();
            bool actual = validInput.ValidateYesNoInput(invalidInput);
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void ValidatePlayAgainAccurateInputTest()
        {
            string invalidInput = "N";
            bool expected = true;
            ValidateInput validInput = new ValidateInput();
            bool actual = validInput.ValidateYesNoInput(invalidInput);
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void InputToUpperTest()
        {
            string input = "All will Return Upper Case";
            string expected = "ALL WILL RETURN UPPER CASE";
            ValidateInput validInput = new ValidateInput();
            string actual = validInput.InputToUpper(input);
            Assert.Equal(expected, actual);
        }
    }
}
