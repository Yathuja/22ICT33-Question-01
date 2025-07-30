using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttendanceTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Populate ComboBox with options
            cmbStatus.Items.Add("Present");
            cmbStatus.Items.Add("Absent");
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            string studentName = txtStudentName.Text;
            string status = cmbStatus.SelectedItem.ToString();

            string record = studentName + " - " + status;
            lstAttendance.Items.Add(record);

            // Clear fields after adding
            txtStudentName.Clear();
            cmbStatus.SelectedIndex = -1;
        }
    }
}
