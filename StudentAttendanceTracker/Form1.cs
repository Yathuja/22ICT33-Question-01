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
            string studentName = txtStudentName.Text.Trim();
            string status = cmbStatus.SelectedItem as string;

            // Validate name is not empty
            if (string.IsNullOrWhiteSpace(studentName))
            {
                MessageBox.Show("Student name cannot be empty.", "Validation Error");
                return;
            }

            // Validate name contains only alphabetic characters
            if (!System.Text.RegularExpressions.Regex.IsMatch(studentName, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Student name must contain only letters and spaces.", "Validation Error");
                return;
            }

            // Validate status is selected
            if (string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Please select the attendance status.", "Validation Error");
                return;
            }

            // Add the record
            lstAttendance.Items.Add(studentName + " - " + status);

            // Clear input fields
            txtStudentName.Clear();
            cmbStatus.SelectedIndex = -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtStudentName.Clear();
            cmbStatus.SelectedIndex = -1;
            lstAttendance.ClearSelected();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstAttendance.SelectedIndex >= 0)
            {
                lstAttendance.Items.RemoveAt(lstAttendance.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a record to delete.", "Delete Record");
            }
        }
    }
}
