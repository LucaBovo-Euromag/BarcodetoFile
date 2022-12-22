using BarcodetoFile.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BarcodetoFile
{
    public partial class PathSettings : Form
    {
        public PathSettings()
        {
            InitializeComponent();

            LoadParams();

        }

        private void LoadParams()
        {
            readPathTxt.Text = Settings.Default.read_path;
            savePathTxt.Text = Settings.Default.save_path;
            logsPathTxt.Text = Settings.Default.log_path;
            movePathTxt.Text = Settings.Default.move_path;
            moveEnabled.Checked = Settings.Default.move_enabled;
            ftpEnabled.Checked = Settings.Default.ftpEnabled;
            ftpServerName.Text = Settings.Default.ftpServerName;
            ftpUser.Text = Settings.Default.ftpUser;
            ftpPassword.Text = Settings.Default.ftpPassword;

            if (moveEnabled.Checked)
            {
                movePathTxt.Enabled = true;
                movePathBtn.Enabled = true;
            }
            else
            {
                movePathTxt.Enabled = false;
                movePathBtn.Enabled = false;
            }

            if (ftpEnabled.Checked)
            {
                ftpServerName.Enabled = true;
                ftpUser.Enabled = true;
                ftpPassword.Enabled = true;
            }
            else
            {
                ftpServerName.Enabled = false;
                ftpUser.Enabled = false;
                ftpPassword.Enabled = false;
            }
        }

        private void saveReadPathBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            folderDlg.SelectedPath = Settings.Default.read_path;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                readPathTxt.Text = folderDlg.SelectedPath;
                Settings.Default.read_path = folderDlg.SelectedPath;
                Settings.Default.Save();
            }
        }

        private void saveWritePathBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            folderDlg.SelectedPath = Settings.Default.save_path;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                savePathTxt.Text = folderDlg.SelectedPath;
                Settings.Default.save_path = folderDlg.SelectedPath;
                Settings.Default.Save();
            }
        }

        private void saveLogPathBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            folderDlg.SelectedPath = Settings.Default.log_path;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                logsPathTxt.Text = folderDlg.SelectedPath;
                Settings.Default.log_path = folderDlg.SelectedPath;
                Settings.Default.Save();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(moveEnabled.Checked)
            {
                movePathTxt.Enabled = true;
                movePathBtn.Enabled = true;
                Settings.Default.move_enabled = true;
            }
            else
            {
                movePathTxt.Enabled = false;
                movePathBtn.Enabled = false;
                Settings.Default.move_enabled = false;
            }
            Settings.Default.Save();
        }

        private void movePathBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            folderDlg.SelectedPath = Settings.Default.move_path;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                movePathTxt.Text = folderDlg.SelectedPath;
                Settings.Default.move_path = folderDlg.SelectedPath;
                Settings.Default.Save();
            }
        }

        private void ftpEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (ftpEnabled.Checked)
            {
                ftpServerName.Enabled = true;
                ftpUser.Enabled = true;
                ftpPassword.Enabled = true; 
                Settings.Default.ftpEnabled = true;
                label2.Text = "Cartella File Temporaneo";
            }
            else
            {
                ftpServerName.Enabled = false;
                ftpUser.Enabled = false;
                ftpPassword.Enabled = false;
                Settings.Default.ftpEnabled = false;
                label2.Text = "Cartella File message.txt";
            }
            Settings.Default.Save();
        }

        private void SaveFtpServerName_Click(object sender, EventArgs e)
        {
            Settings.Default.ftpServerName = ftpServerName.Text;
            Settings.Default.Save();
        }

        private void SaveFtpUser_Click(object sender, EventArgs e)
        {
            Settings.Default.ftpUser = ftpUser.Text;
            Settings.Default.Save();
        }

        private void SaveFtpPassword_Click(object sender, EventArgs e)
        {
            Settings.Default.ftpPassword = ftpPassword.Text;
            Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Sei sicuro?", "Caricamento configurazione di default", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Settings.Default.Reset();
                LoadParams();
            }
        }
    }
}
