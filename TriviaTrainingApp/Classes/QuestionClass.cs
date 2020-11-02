using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaTrainingApp.Classes
{
    public class QuestionClass
    {
        public string Question { get; set; }
        private string[] Incorrect { get; set; }
        private string Correct { get; set; }
        public int CorrectAnswerIndex { get; set; }
        public List<string> Choices { get; set; }

       
        public QuestionClass(string questionText, string [] incorrectOptions, string correctOption)
        {
            Question = questionText;
            Incorrect = incorrectOptions;
            Choices = incorrectOptions.ToList();

            Correct = correctOption;

            Choices.Add(Correct);

            Choices.Sort();
            CorrectAnswerIndex = Choices.IndexOf(Correct);
        }


    }
}
