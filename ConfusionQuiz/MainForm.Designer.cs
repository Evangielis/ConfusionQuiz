namespace ConfusionQuiz
{
    partial class MainForm
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
            this.beginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // beginButton
            // 
            this.beginButton.Location = new System.Drawing.Point(12, 12);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(231, 141);
            this.beginButton.TabIndex = 0;
            this.beginButton.Text = "Begin Quiz";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 167);
            this.Controls.Add(this.beginButton);
            this.Name = "mainForm";
            this.Text = "Quiz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button beginButton;
    }
}

