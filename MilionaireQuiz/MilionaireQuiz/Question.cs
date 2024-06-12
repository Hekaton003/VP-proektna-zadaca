using System.Collections.Generic;

namespace MilionaireQuiz
{
    public class Question
    {
        public string TheQuestion {  get; set; }
        public string CorrectAnswer { get; set; }
        public List<string> Answers { get; set; }
        public bool Answered { get; set; }

        public Question(string theQuestion, string correctAnswer, List<string> answers)
        {
            TheQuestion = theQuestion;
            CorrectAnswer = correctAnswer;
            Answers = answers;
            Answered = false;
        }
    }
}