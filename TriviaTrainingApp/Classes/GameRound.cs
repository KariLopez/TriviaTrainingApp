using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaTrainingApp.Classes
{
    class GameRound
    {
        private int TotalPoints { get; set; }
        private int QuestionsAsked { get; set; }

        private readonly int RoundThreshold = 10;
        private int QuestionLimit { get; set; }
        private ValidateInput inputValidation = new ValidateInput();

        public void StartGameRound(List<QuestionClass> questions, int questionIndex)
        {
            QuestionLimit = questions.Count;
            bool playRound = true;

            while (playRound && questionIndex != QuestionLimit)
            {
                questionIndex = PlayRound(questions, questionIndex);

                Console.WriteLine("Round is complete!");
                Console.WriteLine("Would you like your total points for the completed Round?(Y/N)?");
                var showTotalInput = Console.ReadLine();
                showTotalInput= inputValidation.InputToUpper(showTotalInput);
                bool showTotal = inputValidation.ValidateYesNoInput(showTotalInput);
                if (showTotal) {
                    PrintTotal();
                }
                bool continueNextRound = UnAskedQuestions(questionIndex);
                if (continueNextRound)
                {
                    playRound = AskToPlayAnotherRound();
                }
               
            }
        }
        private int PlayRound(List<QuestionClass> questions, int questionIndex)
        {
            TotalPoints = 0;
            Game game = new Game();

        
            QuestionsAsked = 0;
            while (QuestionsAsked < RoundThreshold && questionIndex<QuestionLimit)
            {
                QuestionClass questionAsked = game.GetQuestion(questions, questionIndex);
                Console.WriteLine(game.PrintQuestion(questionAsked));


                var choices = game.PrintChoices(questionAsked);
                for(int i = 0; i < choices.Count; i++)
                {
                    Console.WriteLine("{0}. {1}", i+1, choices[i]);
                }

                bool validEntry = false;
                while (!validEntry)
                {
                    Console.WriteLine("Please enter your choice 1-{0} below:", choices.Count);

                    string answer = Console.ReadLine();
                    int validIndex;
                    inputValidation.ValidateUserQuestionEntry(answer,out validEntry, out validIndex);
                    if (validEntry)
                    {
                       

                        var isCorrect = game.VerifyAnswer(validIndex, questionAsked);
                        if (isCorrect)
                        {
                            Console.WriteLine("Correct");
                            TotalPoints++;
                        }
                        else
                        {
                            Console.WriteLine("The correct answer is " + questionAsked.Choices[questionAsked.CorrectAnswerIndex]);
                        }
                    }

                }

                questionIndex++;
                QuestionsAsked++;


            }

            return questionIndex;

        }
       
     
        public void PrintTotal()
        {
            Console.WriteLine("You have " + TotalPoints + " points for this round");

        }
         private bool AskToPlayAnotherRound()
        {
            bool playAgain = false;
            bool validEntry = false;
            while (!validEntry)
            {
                Console.WriteLine("Would you like to play another round? (Y/N)");
                string playAgainInput = Console.ReadLine();
                playAgainInput = inputValidation.InputToUpper(playAgainInput);
                validEntry = inputValidation.ValidateYesNoInput(playAgainInput);
                if (validEntry)
                {
                    if (playAgainInput == "Y")
                    {
                        playAgain = true;
                    }

                }
            }
            return playAgain;


        }
        public bool UnAskedQuestions(int questionIndex)
        {
            if(questionIndex < QuestionLimit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
