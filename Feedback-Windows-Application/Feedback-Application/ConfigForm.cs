using Feedback_Application.DatabaseService;
using Feedback_Application.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feedback_Application
{
    public partial class ConfigForm : MetroFramework.Forms.MetroForm
    {

        static Fadevice FADevice = new Fadevice();
        static APIService ApiService;
        private HelperMethods HelperMethods;
        private ConfigModel cfm;
        private FADBService DbService;

        public ConfigForm()
        {
            InitializeComponent();
            HelperMethods = new HelperMethods();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxKeepAlive.Visible = false;
            labelKeepAlive.Visible = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_2(object sender, EventArgs e)
        {

        }
         
        // Kontroler za submit dugme
        // U ovom kontroleru se šalje installation code prema serveru i spasavaju se podaci
        // iz config file-a i odg sa servera
        private async void button1_Click(object sender, EventArgs e)
        {
            bool installationCode = true;
            bool IPaddress = true;
            if (string.IsNullOrWhiteSpace(textBoxInstallationCode.Text))
            {
                installationCode = false;
                textBoxInstallationCode.Focus();
                textBoxInstallationCode.Clear();
                textBoxInstallationCode.BackColor = Color.LightPink;
            }
            else
            {
                installationCode = true;
                textBoxInstallationCode.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(textBoxIPadresa.Text))
            {
                IPaddress = false;
                textBoxIPadresa.Focus();
                textBoxIPadresa.Clear();
                textBoxIPadresa.BackColor = Color.LightPink;
            }
            else
            {
                IPaddress = true;
                textBoxIPadresa.BackColor = Color.White;
            }

            
            if (installationCode && IPaddress)
            {
                try
                {
                    cfm = new ConfigModel() {CampaignId=null, DeviceId = null, Name = null, IPAddress = textBoxIPadresa.Text, ExpectDependentQuestions = radioButtonDA.Checked, PingForDependentQuestionsFrequency = 30, SessionDuration = 180 };
                    HelperMethods.CreateConfigFile(cfm);
                    ApiService = new APIService(cfm);
                    ActivateDeviceModel adm = await ApiService.ActivateDevice(textBoxInstallationCode.Text);
                    //fali textbox na formi gdje se upisuje svako koliko treba uređaj da pinga! defaultno je stavljeno na 30 sekundi
                    cfm = new ConfigModel() { CampaignId=adm.CampaignID, DeviceId = adm.DeviceId, Name = adm.Name, IPAddress = textBoxIPadresa.Text, ExpectDependentQuestions = radioButtonDA.Checked, PingForDependentQuestionsFrequency = 30, SessionDuration = 180 };
                    HelperMethods.CreateConfigFile(cfm);
                    Campaign cmpgn = await ApiService.GetCampaingForDevice(adm.CampaignID);
                    DbService = new FADBService();
                    DbService.SaveInitialCampaign(cmpgn);
                    SessionStartForm frm = new SessionStartForm();
                    frm.Show();
                    this.Hide();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
        }

        public static Fadevice GetFADevice()
        {
            return FADevice;
        }

        static public void WriteToFile(string Message)
        {
            string path = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)) + "\\Logs";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filepath = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)) + "\\Logs\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";
            if (!File.Exists(filepath))
            {
                // Create a file to write to.   
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonDA_CheckedChanged(object sender, EventArgs e)
        {
            textBoxKeepAlive.Visible = true;
            labelKeepAlive.Visible = true;
        }

        private void radioButtonNE_CheckedChanged(object sender, EventArgs e)
        {
            textBoxKeepAlive.Visible = false;
            labelKeepAlive.Visible = false;
        }

        private void textBoxIPadresa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
