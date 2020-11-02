using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using TriviaTrainingApp.Classes;


namespace TriviaTrainingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<QuestionClass> questions = LoadJSON();
            int startingIndex = 0;
            GameRound round = new GameRound();
            round.StartGameRound(questions, startingIndex);
                      

        }
        public static List<QuestionClass> LoadJSON()
        {
            List<QuestionClass> questionList = new List<QuestionClass>();

           
                       
            using (StreamReader r = new StreamReader("Apprentice_TandemFor400_Data.json"))
            {
                
                string jsonString = r.ReadToEnd();
                JArray questionJson = JArray.Parse(jsonString);
                
                foreach(JObject obj in questionJson.Children<JObject>())
                {
                    var incorrect = obj.SelectToken("incorrect").ToObject<string[]>();
                   
                    var correct = obj.SelectToken("correct").ToString();
                    var questionText = obj.SelectToken("question").ToString();
                    QuestionClass question = new QuestionClass(questionText,incorrect,correct);
                    questionList.Add(question);
                }

                return questionList;
             
            }

        }

    }
}
