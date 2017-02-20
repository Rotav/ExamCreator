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
    public partial class MainMenuStudent : Form
    {
        //Initialise variables
        DatabaseConnectioncs objConnector;
        DatabaseConnectioncs objConnector2;

        string stringConnector;
        DataSet ds;
        private int studentID;

        public MainMenuStudent(int Studentid)
        {
            studentID = Studentid;
            InitializeComponent();
            CreateTabs();
            AddTests();
        }

        /// <summary>
        /// Dynamically creates the tabs used on the form 
        /// </summary>
        private void CreateTabs()
        {
            string query = "SELECT * FROM tblTestLevel";//Search for all values inside the table tblTestLevel

            try
            {
                objConnector = new DatabaseConnectioncs();//Creates a new object from the Database connection class.
                objConnector.connection_string = ExamCreator.Properties.Settings.Default.DBConn;//passes the database's file path directory into the database connection object.
                objConnector.Sql = query;//passes the SQL query to select all values in tblTestLevel into the database connection object.

                ds = objConnector.GetConnection;//Connects to the database using the objConnector class.
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            //Loops through each value in tblTestLevel and adds a tab to tb_Menu with the text value of the current row of the "Level" column in the table
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                tb_Menu.TabPages.Add(dr["Level"].ToString());
            }
        }

        /// <summary>
        /// Dynamically adds each form as a button into the corresponding tab
        /// </summary>
        private void AddTests()
        {
            int i = 1;

            foreach (TabPage tab in tb_Menu.TabPages)
            {
                string query2 = "SELECT *" +//Select all rows...
                    " FROM tblTest t, tblStudentTests s" +//...from the tables tblTest and tblStudentTests
                    " WHERE s.StudentId = " + studentID.ToString() +//limits results by selecting values with the same StudentID that the student has logged in with
                    " AND t.TestId = s.TestId" +//limits results by making sure that the TestID in tblTest and tblStudentTests are the same
                    " AND t.LevelId = " + i.ToString() +//limits results by making sure that the levelID in tblTest is equal to the value of i, which is incremented by 3 with each loop
                    " AND s.Completed = 0";//limits results by only selecting rows with the Completed column int tblStudentTests being equal to false (0).

                objConnector2 = new DatabaseConnectioncs();
                objConnector2.connection_string = ExamCreator.Properties.Settings.Default.DBConn;
                objConnector2.Sql = query2;

                ds = objConnector2.GetConnection; //calls Database connection class

                FlowLayoutPanel flp = new FlowLayoutPanel();
                flp.Dock = DockStyle.Fill;

                if (ds.Tables[0].Rows.Count == 0)//if there are no tests in the current level...
                {
                    //...create a label inside the tabpage to tell the user there aren't any tests at this level
                    Label label = new Label();
                    label.Text = "There are no tests at this level.";
                    label.AutoSize = true;

                    flp.Controls.Add(label);//creates label
                }
                else
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {//loops through each row in the dataset, defined by query2
                        TestButton button = new TestButton();//uses TestButton class to produce a button
                        button.Size = new Size(250, 50);
                        button.Text = dr["TestTitle"].ToString() + "    " + dr["Description"].ToString();//determines the value of the button's text by using the current row's TestTile and Description values
                        
                        int testID;
                        Int32.TryParse(dr["TestId"].ToString(), out testID);
                        button.TestId = testID;

                        int studentTestID;
                        Int32.TryParse(dr["Id"].ToString(), out studentTestID);
                        button.StudentTestID = studentTestID;

                        button.Click += new EventHandler(this.OpenTest);//adds an event that occurs if the user clicks the button

                        flp.Controls.Add(button);//adds the button to the current tabpage
                    }
                }

                tab.Controls.Add(flp);//adds the tab to the tabpage in the form
                i = i+3;
            }
        }

        
        private void OpenTest(Object sense, EventArgs e)
        {
            TestButton button = sense as TestButton;
            Test test = new Test(button.TestId, button.StudentTestID, studentID); //opens test form and passes values if the user clicks the button
            test.Show();
        }

        private void MainMenuStudent_Load(object sender, EventArgs e)
        {
            objConnector = new DatabaseConnectioncs();
            objConnector.connection_string = ExamCreator.Properties.Settings.Default.DBConn;
            objConnector.Sql = "SELECT * FROM tblTest";//selects all values in the table tblTest

            ds = objConnector.GetConnection;
        }
    }
}
