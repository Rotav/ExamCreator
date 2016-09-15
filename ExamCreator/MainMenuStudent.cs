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

        private void CreateTabs()
        {
            string query = "SELECT * FROM tblTestLevel";

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
                tb_Menu.TabPages.Add(dr["Level"].ToString());
            }
        }

        private void AddTests()
        {
            int i = 1;

            foreach (TabPage tab in tb_Menu.TabPages)
            {
                string query2 = "SELECT *" +
                    " FROM tblTest t, tblStudentTests s" +
                    " WHERE s.StudentId = " + studentID.ToString() +
                    " AND t.TestId = s.TestId" +
                    " AND t.LevelId = " + i.ToString() +
                    " AND s.Completed = 0";

                objConnector2 = new DatabaseConnectioncs();
                objConnector2.connection_string = ExamCreator.Properties.Settings.Default.DBConn;
                objConnector2.Sql = query2;

                ds = objConnector2.GetConnection; //calls Database connection class

                FlowLayoutPanel flp = new FlowLayoutPanel();
                flp.Dock = DockStyle.Fill;

                if (ds.Tables[0].Rows.Count == 0)
                {
                    Label label = new Label();
                    label.Text = "There are no tests at this level.";
                    label.AutoSize = true;

                    flp.Controls.Add(label);//creates label
                }
                else
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        TestButton button = new TestButton();
                        button.Size = new Size(250, 50);
                        button.Text = dr["TestTitle"].ToString() + "    " + dr["Description"].ToString();
                        
                        int testID;
                        Int32.TryParse(dr["TestId"].ToString(), out testID);
                        button.TestId = testID;

                        int studentTestID;
                        Int32.TryParse(dr["Id"].ToString(), out studentTestID);
                        button.StudentTestID = studentTestID;

                        button.Click += new EventHandler(this.OpenTest);

                        flp.Controls.Add(button);
                    }
                }

                tab.Controls.Add(flp);
                i = i+3;
            }
        }

        private void OpenTest(Object sense, EventArgs e)
        {
            TestButton button = sense as TestButton;
            Test test = new Test(button.TestId, button.StudentTestID, studentID); //opens test form, passes values 
            test.Show();
        }

        private void MainMenuStudent_Load(object sender, EventArgs e)
        {
            objConnector = new DatabaseConnectioncs();
            objConnector.connection_string = ExamCreator.Properties.Settings.Default.DBConn;
            objConnector.Sql = "SELECT * FROM tblTest";

            ds = objConnector.GetConnection;
        }
    }
}
