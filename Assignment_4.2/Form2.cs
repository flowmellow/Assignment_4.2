using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4._2
{
    public partial class Form2 : Form
    {
        Student studentData = new Student();
        public Form2()
        {
            InitializeComponent();
        }

        private void saveRecord_Click(object sender, EventArgs e)
        {
            if (studentIdTextBox.Text != "")
            {
                studentData.StudentId = studentIdTextBox.Text;

            }
            else
            {
                MessageBox.Show("Please enter Student ID");
            }

            if (studentFirstNameTextBox.Text != "")
            {
                studentData.FirstName = studentFirstNameTextBox.Text;

            }
            else
            {
                MessageBox.Show("Please enter Student First Name");
            }

            if (studentLastNameTextBox.Text != "")
            {
                studentData.LastName = studentLastNameTextBox.Text;

            }
            else
            {
                MessageBox.Show("Please enter Student Last Name");
            }

            if (studentGPATextBox.Text != "")
            {
                studentData.GPA = Convert.ToDouble(studentGPATextBox.Text);

            }
            else
            {
                MessageBox.Show("Please enter Student GPA");
            }

            Program.studentList.Add(studentData);

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WriteToFile_Click(object sender, EventArgs e)
        {
            string[] studentListArray = { studentData.StudentId, studentData.FirstName, studentData.LastName, Convert.ToString(studentData.GPA) };

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "StudentList.txt")))
            {
                foreach (string line in studentListArray)
                {
                    outputFile.WriteLine(line);
                }
            }
        }
    }
}
