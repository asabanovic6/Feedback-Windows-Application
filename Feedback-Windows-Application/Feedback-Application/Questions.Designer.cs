﻿
using Feedback_Application.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace Feedback_Application
{
    partial class Questions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public int page = 0;
        public List<MetroFramework.Controls.MetroPanel> panels = new List<MetroFramework.Controls.MetroPanel>();
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.BackgroundImage = global::Feedback_Application.Properties.Resources.iconfinder_UI_Basic_outline_116_4733225__1_;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(139, 14);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Padding = new System.Windows.Forms.Padding(10);
            this.buttonBack.Size = new System.Drawing.Size(55, 50);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.BackgroundImage = global::Feedback_Application.Properties.Resources.iconfinder_UI_Basic_outline_116_;
            this.buttonOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonOK.Location = new System.Drawing.Point(200, 14);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Padding = new System.Windows.Forms.Padding(10);
            this.buttonOK.Size = new System.Drawing.Size(55, 50);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.TabStop = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackgroundImage = global::Feedback_Application.Properties.Resources.logout;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonExit.Location = new System.Drawing.Point(726, 405);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(56, 56);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click_1);
            // 
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Feedback_Application.Properties.Resources.iconfinder_UI_Basic_outline_116_4733225__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(805, 484);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonBack);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "Questions";
            this.Text = "Questions";
            this.Load += new System.EventHandler(this.Questions_Load);
            this.ResumeLayout(false);

        }

        private MetroFramework.Controls.MetroPanel createPanel()
        {
            MetroFramework.Controls.MetroPanel mainPanel = new MetroFramework.Controls.MetroPanel();

            mainPanel.HorizontalScrollbarBarColor = true;
            mainPanel.HorizontalScrollbarHighlightOnWheel = false;
            mainPanel.HorizontalScrollbarSize = 10;
            mainPanel.Location = new System.Drawing.Point(23, 86);
            mainPanel.Name = "mainPanel" + page.ToString();
            mainPanel.Size = new System.Drawing.Size(500, 200);
            mainPanel.TabIndex = 2;
            mainPanel.VerticalScrollbarBarColor = true;
            mainPanel.VerticalScrollbarHighlightOnWheel = false;
            mainPanel.VerticalScrollbarSize = 10;
            return mainPanel;
        }

        private MetroFramework.Controls.MetroCheckBox createCheckBox(int startPosition, int endPosition, int i, string text, MetroFramework.Controls.MetroPanel mainPanel)
        {
            MetroFramework.Controls.MetroCheckBox metroCheckBox = new MetroFramework.Controls.MetroCheckBox();

            metroCheckBox.AutoSize = true;
            metroCheckBox.Location = new System.Drawing.Point(startPosition, endPosition);
            metroCheckBox.Name = "metroCheckBox " + i.ToString();
            metroCheckBox.Size = new System.Drawing.Size(114, 15);
            metroCheckBox.TabIndex = 2;
            metroCheckBox.Text = text;
            metroCheckBox.UseSelectable = true;
            mainPanel.SuspendLayout();
            mainPanel.Controls.Add(metroCheckBox);
            this.Controls.Add(mainPanel);

            return metroCheckBox;
        }

        private MetroFramework.Controls.MetroRadioButton createRadioButton(int startPosition, int endPosition, int i , string text, MetroFramework.Controls.MetroPanel mainPanel)
        {
            MetroFramework.Controls.MetroRadioButton radioButton = new MetroFramework.Controls.MetroRadioButton();
            radioButton.AutoSize = true;
            radioButton.Location = new System.Drawing.Point(startPosition, endPosition);
            radioButton.Name = "metroRadioButton " + i.ToString();
            radioButton.Size = new System.Drawing.Size(127, 15);
            radioButton.TabIndex = 0;
            radioButton.Text = text;
            radioButton.UseSelectable = true;
            mainPanel.SuspendLayout();
            mainPanel.Controls.Add(radioButton);
            this.Controls.Add(mainPanel);

            return radioButton;
        }

        private void createTextBoxForCustomAnswer(MetroFramework.Controls.MetroPanel panel)
        {
            System.Windows.Forms.TextBox textBoxAnswer = new System.Windows.Forms.TextBox();

            textBoxAnswer.Location = new System.Drawing.Point(23, 50);
            textBoxAnswer.Name = "textBox";
            textBoxAnswer.Size = new System.Drawing.Size(351, 23);
            textBoxAnswer.TabIndex = 2;

            panel.SuspendLayout();
            panel.Controls.Add(textBoxAnswer);
            this.Controls.Add(panel);
        }

        private void createQuestionLabel(MetroFramework.Controls.MetroPanel panel, List<Question> questions) 
        {
            System.Windows.Forms.Label questionLabel = new System.Windows.Forms.Label();

            questionLabel.AutoSize = true;
            questionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            questionLabel.ForeColor = System.Drawing.Color.Black;
            questionLabel.Location = new System.Drawing.Point(15, 10);
            questionLabel.Name = "metroLabel1";
            questionLabel.Size = new System.Drawing.Size(81, 19);
            questionLabel.TabIndex = 3;
            questionLabel.Text = questions[page].QuestionText;
            
            panel.Controls.Add(questionLabel);
        }

        private void createMultipleChoicePanel(MetroFramework.Controls.MetroPanel panel, List<Question> pitanja, int startPosition, int endPosition)
        {
            List<QuestionAnswer> qa = new List<QuestionAnswer>();
            qa.AddRange(pitanja[page].QuestionAnswers);

            for (int j = 0; j < qa.Count; j++)
            {
                MetroFramework.Controls.MetroCheckBox cb = createCheckBox(startPosition, endPosition, j, qa[j].Answer.AnswerText, panel);
                endPosition += 40;
            }
            panels.Add(panel);
        }

        private void createSingleChoicePanel(MetroFramework.Controls.MetroPanel panel, List<Question> pitanja, int startPosition, int endPosition)
        {
            List<QuestionAnswer> qa = new List<QuestionAnswer>();
            qa.AddRange(pitanja[page].QuestionAnswers);

            for (int j = 0; j < qa.Count; j++)
            {
                MetroFramework.Controls.MetroRadioButton rb = createRadioButton(startPosition, endPosition, j, qa[j].Answer.AnswerText, panel);
                endPosition += 40;
            }

            panels.Add(panel);
        }

        private void createSlider(MetroFramework.Controls.MetroPanel panel, List<QuestionAnswer> qa)
        {

            MetroFramework.Controls.MetroTrackBar trackBar = new MetroFramework.Controls.MetroTrackBar();
            trackBar.BackColor = System.Drawing.Color.Transparent;
            trackBar.Location = new System.Drawing.Point(23, 50);
            trackBar.Name = "trackBar";
            trackBar.Size = new System.Drawing.Size(300, 23);
            trackBar.TabIndex = 2;
            trackBar.Minimum = int.Parse(qa[0].Answer.AnswerText);
            trackBar.Maximum = int.Parse(qa[qa.Count - 1].Answer.AnswerText);

            //creating labels
            MetroFramework.Controls.MetroLabel middleLabel = new MetroFramework.Controls.MetroLabel();
            MetroFramework.Controls.MetroLabel endLabel = new MetroFramework.Controls.MetroLabel();
            MetroFramework.Controls.MetroLabel startLabel = new MetroFramework.Controls.MetroLabel();

            /*middleLabel.AutoSize = true;
            middleLabel.Location = new System.Drawing.Point(139, 90);
            middleLabel.Name = "metroLabel1";
            middleLabel.Size = new System.Drawing.Size(50, 19);
            middleLabel.TabIndex = 6;
            int middle = qa.Count / 2;
            middleLabel.Text = trackBar.Value.ToString();
            */

            startLabel.AutoSize = true;
            startLabel.Location = new System.Drawing.Point(18, 90);
            startLabel.Name = "metroLabel3";
            startLabel.Size = new System.Drawing.Size(35, 19);
            startLabel.TabIndex = 8;
            startLabel.Text = qa[0].Answer.AnswerText;

            endLabel.AutoSize = true;
            endLabel.Location = new System.Drawing.Point(314, 90);
            endLabel.Name = "metroLabel2";
            endLabel.Size = new System.Drawing.Size(35, 19);
            endLabel.TabIndex = 7;
            endLabel.Text = qa[qa.Count - 1].Answer.AnswerText;

            panel.SuspendLayout();
            panel.Controls.Add(middleLabel);
            panel.Controls.Add(endLabel);
            panel.Controls.Add(startLabel);
            panel.Controls.Add(trackBar);
            this.Controls.Add(panel);
        }

        private void loadQuestions(List<Question>pitanja) 
        {
            int startPosition = 23;
            int endPosition = 50;
            MetroFramework.Controls.MetroPanel panel = createPanel();
            createQuestionLabel(panel, pitanja);

            if (pitanja[page].QuestionType.Equals("multiple choice"))
            {
                createMultipleChoicePanel(panel, pitanja, startPosition, endPosition);
            }
            else if (pitanja[page].QuestionType.Equals("single choice"))
            {
                createSingleChoicePanel(panel, pitanja, startPosition, endPosition);
            }
            else if (pitanja[page].QuestionType.Equals("custom choice"))
            {
                createTextBoxForCustomAnswer(panel);
                panels.Add(panel);
            }
            else if (pitanja[page].QuestionType.Equals("scala choice"))
            {
                List<QuestionAnswer> qa = new List<QuestionAnswer>();
                qa.AddRange(pitanja[page].QuestionAnswers);

                createSlider(panel, qa);
                panels.Add(panel);
            }
        }

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonOK;
        private Button buttonExit;
    }

    #endregion
}