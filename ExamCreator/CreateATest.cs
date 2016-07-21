using ExamCreator.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamCreator
{
    public partial class CreateATest : Form
    {
        DatabaseConnectioncs objConnector;
        string stringConnector;

        DataSet ds;

        private int teacherID;
        public CreateATest(int TeacherID)
        {
            teacherID = TeacherID;

            InitializeComponent();
        }

        private void btn_CreateTest_Click(object sender, EventArgs e)
        {
            if (txt_Title.Text == "")
            {
                MessageBox.Show("You must enter a test title in order to create a test");
            }
            else
            {
                bool privacy = true;

                if (rb_Public.Checked == true)
                {
                    privacy = true;
                }
                else
                {
                    privacy = false;
                }

                int level;

                if (rb_GCSE.Checked == true)
                {
                    level = 7;
                }
                else if (rb_AS.Checked == true)
                {
                    level = 1;
                }
                else
                {
                    level = 4;
                }

                DataRow dr = ds.Tables[0].NewRow(); //creates new row in table
                
                dr[1] = privacy;//privacy
                dr[2] = txt_Title.Text; //Question Title
                dr[3] = level; //Question level
                dr[4] = txt_Description.Text; //Question description 
                
                ds.Tables[0].Rows.Add(dr); //adds row to table

                try
                {
                    objConnector.UpdateDatabase(ds);            
                    int rows = ds.Tables[0].Rows.Count;
                    MessageBox.Show("Your test has been successfully created!");
                    TestBuilder testbuilder = new TestBuilder(rows, teacherID);
                    testbuilder.Show();
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CreateATest_Load(object sender, EventArgs e)
        {
            objConnector = new DatabaseConnectioncs();
            stringConnector = Settings.Default.DBConn;

            objConnector.connection_string = stringConnector;
            objConnector.Sql = Settings.Default.SelectQuestions;
            dataGridView1.DataSource = objConnector.MyBindingSource();
            
            try
            {
                objConnector = new DatabaseConnectioncs();
                objConnector.connection_string = ExamCreator.Properties.Settings.Default.DBConn;
                objConnector.Sql = "SELECT * FROM tblTest";

                ds = objConnector.GetConnection;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rb_Public_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_Private_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}