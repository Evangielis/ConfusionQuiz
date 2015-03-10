namespace ConfusionQuiz
{
    partial class QuestionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.questionBox = new System.Windows.Forms.TextBox();
            this.answersPanel = new System.Windows.Forms.Panel();
            this.answerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionBox
            // 
            this.questionBox.Location = new System.Drawing.Point(2, 2);
            this.questionBox.Multiline = true;
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(279, 128);
            this.questionBox.TabIndex = 0;
            // 
            // answersPanel
            // 
            this.answersPanel.Location = new System.Drawing.Point(3, 135);
            this.answersPanel.Name = "answersPanel";
            this.answersPanel.Size = new System.Drawing.Size(277, 147);
            this.answersPanel.TabIndex = 1;
            // 
            // answerButton
            // 
            this.answerButton.Location = new System.Drawing.Point(2, 288);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(278, 27);
            this.answerButton.TabIndex = 2;
            this.answerButton.Text = "Answer This!";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 319);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.answersPanel);
            this.Controls.Add(this.questionBox);
            this.Name = "QuestionForm";
            this.Text = "Question";
            this.Load += new System.EventHandler(this.questionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox questionBox;
        private System.Windows.Forms.Panel answersPanel;
        private System.Windows.Forms.Button answerButton;
    }
}