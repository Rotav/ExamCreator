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
        //Initialise variables 
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
            objConnector = new DatabaseConnectioncs();//Creates a new object from the database connection class.

            //passes the database's file path directory into the database connection class.
            stringConnector = Settings.Default.DBConn;
            objConnector.connection_string = stringConnector;
            
            objConnector.Sql = Settings.Default.SelectStudent;//Uses the SelectStudent query for the database connection object. 
            
            dg_Students.DataSource = objConnector.StudentTableBindingSource();//Displays the datagrid with the values of the tblStudent table. 

            
            objConnector2 = new DatabaseConnectioncs();

            objConnector2.connection_string = stringConnector;

            objConnector2.Sql = "SELECT * FROM tblStudentTests";//Selects all the values in the tblStudentTests table and uses the query for the database connection object.

            ds = objConnector2.GetConnection;//Connects to the database using the objConnector2 class.
        }

        private void btn_AddToList_Click(object sender, EventArgs e)
        {
            string UserValue = dg_Students["Username", dg_Students.CurrentRow.Index].Value.ToString();//stores the currently selected datagrid value into the UserValue string variable.
            
            if (lb_SendUsers.Items.Contains(UserValue))//If the selected value is already inside the listbox...
            {
                MessageBox.Show("This user has already been addded to the list.");//...Display error message.
            }
            else
            {
                lb_SendUsers.Items.Add(UserValue);//Otherwise add the string to the listbox as a new item.
            }
   
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            lb_SendUsers.Items.Remove(lb_SendUsers.SelectedItem);//deletes the item selected by the user in the listbox.
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (lb_SendUsers.Items == null)//If there are no items in the listbox...
            {
                MessageBox.Show("You must have at least one student in the list in order to send the test.");//...Display error message.
            }
            else
            {
                foreach (string item in lb_SendUsers.Items)//loops through every item (student user) in the list.
                {
                    DataRow dr = ds.Tables[0].NewRow();//Creates a new row in tblStudentTests.

                    int rowIndex = -1;
                    foreach (DataGridViewRow row in dg_Students.Rows)//loops through each row in the student datagrid.
                    {
                        if (row.Cells[1].Value.ToString().Equals(item))//If the item in the listbox is equal to the current row of the datagrid in the loop...
                        {
                            rowIndex = row.Index;//...Set the index of the current row in the datagrid to the rowIndex variable.
                            break;
                        }
                    }

                    string i2 = dg_Students["Id", rowIndex].Value.ToString();//Initialises the i2 variable using the Student ID value of the current rowIndex.
                    int i3;
                    Int32.TryParse(i2, out i3);//Parses the string value of the student's ID to an integer.

                    //Write values into the datarow:
                    dr[1] = testID;
                    dr[2] = i3;
                    dr[3] = teacherID;

                    ds.Tables[0].Rows.Add(dr);//Add datarow to tblStudentTests.

                    try
                    {
                        objConnector2.UpdateDatabase(ds);//Updates the database.
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("An Error has occured when sending the test\n Error: " + err.ToString());
                    }
                }
                MessageBox.Show("Test successfully sent!");//Error message telling the user that the test has been successfully sent to all selected students.
            }
        }
    }
}
