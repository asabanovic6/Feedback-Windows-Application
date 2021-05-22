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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feedback_Application
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        static Fadevice FADevice = new Fadevice();

        public Form1()
        {
            InitializeComponent();
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
        private void button1_Click(object sender, EventArgs e)
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
                string values = "NE";
                if (radioButtonDA.Checked == true)
                {
                    values = "DA";
                }
                //ovaj json se salje prema serveru
                /* String json = "{\"Installation code\":\"" + textBoxInstallationCode.Text + "\", \"IP adresa\":\"" + textBoxIPadresa.Text
                    + "\", \"Zavisna pitanja\":\"" + values + "\", \"keepAlive\":\"" + textBoxKeepAlive.Text + "\"}";*/
                String json = null;
               

                String url = "https://si-main-server.herokuapp.com/api/device/activate" + "/" + textBoxInstallationCode.Text;
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
                        //WriteToFile(result.ToString());

                    }

                    int DeviceId = Int32.Parse(result["DeviceId"].Value<String>());
                    int CampaignId = Int32.Parse(result["CampaignId"].Value<String>());
                    //String DeviceId = result["DeviceId"].Value<String>();
                    String Naziv = result["Naziv"].Value<String>();

                    FADevice.DeviceId = DeviceId;
                    FADevice.CampaignId = CampaignId;
                    if (values == "DA")
                    {
                        FADevice.PingForDependent = true;
                    }
                    else
                    {
                        FADevice.PingForDependent = false;
                    }

                    json = "{\"ID\":\"" + DeviceId + "\", \"Naziv\":\"" + Naziv +  "\", \"IP adresa\":\"" + textBoxIPadresa.Text
                       + "\", \"Zavisna pitanja\":\"" + values + "\", \"keepAlive\":\"" + textBoxKeepAlive.Text + "\"}";

                }
                catch (Exception except)
                {
                    Console.WriteLine(except);
                }

                //dio koda sa spasavanje config-a u MyDocuments

                FileInfo fi = new FileInfo((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)) + "\\config.json");
                if (!fi.Exists)
                {
                    fi.Create().Dispose();
                }
                File.WriteAllText((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)) + "\\config.json", json);
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
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
