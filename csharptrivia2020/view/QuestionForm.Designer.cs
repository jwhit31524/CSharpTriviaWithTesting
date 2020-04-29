namespace csharptrivia2020.view
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
            this.QuestionNumberLabel = new System.Windows.Forms.Label();
            this.QuestionTextLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AnswerC = new System.Windows.Forms.RadioButton();
            this.AnswerB = new System.Windows.Forms.RadioButton();
            this.AnswerA = new System.Windows.Forms.RadioButton();
            this.NextQuestionButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuestionNumberLabel
            // 
            this.QuestionNumberLabel.AutoSize = true;
            this.QuestionNumberLabel.Location = new System.Drawing.Point(13, 13);
            this.QuestionNumberLabel.Name = "QuestionNumberLabel";
            this.QuestionNumberLabel.Size = new System.Drawing.Size(95, 13);
            this.QuestionNumberLabel.TabIndex = 1;
            this.QuestionNumberLabel.Text = "[Question Number]";
            // 
            // QuestionTextLabel
            // 
            this.QuestionTextLabel.AutoSize = true;
            this.QuestionTextLabel.Location = new System.Drawing.Point(15, 44);
            this.QuestionTextLabel.Name = "QuestionTextLabel";
            this.QuestionTextLabel.Size = new System.Drawing.Size(133, 13);
            this.QuestionTextLabel.TabIndex = 3;
            this.QuestionTextLabel.Text = "[Question Text Goes Here]";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AnswerC);
            this.panel1.Controls.Add(this.AnswerB);
            this.panel1.Controls.Add(this.AnswerA);
            this.panel1.Location = new System.Drawing.Point(16, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 251);
            this.panel1.TabIndex = 5;
            // 
            // AnswerC
            // 
            this.AnswerC.AutoSize = true;
            this.AnswerC.Location = new System.Drawing.Point(4, 66);
            this.AnswerC.Name = "AnswerC";
            this.AnswerC.Size = new System.Drawing.Size(110, 17);
            this.AnswerC.TabIndex = 2;
            this.AnswerC.TabStop = true;
            this.AnswerC.Text = "[Answer Option C]";
            this.AnswerC.UseVisualStyleBackColor = true;
            // 
            // AnswerB
            // 
            this.AnswerB.AutoSize = true;
            this.AnswerB.Location = new System.Drawing.Point(4, 43);
            this.AnswerB.Name = "AnswerB";
            this.AnswerB.Size = new System.Drawing.Size(110, 17);
            this.AnswerB.TabIndex = 1;
            this.AnswerB.TabStop = true;
            this.AnswerB.Text = "[Answer Option B]";
            this.AnswerB.UseVisualStyleBackColor = true;
            // 
            // AnswerA
            // 
            this.AnswerA.AutoSize = true;
            this.AnswerA.Location = new System.Drawing.Point(4, 20);
            this.AnswerA.Name = "AnswerA";
            this.AnswerA.Size = new System.Drawing.Size(110, 17);
            this.AnswerA.TabIndex = 0;
            this.AnswerA.TabStop = true;
            this.AnswerA.Text = "[Answer Option A]";
            this.AnswerA.UseVisualStyleBackColor = true;
            // 
            // NextQuestionButton
            // 
            this.NextQuestionButton.Location = new System.Drawing.Point(592, 342);
            this.NextQuestionButton.Name = "NextQuestionButton";
            this.NextQuestionButton.Size = new System.Drawing.Size(116, 23);
            this.NextQuestionButton.TabIndex = 6;
            this.NextQuestionButton.Text = "Next Question";
            this.NextQuestionButton.UseVisualStyleBackColor = true;
            this.NextQuestionButton.Click += new System.EventHandler(this.NextQuestionButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(454, 342);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(112, 23);
            this.PreviousButton.TabIndex = 7;
            this.PreviousButton.Text = "Previous Question";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.NextQuestionButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.QuestionTextLabel);
            this.Controls.Add(this.QuestionNumberLabel);
            this.Name = "QuestionForm";
            this.Text = "QuestionForm";
            this.Activated += new System.EventHandler(this.QuestionForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuestionForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuestionNumberLabel;
        private System.Windows.Forms.Label QuestionTextLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton AnswerC;
        private System.Windows.Forms.RadioButton AnswerB;
        private System.Windows.Forms.RadioButton AnswerA;
        private System.Windows.Forms.Button NextQuestionButton;
        private System.Windows.Forms.Button PreviousButton;
    }
}