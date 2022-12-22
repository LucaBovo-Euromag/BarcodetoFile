namespace BarcodetoFile
{
    partial class PathSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PathSettings));
            this.selectSavePath = new System.Windows.Forms.FolderBrowserDialog();
            this.selectReadPath = new System.Windows.Forms.FolderBrowserDialog();
            this.selectLogPath = new System.Windows.Forms.FolderBrowserDialog();
            this.saveReadPathBtn = new System.Windows.Forms.Button();
            this.saveWritePathBtn = new System.Windows.Forms.Button();
            this.saveLogPathBtn = new System.Windows.Forms.Button();
            this.readPathTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.savePathTxt = new System.Windows.Forms.TextBox();
            this.logsPathTxt = new System.Windows.Forms.TextBox();
            this.moveEnabled = new System.Windows.Forms.CheckBox();
            this.movePathTxt = new System.Windows.Forms.TextBox();
            this.movePathBtn = new System.Windows.Forms.Button();
            this.ftpEnabled = new System.Windows.Forms.CheckBox();
            this.ftpServerName = new System.Windows.Forms.TextBox();
            this.SaveFtpServerName = new System.Windows.Forms.Button();
            this.SaveFtpUser = new System.Windows.Forms.Button();
            this.SaveFtpPassword = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ftpUser = new System.Windows.Forms.TextBox();
            this.ftpPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveReadPathBtn
            // 
            this.saveReadPathBtn.Location = new System.Drawing.Point(434, 27);
            this.saveReadPathBtn.Name = "saveReadPathBtn";
            this.saveReadPathBtn.Size = new System.Drawing.Size(96, 23);
            this.saveReadPathBtn.TabIndex = 0;
            this.saveReadPathBtn.Text = "Cambia";
            this.saveReadPathBtn.UseVisualStyleBackColor = true;
            this.saveReadPathBtn.Click += new System.EventHandler(this.saveReadPathBtn_Click);
            // 
            // saveWritePathBtn
            // 
            this.saveWritePathBtn.Location = new System.Drawing.Point(434, 55);
            this.saveWritePathBtn.Name = "saveWritePathBtn";
            this.saveWritePathBtn.Size = new System.Drawing.Size(96, 23);
            this.saveWritePathBtn.TabIndex = 1;
            this.saveWritePathBtn.Text = "Cambia";
            this.saveWritePathBtn.UseVisualStyleBackColor = true;
            this.saveWritePathBtn.Click += new System.EventHandler(this.saveWritePathBtn_Click);
            // 
            // saveLogPathBtn
            // 
            this.saveLogPathBtn.Location = new System.Drawing.Point(435, 185);
            this.saveLogPathBtn.Name = "saveLogPathBtn";
            this.saveLogPathBtn.Size = new System.Drawing.Size(96, 23);
            this.saveLogPathBtn.TabIndex = 2;
            this.saveLogPathBtn.Text = "Cambia";
            this.saveLogPathBtn.UseVisualStyleBackColor = true;
            this.saveLogPathBtn.Click += new System.EventHandler(this.saveLogPathBtn_Click);
            // 
            // readPathTxt
            // 
            this.readPathTxt.Location = new System.Drawing.Point(133, 30);
            this.readPathTxt.Name = "readPathTxt";
            this.readPathTxt.Size = new System.Drawing.Size(295, 20);
            this.readPathTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cartella Files .txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cartella File message.txt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cartella Log";
            // 
            // savePathTxt
            // 
            this.savePathTxt.Location = new System.Drawing.Point(133, 57);
            this.savePathTxt.Name = "savePathTxt";
            this.savePathTxt.Size = new System.Drawing.Size(295, 20);
            this.savePathTxt.TabIndex = 7;
            // 
            // logsPathTxt
            // 
            this.logsPathTxt.Location = new System.Drawing.Point(133, 188);
            this.logsPathTxt.Name = "logsPathTxt";
            this.logsPathTxt.Size = new System.Drawing.Size(295, 20);
            this.logsPathTxt.TabIndex = 8;
            // 
            // moveEnabled
            // 
            this.moveEnabled.AutoSize = true;
            this.moveEnabled.Location = new System.Drawing.Point(16, 217);
            this.moveEnabled.Name = "moveEnabled";
            this.moveEnabled.Size = new System.Drawing.Size(101, 17);
            this.moveEnabled.TabIndex = 9;
            this.moveEnabled.Text = "Sposta Files Txt";
            this.moveEnabled.UseVisualStyleBackColor = true;
            this.moveEnabled.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // movePathTxt
            // 
            this.movePathTxt.Location = new System.Drawing.Point(133, 214);
            this.movePathTxt.Name = "movePathTxt";
            this.movePathTxt.Size = new System.Drawing.Size(295, 20);
            this.movePathTxt.TabIndex = 10;
            // 
            // movePathBtn
            // 
            this.movePathBtn.Location = new System.Drawing.Point(435, 211);
            this.movePathBtn.Name = "movePathBtn";
            this.movePathBtn.Size = new System.Drawing.Size(96, 23);
            this.movePathBtn.TabIndex = 11;
            this.movePathBtn.Text = "Cambia";
            this.movePathBtn.UseVisualStyleBackColor = true;
            this.movePathBtn.Click += new System.EventHandler(this.movePathBtn_Click);
            // 
            // ftpEnabled
            // 
            this.ftpEnabled.AutoSize = true;
            this.ftpEnabled.Location = new System.Drawing.Point(15, 92);
            this.ftpEnabled.Name = "ftpEnabled";
            this.ftpEnabled.Size = new System.Drawing.Size(79, 17);
            this.ftpEnabled.TabIndex = 12;
            this.ftpEnabled.Text = "Cartella Ftp";
            this.ftpEnabled.UseVisualStyleBackColor = true;
            this.ftpEnabled.CheckedChanged += new System.EventHandler(this.ftpEnabled_CheckedChanged);
            // 
            // ftpServerName
            // 
            this.ftpServerName.Location = new System.Drawing.Point(133, 89);
            this.ftpServerName.Name = "ftpServerName";
            this.ftpServerName.Size = new System.Drawing.Size(295, 20);
            this.ftpServerName.TabIndex = 13;
            // 
            // SaveFtpServerName
            // 
            this.SaveFtpServerName.Location = new System.Drawing.Point(436, 86);
            this.SaveFtpServerName.Name = "SaveFtpServerName";
            this.SaveFtpServerName.Size = new System.Drawing.Size(95, 23);
            this.SaveFtpServerName.TabIndex = 14;
            this.SaveFtpServerName.Text = "Salva";
            this.SaveFtpServerName.UseVisualStyleBackColor = true;
            this.SaveFtpServerName.Click += new System.EventHandler(this.SaveFtpServerName_Click);
            // 
            // SaveFtpUser
            // 
            this.SaveFtpUser.Location = new System.Drawing.Point(435, 115);
            this.SaveFtpUser.Name = "SaveFtpUser";
            this.SaveFtpUser.Size = new System.Drawing.Size(95, 23);
            this.SaveFtpUser.TabIndex = 15;
            this.SaveFtpUser.Text = "Salva";
            this.SaveFtpUser.UseVisualStyleBackColor = true;
            this.SaveFtpUser.Click += new System.EventHandler(this.SaveFtpUser_Click);
            // 
            // SaveFtpPassword
            // 
            this.SaveFtpPassword.Location = new System.Drawing.Point(435, 142);
            this.SaveFtpPassword.Name = "SaveFtpPassword";
            this.SaveFtpPassword.Size = new System.Drawing.Size(95, 23);
            this.SaveFtpPassword.TabIndex = 16;
            this.SaveFtpPassword.Text = "Salva";
            this.SaveFtpPassword.UseVisualStyleBackColor = true;
            this.SaveFtpPassword.Click += new System.EventHandler(this.SaveFtpPassword_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "User";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Password";
            // 
            // ftpUser
            // 
            this.ftpUser.Location = new System.Drawing.Point(133, 118);
            this.ftpUser.Name = "ftpUser";
            this.ftpUser.Size = new System.Drawing.Size(295, 20);
            this.ftpUser.TabIndex = 19;
            // 
            // ftpPassword
            // 
            this.ftpPassword.Location = new System.Drawing.Point(133, 145);
            this.ftpPassword.Name = "ftpPassword";
            this.ftpPassword.Size = new System.Drawing.Size(295, 20);
            this.ftpPassword.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Carica valori di default";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PathSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 301);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ftpPassword);
            this.Controls.Add(this.ftpUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaveFtpPassword);
            this.Controls.Add(this.SaveFtpUser);
            this.Controls.Add(this.SaveFtpServerName);
            this.Controls.Add(this.ftpServerName);
            this.Controls.Add(this.ftpEnabled);
            this.Controls.Add(this.movePathBtn);
            this.Controls.Add(this.movePathTxt);
            this.Controls.Add(this.moveEnabled);
            this.Controls.Add(this.logsPathTxt);
            this.Controls.Add(this.savePathTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.readPathTxt);
            this.Controls.Add(this.saveLogPathBtn);
            this.Controls.Add(this.saveWritePathBtn);
            this.Controls.Add(this.saveReadPathBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PathSettings";
            this.Text = "Cartelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog selectSavePath;
        private System.Windows.Forms.FolderBrowserDialog selectReadPath;
        private System.Windows.Forms.FolderBrowserDialog selectLogPath;
        private System.Windows.Forms.Button saveReadPathBtn;
        private System.Windows.Forms.Button saveWritePathBtn;
        private System.Windows.Forms.Button saveLogPathBtn;
        private System.Windows.Forms.TextBox readPathTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox savePathTxt;
        private System.Windows.Forms.TextBox logsPathTxt;
        private System.Windows.Forms.CheckBox moveEnabled;
        private System.Windows.Forms.TextBox movePathTxt;
        private System.Windows.Forms.Button movePathBtn;
        private System.Windows.Forms.CheckBox ftpEnabled;
        private System.Windows.Forms.TextBox ftpServerName;
        private System.Windows.Forms.Button SaveFtpServerName;
        private System.Windows.Forms.Button SaveFtpUser;
        private System.Windows.Forms.Button SaveFtpPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ftpUser;
        private System.Windows.Forms.TextBox ftpPassword;
        private System.Windows.Forms.Button button1;
    }
}