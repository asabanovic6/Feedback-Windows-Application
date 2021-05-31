namespace Feedback_Application
{
    partial class ConfigForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.textBoxInstallationCode.Location = new System.Drawing.Point(207, 49);
            this.textBoxInstallationCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxInstallationCode.Name = "textBoxInstallationCode";
            this.textBoxInstallationCode.Size = new System.Drawing.Size(264, 23);
            this.textBoxInstallationCode.TabIndex = 3;
            this.textBoxInstallationCode.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelKeepAlive
            // 
            this.labelKeepAlive.AutoSize = true;
            this.labelKeepAlive.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelKeepAlive.ForeColor = System.Drawing.SystemColors.Window;
            this.labelKeepAlive.Location = new System.Drawing.Point(272, 282);
            this.labelKeepAlive.Name = "labelKeepAlive";
            this.labelKeepAlive.Size = new System.Drawing.Size(134, 28);
            this.labelKeepAlive.TabIndex = 8;
            this.labelKeepAlive.Text = "Ping Interval";
            this.labelKeepAlive.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxIPadresa
            // 
            this.textBoxIPadresa.Location = new System.Drawing.Point(207, 135);
            this.textBoxIPadresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIPadresa.Name = "textBoxIPadresa";
            this.textBoxIPadresa.Size = new System.Drawing.Size(264, 23);
            this.textBoxIPadresa.TabIndex = 7;
            this.textBoxIPadresa.TextChanged += new System.EventHandler(this.textBoxIPadresa_TextChanged);
            // 
            // labelIPadresa
            // 
            this.labelIPadresa.AutoSize = true;
            this.labelIPadresa.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIPadresa.ForeColor = System.Drawing.SystemColors.Window;
            this.labelIPadresa.Location = new System.Drawing.Point(290, 93);
            this.labelIPadresa.Name = "labelIPadresa";
            this.labelIPadresa.Size = new System.Drawing.Size(104, 28);
            this.labelIPadresa.TabIndex = 4;
            this.labelIPadresa.Text = "IP Adress:";
            this.labelIPadresa.Click += new System.EventHandler(this.label3_Click);
            // 
            // radioButtonDA
            // 
            this.radioButtonDA.AutoSize = true;
            this.radioButtonDA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonDA.Location = new System.Drawing.Point(281, 228);
            this.radioButtonDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonDA.Name = "radioButtonDA";
            this.radioButtonDA.Size = new System.Drawing.Size(51, 25);
            this.radioButtonDA.TabIndex = 9;
            this.radioButtonDA.Text = "Yes";
            this.radioButtonDA.UseVisualStyleBackColor = true;
            this.radioButtonDA.CheckedChanged += new System.EventHandler(this.radioButtonDA_CheckedChanged);
            // 
            // labelPitanja
            // 
            this.labelPitanja.AutoSize = true;
            this.labelPitanja.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPitanja.ForeColor = System.Drawing.SystemColors.Window;
            this.labelPitanja.Location = new System.Drawing.Point(213, 185);
            this.labelPitanja.Name = "labelPitanja";
            this.labelPitanja.Size = new System.Drawing.Size(258, 28);
            this.labelPitanja.TabIndex = 12;
            this.labelPitanja.Text = "Dependent Question Type";
            this.labelPitanja.Click += new System.EventHandler(this.label5_Click);
            // 
            // radioButtonNE
            // 
            this.radioButtonNE.AutoSize = true;
            this.radioButtonNE.Checked = true;
            this.radioButtonNE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonNE.Location = new System.Drawing.Point(353, 228);
            this.radioButtonNE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonNE.Name = "radioButtonNE";
            this.radioButtonNE.Size = new System.Drawing.Size(49, 25);
            this.radioButtonNE.TabIndex = 10;
            this.radioButtonNE.TabStop = true;
            this.radioButtonNE.Text = "No";
            this.radioButtonNE.UseVisualStyleBackColor = true;
            this.radioButtonNE.CheckedChanged += new System.EventHandler(this.radioButtonNE_CheckedChanged);
            // 
            // labelInstallationCode
            // 
            this.labelInstallationCode.AutoSize = true;
            this.labelInstallationCode.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInstallationCode.ForeColor = System.Drawing.SystemColors.Window;
            this.labelInstallationCode.Location = new System.Drawing.Point(259, 8);
            this.labelInstallationCode.Name = "labelInstallationCode";
            this.labelInstallationCode.Size = new System.Drawing.Size(172, 28);
            this.labelInstallationCode.TabIndex = 2;
            this.labelInstallationCode.Text = "Installation Code";
            this.labelInstallationCode.Click += new System.EventHandler(this.label2_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(135)))));
            this.SubmitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(135)))));
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.Window;
            this.SubmitButton.Location = new System.Drawing.Point(272, 386);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(147, 60);
            this.SubmitButton.TabIndex = 14;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxKeepAlive
            // 
            this.textBoxKeepAlive.Location = new System.Drawing.Point(207, 330);
            this.textBoxKeepAlive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxKeepAlive.Name = "textBoxKeepAlive";
            this.textBoxKeepAlive.Size = new System.Drawing.Size(264, 23);
            this.textBoxKeepAlive.TabIndex = 13;
            this.textBoxKeepAlive.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(135)))));
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
            this.panel1.Location = new System.Drawing.Point(145, 147);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 446);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(135)))));
            this.pictureBox1.BackgroundImage = global::Feedback_Application.Properties.Resources.backgroundImage;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(283, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 152);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(135)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 613);
            this.panel2.TabIndex = 17;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::Feedback_Application.Properties.Resources.white_removebg_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(978, 669);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConfigForm";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 15);
            this.Text = "Configuration Form";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

