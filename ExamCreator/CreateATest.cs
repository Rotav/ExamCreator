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
        //Initialise variables
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
                int level;
                //set values for each level provided by radio buttons
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

                DataRow dr = ds.Tables[0].NewRow(); //creates new row in tblTest table
                
                dr[1] = txt_Title.Text; //Stores Question Title into the datarow.
                dr[2] = level; //Stores Question level into the datarow.
                dr[3] = txt_Description.Text; //Stores the Question description into the datarow.
                
                ds.Tables[0].Rows.Add(dr); //adds row to the tblTest table.

                try
                {
                    objConnector.UpdateDatabase(ds);//update the database with new dataset.            
                    int rows = ds.Tables[0].Rows.Count;
                    MessageBox.Show("Your test has been successfully created!");
                    TestBuilder testbuilder = new TestBuilder(rows, teacherID);
                    testbuilder.Show();
                }
                catch(Exception err)
                {
                    MessageBox.Show("An error has occured: " + err.ToString());
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void CreateATest_Load(object sender, EventArgs e)
        {
            objConnector = new DatabaseConnectioncs();//Creates a new object from the Database connection class.
            stringConnector = Settings.Default.DBConn;//passes the database's file path directory into the stringConnector variable.

            objConnector.connection_string = stringConnector;//passes the file path into the database connection object. 
            objConnector.Sql = Settings.Default.SelectQuestions;//passes the SQL query to select all values in QuestionTable into the database connection object.
            
            try
            {
                objConnector = new DatabaseConnectioncs(); ;//Creates a new object from the Database connection class.
                objConnector.connection_string = ExamCreator.Properties.Settings.Default.DBConn;//passes the file path into the database connection object.
                objConnector.Sql = "SELECT * FROM tblTest";//selects all values from the table tblTest and passes it into the database connection object.

                ds = objConnector.GetConnection;//Connects to the database using the objConnector object.
            }
            catch (Exception err)
            {
                MessageBox.Show("An error has occured: " + err.Message);
            }
        }
    }
}