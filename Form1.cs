using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using BarcodetoFile.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;
using System.Net.NetworkInformation;

namespace BarcodetoFile
{
    public partial class Form_barcode : Form
    {
        public Form_barcode()
        {
            InitializeComponent();

            RefreshSettings();

            if (!Directory.Exists(log_path))
            {
                log_path = Application.StartupPath;
            }
            
            textBox_msg.Text = "Percorso di salvatagio:\r\n\r\n" + save_path;
            toolStripComboBox1.Text = Properties.Settings.Default.Serial_com;

            cnt_time_out_minimize = (Properties.Settings.Default.time_out_minimize * 1000)/timer_ciclo.Interval; 

            this.Name +="[rev.1.01]";

            OpenCom();
        }

        private void RefreshSettings()
        {
            save_path = Settings.Default.save_path;
            read_path = Settings.Default.read_path;
            file_name = Settings.Default.file_name;
            log_path = Settings.Default.log_path;
            move_path = Settings.Default.move_path;
            move_enabled = Settings.Default.move_enabled;
            ftp_server = Settings.Default.ftpServerName;
            ftp_user = Settings.Default.ftpUser;
            ftp_password = Settings.Default.ftpPassword;
            ftp_enabled = Settings.Default.ftpEnabled;
        }

        string save_path="";
        string read_path = "";
        string log_path = "";
        string move_path = "";
        string ftp_server = "";
        string ftp_user = "";
        string ftp_password = "";
        bool move_enabled = false;
        bool ftp_enabled = false;
        bool ftp_write_request = false;
        string MessageFile = "";
        string SourceFile = "";
        string DestinationFile = "";
        string BdlNumber = "";
        string file_name="";
        string log_file ="Scan_History";
        string recived_from_com = "";
        int cnt_time_out_minimize = 100;//in secondi
        int cnt_time_out_gray = 100;//in secondi
        int cnt_time_out =0;//in secondi

        bool inPausa = false;
        bool ComOpen_Ok = false;
        bool new_msg = false;
        private void pathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PathSettings settings_page = new PathSettings();
            settings_page.Show();

            /*if (Directory.Exists(save_path))
            {
                MessageBox.Show(save_path);
            }
            else
            {
                MessageBox.Show("Percorso non valido\r\n" + save_path, "Salva file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void textBox_code_Validated(object sender, EventArgs e)
        {


        }

        private void textBox_code_TabIndexChanged(object sender, EventArgs e)
        {

            //txt_box_code.BackColor = Color.White;
        }

        private void textBox_code_Enter(object sender, EventArgs e)
        {
        
        }

        private void textBox_code_KeyDown(object sender, KeyEventArgs e)
        {
           
            /*if (e.KeyData == Keys.Enter)
            {
              if(WriteFile(txt_box_code.Text))
               // textBox_code.Text = ""; 

                txt_box_code.Focus();
            }
            */
        }

        private void textBox_code_TextChanged(object sender, EventArgs e)
        {
            txt_box_code.BackColor = Color.White;
          //  textBox_msg.Text = "Percorso di salvatagio:\r\n\r\n" + save_path;
        }

        private bool WriteFile(string msg )
        {
           
          // file_name = msg;
            //string savefilepath = save_path + "\\" + file_name;


            if (msg.Length > 3)
            {
                try
                {
                    BdlNumber = msg.Trim();

                    if(GetFileTxtAndCopy(BdlNumber) == true )
                    {                        
                        if(ftp_enabled == false)
                        {
                            textBox_msg.Text = "File message creato in: " + save_path;

                            if (move_enabled)
                            {
                                textBox_msg.Text += "\r\nFile Bdl spostato in: " + move_path;
                            }
                        }

                        txt_box_code.BackColor = Color.LightGreen;
                        txt_box_code.Text = BdlNumber;

                        label_timescan.Text = "Ora di scannerizzazione:  " + DateTime.Now.ToString("HH:mm:ss  dd/MM/yy ");
                        cnt_time_out = 0;
                        WriteLog(BdlNumber);
                        return true;
                    }
                    else
                    {
                        label_timescan.Text = "BDL NON TROVATO / ERRORE";
                        textBox_msg.Text = "Bdl Non Trovato / Errore";

                        txt_box_code.BackColor = Color.LightSalmon;
                        txt_box_code.Text = BdlNumber;
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    textBox_msg.Text = ex.Message;
                    txt_box_code.BackColor = Color.Red;
 
                    return false;
                }
            }
            else
            {
                textBox_msg.Text = "numero  carateri inseriti /ricevuti  < 3 !!";
                txt_box_code.BackColor = Color.Red;
            }



           

            return false;
        }

        private bool GetFileTxtAndCopy(string filename)
        {
            try
            {
                string[] txtList = Directory.GetFiles(read_path, "*.txt");

                foreach (string f in txtList)
                {
                    string fName = f.Substring(read_path.Length + 1);

                    if (f.Contains(filename))
                    {
                        MessageFile = save_path + "//message.txt";

                        SourceFile = f;
                        DestinationFile = fName;

                        if (ftp_enabled)  //Invio file Message via ftp
                        {
                            File.Copy(SourceFile, MessageFile, true);
                            ftp_write_request = true;
                            return true;
                        }
                        else if (File.Exists(MessageFile)) //Salavatggio file Message su cartella locale
                        {
                            MessageBox.Show("File message.txt ancora presente\nCancellare commessa per procedere", "Errore Resinatrice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        else
                        {                            
                            File.Copy(SourceFile, MessageFile, false);
                            MoveFile(SourceFile, DestinationFile);
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void MoveFile(string sourceFile, string destinationFile)
        {
            if (move_enabled)
            {
                string ProcessedFile = move_path + "//" + destinationFile;

                if (File.Exists(ProcessedFile))
                {
                    if (MessageBox.Show("File " + destinationFile + " già presente, continuare?", "Bdl già elaborato", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        string FileName = Path.GetFileNameWithoutExtension(ProcessedFile);
                        string ProcessedFileNew = move_path + "//" + FileName + "_reprocessedOnDate_" + DateTime.Now.ToString("dd-MM-yy_HH_mm_ss");
                        File.Copy(sourceFile, ProcessedFileNew);
                    }
                }
                else
                    File.Copy(sourceFile, ProcessedFile);
            }
        }

        private bool WriteLog(string msg)
        {
           // file_name = msg;
            
            string savefilepath = log_path + "\\" + log_file + ".csv";

            if (file_name.Length > 3)
            {
                try
                {
                    //File.WriteAllLines(savefilepath, new string[] { msg + ";" + DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() });

                    File.AppendAllLines(savefilepath, new string[] { msg + ";"  + DateTime.Now.ToShortDateString()+ " - " +DateTime.Now.ToLongTimeString() });

                    if (!ComOpen_Ok)
                    {
                        textBox_msg.Text += "\t\r\nCOM OPEN  ERROR!!\t\r\nSOLO  MODALITA MANUALE\r\n";
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    textBox_msg.Text = ex.Message;
                    txt_box_code.BackColor = Color.Red;
                    return false;
                }
            }

           

            return false;
        }


        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            toolStripComboBox1.Items.Clear();
            toolStripComboBox1.Items.AddRange(ports);
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Focused)
            {
                Properties.Settings.Default.Serial_com = toolStripComboBox1.Text;

            }
        }

        private void oPENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCom();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (recived_from_com.Length < 3) // msg non ancora letto ignoro altri msg
            {
                while (serialPort1.BytesToRead > 0)
                {
                    recived_from_com += serialPort1.ReadExisting();
                    Thread.Sleep(10);

                }
                new_msg = true;
            }
        }

        private void cLOSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }


        private void OpenCom()
        {

            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.PortName = Properties.Settings.Default.Serial_com;
                    serialPort1.Open();
                    textBox_msg.Text = serialPort1.PortName + " OPEN OK ";
                    Properties.Settings.Default.Save();

                    toolStripStatusLabel_Com_Status.Text = serialPort1.PortName + " OPEN OK";
                    toolStripStatusLabel_Com_Status.BackColor = Color.LightGreen;
                    ComOpen_Ok = true;
                }
                catch (Exception ex)
                {
                    ComOpen_Ok = false;

                    toolStripStatusLabel_Com_Status.Text = serialPort1.PortName + " OPEN ERROR";
                    toolStripStatusLabel_Com_Status.BackColor = Color.Red;
                    textBox_msg.Text = ex.Message;
                   // MessageBox.Show(ex.Message, "Com Open", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void timer_ciclo_Tick(object sender, EventArgs e)
        {

            RefreshSettings();

            cnt_time_out++;
            if (cnt_time_out > cnt_time_out_gray)
            {
                this.txt_box_code.BackColor = Color.LightGray;
                cnt_time_out = 0;
            }

            if (inPausa)
            {
                toolStripStatusLabel1.Text = "In PAUSA... (" + DateTime.Now.ToString("HH:mm:ss dd/MM/yy)");
                this.txt_box_code.BackColor = Color.Orange;
                this.txt_box_code.Text = "IN PAUSA...";
            }
            else
            {
               toolStripStatusLabel1.Text = "In attesa di nuova scansione... (" + DateTime.Now.ToString("HH:mm:ss dd/MM/yy)");
            }

            if (new_msg && !inPausa)
            {
                new_msg = false;
                if (!WriteFile(recived_from_com))
                {
                    cnt_time_out = 0;
                    //  this.WindowState = FormWindowState.Maximized;
                }
                recived_from_com = "";
            }

            if(ftp_write_request)
            {
                ftp_write_request = false;
                FtpSendFile(MessageFile);
            }

            new_msg = false;


        }

        private void Form_barcode_MouseClick(object sender, MouseEventArgs e)
        {
            cnt_time_out = 0;
        }

        private void Form_barcode_MouseUp(object sender, MouseEventArgs e)
        {
            cnt_time_out = 0;
        }

        private void Form_barcode_Load(object sender, EventArgs e)
        {

        }

        private void Form_barcode_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btn_pausa_Click(object sender, EventArgs e)
        {

            inPausa = !inPausa;

            if (inPausa)
            {
                btn_pausa.Text = "Avvia";
                this.txt_box_code.Enabled = false;
            }
            else
            {
                btn_pausa.Text = "Pausa";
                this.txt_box_code.Enabled = true;
                this.txt_box_code.Text = "";
                this.txt_box_code.BackColor = Color.White;
            
            }

        }

        private void btn_send_Click(object sender, EventArgs e)
        {

            if (!inPausa)
                WriteFile(txt_box_code.Text);
                // textBox_code.Text = "";
            // txt_box_code.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GetFileTxtAndCopy(txt_box_code.Text) == true)
            {
                textBox_msg.Text = "File salvato in:\r\n\r\n " + save_path;

                txt_box_code.BackColor = Color.LightGreen;
                txt_box_code.Text = txt_box_code.Text;

                label_timescan.Text = "Ora di scannerizzazione:  " + DateTime.Now.ToString("HH:mm:ss  dd/MM/yy ");
                cnt_time_out = 0;
                WriteLog(txt_box_code.Text);
            }
        }

        private FtpSendState FtpState;
        private enum FtpSendState
        {
            SEND_DataBin,
            SEND_DataReady,
            SEND_Wait
        }

        private void FtpSendFile(string UploadFile)
        {
            string FileName = Path.GetFileName(UploadFile);
            Uri FtpUri = new Uri(ftp_server + FileName);

            using (var client = new WebClient())
            {
                client.Credentials = new NetworkCredential(ftp_user, ftp_password);
                client.UploadFileAsync(FtpUri, WebRequestMethods.Ftp.UploadFile, UploadFile);
                client.UploadFileCompleted += FTUploadFileCompleted;                
            }
        }

        private void FTUploadFileCompleted(object sender, UploadFileCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                label_timescan.Text = "ERRORE FTP";
                textBox_msg.Text = e.Error.Message;

                txt_box_code.BackColor = Color.LightSalmon;
                txt_box_code.Text = BdlNumber;
            }                
            else
            {
                MoveFile(SourceFile, DestinationFile);

                textBox_msg.Text = "File message inviato via Ftp correttamente";

                if (move_enabled)
                {
                    textBox_msg.Text += "\r\nFile Bdl spostato in: " + move_path;
                }
            }
        }

    }
}
