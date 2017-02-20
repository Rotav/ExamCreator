using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamCreator
{
    public partial class QuestionCreator : Form
    {
        //Initialise variables
        DatabaseConnectioncs objConnector;

        DataSet ds;

        int maxRows;
        
        public QuestionCreator()
        {
            InitializeComponent();
        }

        private void QuestionCreator_Load(object sender, EventArgs e)
        {
            try
            {
                objConnector = new DatabaseConnectioncs();//Creates a new object from the Database connection class.
                
                //Passes the database's file path directory into the database connection object. 
                objConnector.connection_string = ExamCreator.Properties.Settings.Default.DBConn;
                
                objConnector.Sql = "SELECT * FROM QuestionTable";//Selects all values from the table QuestionTable and passes it into the database connection object.

                ds = objConnector.GetConnection;//Connects to the database using the objConnector class.
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        /// <summary>
        /// Writes the inputted data for the question into the QuestionTable when the user clicks the submit button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SubmitQuestion_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables[0].NewRow();//Creates a new row in the QuestionTable.
            
            dr[1] = tbar_Difficulty.Value; //Writes the question's difficulty into the new row in QuestionTable.
            dr[2] = txt_QuestionTitle.Text; //Writes the question's title into the new row in QuestionTable.
            dr[3] = txt_Question.Text; //Writes the question's text into the new row in QuestionTable.
            dr[4] = num_Mark.Value; //Writes the question's mark into the new row in QuestionTable.
            dr[5] = lb_Topics.SelectedItem; //Writes the question's assigned topic into the new row in QuestionTable.
            
            ds.Tables[0].Rows.Add(dr); //Adds a new row to QuestionTable.

            try
            {
                objConnector.UpdateDatabase(ds);//Updates the database.
                MessageBox.Show("Your question has been added!");
            }
            catch
            {
                MessageBox.Show("Please fill in all of the empty fields");
            }
             
        }
    }
}
