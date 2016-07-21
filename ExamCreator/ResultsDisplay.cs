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
        DatabaseConnectioncs objConnector;
        DatabaseConnectioncs objConnector2;
        DataSet ds;

        public ResultsDisplay()
        {
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

            int i = 1;

            foreach (TabPage tab in tb_Results.TabPages)
            {
                string query = "SELECT Id FROM tblStudent WHERE Username = " + tab.Text;

                objConnector = new DatabaseConnectioncs();
                objConnector.connection_string = ExamCreator.Properties.Settings.Default.DBConn;
                objConnector.Sql = query;

                ds = objConnector.GetConnection;

                DataRow dr1 = ds.Tables[0].Rows[0];
                string student = dr1["Id"].ToString();
                Debug.WriteLine(student);
                int studentID;
                Int32.TryParse(student, out studentID);

                string query2 = "SELECT *" +
                " FROM tblTest t, tblStudentTests s" +
                " WHERE t.TestId = s.TestId" +
                " AND s.StudentID = " + studentID +
                " AND s.Completed = 1";

                objConnector2 = new DatabaseConnectioncs();
                objConnector2.connection_string = ExamCreator.Properties.Settings.Default.DBConn;
                objConnector2.Sql = query2;


                ds = objConnector2.GetConnection;

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

                        button.Click += new EventHandler(this.OpenResults);

                        flp.Controls.Add(button);
                    }
                }

                tab.Controls.Add(flp);
                i = i + 3;
            }
        }

        private void OpenResults(Object sense, EventArgs e)
        {
            TestButton button = sense as TestButton;
            MarkingForm markingform = new MarkingForm(button.TestId, button.StudentTestID);
            markingform.Show();
        }
    }
}
