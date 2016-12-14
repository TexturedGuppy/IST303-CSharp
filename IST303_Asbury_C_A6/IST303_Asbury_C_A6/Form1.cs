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
        DateTimePicker date = new DateTimePicker(); //My DateTimePicker Control Variable
        List<string> LtoDoList = new List<string>();//to do list of type list
        List<DateTime> Ldate = new List<DateTime>();//Was going to use for sorting the dates
        List<string> Lnames = new List<string>();//Was going to use for sorting names
        string file = "toDoList.txt"; //Text File to save and read from
        string name; //Name of the task on the todo list

        public frmMain()
        {

            InitializeComponent();

        }

       
        /// <summary>
        /// Add button functionality
        /// Checks to see if name text is empty before allowing user to input a task.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtToDo.Text))
            {
                name = txtToDo.Text;
                lblTest.Visible = false;
                string dateAndTime = "Date:" + date.Value.ToShortDateString() + " Time:" + date.Value.ToShortTimeString() + " Task:" + name;
                name = txtToDo.Text;
                lblTest.Text = dateAndTime.Split(':', ' ')[1];
                Ldate.Add(date.Value);
                LtoDoList.Add(dateAndTime);
                lstList.Items.Add(dateAndTime);
                date.Value = DateTime.Now;
                txtToDo.Clear();
            }
            else
            {
                lblTest.Visible = true;
                lblTest.Text = "No Name for your To Do List Item.";
            }

        }

        /// <summary>
        /// What happens when the form is loaded.
        /// This is where the magic happens if you already have text saved to a file
        /// Reads from the file and stores the information to listBox and to the List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {

            lblTest.Visible = false;
            date = dateTimePicker1;
            LtoDoList = File.ReadLines(file).ToList();
            date.Value = DateTime.Now;
            string[] _file = File.ReadAllLines(file);
            lstList.Items.AddRange(_file);
            //date.Format = DateTimePickerFormat.Custom;
            date.CustomFormat = "MM/dd/yyyy     hh:mm:ss tt";
            date.Format = DateTimePickerFormat.Custom;
            date.MinDate = DateTime.Today;
            //foreach(string str in LtoDoList)
            //{
            //    Ldate.Add(Convert.ToDateTime(str));
            //}
        }

        /// <summary>
        /// QUit button
        /// does exactly what you think it would
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Have the form write to the file upon closing as to not lose any data between sessions
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllLines(file, LtoDoList);
        }

        /// <summary>
        /// Remove button
        /// Will remove any selected item from the listbox
        /// After removing it will update the normal list as well
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstList.Items.Remove(lstList.SelectedItem);
            LtoDoList.Clear();
            foreach (string str in lstList.Items)
            {
                LtoDoList.Add(str);
            }
            
        }

        /// <summary>
        /// Sort by date function, that is incomplete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortByDate_Click(object sender, EventArgs e)
        {
            
                //var dateSorted = from str in LtoDoList orderby date ascending select Convert.ToDateTime(str.Substring(str.IndexOf(":") + 1,str.IndexOf(" ") - 1));
                var dateSorted = from str in LtoDoList orderby date ascending select str.Split(':', ' ')[1];
                lstList.Items.Clear();

                foreach (string str in dateSorted)
                {
                    lstList.Items.Add(str);
                }

                LtoDoList.Clear();
            foreach (string str in lstList.Items)
            {
                LtoDoList.Add(str);
            }



        }

        private void btnSortByName_Click(object sender, EventArgs e)
        {

        }

       
    }
}
