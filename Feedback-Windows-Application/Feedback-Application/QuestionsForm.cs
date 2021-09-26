using Feedback_Application.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using Feedback_Application.DatabaseService;
using System.Windows.Forms;
using System.Threading;

namespace Feedback_Application
{
    public partial class QuestionsForm : MetroFramework.Forms.MetroForm
    {

        private Campaign campaign;
        private FADBService DbService;
        private APIService ApiService;
        private System.Windows.Forms.Timer myTimer;

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
            for (int i = 0; i < questions.Count; i++)
            {
                if (questions[i].QuestionType != "custom choice")
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
            myTimer = new System.Windows.Forms.Timer();
            InitializeComponent();
            if(page == 0)
            {
                buttonOK.Visible = true;
            }
            //PredjiNaSljedecePitanje();
        }


        public void PredjiNaSljedecePitanje()
        {

            myTimer.Tick += new EventHandler(TimerEventProcessor);

            // Sets the timer interval to 10 seconds.
            myTimer.Interval = 10000;
            myTimer.Start();
        }

        private void TimerEventProcessor(object sender, EventArgs e)
        {
            if (page < campaign.Questions.ToList().Count - 1)
            {
                buttonOK_Click(null, null);
            }
            else
            {
                myTimer.Stop();
                SubmitSessionButton_Click(null, null);
            }
        }

        private void Questions_Load(object sender, EventArgs e)
        {
            //ConfigForm.WriteToFile(questions.Count.ToString());
            loadQuestions(campaign.Questions.ToList());
            buttonOK.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonOK.Width, buttonOK.Height, 10, 10));
            buttonBack.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonBack.Width, buttonBack.Height, 10, 10));
            buttonExit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonExit.Width, buttonExit.Height, 10, 10));
            SubmitSessionButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, SubmitSessionButton.Width, SubmitSessionButton.Height, 10, 10));
            if (page == 0)
            {
                this.buttonBack.Visible = false;
                this.SubmitSessionButton.Visible = false;
            }
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.buttonOK.Visible = false;

            if (page > 0)
            {
                this.buttonBack.Visible = true;
                page--;
                if (page == 0)
                    this.buttonBack.Visible = false;
                loadQuestions(campaign.Questions.ToList());

                panels[page].Visible = true;
                panels[page].BringToFront();

                page++;
                panels[page].Visible = false;
                panels[page].SendToBack();

                page--;
                this.Update();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.buttonBack.Visible = true;

            if (page < campaign.Questions.ToList().Count - 1)
            {
                this.SubmitSessionButton.Visible = false;
                this.buttonOK.Visible = false;


                page++;
                if (page == campaign.Questions.ToList().Count - 1)
                {
                    this.buttonOK.Visible = false;
                    this.SubmitSessionButton.Visible = true;
                }
                loadQuestions(campaign.Questions.ToList());
                panels[page].Visible = true;
                panels[page].BringToFront();

                page--;
                panels[page].Visible = false;
                panels[page].SendToBack();
                var elementCount = panels[page].Controls;
                if (page == 0)
                {
                    PredjiNaSljedecePitanje();
                }
                page++;
                this.Update();
                
            }
        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            myTimer.Stop();
            var configModel = HelperMethods.GetConfigFile();
            campaign.Sessions.Add(new Session() { IsSynced = false, CampaignId = (int)campaign.CampaignId, Duration = (int)configModel.SessionDuration });
            QuestionsForm sesija = new QuestionsForm(campaign);
            this.Hide();
            sesija.ShowDialog();
            this.Close();
        }

        private void SubmitSessionButton_Click(object sender, EventArgs e)
        {
            DbService.ExtractUserRespones(campaign, panels);
            ApiService.SendUserResponseToServer(campaign.Sessions.FirstOrDefault());
            campaign = DbService.GetCampaign();
            campaign.Sessions = new HashSet<Session>();
            var configModel = HelperMethods.GetConfigFile();
            campaign.Sessions.Add(new Session() { IsSynced = false, CampaignId = (int)campaign.CampaignId, Duration = (int)configModel.SessionDuration });
            QuestionsForm sesija = new QuestionsForm(campaign);
            
            MessageBox.Show("Hvala na izdvojenom vremenu!");

            this.Hide();
            sesija.ShowDialog();
            this.Close();


        }
    }
}