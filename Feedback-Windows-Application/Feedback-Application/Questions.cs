using Feedback_Application.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Feedback_Application
{
    public partial class Questions : MetroFramework.Forms.MetroForm
    {

        Fadevice FADevice = Form1.GetFADevice();

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
            Console.WriteLine("pocetak............................");
            Console.ReadLine();
            // ovdje dohvatiti listu pitanja

            String url = "https://si-main-server.herokuapp.com/api/campaign" + "/1";
            JToken result;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            try
            {
                var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (Stream stream = httpWebResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                    String responseString = reader.ReadToEnd();

                    result = JsonConvert.DeserializeObject<JToken>(responseString);
                    var nesto = result["Questions"].ToString();
                    List<Question> pitanja = JsonConvert.DeserializeObject<List<Question>>(nesto);
                    //questions = pitanja;
                    questions.Add(pitanja[1]);
                    //Form1.WriteToFile(questions.Count.ToString());
                }

            }
            catch (Exception except)
            {
                Console.WriteLine(except);
                Form1.WriteToFile(except.ToString());
            }
         
            //addAnswersToQuestions(questions);
            InitializeComponent();
        }

        private void Questions_Load(object sender, EventArgs e)
        {
            Form1.WriteToFile(questions.Count.ToString());
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
