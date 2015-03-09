using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfusionQuiz
{
    private class Question
    {
        string Text { get; set; }
        List<string> Answers { get; set; }

    }

    class Quiz
    {
        List<Question> _questions;
    }
}
