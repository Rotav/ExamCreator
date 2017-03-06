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
        //Initialise variables
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

        /// <summary>
        /// Removes selected item from the listbox when this button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DeleteQuestion_Click(object sender, EventArgs e)
        {
            lb_QuestionList.Items.Remove(lb_QuestionList.SelectedItem);
        }

        private void TestBuilder_Load(object sender, EventArgs e)
        {
            objConnector = new DatabaseConnectioncs();//Creates a new object from the Database connection class.
            stringConnector = Settings.Default.DBConn;//passes the database's file path directory into the stringConnector variable.

            objConnector.connection_string = stringConnector;//passes the file path into the database connection object. 
            objConnector.Sql = Settings.Default.SelectQuestions;//passes the SQL query to select all values in QuestionTable into the database connection object.
            dg_Public.DataSource = objConnector.StudentBindingSource();//Adds the QuestionTable values to the datagrid.

            objConnector2 = new DatabaseConnectioncs();//Creates a new object from the Database connection class.

            objConnector2.connection_string = stringConnector;

            objConnector2.Sql = "SELECT * FROM tblTestQuestion";//selects all values from the table tblTestQuestion and passes it into the database connection object.

            ds = objConnector2.GetConnection;//Connects to the database using the objConnector2 class.
        }

        /// <summary>
        /// Adds a question to the listbox when the user clicks the add question button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            if (lb_QuestionList.Items.Count <= 0) //If there are no items in the listbox...
            {
                MessageBox.Show("You must have at least one question in the test to complete it.");//...Send error message
            }
            else
            {
                foreach (string item in lb_QuestionList.Items)//...Otherwise, loop through each item in the listbox.
                {
                    DataRow dr = ds.Tables[0].NewRow();//adds a new row 

                    int rowIndex = -1;
                    foreach(DataGridViewRow row in dg_Public.Rows)//searches through each row in the datagrid
                    {
                        if(row.Cells[2].Value.ToString().Equals(item))//if a row is equal to one of the values in the datagrid...
                        {
                            rowIndex = row.Index;//sets the rowIndex value equal to the index of the row found.
                            break;
                        }
                    }

                    

                    string i2 = dg_Public["id", rowIndex].Value.ToString();//finds the cell that contains the value needed (the question's ID).
                    int i3;
                    Int32.TryParse(i2, out i3);

                    dr[1] = testID;//Stores Test ID into the datarow.
                    dr[2] = i3; //Stores Question ID into the datarow.

                    ds.Tables[0].Rows.Add(dr);//adds row to tblTestQuestion

                    try
                    {
                        objConnector2.UpdateDatabase(ds);//Updates the database.
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
        }
    }
}