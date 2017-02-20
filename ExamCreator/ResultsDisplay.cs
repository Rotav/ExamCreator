using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamCreator
{
    public partial class ResultsDisplay : Form
    {
        //Initialise variables.
        private int teacherID = 0;

        DatabaseConnectioncs objConnector;
        DatabaseConnectioncs objConnector2;
        DataSet ds;

        string selectedTab = "";

        public ResultsDisplay(int TeacherID)
        {
            teacherID = TeacherID;

            InitializeComponent();
            CreateTabs();
            AddResults();
        }

        /// <summary>
        /// Dynamically creates the tabs by searching for all of the student users in tblStudent.
        /// </summary>
        private void CreateTabs()
        {
            string query = "SELECT * FROM tblStudent"; //Selects all the rows in tblStudent

            try
            {
                objConnector = new DatabaseConnectioncs(); //Creates a new object from the Database connection class.

                //Passes the database's file path directory into the database connection object. 
                objConnector.connection_string = ExamCreator.Properties.Settings.Default.DBConn;
                objConnector.Sql = query; //passes the SQL query into the database connection object.

                ds = objConnector.GetConnection;//Connects to the database using the objConnector class.
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            //Loops through every row in tblStudent.
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                //Adds the username of the student in the current row of the table.
                tb_Results.TabPages.Add(dr["Username"].ToString());
                tb_CompletedResults.TabPages.Add(dr["Username"].ToString());
            }
        }

        private void AddResults()
        {
            LoopTabpages(false);
            LoopTabpages(true);
        }

        /// <summary>
        /// Loops through each tab to make sure that each student tab contains the correct tests. 
        /// </summary>
        /// <param name="completedResultsTabPage"></param>
        /// <returns></returns>
        private bool LoopTabpages(bool completedResultsTabPage)
        {
            int i = 0;
            DataRow dr2;

            if (completedResultsTabPage)
            {
                foreach (TabPage tab in tb_Results.TabPages)//loops through each tab in the tb_results tabpages.
                {
                    string query = "SELECT * FROM tblStudent";//Selects every row in tblStudent.

                    objConnector = new DatabaseConnectioncs();//Creates a new object from the database connection class.
                    objConnector.connection_string = ExamCreator.Properties.Settings.Default.DBConn;//passes the database's file path directory into the database connection class.
                    objConnector.Sql = query;//passes the SQL query into the database connection object.

                    ds = objConnector.GetConnection;//Connects to the database using the objConnector class.

                    dr2 = ds.Tables[0].Rows[i];//Writes the current row in the data set into a new dataset 
                    string student = dr2["Id"].ToString();//uses the new dataset to pass the ID value into a string value.

                    int studentID;
                    Int32.TryParse(student, out studentID);

                    string query2 = "SELECT *" + //Select all rows...
                    " FROM tblTest a, tblStudentTests s" + //...From the tables tblTest and tblStudentTests
                    " WHERE a.TestId = s.TestId" + //limits results by selecting rows with the same TestID in tblTest and tblStudentTests.
                    " AND s.StudentID = " + studentID.ToString() + //limits results by selecting rows with the same QuestionID in tblTestAnswers and tblTestQuestion.
                    " AND s.TeacherID = " + teacherID.ToString() +
                    " AND s.Completed = 1"; //Limits results of tblStudentTests by selecting rows that have the Completed column equal to 1 (true).

                    objConnector2 = new DatabaseConnectioncs();
                    objConnector2.connection_string = ExamCreator.Properties.Settings.Default.DBConn;
                    objConnector2.Sql = query2;


                    ds = objConnector2.GetConnection;

                    DataTable dt = new DataTable();

                    dt = ds.Tables[0];

                    foreach (DataRow dr1 in dt.Rows)//loops through each row in the datatable.
                    {
                        FlowLayoutPanel flp = new FlowLayoutPanel();
                        flp.Dock = DockStyle.Fill;

                        if (ds.Tables[0].Rows.Count == 0)//If there are no rows in the datatable...
                        {
                            //...Create a label letting the user know that there is no tests in the tab currently open.
                            Label label = new Label();
                            label.Text = "There are no tests in this tab.";

                            flp.Controls.Add(label);
                        }
                        else
                        {
                            foreach (DataRow dr in ds.Tables[0].Rows)//loops through each row.
                            {
                                //Creates a button for the current test in the row.
                                TestButton button = new TestButton();//Creates a new class using the TestButton object.
                                button.Size = new Size(250, 50);//sets the dimensions of the button in pixels.
                                button.Text = dr["TestTitle"].ToString() + "    " + dr["Description"].ToString();

                                int testID;
                                Int32.TryParse(dr["TestID"].ToString(), out testID);
                                button.TestId = testID; //Writes the testID into the TestButton object.

                                int studentTestID;
                                Int32.TryParse(dr["Id"].ToString(), out studentTestID);
                                button.StudentTestID = studentTestID;//Writes the studentTestID into the TestButton object.

                                button.StudentID = studentID;

                                button.Click += new EventHandler(this.OpenResults); //executes the OpenResults subroutine when the button is pressed.

                                flp.Controls.Add(button); //adds the buttton to the tabpage.
                            }

                            tab.Controls.Add(flp); //adds the FlowLayout Panel to the current tab.

                        }
                    }
                    i++;
                }
            }
            else
            {
                foreach (TabPage tab in tb_CompletedResults.TabPages)//loops through each tab in the tb_CompletedResults tabpages.
                {
                    string query = "SELECT * FROM tblStudent";//Selects every row in tblStudent.

                    objConnector = new DatabaseConnectioncs();//Creates a new object from the database connection class.
                    objConnector.connection_string = ExamCreator.Properties.Settings.Default.DBConn;//passes the database's file path directory into the database connection class.
                    objConnector.Sql = query;//passes the SQL query into the database connection object.

                    ds = objConnector.GetConnection;//Connects to the database using the objConnector class.

                    dr2 = ds.Tables[0].Rows[i];//Writes the current row in the data set into a new dataset 
                    string student = dr2["Id"].ToString();//uses the new dataset to pass the ID value into a string value.

                    int studentID;
                    Int32.TryParse(student, out studentID);

                    //Query is the same as on lines 99-104 above, except that it searches through all of the rows where the Completed column in tblStudentTests is equal to 0 (false).
                    string query2 = "SELECT *" +
                    " FROM tblTest a, tblStudentTests s" +
                    " WHERE a.TestId = s.TestId" +
                    " AND s.StudentID = " + studentID.ToString() +
                    " AND s.TeacherID = " + teacherID.ToString() +
                    " AND s.Completed = 0";

                    objConnector2 = new DatabaseConnectioncs();
                    objConnector2.connection_string = ExamCreator.Properties.Settings.Default.DBConn;
                    objConnector2.Sql = query2;


                    ds = objConnector2.GetConnection;

                    DataTable dt = new DataTable();

                    dt = ds.Tables[0];

                    foreach (DataRow dr1 in dt.Rows)//loops through each row in the datatable.
                    {
                        FlowLayoutPanel flp = new FlowLayoutPanel();
                        flp.Dock = DockStyle.Fill;

                        if (ds.Tables[0].Rows.Count == 0)//If there are no rows in the datatable...
                        {
                            //...Create a label letting the user know that there is no tests in the tab currently open.
                            Label label = new Label();
                            label.Text = "There are no tests in this tab.";

                            flp.Controls.Add(label);
                        }
                        else
                        {
                            foreach (DataRow dr in ds.Tables[0].Rows)
                            {
                                //Creates a button for the current test in the row.
                                TestButton button = new TestButton();//Creates a new class using the TestButton object.
                                button.Size = new Size(250, 50); //sets the dimensions of the button in pixels.
                                button.Text = dr["TestTitle"].ToString() + "    " + dr["Description"].ToString();

                                int testID;
                                Int32.TryParse(dr["TestID"].ToString(), out testID);
                                button.TestId = testID;//Writes the testID into the TestButton object.

                                int studentTestID;
                                Int32.TryParse(dr["Id"].ToString(), out studentTestID);
                                button.StudentTestID = studentTestID;//Writes the studentTestID into the TestButton object.

                                button.StudentID = studentID;

                                button.Click += new EventHandler(this.OpenResultStats);//executes the OpenResultsStats subroutine when the button is pressed.

                                flp.Controls.Add(button);//adds the buttton to the tabpage.
                            }

                            tab.Controls.Add(flp);//adds the FlowLayout Panel to the current tab.

                        }
                    }
                    i++;
                }
            }
            return false;
        }


        /// <summary>
        /// Subroutine which is executed when one of the tests is clicked on in tb_Results. It will send the user to the correct test to mark when the button is clicked.
        /// </summary>
        /// <param name="sense"></param>
        /// <param name="e"></param>
        private void OpenResults(Object sense, EventArgs e)
        {
            TestButton button = sense as TestButton;

            //uses the student and test ID from the button clicked in order to determine what test has been clicked so the MarkingForm can display the correct information.
            MarkingForm markingform = new MarkingForm(button.TestId, button.StudentID);
            markingform.Show();
        }

        /// <summary>
        /// Subroutine which is executed when one of the tests is clicked on in tb_CompletedResults. It will send the user to the correct test to mark when the button is clicked.
        /// </summary>
        /// <param name="sense"></param>
        /// <param name="e"></param>
        private void OpenResultStats(Object sense, EventArgs e)
        {
            TestButton button = sense as TestButton;

            selectedTab = tb_CompletedResults.SelectedTab.Text.ToString();

            //uses the student and test ID from the button clicked in order to determine what test has been clicked so ResultStats can display the correct information.
            ResultStats resultstats = new ResultStats(button.TestId, button.StudentID);
            resultstats.Show();
        }
    }
}