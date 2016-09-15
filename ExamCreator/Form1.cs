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
        DataRow dataResult;

        DatabaseConnectioncs objConnector2;
        string stringConnector2;

        DataSet ds2;
        DataRow dr2;

        int maxRows2;
        DataRow dataResult2;

        bool correct = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void CheckTable(string button)
        {
            correct = false;
            if (button == "teacher")
            {
                for (int i = 0; i < maxRows; i++)
                {
                    dr = ds.Tables[0].Rows[i]; 
                    if (txt_Username.Text == dr.ItemArray.GetValue(1).ToString() && txt_Password.Text == dr.ItemArray.GetValue(2).ToString())
                    { //checks if the database has the same values as what has been entered into the textboxes.
                        dataResult = dr;
                        correct = true;
                        break;
                    }
                }
                if (correct)
                {
                    int teachID;
                    Int32.TryParse(dr["Id"].ToString(), out teachID);
                    MainMenuTeacher mainmenu = new MainMenuTeacher(teachID);
                    mainmenu.Show();
                }
                else
                {
                    MessageBox.Show("The username or password is incorrect or does not exist.");
                }
            }
            if (button == "student")
            {
                for (int i = 0; i < maxRows2; i++)
                {
                    dr2 = ds2.Tables[0].Rows[i];
                    if (txt_Username.Text == dr2.ItemArray.GetValue(1).ToString() && txt_Password.Text == dr2.ItemArray.GetValue(2).ToString())
                    {
                        dataResult2 = dr2;
                        correct = true;
                        break;
                    }
                }
                if (correct)
                {
                    int studentId;
                    Int32.TryParse(dr2["Id"].ToString(), out studentId);
                    MessageBox.Show("studentID: " + studentId);
                    MainMenuStudent mainmenu = new MainMenuStudent(studentId);
                    mainmenu.Show();
                }
                else
                {
                    MessageBox.Show("The username or password is incorrect or does not exist.");
                }
            }
        }

        private void btn_Lbtn_Loginogin_Click(object sender, EventArgs e)
        {
            CheckTable("student");
        }

        private void btn_LoginTeacher_Click(object sender, EventArgs e)
        {
            CheckTable("teacher");
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

            try
            {
                objConnector2 = new DatabaseConnectioncs();
                stringConnector2 = Settings.Default.DBConn;

                objConnector2.connection_string = stringConnector2;
                objConnector2.Sql = Settings.Default.SelectStudent;

                ds2 = objConnector2.GetConnection;
                maxRows2 = ds2.Tables[0].Rows.Count;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
