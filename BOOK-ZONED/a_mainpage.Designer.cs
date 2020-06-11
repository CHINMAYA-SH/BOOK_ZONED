namespace BOOK_ZONED
{
    partial class a_mainpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(a_mainpage));
            this.title = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginLbl = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.pswdLbl = new System.Windows.Forms.Label();
            this.usrLbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.title.Controls.Add(this.label3);
            this.title.Controls.Add(this.pictureBox1);
            this.title.Controls.Add(this.panel1);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(0, 213);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1920, 664);
            this.title.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 30F);
            this.label3.Location = new System.Drawing.Point(937, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(758, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "BOOK-ZONED LIBRARY MANAGEMENT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(654, 654);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loginLbl);
            this.panel1.Controls.Add(this.passwordField);
            this.panel1.Controls.Add(this.usernameField);
            this.panel1.Controls.Add(this.pswdLbl);
            this.panel1.Controls.Add(this.usrLbl);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Location = new System.Drawing.Point(1025, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 363);
            this.panel1.TabIndex = 1;
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Font = new System.Drawing.Font("Times New Roman", 30F);
            this.loginLbl.ForeColor = System.Drawing.Color.White;
            this.loginLbl.Location = new System.Drawing.Point(207, 13);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(156, 46);
            this.loginLbl.TabIndex = 16;
            this.loginLbl.Text = "ADMIN";
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(316, 196);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(227, 32);
            this.passwordField.TabIndex = 15;
            // 
            // usernameField
            // 
            this.usernameField.Location = new System.Drawing.Point(316, 109);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(227, 32);
            this.usernameField.TabIndex = 14;
            // 
            // pswdLbl
            // 
            this.pswdLbl.AutoSize = true;
            this.pswdLbl.ForeColor = System.Drawing.Color.White;
            this.pswdLbl.Location = new System.Drawing.Point(73, 196);
            this.pswdLbl.Name = "pswdLbl";
            this.pswdLbl.Size = new System.Drawing.Size(128, 25);
            this.pswdLbl.TabIndex = 13;
            this.pswdLbl.Text = "PASSWORD";
            // 
            // usrLbl
            // 
            this.usrLbl.AutoSize = true;
            this.usrLbl.ForeColor = System.Drawing.Color.White;
            this.usrLbl.Location = new System.Drawing.Point(73, 116);
            this.usrLbl.Name = "usrLbl";
            this.usrLbl.Size = new System.Drawing.Size(130, 25);
            this.usrLbl.TabIndex = 12;
            this.usrLbl.Text = "USERNAME";
            // 
            // loginBtn
            // 
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Location = new System.Drawing.Point(200, 299);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(169, 48);
            this.loginBtn.TabIndex = 11;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1681, 1033);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "design copyrights © CHINMAYA SH";
            // 
            // a_mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "a_mainpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Label pswdLbl;
        private System.Windows.Forms.Label usrLbl;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

