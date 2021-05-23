using Feedback_Application.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using Feedback_Application.DatabaseService;

namespace Feedback_Application
{
    public partial class QuestionsForm : MetroFramework.Forms.MetroForm
    {

        private Campaign campaign;
        private FADBService DbService;
        private APIService ApiService;

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
        public QuestionsForm(Campaign cmpgn)
        {
            campaign = cmpgn;
            DbService = new FADBService();
            ApiService = new APIService(HelperMethods.GetConfigFile());
            InitializeComponent();
        }

        private void Questions_Load(object sender, EventArgs e)
        {
            //ConfigForm.WriteToFile(questions.Count.ToString());
            loadQuestions(campaign.Questions.ToList());
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
                loadQuestions(campaign.Questions.ToList());
                panels[page].Visible = true;
                panels[page].BringToFront();
                this.Update();
            } 
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.buttonBack.Visible = true;
            
            if (page < campaign.Questions.ToList().Count - 1)
            {
                this.SubmitSessionButton.Visible = false;
                this.buttonOK.Visible = true;
                panels[page].Visible = false;
                panels[page].SendToBack();
                var elementCount = panels[page].Controls;
                page++;
                if (page == campaign.Questions.ToList().Count - 1)
                {
                    this.buttonOK.Visible = false;
                    this.SubmitSessionButton.Visible = true;
                }
                loadQuestions(campaign.Questions.ToList());
                panels[page].Visible = true;
                panels[page].BringToFront();
                this.Update();
            }
        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitSessionButton_Click(object sender, EventArgs e)
        {
            try
            {
                DbService.ExtractUserRespones(campaign, panels);
                ApiService.SendUserResponseToServer(campaign.Sessions.FirstOrDefault());
                SessionStartForm newSessionForm = new SessionStartForm();
                this.Hide();
                newSessionForm.ShowDialog();
                this.Close();
            }
            catch(Exception ex)
            {
                //treba se spasiti sesija u lokalnu bazu i opet redirectati na pocetak
            }
        }
    }
}
