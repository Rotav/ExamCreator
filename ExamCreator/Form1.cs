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
        DatabaseConnectioncs objConnector;
        string stringConnector;

        DataSet ds;
        DataRow dr;

        int maxRows;
        bool correct = false;
        DataRow dataResult;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Lbtn_Loginogin_Click(object sender, EventArgs e)
        {
        }

        private void btn_LoginTeacher_Click(object sender, EventArgs e)
        {
            correct = false;
            for (int i = 0; i < maxRows; i++)
            {
                dr = ds.Tables[0].Rows[i];
                if (txt_Username.Text == dr.ItemArray.GetValue(1).ToString() && txt_Password.Text == dr.ItemArray.GetValue(2).ToString())
                {
                    dataResult = dr;
                    correct = true;
                    break;
                }
            }

            if (correct)
            {
                MainMenuTeacher mainmenu = new MainMenuTeacher();
                mainmenu.Show();
            }
            else if (txt_Username.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("You must enter text into each field.");
            }
            else
            {
                MessageBox.Show("The username or password is incorrect or does not exist.");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ActiveControl = txt_Username;
            try
            {
                objConnector = new DatabaseConnectioncs();
                stringConnector = Settings.Default.DBConn;

                objConnector.connection_string = stringConnector;
                objConnector.Sql = Settings.Default.SelectTeachers;

                ds = objConnector.GetConnection; 
                maxRows = ds.Tables[0].Rows.Count;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void lbl_Password_Click(object sender, EventArgs e)
        {
            QuestionCreator questioncreator = new QuestionCreator();
            questioncreator.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MainMenuTeacher mainmenu = new MainMenuTeacher();
            mainmenu.Show();
        }
    }
}
