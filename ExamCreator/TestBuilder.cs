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
    public partial class TestBuilder : Form
    {

        DatabaseConnectioncs objConnector;
        DatabaseConnectioncs objConnector2;
        string stringConnector;
        public int testID;

        DataSet ds;

        int teacherID;

        public TestBuilder(int TestID, int TeacherID)
        {
            testID = TestID;
            teacherID = TeacherID;

            InitializeComponent();
        }

        private void btn_DeleteQuestion_Click(object sender, EventArgs e)
        {
            lb_QuestionList.Items.Remove(lb_QuestionList.SelectedItem);
        }

        private void TestBuilder_Load(object sender, EventArgs e)
        {
            objConnector = new DatabaseConnectioncs();
            stringConnector = Settings.Default.DBConn;

            objConnector.connection_string = stringConnector;
            objConnector.Sql = Settings.Default.SelectQuestions;
            dg_Public.DataSource = objConnector.StudentBindingSource();

            objConnector2 = new DatabaseConnectioncs();

            objConnector2.connection_string = stringConnector;

            objConnector2.Sql = "SELECT * FROM tblTestQuestion";

            ds = objConnector2.GetConnection;
        }

        private void btn_AddQuestion_Click(object sender, EventArgs e)
        {
            string cellValue = dg_Public["QuestionTitle", dg_Public.CurrentRow.Index].Value.ToString();
            if (lb_QuestionList.Items.Contains(cellValue))
            {
                MessageBox.Show("This question has already been addded to the list.");
            }
            else
            {
                lb_QuestionList.Items.Add(cellValue);  
            }
                      
        }

        private void btn_Complete_Click(object sender, EventArgs e)
        {
            if (lb_QuestionList.Items == null) 
            {
                MessageBox.Show("You must have at least one question in the test to complete it.");
            }
            else
            {
                foreach (string item in lb_QuestionList.Items)
                {
                    DataRow dr = ds.Tables[0].NewRow();

                    int rowIndex = -1;
                    foreach(DataGridViewRow row in dg_Public.Rows)
                    {
                        if(row.Cells[2].Value.ToString().Equals(item))
                        {
                            rowIndex = row.Index;
                            break;
                        }
                    }

                    

                    string i2 = dg_Public["id", rowIndex].Value.ToString();
                    int i3;
                    Int32.TryParse(i2, out i3);

                    dr[1] = testID;//Test ID
                    dr[2] = i3; //Question ID

                    ds.Tables[0].Rows.Add(dr);

                    try
                    {
                        objConnector2.UpdateDatabase(ds);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.ToString());
                    }
                }
                SendTest sendtest = new SendTest(testID, teacherID);
                sendtest.Show();
            }
        }

        private void lb_QuestionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string content = lb_QuestionList.GetItemText(lb_QuestionList.SelectedItem);
            lab_QuestionContent.Text = lb_QuestionList.GetItemText(lb_QuestionList.SelectedItem);
            lab_Mark.Text = lb_QuestionList.GetItemText(lb_QuestionList.SelectedItem);
        }
    }
}
