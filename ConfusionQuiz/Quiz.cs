using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfusionQuiz
{
    public class Question
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public List<string> Answers { get; set; }
        public int Rating { get; set; }
        public int Correct { get; set; }

        public Question(string name, string text, List<string> answers, int correct)
        {
            this.Name = name;
            this.Text = text;
            this.Answers = answers;
            this.Rating = 0;
            this.Correct = correct;
        }
    }

    public class Quiz
    {
        List<Question> _questions;

        public Quiz()
        {
            _questions = new List<Question>();
        }

        public void AddQuestion(string name, string text, List<string> answers, int correct)
        {
            Question q = new Question(name, text, answers, correct);
            this._questions.Add(q);
        }
    }
}
