using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace IST303_Asbury_C_A7
{
    public partial class frmMain : Form
    {
        FolderBrowserDialog fileBrowser = new FolderBrowserDialog();
        string fileFolder;

        public frmMain()
        {
            InitializeComponent();
        }

       

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            fileBrowser.ShowDialog();
            fileFolder = fileBrowser.SelectedPath;
            label1.Text = fileFolder;
            label1.Visible = true;

            if (fileBrowser.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {

            }

            else
            {
                if (checkBox1.Checked)
                {
                    string[] files = Directory.GetFileSystemEntries(fileFolder, "*", SearchOption.TopDirectoryOnly);
                    foreach (string line in files)
                        rchTxtFilesAndFolders.AppendText(line + "\n");
                }
                else
                {
                    string[] files = Directory.GetFileSystemEntries(fileFolder, "*", SearchOption.AllDirectories);
                    foreach (string line in files)
                        rchTxtFilesAndFolders.AppendText(line + "\n");

                }

            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
    }
}
