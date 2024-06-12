using System.Collections.Generic;

namespace MilionaireQuiz
{
    public class Question
    {
        private string TheQuestion {  get; set; }
        private string CorrectAnswer { get; set; }
        private List<string> Answers { get; set; }
        private bool Answered { get; set; }

        public Question(string theQuestion, string correctAnswer, List<string> answers)
        {
            TheQuestion = theQuestion;
            CorrectAnswer = correctAnswer;
            Answers = answers;
            Answered = false;
        }
    }
}