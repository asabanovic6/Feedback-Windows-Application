using Feedback_Application.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Feedback_Application
{
    public partial class Questions : MetroFramework.Forms.MetroForm
    {
        public List<Question> questions = new List<Question>();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse

            );
        private void addAnswersToQuestions(List<Question> questions)
        {
            for(int i = 0; i < questions.Count; i++)
            {
                if(questions[i].QuestionType != "custom choice")
                {
                    List<QuestionAnswer> answers = new List<QuestionAnswer>();
                    answers.AddRange(new List<QuestionAnswer>
                    {
                        new QuestionAnswer { Id = 1, AnswerId = 1, QuestionId = i, Answer = new Answer { AnswerId = 1, AnswerText = "1", IsApicture = false} },
                        new QuestionAnswer { Id = 2, AnswerId = 2, QuestionId = i, Answer = new Answer { AnswerId = 2, AnswerText = "2" ,IsApicture = false} },
                        new QuestionAnswer { Id = 3, AnswerId = 3, QuestionId = i, Answer = new Answer { AnswerId = 3, AnswerText = "3" ,IsApicture = false} },
                    });
                    questions[i].QuestionAnswers = answers;
                }
            }

        }
        public Questions()
        {
            questions.AddRange( new List<Question> {
                new Question { QuestionId = 1, QuestionType = "multiple choice", QuestionText = "Kakav je danas dan?" ,IsDependent = false, Data1 = null, Data2 = null, Data3 = null, CampaignId = 1},
                new Question { QuestionId = 2, QuestionType = "single choice", QuestionText = "Kako si?", IsDependent = false, Data1 = null, Data2 = null, Data3 = null, CampaignId = 1},
                new Question { QuestionId = 3, QuestionType = "custom choice", QuestionText = "Sta ima?", IsDependent = false, Data1 = null, Data2 = null, Data3 = null, CampaignId = 1 },
                new Question { QuestionId = 4, QuestionType = "multiple choice", QuestionText = "Ovo je primjer pitanja?", IsDependent = true, Data1 = null, Data2 = null, Data3 = null, CampaignId = 1 },
                new Question { QuestionId = 5, QuestionType = "scala choice", QuestionText = "Ovo je scala choice", IsDependent = true, Data1 = null, Data2 = null, Data3 = null, CampaignId = 1 }
            });
            addAnswersToQuestions(questions);
            InitializeComponent();
        }

        private void Questions_Load(object sender, EventArgs e)
        {
            
            loadQuestions(questions);
            buttonOK.Region = Region.FromHrgn(CreateRoundRectRgn(0,0,buttonOK.Width, buttonOK.Height,10,10));
            buttonBack.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonBack.Width, buttonBack.Height, 10, 10));
            buttonExit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonExit.Width, buttonExit.Height, 10, 10));
            if (page == 0)
            {
                this.buttonBack.Visible = false;
            }
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.buttonOK.Visible = true;

            if (page > 0)
            {
                this.buttonBack.Visible = true;
                panels[page].Visible = false;
                panels[page].SendToBack();

                page--;
                if(page == 0)
                    this.buttonBack.Visible = false;
                loadQuestions(questions);
                panels[page].Visible = true;
                panels[page].BringToFront();
                this.Update();
            } 
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.buttonBack.Visible = true;

            if (page < questions.Count - 1)
            {
                this.buttonOK.Visible = true;
                panels[page].Visible = false;
                panels[page].SendToBack();

                page++;
                if(page == questions.Count - 1)
                    this.buttonOK.Visible = false;
                loadQuestions(questions);
                panels[page].Visible = true;
                panels[page].BringToFront();
                this.Update();
            }
        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
