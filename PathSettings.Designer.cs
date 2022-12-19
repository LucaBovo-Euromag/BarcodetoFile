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
            this.saveLogPathBtn.Location = new System.Drawing.Point(434, 85);
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
            this.label3.Location = new System.Drawing.Point(13, 88);
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
            this.logsPathTxt.Location = new System.Drawing.Point(133, 85);
            this.logsPathTxt.Name = "logsPathTxt";
            this.logsPathTxt.Size = new System.Drawing.Size(295, 20);
            this.logsPathTxt.TabIndex = 8;
            // 
            // moveEnabled
            // 
            this.moveEnabled.AutoSize = true;
            this.moveEnabled.Location = new System.Drawing.Point(12, 113);
            this.moveEnabled.Name = "moveEnabled";
            this.moveEnabled.Size = new System.Drawing.Size(101, 17);
            this.moveEnabled.TabIndex = 9;
            this.moveEnabled.Text = "Sposta Files Txt";
            this.moveEnabled.UseVisualStyleBackColor = true;
            this.moveEnabled.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // movePathTxt
            // 
            this.movePathTxt.Location = new System.Drawing.Point(133, 111);
            this.movePathTxt.Name = "movePathTxt";
            this.movePathTxt.Size = new System.Drawing.Size(295, 20);
            this.movePathTxt.TabIndex = 10;
            // 
            // movePathBtn
            // 
            this.movePathBtn.Location = new System.Drawing.Point(434, 111);
            this.movePathBtn.Name = "movePathBtn";
            this.movePathBtn.Size = new System.Drawing.Size(96, 23);
            this.movePathBtn.TabIndex = 11;
            this.movePathBtn.Text = "Cambia";
            this.movePathBtn.UseVisualStyleBackColor = true;
            this.movePathBtn.Click += new System.EventHandler(this.movePathBtn_Click);
            // 
            // PathSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 176);
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
    }
}