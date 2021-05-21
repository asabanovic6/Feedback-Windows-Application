using Feedback_Application.DatabaseService;
using Feedback_Application.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feedback_Application
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
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
                String json = "{\"Installation code\":\"" + textBoxInstallationCode.Text + "\", \"IP adresa\":\"" + textBoxIPadresa.Text
                   + "\", \"Zavisna pitanja\":\"" + values + "\", \"keepAlive\":\"" + textBoxKeepAlive.Text + "\"}";

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
