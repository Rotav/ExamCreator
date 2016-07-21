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
    public partial class SendTest : Form
    {
        DatabaseConnectioncs objConnector;
        string stringConnector;
        DataSet ds;
        DatabaseConnectioncs objConnector2;
        
        public int testID;
        public int teacherID;

        public SendTest(int TestID, int TeacherID)
        {
            testID = TestID;
            teacherID = TeacherID;

            InitializeComponent();
        }

        private void SendTest_Load(object sender, EventArgs e)
        {
            objConnector = new DatabaseConnectioncs();
            stringConnector = Settings.Default.DBConn;
            objConnector.connection_string = stringConnector;
            objConnector.Sql = Settings.Default.SelectStudent;
            dg_Students.DataSource = objConnector.StudentTableBindingSource();

            objConnector = new DatabaseConnectioncs();
            stringConnector = Settings.Default.DBConn;

            objConnector2 = new DatabaseConnectioncs();

            objConnector2.connection_string = stringConnector;

            objConnector2.Sql = "SELECT * FROM tblStudentTests";

            ds = objConnector2.GetConnection;
        }

        private void btn_AddToList_Click(object sender, EventArgs e)
        {
            string UserValue = dg_Students["Username", dg_Students.CurrentRow.Index].Value.ToString();
            
            if (lb_SendUsers.Items.Contains(UserValue))
            {
                MessageBox.Show("This user has already been addded to the list.");
            }
            else
            {
                lb_SendUsers.Items.Add(UserValue);
            }
   
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            lb_SendUsers.Items.Remove(lb_SendUsers.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lb_SendUsers.Items == null)
            {
                MessageBox.Show("You must have at least one question in the test to complete it.");
            }
            else
            {
                foreach (string item in lb_SendUsers.Items)
                {
                    DataRow dr = ds.Tables[0].NewRow();

                    int rowIndex = -1;
                    foreach (DataGridViewRow row in dg_Students.Rows)
                    {
                        if (row.Cells[1].Value.ToString().Equals(item))
                        {
                            rowIndex = row.Index;
                            break;
                        }
                    }

                    string i2 = dg_Students["Id", rowIndex].Value.ToString();
                    int i3;
                    Int32.TryParse(i2, out i3);

                    dr[1] = testID;//Test ID
                    dr[2] = i3; //Student ID
                    dr[3] = teacherID; //Teacher ID

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
                MessageBox.Show("Test successfully sent!");
            }
        }
    }
}
