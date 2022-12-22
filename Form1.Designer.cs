
namespace BarcodetoFile
{
    partial class Form_barcode
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_barcode));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txt_box_code = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.oPENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLOSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_msg = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer_ciclo = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Com_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_timescan = new System.Windows.Forms.Label();
            this.btn_pausa = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_box_code
            // 
            this.txt_box_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_code.Location = new System.Drawing.Point(12, 45);
            this.txt_box_code.Name = "txt_box_code";
            this.txt_box_code.Size = new System.Drawing.Size(517, 44);
            this.txt_box_code.TabIndex = 0;
            this.txt_box_code.TabIndexChanged += new System.EventHandler(this.textBox_code_TabIndexChanged);
            this.txt_box_code.TextChanged += new System.EventHandler(this.textBox_code_TextChanged);
            this.txt_box_code.Enter += new System.EventHandler(this.textBox_code_Enter);
            this.txt_box_code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_code_KeyDown);
            this.txt_box_code.Validated += new System.EventHandler(this.textBox_code_Validated);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pathToolStripMenuItem,
            this.toolStripComboBox1,
            this.oPENToolStripMenuItem,
            this.cLOSEToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // pathToolStripMenuItem
            // 
            this.pathToolStripMenuItem.Name = "pathToolStripMenuItem";
            this.pathToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.pathToolStripMenuItem.Text = "Settings";
            this.pathToolStripMenuItem.Click += new System.EventHandler(this.pathToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.Text = "COM";
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // oPENToolStripMenuItem
            // 
            this.oPENToolStripMenuItem.Name = "oPENToolStripMenuItem";
            this.oPENToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.oPENToolStripMenuItem.Text = "OPEN";
            this.oPENToolStripMenuItem.Click += new System.EventHandler(this.oPENToolStripMenuItem_Click);
            // 
            // cLOSEToolStripMenuItem
            // 
            this.cLOSEToolStripMenuItem.Name = "cLOSEToolStripMenuItem";
            this.cLOSEToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.cLOSEToolStripMenuItem.Text = "CLOSE";
            this.cLOSEToolStripMenuItem.Click += new System.EventHandler(this.cLOSEToolStripMenuItem_Click);
            // 
            // textBox_msg
            // 
            this.textBox_msg.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_msg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_msg.Location = new System.Drawing.Point(12, 202);
            this.textBox_msg.Multiline = true;
            this.textBox_msg.Name = "textBox_msg";
            this.textBox_msg.ReadOnly = true;
            this.textBox_msg.Size = new System.Drawing.Size(456, 70);
            this.textBox_msg.TabIndex = 2;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer_ciclo
            // 
            this.timer_ciclo.Enabled = true;
            this.timer_ciclo.Tick += new System.EventHandler(this.timer_ciclo_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Com_Status,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 287);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(630, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Com_Status
            // 
            this.toolStripStatusLabel_Com_Status.Name = "toolStripStatusLabel_Com_Status";
            this.toolStripStatusLabel_Com_Status.Size = new System.Drawing.Size(76, 17);
            this.toolStripStatusLabel_Com_Status.Text = "COM STATUS";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(34, 17);
            this.toolStripStatusLabel1.Text = "Stato";
            // 
            // label_timescan
            // 
            this.label_timescan.AutoSize = true;
            this.label_timescan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timescan.Location = new System.Drawing.Point(12, 110);
            this.label_timescan.Name = "label_timescan";
            this.label_timescan.Size = new System.Drawing.Size(100, 25);
            this.label_timescan.TabIndex = 4;
            this.label_timescan.Text = "Data ora ";
            // 
            // btn_pausa
            // 
            this.btn_pausa.Location = new System.Drawing.Point(12, 150);
            this.btn_pausa.Name = "btn_pausa";
            this.btn_pausa.Size = new System.Drawing.Size(100, 34);
            this.btn_pausa.TabIndex = 5;
            this.btn_pausa.Text = "PAUSA";
            this.btn_pausa.UseVisualStyleBackColor = true;
            this.btn_pausa.Click += new System.EventHandler(this.btn_pausa_Click);
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.Location = new System.Drawing.Point(545, 45);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(73, 44);
            this.btn_send.TabIndex = 6;
            this.btn_send.Text = "INVIA";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(474, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form_barcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 309);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_pausa);
            this.Controls.Add(this.label_timescan);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox_msg);
            this.Controls.Add(this.txt_box_code);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(505, 244);
            this.Name = "Form_barcode";
            this.Text = "Barcode to .csv file Converter [rev 2.1]";
            this.Load += new System.EventHandler(this.Form_barcode_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form_barcode_MouseClick);
            this.MouseEnter += new System.EventHandler(this.Form_barcode_MouseEnter);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_barcode_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txt_box_code;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pathToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_msg;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem oPENToolStripMenuItem;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ToolStripMenuItem cLOSEToolStripMenuItem;
        private System.Windows.Forms.Timer timer_ciclo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label_timescan;
        private System.Windows.Forms.Button btn_pausa;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Com_Status;
    }
}

