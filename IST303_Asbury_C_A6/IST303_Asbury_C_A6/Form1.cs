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

namespace IST303_Asbury_C_A6
{
    public partial class frmMain : Form
    {
        DateTimePicker date = new DateTimePicker();
        private DateTimePicker timePicker;
        List<string> toDoList = new List<string>();

        public frmMain()
        {
            InitializeComponent();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblTest.Text = "Date:" + date.Value.ToShortDateString() + " Time:" + date.Value.ToShortTimeString();
            date.Value = DateTime.Now;
            toDoList.Add("Date:" + date.Value.ToShortDateString() + " Time:" + date.Value.ToShortTimeString());
            lstList.DataSource = toDoList;
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            //date.Format = DateTimePickerFormat.Custom;
            date = dateTimePicker1;
            date.CustomFormat = "MM/dd/yyyy     hh:mm:ss tt";
            date.Format = DateTimePickerFormat.Custom;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        

    }
}
