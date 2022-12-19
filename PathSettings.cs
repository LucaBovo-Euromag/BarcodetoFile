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

            readPathTxt.Text = Settings.Default.read_path;
            savePathTxt.Text = Settings.Default.save_path;
            logsPathTxt.Text = Settings.Default.log_path;
            movePathTxt.Text = Settings.Default.move_path;
            moveEnabled.Checked = Settings.Default.move_enabled;

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
    }
}
