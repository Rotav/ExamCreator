using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExamCreator
{
    public partial class CreateAccount : Form
    {
        private ExamDBEntities examde = new ExamDBEntities();

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btn_createacc_Click(object sender, EventArgs e)
        {
            if(txt_forename.Text == "" || txt_surname.Text == "" || txt_Confirm.Text == "" || txt_Password.Text == "" || txt_Username.Text == "")
            {
                MessageBox.Show("One or more fields have been left blank. All fields must be filled.");
            }
            else if (txt_Confirm.Text != txt_Password.Text)
            {
                MessageBox.Show("The text inside the password and confirm password fields are not the same.");
            }
            else
            {
                /**StudentTable student = new StudentTable();

                student.SchoolID = Int32.Parse(txt_schoolID.Text);
                student.Username = txt_Username.Text;
                student.Password = txt_Password.Text;
                student.Forename = txt_forename.Text;
                student.Surname = txt_surname.Text;

                examde.tblStudent.Add(student);
                 * **/
                String connectionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password";
                //SqlConnection cn = new SqlConnection(global::ExamCreator.Properties.Settings.Default.tblStudent_DatabaseConnectionString);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO tblStudent (Username, Password, Forename, Surname, SchoolID) VALUES (@Name, @pwd, @fore, @sur, @id)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@Name", txt_Username.Text);
                    cmd.Parameters.AddWithValue("@pwd", txt_Password.Text);
                    cmd.Parameters.AddWithValue("@fore", txt_forename.Text);
                    cmd.Parameters.AddWithValue("@sur", txt_surname.Text);
                    cmd.Parameters.AddWithValue("@id", Int32.Parse(txt_schoolID.Text));
                    connection.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Account created!");
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rad_Teacher_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
