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

namespace BarcodetoFile
{
    public partial class Form_barcode : Form
    {
        public Form_barcode()
        {
            InitializeComponent();

            save_path = Properties.Settings.Default.save_path;
            file_name = Properties.Settings.Default.file_name;
            log_path  = Properties.Settings.Default.log_path;

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


        string save_path="";
        string log_path = "";
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
            if (Directory.Exists(save_path))
            {
                MessageBox.Show(save_path);
            }
            else
            {
                MessageBox.Show("Percorso non valido\r\n" + save_path, "Salva file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            string savefilepath = save_path + "\\" + file_name;


            if (msg.Length > 3)
            {
                try
                {
             

                    msg = msg.Trim();

                    File.WriteAllLines(savefilepath, new string[] { msg });
                    textBox_msg.Text = "File salvato in:\r\n\r\n " + savefilepath;
                   
                    txt_box_code.BackColor = Color.LightGreen;
                    txt_box_code.Text = msg;

                    label_timescan.Text = "Ora di scannerizzazione:  " + DateTime.Now.ToString("HH:mm:ss  dd/MM/yy ");
                    cnt_time_out = 0;
                    WriteLog(msg);
                    return true;
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
               toolStripStatusLabel1.Text = "In attesa di nuova scanssione... (" + DateTime.Now.ToString("HH:mm:ss dd/MM/yy)");
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
    }
}
