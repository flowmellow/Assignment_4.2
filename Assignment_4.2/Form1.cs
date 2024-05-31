namespace Assignment_4._2
{
    
    public partial class Form1 : Form
    {
        Teacher teachers = new Teacher();    


        public Form1()
        {
            InitializeComponent();
        }

        private void logInEnterButton_Click(object sender, EventArgs e)
        {
            // Simulated DataBase
            teachers.TeacherId = "Teacher";
            teachers.TeacherPassord = "Admin";
            

            if (userNameTextBox.Text == teachers.TeacherId && passwordTextBox.Text == teachers.TeacherPassord)
            {
                //this.Hide();
                Form2 studentForm = new Form2();
                studentForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Entry");
                               
            }
        }
    }
}
