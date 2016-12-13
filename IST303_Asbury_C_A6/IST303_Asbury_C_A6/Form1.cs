using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IST303_Asbury_C_A6
{
    public partial class frmMain : Form
    {
        DateTimePicker date = new DateTimePicker();


        public frmMain()
        {
            InitializeComponent();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblTest.Text = date.ToString();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            date.Format = DateTimePickerFormat.Custom;
            date.CustomFormat = "MM dd yyyy hh mm ss";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
