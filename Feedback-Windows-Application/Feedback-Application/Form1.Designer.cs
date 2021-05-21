namespace Feedback_Application
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxInstallationCode = new System.Windows.Forms.TextBox();
            this.labelKeepAlive = new System.Windows.Forms.Label();
            this.textBoxIPadresa = new System.Windows.Forms.TextBox();
            this.labelIPadresa = new System.Windows.Forms.Label();
            this.radioButtonDA = new System.Windows.Forms.RadioButton();
            this.labelPitanja = new System.Windows.Forms.Label();
            this.radioButtonNE = new System.Windows.Forms.RadioButton();
            this.labelInstallationCode = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.textBoxKeepAlive = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(74, 24);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(27, 20);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID:";
            this.labelID.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxInstallationCode
            // 
            this.textBoxInstallationCode.Location = new System.Drawing.Point(354, 58);
            this.textBoxInstallationCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxInstallationCode.Name = "textBoxInstallationCode";
            this.textBoxInstallationCode.Size = new System.Drawing.Size(168, 23);
            this.textBoxInstallationCode.TabIndex = 3;
            this.textBoxInstallationCode.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelKeepAlive
            // 
            this.labelKeepAlive.AutoSize = true;
            this.labelKeepAlive.Location = new System.Drawing.Point(65, 168);
            this.labelKeepAlive.Name = "labelKeepAlive";
            this.labelKeepAlive.Size = new System.Drawing.Size(208, 15);
            this.labelKeepAlive.TabIndex = 8;
            this.labelKeepAlive.Text = "Interval provjere pitanja u sekundama:";
            this.labelKeepAlive.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxIPadresa
            // 
            this.textBoxIPadresa.Location = new System.Drawing.Point(354, 96);
            this.textBoxIPadresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIPadresa.Name = "textBoxIPadresa";
            this.textBoxIPadresa.Size = new System.Drawing.Size(168, 23);
            this.textBoxIPadresa.TabIndex = 7;
            this.textBoxIPadresa.TextChanged += new System.EventHandler(this.textBoxIPadresa_TextChanged);
            // 
            // labelIPadresa
            // 
            this.labelIPadresa.AutoSize = true;
            this.labelIPadresa.Location = new System.Drawing.Point(65, 96);
            this.labelIPadresa.Name = "labelIPadresa";
            this.labelIPadresa.Size = new System.Drawing.Size(57, 15);
            this.labelIPadresa.TabIndex = 4;
            this.labelIPadresa.Text = "IP adresa:";
            this.labelIPadresa.Click += new System.EventHandler(this.label3_Click);
            // 
            // radioButtonDA
            // 
            this.radioButtonDA.AutoSize = true;
            this.radioButtonDA.Location = new System.Drawing.Point(387, 128);
            this.radioButtonDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonDA.Name = "radioButtonDA";
            this.radioButtonDA.Size = new System.Drawing.Size(41, 19);
            this.radioButtonDA.TabIndex = 9;
            this.radioButtonDA.Text = "DA";
            this.radioButtonDA.UseVisualStyleBackColor = true;
            this.radioButtonDA.CheckedChanged += new System.EventHandler(this.radioButtonDA_CheckedChanged);
            // 
            // labelPitanja
            // 
            this.labelPitanja.AutoSize = true;
            this.labelPitanja.Location = new System.Drawing.Point(65, 130);
            this.labelPitanja.Name = "labelPitanja";
            this.labelPitanja.Size = new System.Drawing.Size(169, 15);
            this.labelPitanja.TabIndex = 12;
            this.labelPitanja.Text = "Da li očekujete zavisna pitanja?";
            this.labelPitanja.Click += new System.EventHandler(this.label5_Click);
            // 
            // radioButtonNE
            // 
            this.radioButtonNE.AutoSize = true;
            this.radioButtonNE.Checked = true;
            this.radioButtonNE.Location = new System.Drawing.Point(456, 128);
            this.radioButtonNE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonNE.Name = "radioButtonNE";
            this.radioButtonNE.Size = new System.Drawing.Size(40, 19);
            this.radioButtonNE.TabIndex = 10;
            this.radioButtonNE.TabStop = true;
            this.radioButtonNE.Text = "NE";
            this.radioButtonNE.UseVisualStyleBackColor = true;
            this.radioButtonNE.CheckedChanged += new System.EventHandler(this.radioButtonNE_CheckedChanged);
            // 
            // labelInstallationCode
            // 
            this.labelInstallationCode.AutoSize = true;
            this.labelInstallationCode.Location = new System.Drawing.Point(65, 63);
            this.labelInstallationCode.Name = "labelInstallationCode";
            this.labelInstallationCode.Size = new System.Drawing.Size(93, 15);
            this.labelInstallationCode.TabIndex = 2;
            this.labelInstallationCode.Text = "Instalacijski kod:";
            this.labelInstallationCode.Click += new System.EventHandler(this.label2_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.Azure;
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SubmitButton.Location = new System.Drawing.Point(439, 210);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(82, 22);
            this.SubmitButton.TabIndex = 14;
            this.SubmitButton.Text = "Potvrdi";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxKeepAlive
            // 
            this.textBoxKeepAlive.Location = new System.Drawing.Point(354, 163);
            this.textBoxKeepAlive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxKeepAlive.Name = "textBoxKeepAlive";
            this.textBoxKeepAlive.Size = new System.Drawing.Size(168, 23);
            this.textBoxKeepAlive.TabIndex = 13;
            this.textBoxKeepAlive.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBoxKeepAlive);
            this.panel1.Controls.Add(this.SubmitButton);
            this.panel1.Controls.Add(this.labelInstallationCode);
            this.panel1.Controls.Add(this.radioButtonNE);
            this.panel1.Controls.Add(this.labelPitanja);
            this.panel1.Controls.Add(this.radioButtonDA);
            this.panel1.Controls.Add(this.labelIPadresa);
            this.panel1.Controls.Add(this.textBoxIPadresa);
            this.panel1.Controls.Add(this.labelKeepAlive);
            this.panel1.Controls.Add(this.textBoxInstallationCode);
            this.panel1.Location = new System.Drawing.Point(18, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 234);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 372);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 15);
            this.Text = "Konfiguracijska forma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxInstallationCode;
        private System.Windows.Forms.Label labelKeepAlive;
        private System.Windows.Forms.TextBox textBoxIPadresa;
        private System.Windows.Forms.Label labelIPadresa;
        private System.Windows.Forms.RadioButton radioButtonDA;
        private System.Windows.Forms.Label labelPitanja;
        private System.Windows.Forms.RadioButton radioButtonNE;
        private System.Windows.Forms.Label labelInstallationCode;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox textBoxKeepAlive;
        private System.Windows.Forms.Panel panel1;
    }
}

