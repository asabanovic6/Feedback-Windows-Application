
using Feedback_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Feedback_Application.DatabaseService
{
    public class FADBService
    {
        private FAContext context;
        private ConfigModel configModel;
        public FADBService()
        {
            context = new FAContext();
            configModel = HelperMethods.GetConfigFile();
        }


        public void ClearLocalDatabase()
        {

        }

        public void SaveInitialCampaign(Campaign cmpgn)
        {
            cmpgn.Fadevices.Add(new Fadevice() { DeviceId= (int)configModel.DeviceId, CampaignId= (int)cmpgn.CampaignId, PingForDependent = (bool)configModel.ExpectDependentQuestions});
            context.Add(cmpgn);
            context.SaveChanges();
        }

        public Campaign GetCampaign()
        {
            Campaign cmpgn = context.Campaigns.Find(configModel.CampaignId);
            context.Entry(cmpgn).Collection(c => c.Questions).Load();
            foreach (Question question in cmpgn.Questions)
            {
                context.Entry(question).Collection(q => q.QuestionAnswers).Load();
                foreach (QuestionAnswer questionAnswer in question.QuestionAnswers)
                {
                    context.Entry(questionAnswer).Reference(qa => qa.Answer).Load();
                }
            }
            return cmpgn;
        }

        public void ExtractUserRespones(Campaign campaign, List<MetroFramework.Controls.MetroPanel> panels)
        {
            List<Question> questions = campaign.Questions.ToList();
            Session currentSession = campaign.Sessions.FirstOrDefault();
            for (int i = 0; i<questions.Count; i++)
            {
                var panel = panels[i];
                if(questions[i].QuestionType == "Multiple")
                {
                    var controls = panel.Controls.OfType<MetroFramework.Controls.MetroCheckBox>().Where(x=> x.Checked==true).ToList();
                    foreach(var item in controls)
                    {
                        QuestionAnswer tempAnswer = questions[i].QuestionAnswers.Where(x => x.Answer.AnswerText == item.Text).FirstOrDefault();
                        currentSession.UserResponses.Add(new UserResponse() { SessionId = currentSession.SessionId, AnswerId = tempAnswer.AnswerId, QuestionId = questions[i].QuestionId });
                    }
                }
                else if (questions[i].QuestionType == "Single")
                {
                    var controls = panel.Controls.OfType<MetroFramework.Controls.MetroRadioButton>().Where(x => x.Checked == true).ToList();
                    foreach (var item in controls)
                    {
                        QuestionAnswer tempAnswer = questions[i].QuestionAnswers.Where(x => x.Answer.AnswerText == item.Text).FirstOrDefault();
                        currentSession.UserResponses.Add(new UserResponse() { SessionId = currentSession.SessionId, AnswerId = tempAnswer.AnswerId, QuestionId = questions[i].QuestionId });
                    }
                }
                else if (questions[i].QuestionType == "Text")
                {
                    var controls = panel.Controls.OfType<System.Windows.Forms.TextBox>().Where(x => String.IsNullOrEmpty(x.Text) == false).ToList();
                    //kako izhendlat ako je custom textfield prazan, OVDJE SE PRETPOSTAVLJA DA SE VAZDA NEŠTO ODGOVORI
                    foreach (var item in controls)
                    {
                        currentSession.UserResponses.Add(new UserResponse() { SessionId = currentSession.SessionId, AnswerId = -1, QuestionId = questions[i].QuestionId, CustomAnswer = item.Text });
                    }
                }
                else
                {
                    var controls = panel.Controls.OfType<MetroFramework.Controls.MetroTrackBar>().ToList();
                    //kako izhendlat ako je custom textfield prazan, OVDJE SE PRETPOSTAVLJA DA SE VAZDA NEŠTO ODGOVORI
                    foreach (var item in controls)
                    {
                        currentSession.UserResponses.Add(new UserResponse() { SessionId = currentSession.SessionId, AnswerId = -1, QuestionId = questions[i].QuestionId, CustomAnswer = item.Value.ToString() });
                    }
                }
            }
        }


        public void SaveCurrentSession(Session currentSession)
        {
            context.Add(currentSession);
            context.SaveChanges();

        }



    }
}
