
namespace Feedback_Application
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartSession = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartSession
            // 
            this.btnStartSession.BackColor = System.Drawing.Color.Azure;
            this.btnStartSession.Location = new System.Drawing.Point(239, 102);
            this.btnStartSession.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartSession.Name = "btnStartSession";
            this.btnStartSession.Size = new System.Drawing.Size(152, 21);
            this.btnStartSession.TabIndex = 0;
            this.btnStartSession.Text = "OK";
            this.btnStartSession.UseVisualStyleBackColor = false;
            this.btnStartSession.Click += new System.EventHandler(this.btnStartSession_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Za početak sesije kliknite na OK";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 194);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartSession);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 15);
            this.Text = "Početak sesije";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartSession;
        private System.Windows.Forms.Label label1;
    }
}