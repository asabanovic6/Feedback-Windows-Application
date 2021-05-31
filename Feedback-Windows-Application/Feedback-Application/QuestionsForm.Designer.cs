
using Feedback_Application.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace Feedback_Application
{
    partial class QuestionsForm
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
            this.SubmitSessionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.BackgroundImage = global::Feedback_Application.Properties.Resources.icons8_next_page_50__1_;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(139, 14);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.MaximumSize = new System.Drawing.Size(55, 50);
            this.buttonBack.MinimumSize = new System.Drawing.Size(55, 50);
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
            this.buttonOK.BackgroundImage = global::Feedback_Application.Properties.Resources.icons8_next_page_50;
            this.buttonOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonOK.Location = new System.Drawing.Point(261, 14);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOK.MaximumSize = new System.Drawing.Size(55, 50);
            this.buttonOK.MinimumSize = new System.Drawing.Size(55, 50);
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
            this.buttonExit.BackgroundImage = global::Feedback_Application.Properties.Resources.iconfinder_Log_out_4473020;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonExit.Location = new System.Drawing.Point(350, 14);
            this.buttonExit.MaximumSize = new System.Drawing.Size(55, 50);
            this.buttonExit.MinimumSize = new System.Drawing.Size(55, 50);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(55, 50);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click_1);
            // 
            // SubmitSessionButton
            // 
            this.SubmitSessionButton.BackgroundImage = global::Feedback_Application.Properties.Resources.icons8_ok_50__1_;
            this.SubmitSessionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SubmitSessionButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SubmitSessionButton.FlatAppearance.BorderSize = 0;
            this.SubmitSessionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SubmitSessionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitSessionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SubmitSessionButton.Location = new System.Drawing.Point(200, 14);
            this.SubmitSessionButton.MaximumSize = new System.Drawing.Size(55, 50);
            this.SubmitSessionButton.MinimumSize = new System.Drawing.Size(55, 50);
            this.SubmitSessionButton.Name = "SubmitSessionButton";
            this.SubmitSessionButton.Size = new System.Drawing.Size(55, 50);
            this.SubmitSessionButton.TabIndex = 3;
            this.SubmitSessionButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SubmitSessionButton.Click += new System.EventHandler(this.SubmitSessionButton_Click);
            // 
            // QuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Feedback_Application.Properties.Resources.iconfinder_UI_Basic_outline_116_4733225__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(805, 700);
            this.Controls.Add(this.SubmitSessionButton);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonExit);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Coral;
            this.MinimizeBox = false;
            this.Name = "QuestionsForm";
            this.Text = "Kampanja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Questions_Load);
            this.ResumeLayout(false);

        }

        private MetroFramework.Controls.MetroPanel createPanel()
        {
            MetroFramework.Controls.MetroPanel mainPanel = new MetroFramework.Controls.MetroPanel();

            mainPanel.HorizontalScrollbarBarColor = true;
            mainPanel.HorizontalScrollbarHighlightOnWheel = false;
            mainPanel.HorizontalScrollbarSize = 10;
            mainPanel.Location = new System.Drawing.Point((int)(this.Width * 0.43), (int)(this.Height * 0.2));

            mainPanel.Name = "mainPanel" + page.ToString();
            mainPanel.Size = new System.Drawing.Size(700, 700);
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
            radioButton.Parent = mainPanel;
            mainPanel.Controls.Add(radioButton);
            mainPanel.Parent = this;
            this.Controls.Add(mainPanel);

            return radioButton;
        }

        private void createPictureBox(int startPosition, int endPosition,MetroFramework.Controls.MetroPanel panel, string base64String)
        {
            System.Windows.Forms.PictureBox pictureBoxAnswer = new System.Windows.Forms.PictureBox();


            pictureBoxAnswer.Location = new System.Drawing.Point(startPosition, endPosition);
            pictureBoxAnswer.Name = "pictureBox";
            pictureBoxAnswer.Size = new System.Drawing.Size(350, 200);
            pictureBoxAnswer.TabIndex = 2;
            byte[] imageBytes = Convert.FromBase64String("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");
            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes))
            {
                pictureBoxAnswer.Image = Image.FromStream(ms, true);
            }
            pictureBoxAnswer.SizeMode = PictureBoxSizeMode.StretchImage;

            panel.Controls.Add(pictureBoxAnswer);
            //panel.SuspendLayout();
            //panel.Controls.Add(pictureBoxAnswer);
            //this.Controls.Add(panel);
        }

        private int createTextBoxForCustomAnswer(MetroFramework.Controls.MetroPanel panel)
        {
            System.Windows.Forms.TextBox textBoxAnswer = new System.Windows.Forms.TextBox();

            textBoxAnswer.Location = new System.Drawing.Point(23, 50);
            textBoxAnswer.Name = "textBox";
            textBoxAnswer.Size = new System.Drawing.Size(351, 23);
            textBoxAnswer.TabIndex = 2;

            panel.SuspendLayout();
            panel.Controls.Add(textBoxAnswer);
            this.Controls.Add(panel);
            return 60;
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

        private void createDataLabel(MetroFramework.Controls.MetroPanel panel, string data, int endPosition)
        {
            System.Windows.Forms.Label questionLabel = new System.Windows.Forms.Label();

            questionLabel.AutoSize = true;
            questionLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.GraphicsUnit.Point);
            questionLabel.ForeColor = System.Drawing.Color.Black;
            questionLabel.Location = new System.Drawing.Point(15, endPosition);
            questionLabel.Name = "metroLabel1";
            questionLabel.Size = new System.Drawing.Size(81, 19);
            questionLabel.TabIndex = 3;
            questionLabel.Text = data;

            panel.Controls.Add(questionLabel);
        }

        private int createMultipleChoicePanel(MetroFramework.Controls.MetroPanel panel, List<Question> pitanja, int startPosition, int endPosition)
        {
            List<QuestionAnswer> qa = new List<QuestionAnswer>();
            qa.AddRange(pitanja[page].QuestionAnswers);

            for (int j = 0; j < qa.Count; j++)
            {
                if (qa[j].Answer.IsApicture.Equals(true))
                {
                    endPosition += 100;
                    MetroFramework.Controls.MetroCheckBox cb = createCheckBox(startPosition, endPosition, j, "", panel);

                    createPictureBox(startPosition + 20, endPosition, panel, qa[j].Answer.Base64);
                    endPosition += 250;
                }
                else
                {
                    MetroFramework.Controls.MetroCheckBox cb = createCheckBox(startPosition, endPosition, j, qa[j].Answer.AnswerText, panel);
                    endPosition += 40;
                }

            }
            panels.Add(panel);
            return endPosition;
        }

        private int createSingleChoicePanel(MetroFramework.Controls.MetroPanel panel, List<Question> pitanja, int startPosition, int endPosition)
        {
            List<QuestionAnswer> qa = new List<QuestionAnswer>();
            qa.AddRange(pitanja[page].QuestionAnswers);

            for (int j = 0; j < qa.Count; j++)
            {
                if (qa[j].Answer.IsApicture.Equals(true))
                {
                    endPosition += 100;
                    MetroFramework.Controls.MetroRadioButton rb = createRadioButton(startPosition, endPosition, j," ", panel);
                    
                    createPictureBox(startPosition+20, endPosition, panel,qa[j].Answer.Base64);
                    endPosition += 250;
                }
                else
                {
                    MetroFramework.Controls.MetroRadioButton rb = createRadioButton(startPosition, endPosition, j, qa[j].Answer.AnswerText, panel);
                    endPosition += 40;
                }
            }
            panels.Add(panel);
            return endPosition;
        }

        private int createSlider(MetroFramework.Controls.MetroPanel panel, List<QuestionAnswer> qa)
        {

            MetroFramework.Controls.MetroTrackBar trackBar = new MetroFramework.Controls.MetroTrackBar();
            trackBar.BackColor = System.Drawing.Color.Transparent;
            trackBar.Location = new System.Drawing.Point(23, 50);
            trackBar.Name = "trackBar";
            trackBar.Size = new System.Drawing.Size(300, 23);
            trackBar.TabIndex = 2;
            trackBar.Minimum = 1;
            trackBar.Maximum = int.Parse(qa[0].Answer.AnswerText);



            //creating labels
            System.Windows.Forms.Label middleLabel = new System.Windows.Forms.Label();
            System.Windows.Forms.Label endLabel = new System.Windows.Forms.Label();
            System.Windows.Forms.Label startLabel = new System.Windows.Forms.Label();

            /*middleLabel.AutoSize = true;
            middleLabel.Location = new System.Drawing.Point(139, 90);
            middleLabel.Name = "metroLabel1";
            middleLabel.Size = new System.Drawing.Size(50, 19);
            middleLabel.TabIndex = 6;
            int middle = qa.Count / 2;
            middleLabel.Text = trackBar.Value.ToString();
            */

            startLabel.AutoSize = true;
            startLabel.Location = new System.Drawing.Point(15, 90);
            startLabel.Name = "metroLabel3";
            startLabel.ForeColor = Color.Black;
            startLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            startLabel.Size = new System.Drawing.Size(50, 25);
            //startLabel.Size = new System.Drawing.Size(35, 19);
            startLabel.TabIndex = 8;
            startLabel.Text = "1";

            endLabel.AutoSize = true;
            endLabel.Location = new System.Drawing.Point(312, 90);
            endLabel.Name = "metroLabel2";
            //endLabel.Size = new System.Drawing.Size(35, 19);
            endLabel.ForeColor = Color.Black;
            endLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            endLabel.Size = new System.Drawing.Size(58, 25);
            endLabel.TabIndex = 7;
            endLabel.Text = qa[0].Answer.AnswerText;

            panel.SuspendLayout();
            panel.Controls.Add(middleLabel);
            panel.Controls.Add(endLabel);
            panel.Controls.Add(startLabel);
            panel.Controls.Add(trackBar);
            this.Controls.Add(panel);
            return 100;
        }


        private void loadQuestions(List<Question>pitanja) 
        {
            int startPosition = 23;
            int endPosition = 50;
            int x;
            MetroFramework.Controls.MetroPanel panel = createPanel();
            createQuestionLabel(panel, pitanja);

            if (pitanja[page].QuestionType.Equals("Multiple"))
            {
                if (pitanja[page].IsDependent == true)
                {
                   x = createMultipleChoicePanel(panel, pitanja, startPosition, endPosition);
                    createDataLabel(panel, pitanja[page].Data1, x);
                    x += 20;
                    createDataLabel(panel, pitanja[page].Data2, x);
                    x += 20;
                    createDataLabel(panel, pitanja[page].Data3, x);
                } else
                {
                    createMultipleChoicePanel(panel, pitanja, startPosition, endPosition);
                }
              
            }
            else if (pitanja[page].QuestionType.Equals("Single"))
            {
                if (pitanja[page].IsDependent == true)
                {
                    x = createSingleChoicePanel(panel, pitanja, startPosition, endPosition);
                    createDataLabel(panel, pitanja[page].Data1, x);
                    x += 20;
                    createDataLabel(panel, pitanja[page].Data2, x);
                    x += 20;
                    createDataLabel(panel, pitanja[page].Data3, x);
                }
                else
                {
                    createSingleChoicePanel(panel, pitanja, startPosition, endPosition);
                }
            }
            else if (pitanja[page].QuestionType.Equals("Text"))
            {
                if (pitanja[page].IsDependent == true)
                {
                    x = createTextBoxForCustomAnswer(panel);
                    createDataLabel(panel, pitanja[page].Data1, x);
                    x += 20;
                    createDataLabel(panel, pitanja[page].Data2, x);
                    x += 20;
                    createDataLabel(panel, pitanja[page].Data3, x);
                }
                else
                {
                    createTextBoxForCustomAnswer(panel);
                }
                panels.Add(panel);
            }
            else if (pitanja[page].QuestionType.Equals("Scale"))
            {
                List<QuestionAnswer> qa = new List<QuestionAnswer>();
                qa.AddRange(pitanja[page].QuestionAnswers);
                if (pitanja[page].IsDependent == true)
                {
                    x = createSlider(panel,qa);
                    createDataLabel(panel, pitanja[page].Data1, x);
                    x += 20;
                    createDataLabel(panel, pitanja[page].Data2, x);
                    x += 20;
                    createDataLabel(panel, pitanja[page].Data3, x);
                }
                else
                {

                    createSlider(panel, qa);
                }
                panels.Add(panel);
            }
            
        }

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonOK;
        private Button buttonExit;
        private Button SubmitSessionButton;
    }

    #endregion
}