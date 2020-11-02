using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaTrainingApp.Classes
{
    class ValidateInput
    {
        public void ValidateUserQuestionEntry(string input, out bool isInt, out int index)
        {
            index = -1;
            isInt = int.TryParse(input, out int selection);
            if (isInt)
            {
                index = selection - 1;
            }
            else
            {
                Console.WriteLine("Please enter a valid choice");

            }
        }
        public bool ValidateYesNoInput(string input)
        {

            if (input != "Y" && input != "N")
            {
                Console.WriteLine("Please enter a valid input");
                return false;
            }
            else
            {
                return true;
            }
        }
        public string InputToUpper(string input)
        {
            input = input.ToUpper();
            return input;
        }
    }
}
