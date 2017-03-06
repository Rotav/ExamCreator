using ExamCreator.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Lbtn_Loginogin_Click(object sender, EventArgs e)
        {
            CheckTable("tblStudent");//sends value student to the CheckTable subroutine when login as student is pressed
        }

        private void btn_LoginTeacher_Click(object sender, EventArgs e)
        {
            CheckTable("tblTeacher");//sends value teacher to the CheckTable subroutine when login as teacher is pressed
        }

        /// <summary>
        /// Subroutine that checks that the username and password match details in the database.
        /// </summary>
        /// <param name="table"></param>
        private void CheckTable(string table)
        {
            //Opens a datasource which connects to the database
            using (SqlConnection con = new SqlConnection(Settings.Default.DBConn))
            {
                //Opens an SQL command which selects rows in the tblStudent or tblTeacher tables.
                using (SqlCommand cmd = new SqlCommand("Select Id, Username, Password from " + table + " where Username=@Username", con))
                {
                    //Adds the value of @Username to the SQL command.
                    cmd.Parameters.AddWithValue("@Username", txt_Username.Text);

                    //writes the values in the database into a SqlDataAdapter object.
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    //assigns the found account's username and password to string values.
                    string username = dt.Rows[0]["Username"].ToString();
                    string password = dt.Rows[0]["Password"].ToString();

                    //Call the Encryption class the verify the password inputted by the user.
                    bool check = Encryption.HashVerify(txt_Password.Text, "SHA512", password);

                    //checks that the information inputted by the user is correct
                    if (username == txt_Username.Text && check == true)
                    {
                        if (table == "tblStudent") //If the user is logging into a student account...
                        {
                            //...Find the user's unique ID and pass it through into the student's main menu
                            int studentID;
                            Int32.TryParse(dt.Rows[0]["Id"].ToString(), out studentID);
                            MainMenuStudent mainMenuStudent = new MainMenuStudent(studentID);
                            mainMenuStudent.Show();
                        }
                        else if (table == "tblTeacher")//If the user is logging into a teacher account...
                        {
                            //...Find the user's unique ID and pass it through into the teacher's main menu
                            int teacherID;
                            Int32.TryParse(dt.Rows[0]["Id"].ToString(), out teacherID);
                            MainMenuTeacher mainMenuTeacher = new MainMenuTeacher(teacherID);
                            mainMenuTeacher.Show();
                        }
                        else
                        {
                            //Validation if neither of the options have been met (should be impossible).
                            MessageBox.Show("An unexpected error has occured. Please restart the application");
                        }
                    }
                    else
                    {
                        //...Else show an error message.
                        MessageBox.Show("The username or password is incorrect");
                    }
                    txt_Password.Text = string.Empty;
                }
            }
        }

        private void lbl_Username_Click(object sender, EventArgs e)
        {
            MainMenuTeacher mainmenu = new MainMenuTeacher(1);
            mainmenu.Show();
        }
    }
}