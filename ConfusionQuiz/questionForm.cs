using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfusionQuiz
{
    public partial class QuestionForm : Form
    {
        TextBox _questionText;

        public string QuestionText
        {
            get { return this.questionBox.Text; }
            set { this.questionBox.Text = value; }
        }

        public QuestionForm(Question q)
        {
            InitializeComponent();

            this.QuestionText = q.Text;

            foreach (string ans in q.Answers)
            {
                RadioButton rb = new RadioButton();
                rb.Text = ans;
                this.answersPanel.Controls.Add(rb);
            }
        }

        private void questionForm_Load(object sender, EventArgs e)
        {
        }

    }
}
