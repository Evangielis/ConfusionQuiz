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
        List<RadioButton> _radioButtons;
        Question _question;

        public string QuestionText
        {
            get { return this.questionBox.Text; }
            set { this.questionBox.Text = value; }
        }

        public QuestionForm(Question q)
        {
            InitializeComponent();

            this.QuestionText = q.Text;
            this._radioButtons = new List<RadioButton>();
            this._question = q;

            for (int i = 0; i < q.Answers.Count; ++i)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Text = q.Answers[i];
                radioButton.Location = new System.Drawing.Point(
                    10, 10 + i * 20);
                this.answersPanel.Controls.Add(radioButton);
                this._radioButtons.Add(radioButton);
            }
        }

        private void questionForm_Load(object sender, EventArgs e)
        {
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            int answer = -1;
            for (int i = 0; i < _radioButtons.Count; ++i)
            {
                if (_radioButtons[i].Checked)
                {
                    answer = i;
                }
            }

            MessageBox.Show("You picked " + this._question.Answers[answer].ToString());
            this.Close();
        }

    }
}
