using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaTrainingApp.Classes
{
    public class Game
    {
         
        public QuestionClass GetQuestion(List<QuestionClass> gameQuestions,int index)
        {
            return gameQuestions[index];
        }
        public string PrintQuestion(QuestionClass question)
        {
            return question.Question;
        }
        public List<string> PrintChoices(QuestionClass question)
        {
            return question.Choices;
        }
        public bool VerifyAnswer(int userSelection,QuestionClass question)
        {
            
            if (question.CorrectAnswerIndex == userSelection)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int CorrectAnswerIndex(QuestionClass question)
        {
            return question.CorrectAnswerIndex;
        }
    }
}
