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
        
       
       //Program Variables
        FolderBrowserDialog fileBrowser = new FolderBrowserDialog(); //The File Browser 
        string fileFolder; //String to store file path

        public frmMain()
        {
            InitializeComponent();
        }

       
        /// <summary>
        /// Controls Basically Entire Program
        /// Checks to see if you want to see Top Directory or All Directories with the CheckBox
        /// Controls the Adding of Threads when calling the Print Function
        /// Asynchronous
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            
            DialogResult d = fileBrowser.ShowDialog();
            fileFolder = fileBrowser.SelectedPath;
            label1.Text = fileFolder;
            label1.Visible = true;

            if (d == DialogResult.OK)
            {
                if (checkBox1.Checked)
                {
                    //string[] files = Directory.GetFileSystemEntries(fileFolder, "*", SearchOption.TopDirectoryOnly);
                    //foreach (string line in files)
                    //    rchTxtFilesAndFolders.AppendText(line + "\n");
                    string[] files = Directory.GetFileSystemEntries(fileFolder, "*", SearchOption.TopDirectoryOnly);
                    await Task.Run(() => GetAndPrint(files));
                }
                else
                {
                    //string[] files = Directory.GetFileSystemEntries(fileFolder, "*", SearchOption.AllDirectories);
                    //foreach (string line in files)
                    //    rchTxtFilesAndFolders.AppendText(line + "\n");
                    string[] files = Directory.GetFileSystemEntries(fileFolder, "*", SearchOption.AllDirectories);

                    await Task.Run(() => GetAndPrint(files));

                }
            }
            else
            {
                label1.Text = "No Folder or File Selected";
            }


        }

        /// <summary>
        /// Takes in a string array and prints it out one by one into the Rich Text Box
        /// </summary>
        /// <param name="files"></param>
        private void GetAndPrint(string [] files)
        {
            foreach (string line in files)
                rchTxtFilesAndFolders.AppendText(line + "\n");
        }

        /// <summary>
        /// Form Loading Function
        /// Currently just controls the label for letting you know what file path you're on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
    }
}
