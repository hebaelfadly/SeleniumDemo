namespace SeleniumDemo
{
    partial class Form1
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
            if(driver != null)
                driver.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetStatistics = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.RichTextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnGetScreenShot = new System.Windows.Forms.Button();
            this.btnNavigate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetStatistics
            // 
            this.btnGetStatistics.Location = new System.Drawing.Point(12, 81);
            this.btnGetStatistics.Name = "btnGetStatistics";
            this.btnGetStatistics.Size = new System.Drawing.Size(216, 23);
            this.btnGetStatistics.TabIndex = 0;
            this.btnGetStatistics.Text = "Get Survey Statistics";
            this.btnGetStatistics.UseVisualStyleBackColor = true;
            this.btnGetStatistics.Click += new System.EventHandler(this.btnGetStatistics_Click);
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(12, 186);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(216, 152);
            this.txtResults.TabIndex = 1;
            this.txtResults.Text = "";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 52);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(216, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnGetScreenShot
            // 
            this.btnGetScreenShot.Location = new System.Drawing.Point(12, 110);
            this.btnGetScreenShot.Name = "btnGetScreenShot";
            this.btnGetScreenShot.Size = new System.Drawing.Size(216, 23);
            this.btnGetScreenShot.TabIndex = 3;
            this.btnGetScreenShot.Text = "Get Screenshot";
            this.btnGetScreenShot.UseVisualStyleBackColor = true;
            this.btnGetScreenShot.Click += new System.EventHandler(this.btnGetScreenShot_Click);
            // 
            // btnNavigate
            // 
            this.btnNavigate.Location = new System.Drawing.Point(13, 22);
            this.btnNavigate.Name = "btnNavigate";
            this.btnNavigate.Size = new System.Drawing.Size(216, 23);
            this.btnNavigate.TabIndex = 0;
            this.btnNavigate.Text = "Navigate";
            this.btnNavigate.UseVisualStyleBackColor = true;
            this.btnNavigate.Click += new System.EventHandler(this.btnNavigate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 365);
            this.Controls.Add(this.btnNavigate);
            this.Controls.Add(this.btnGetScreenShot);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btnGetStatistics);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetStatistics;
        private System.Windows.Forms.RichTextBox txtResults;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnGetScreenShot;
        private System.Windows.Forms.Button btnNavigate;
    }
}