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
    public partial class CreateUser : Form
    {
        //Initialise variables
        string forename;
        string surname;
        string username;
        string password;

        DatabaseConnectioncs objConnector;
        string stringConnector;
        
        DataSet ds;

        public CreateUser()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Reads all of the data from the fields and adds the details to the correct table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CreateAccount_Click(object sender, EventArgs e)
        {
            //If any of the textbox fields have been left blank...
            if (txt_Forename.Text == "" && txt_Surname.Text == "" && txt_Username.Text == ""
                && txt_Password.Text == "" && txt_ConfirmPassword.Text == "")
                //...Show error error message
                MessageBox.Show("One or more of the text fields have been left blank. All fields must be filled.");
            else if (txt_Password.Text != txt_ConfirmPassword.Text) //If the two password fields do not match...
            {
                //...Show error message
                MessageBox.Show("Invalid password: the contents of the two password fields do not match.");
            }
            else
            {
                //...Else write the text inside the textboxes into the corresponding variables.
                forename = txt_Forename.Text;
                surname = txt_Surname.Text;
                username = txt_Username.Text;
                password = txt_Password.Text;

                if (rb_Student.Checked == true)//If the student radio button is checked...
                {
                    EncryptPassword("tblStudent", "student"); //Calls the EncryptPassword subroutine centered around creating a new student user.
                }
                else if (rb_Teacher.Checked == true)//...Else if the student radio button is checked...
                {
                    EncryptPassword("tblTeacher", "teacher");//Calls the EncryptPassword subroutine centered around creating a new student user.
                }
                else
                {
                    //...Else show error message.
                    //This error message should be impossible to achieve as one of the radio buttons is checked by default.
                    MessageBox.Show("Please check one of the account type radio buttons.");
                }
            }
        }
        /// <summary>
        /// Subroutine that clears the text from the textboxes.
        /// </summary>
        private void ClearText()
        {
            txt_Forename.Text = string.Empty;
            txt_Surname.Text = string.Empty;
            txt_Username.Text = string.Empty;
            txt_Password.Text = string.Empty;
            txt_ConfirmPassword.Text = string.Empty;
        }

        /// <summary>
        /// Subroutine used to encrypt the password and insert the details entered by the user into the database.
        /// </summary>
        private void EncryptPassword(string table, string accountType)
        {
            //Opens a datasource which connects to the database
            using (SqlConnection con = new SqlConnection(Settings.Default.DBConn))
            {
                //Opens an SQL command which inserts a new row into tblStudent or tblTeacher in order to create new user details.
                using (SqlCommand cmd = new SqlCommand("Insert into " + table + "(Username, Password, Forename, Surname) " +
                    "values(@Username, @Password, @Forename, @Surname)", con))
                {
                    //string that stores the encrppted version of the password by calling the Encryption class.
                    string encryptPass = Encryption.Hash(password, "SHA512", null);
                    
                    //Write the values into the table
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", encryptPass);
                    cmd.Parameters.AddWithValue("@Forename", forename);
                    cmd.Parameters.AddWithValue("@Surname", surname);

                    con.Open();//Opens an SQL connection by using the datasource.
                    cmd.ExecuteNonQuery();//Executes the SQLCommand above.
                    con.Close();//Closes the SQL connection.

                    //Opens a message box for the user to let them know that the account has been successfully created.
                    MessageBox.Show("The " + accountType + " account for " + forename + " " + surname + " has been successfully created!");
                    ClearText();//Clears textbox text.
                }
            }
        }
    }
}
