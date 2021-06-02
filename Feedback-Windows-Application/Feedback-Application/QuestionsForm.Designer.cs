
using Feedback_Application.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace Feedback_Application
{
    partial class QuestionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
        private Color panelColor = ColorTranslator.FromHtml("#009387");
        private System.ComponentModel.IContainer components = null;
        public int page = 0;
        public List<System.Windows.Forms.Panel> panels = new List<System.Windows.Forms.Panel>();
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
            this.buttonOK.Visible = false;
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
            this.buttonOK.Visible = false;
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
        #endregion


        private System.Windows.Forms.Panel createPanel()
        {
            System.Windows.Forms.Panel mainPanel = new System.Windows.Forms.Panel();
            mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
           | System.Windows.Forms.AnchorStyles.Left)
           | System.Windows.Forms.AnchorStyles.Right)));
       
            mainPanel.Location = new System.Drawing.Point(0, (int)(this.Size.Height * 0.1));

            mainPanel.BackColor = panelColor;

            mainPanel.Name = "mainPanel" + page.ToString();
            //mainPanel.AutoSize = true;
            mainPanel.Size = new System.Drawing.Size(this.Size.Width, (int)(this.Size.Height * 0.88));
            mainPanel.TabIndex = 2;

            ScrollBar vScrollBar1 = new VScrollBar();
            vScrollBar1.Dock = DockStyle.Right;
            vScrollBar1.Scroll += (sender, e) => { mainPanel.VerticalScroll.Value = vScrollBar1.Value; };
            mainPanel.Controls.Add(vScrollBar1);

            return mainPanel;
        }

        private System.Windows.Forms.CheckBox createCheckBox(int startPosition, int endPosition, int i, string text, System.Windows.Forms.Panel mainPanel)
        {
            System.Windows.Forms.CheckBox metroCheckBox = new System.Windows.Forms.CheckBox();

            metroCheckBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            metroCheckBox.AutoSize = true;
            metroCheckBox.Location = new System.Drawing.Point(startPosition, endPosition);
            metroCheckBox.Name = "metroCheckBox " + i.ToString();
            //metroCheckBox.Size = new System.Drawing.Size(20, 20);
            metroCheckBox.TabIndex = 2;
            metroCheckBox.Text = text;
            //metroCheckBox.UseSelectable = true;
            metroCheckBox.BackColor = panelColor;

            int x = (mainPanel.Size.Width - metroCheckBox.Size.Width) / 2;
            metroCheckBox.Location = new Point(x, metroCheckBox.Location.Y);

            mainPanel.SuspendLayout();
            mainPanel.Controls.Add(metroCheckBox);
            this.Controls.Add(mainPanel);

            return metroCheckBox;
        }

        private CustomButton createRadioButton(int startPosition, int endPosition, int i, string text, System.Windows.Forms.Panel mainPanel, bool isPicture, string base64String)
        {
            CustomButton radioButton = new CustomButton();
            radioButton.Clicked = false;
            radioButton.Click += RadioButton_Click;
            radioButton.AutoSize = true;
            radioButton.Location = new System.Drawing.Point(startPosition, endPosition);
            radioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));

            radioButton.Name = "metroRadioButton " + i.ToString();
            radioButton.TabIndex = 0;
            radioButton.Text = text;
            radioButton.ForeColor = Color.Transparent;
            radioButton.UseSelectable = true;
            radioButton.Size = new System.Drawing.Size(250, 100);

            if (isPicture)
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                // Convert byte[] to Image

                using (var ms = new MemoryStream(imageBytes))
                {
                    radioButton.BackgroundImage = Image.FromStream(ms, true);
                    radioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    radioButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                    radioButton.FlatAppearance.BorderSize = 0;
                    radioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                    radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    radioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                }
            }

            int x = (mainPanel.Size.Width - radioButton.Size.Width) / 2;
            radioButton.Location = new Point(x, radioButton.Location.Y);
            mainPanel.SuspendLayout();
            radioButton.Parent = mainPanel;
            mainPanel.Controls.Add(radioButton);
            mainPanel.Parent = this;

            this.Controls.Add(mainPanel);

            return radioButton;
        }

        private void RadioButton_Click(object sender, EventArgs e)
        {
            var temp = (CustomButton)sender;
            if (temp.Clicked == false) temp.Clicked = true;
            else temp.Clicked = false;
        }

        private int createTextBoxForCustomAnswer(System.Windows.Forms.Panel panel)
        {
            System.Windows.Forms.TextBox textBoxAnswer = new System.Windows.Forms.TextBox();

            textBoxAnswer.Name = "textBox";
            textBoxAnswer.TabIndex = 2;
            textBoxAnswer.Multiline = true;
            textBoxAnswer.Size = new System.Drawing.Size((int)(this.Size.Width * 0.4), (int)(this.Size.Height * 0.2));
            textBoxAnswer.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            int x = (panel.Size.Width - textBoxAnswer.Size.Width) / 2;
            int y = (panel.Size.Height - textBoxAnswer.Size.Height) / 2;
            textBoxAnswer.Location = new Point((int)(this.Size.Width * 0.3), (int)(this.Size.Height * 0.4));
            //textBoxAnswer.Location = new Point(x, y);

            panel.SuspendLayout();
            panel.Controls.Add(textBoxAnswer);
            this.Controls.Add(panel);
            return 60;
        }

        private void createQuestionLabel(System.Windows.Forms.Panel panel, List<Question> questions) 
        {
            System.Windows.Forms.Label questionLabel = new System.Windows.Forms.Label();

            questionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            questionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            questionLabel.ForeColor = System.Drawing.Color.White;
            questionLabel.AutoSize = false;
            questionLabel.Name = "metroLabel1";
            questionLabel.Size = new System.Drawing.Size((int)(this.Size.Width), (int)(this.Size.Width * 0.05));
            questionLabel.TabIndex = 3;
            questionLabel.Text = questions[page].QuestionText;

            panel.Controls.Add(questionLabel);
        }

        private void createDataLabel(System.Windows.Forms.Panel panel, string data, int endPosition)
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

        private void createPictureBox(int startPosition, int endPosition, System.Windows.Forms.Panel panel, string base64String)
        {
            System.Windows.Forms.PictureBox pictureBoxAnswer = new System.Windows.Forms.PictureBox();


            pictureBoxAnswer.Location = new System.Drawing.Point(startPosition, endPosition);
            pictureBoxAnswer.Name = "pictureBox";
            pictureBoxAnswer.Size = new System.Drawing.Size(300, 200);
            pictureBoxAnswer.TabIndex = 2;
            byte[] imageBytes = Convert.FromBase64String(base64String);
            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes))
            {
                pictureBoxAnswer.Image = Image.FromStream(ms, true);
            }
            pictureBoxAnswer.SizeMode = PictureBoxSizeMode.StretchImage;
            int x = (panel.Size.Width - pictureBoxAnswer.Size.Width) / 2;
            pictureBoxAnswer.Location = new Point(x + 300, pictureBoxAnswer.Location.Y);

            panel.Controls.Add(pictureBoxAnswer);
            //panel.SuspendLayout();
            //panel.Controls.Add(pictureBoxAnswer);
            //this.Controls.Add(panel);
        }

        private int createMultipleChoicePanel(System.Windows.Forms.Panel panel, List<Question> pitanja, int startPosition, int endPosition)
        {
            List<QuestionAnswer> qa = new List<QuestionAnswer>();
            qa.AddRange(pitanja[page].QuestionAnswers);

            string baseS = "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";

            for (int j = 0; j < qa.Count; j++)
            {
                if (qa[j].Answer.IsApicture.Equals(true))
                {
                    endPosition += 130;
                    // Ovo ce se odkomentarisati, problem sa slikama voća prilikom pretvaranja
                    System.Windows.Forms.CheckBox cb = createCheckBox(startPosition, endPosition, j, qa[j].Answer.AnswerText, panel);
                    createPictureBox(startPosition + 20, endPosition, panel, qa[j].Answer.Base64);
                    endPosition += 80;
                }
                else
                {
                    endPosition += 80;
                    System.Windows.Forms.CheckBox cb = createCheckBox(startPosition, endPosition, j, qa[j].Answer.AnswerText, panel);
                    endPosition += 130;
                }

            }
            panels.Add(panel);
            return endPosition;
        }

        private int createSingleChoicePanel(System.Windows.Forms.Panel panel, List<Question> pitanja, int startPosition, int endPosition)
        {
            List<QuestionAnswer> qa = new List<QuestionAnswer>();
            qa.AddRange(pitanja[page].QuestionAnswers);

            for (int j = 0; j < qa.Count; j++)
            {
                if (qa[j].Answer.IsApicture.Equals(true))
                {
                    endPosition += 130;
                    MetroFramework.Controls.MetroButton rb = createRadioButton(startPosition, endPosition, j, qa[j].Answer.AnswerText, panel, qa[j].Answer.IsApicture, qa[j].Answer.Base64);
                    rb.Click += new System.EventHandler(this.buttonOK_Click);
                    endPosition += 50;
                }
                else
                {
                    endPosition += 50;
                    MetroFramework.Controls.MetroButton rb = createRadioButton(startPosition, endPosition, j, qa[j].Answer.AnswerText, panel, qa[j].Answer.IsApicture, qa[j].Answer.Base64);
                    rb.Click += new System.EventHandler(this.buttonOK_Click);
                    endPosition += 130;

                }
            }

            panels.Add(panel);

            return endPosition;
        }

        private int createSlider(System.Windows.Forms.Panel panel, List<QuestionAnswer> qa)
        {

            MyTransparentTrackBar trackBar = new MyTransparentTrackBar();
            trackBar.Location = new System.Drawing.Point(23, 50);
            trackBar.Name = "trackBar";
            trackBar.Size = new System.Drawing.Size(300, 23);
            trackBar.TabIndex = 2;
            trackBar.Minimum = 1;
            trackBar.Maximum = int.Parse(qa[0].Answer.AnswerText);
            int x = (panel.Size.Width - trackBar.Size.Width) / 2;
            trackBar.Location = new Point(x, trackBar.Location.Y + 200);



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
            startLabel.Location = new System.Drawing.Point(x, trackBar.Location.Y + 80);
            startLabel.Name = "metroLabel3";
            startLabel.ForeColor = Color.Black;
            startLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            startLabel.Size = new System.Drawing.Size(50, 25);
            //startLabel.Size = new System.Drawing.Size(35, 19);
            startLabel.TabIndex = 8;
            startLabel.Text = "1";

            endLabel.AutoSize = true;
            endLabel.Location = new System.Drawing.Point(x + 290, trackBar.Location.Y + 80);
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
            System.Windows.Forms.Panel panel = createPanel();
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

}