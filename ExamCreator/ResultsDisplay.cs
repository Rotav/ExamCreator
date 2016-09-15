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
        private int teacherID = 0;

        DatabaseConnectioncs objConnector;
        DatabaseConnectioncs objConnector2;
        DataSet ds;
        DataSet ds2;

        string selectedTab = "";
        int tabNum = 1;

        public ResultsDisplay(int TeacherID)
        {
            teacherID = TeacherID;

            InitializeComponent();
            CreateTabs();
            AddResults();
        }

        private void CreateTabs()
        {
            string query = "SELECT * FROM tblStudent";

            try
            {
                objConnector = new DatabaseConnectioncs();
                objConnector.connection_string = ExamCreator.Properties.Settings.Default.DBConn;
                objConnector.Sql = query;

                ds = objConnector.GetConnection;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                tb_Results.TabPages.Add(dr["Username"].ToString());
                tb_CompletedResults.TabPages.Add(dr["Username"].ToString());
            }
        }

        private void AddResults()
        {
            LoopTabpages(false);
            LoopTabpages(true);
        }

        private bool LoopTabpages(bool completedResultsTabPage)
        {
            int i = 0;
            DataRow dr2;

            if (completedResultsTabPage)
            {
                foreach (TabPage tab in tb_Results.TabPages)
                {
                    string query = "SELECT * FROM tblStudent";

                    objConnector = new DatabaseConnectioncs();
                    objConnector.connection_string = ExamCreator.Properties.Settings.Default.DBConn;
                    objConnector.Sql = query;

                    ds = objConnector.GetConnection;

                    dr2 = ds.Tables[0].Rows[i];
                    string student = dr2["Id"].ToString();

                    int studentID;
                    Int32.TryParse(student, out studentID);

                    string query2 = "SELECT *" +
                    " FROM tblTest a, tblStudentTests s" +
                    " WHERE a.TestId = s.TestId" +
                    " AND s.StudentID = " + studentID.ToString() +
                    " AND s.TeacherID = " + teacherID.ToString() +
                    " AND s.Completed = 1";

                    objConnector2 = new DatabaseConnectioncs();
                    objConnector2.connection_string = ExamCreator.Properties.Settings.Default.DBConn;
                    objConnector2.Sql = query2;


                    ds = objConnector2.GetConnection;

                    DataTable dt = new DataTable();

                    dt = ds.Tables[0];

                    foreach (DataRow dr1 in dt.Rows)
                    {
                        FlowLayoutPanel flp = new FlowLayoutPanel();
                        flp.Dock = DockStyle.Fill;

                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            Label label = new Label();
                            label.Text = "There are no tests in this tab.";

                            flp.Controls.Add(label);
                        }
                        else
                        {
                            foreach (DataRow dr in ds.Tables[0].Rows)
                            {
                                TestButton button = new TestButton();
                                button.Size = new Size(250, 50);
                                button.Text = dr["TestTitle"].ToString() + "    " + dr["Description"].ToString();

                                int testID;
                                Int32.TryParse(dr["TestID"].ToString(), out testID);
                                button.TestId = testID;

                                int studentTestID;
                                Int32.TryParse(dr["Id"].ToString(), out studentTestID);
                                button.StudentTestID = studentTestID;

                                button.StudentID = studentID;

                                button.Click += new EventHandler(this.OpenResults);

                                flp.Controls.Add(button);
                            }

                            tab.Controls.Add(flp);

                        }
                    }
                    i++;
                }
            }
            else
            {
                foreach (TabPage tab in tb_CompletedResults.TabPages)
                {
                    string query = "SELECT * FROM tblStudent";

                    objConnector = new DatabaseConnectioncs();
                    objConnector.connection_string = ExamCreator.Properties.Settings.Default.DBConn;
                    objConnector.Sql = query;

                    ds = objConnector.GetConnection;

                    dr2 = ds.Tables[0].Rows[i];
                    string student = dr2["Id"].ToString();

                    int studentID;
                    Int32.TryParse(student, out studentID);

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

                    foreach (DataRow dr1 in dt.Rows)
                    {
                        FlowLayoutPanel flp = new FlowLayoutPanel();
                        flp.Dock = DockStyle.Fill;

                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            Label label = new Label();
                            label.Text = "There are no tests in this tab.";

                            flp.Controls.Add(label);
                        }
                        else
                        {
                            foreach (DataRow dr in ds.Tables[0].Rows)
                            {
                                TestButton button = new TestButton();
                                button.Size = new Size(250, 50);
                                button.Text = dr["TestTitle"].ToString() + "    " + dr["Description"].ToString();

                                int testID;
                                Int32.TryParse(dr["TestID"].ToString(), out testID);
                                button.TestId = testID;

                                int studentTestID;
                                Int32.TryParse(dr["Id"].ToString(), out studentTestID);
                                button.StudentTestID = studentTestID;

                                button.StudentID = studentID;

                                button.Click += new EventHandler(this.OpenResultStats);

                                flp.Controls.Add(button);
                            }

                            tab.Controls.Add(flp);

                        }
                    }
                    i++;
                }
            }
            return false;
        }

        private void OpenResults(Object sense, EventArgs e)
        {
            TestButton button = sense as TestButton;

            selectedTab = tb_Results.SelectedTab.Text.ToString();
            MessageBox.Show(selectedTab);

            int i = 1;
            foreach (TabPage tab in tb_Results.TabPages)
            {
                MessageBox.Show(tab.Text);
                if (selectedTab == tab.Text)
                {
                    tabNum = i;
                    break;
                }
                i++;
            }

            MessageBox.Show(tabNum.ToString());
            MessageBox.Show("StudentTestID: " + button.StudentTestID + "\nstudentID: " + tabNum);

            MarkingForm markingform = new MarkingForm(button.TestId, tabNum);
            markingform.Show();
        }

        private void OpenResultStats(Object sense, EventArgs e)
        {
            TestButton button = sense as TestButton;

            selectedTab = tb_CompletedResults.SelectedTab.Text.ToString();

            int i = 1;
            
            foreach (TabPage tab in tb_CompletedResults.TabPages)
            {
                MessageBox.Show(tab.Text);
                if (selectedTab == tab.Text)
                {
                    MessageBox.Show(selectedTab + " " + tab.Text + " Mission complete!");
                    tabNum = i;
                    break;
                }
                i++;
            }

            ResultStats resultstats = new ResultStats(button.TestId, tabNum);
            resultstats.Show();
        }
    }
}
