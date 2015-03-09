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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            List<string> ans = new List<string>();
            ans.Add("Answer 1");
            ans.Add("Answer 2");
            ans.Add("Answer 3");
            ans.Add("Answer 4");

            Question q = new Question("test", "This is a test question", ans, 0);
            QuestionForm qf = new QuestionForm(q);

            qf.Show();
        }
    }
}
