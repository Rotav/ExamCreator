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

    public partial class MarkingForm : Form
    {
        //Initialise variables
        DatabaseConnectioncs objConnector;
        DataSet ds;
        DataSet ds2;

        private int testID = 0;
        private int studentID = 1;

        int questionPointer = 0;
        int maxIndex;

        string[] questions;//stores the test's questions
        int[] questionIDs; //stores the questionIDs for the questions in the test.
        string[] submittedAnswers;//stores the answers to the questions inputted by the user in the test.
        int[] marksGiven;//stores the marks given by the teacher for each question in the test.
        int[] maxMarks;//stores the maximum marks achievable for each question in the test.

        public MarkingForm(int TestID, int StudentID)
        {
            testID = TestID;
            studentID = StudentID;
            
            InitializeComponent();
            FindResults();
            WriteArray();
            ChangeResultValues();
        }

        private void FindResults()
        {
            string query2 = "SELECT *" +//Select all rows...
                            " FROM tblTestQuestion tq, tblTestAnswers a" +//...from the tables tblTestQuestion and tblTestAnswers
                            " WHERE a.QuestionID = tq.QuestionID" +//limits results to by selecting rows with the same QuestionID in both tables
                            " AND a.TestID = tq.TestID" +//limits results by selecting rows with the same TestID in both tables
                            " AND a.StudentID = " + studentID.ToString();//limits results by selecting rows with the same StudentID as the student that the teacher selected in the ResultsDisplay form

            string query = "SELECT *" +//Selects all rows...
                           " FROM tblTestQuestion tq, tblTestAnswers a, QuestionTable q" +//...from the tables tblTestQuestion, tblTestAnswers and QuestionTable
                           " WHERE a.QuestionID = tq.QuestionID" +//limits results by selecting rows with the same QuestionID in tblTestAnswers and tblTestQuestion
                           " AND q.Id = a.QuestionID" +//limits results by selecting rows with the same QuestionID in tblTestAnswers and QuestionTable
                           " AND a.TestID = tq.TestID" +//limits results by selecting rows with the same TestID in tblTestAnswers and tblTestQuestion 
                           " AND a.StudentID = " + studentID.ToString();//limits results by selecting rows with the same StudentID as the student that the teacher selected in the ResultsDisplay form

            objConnector = new DatabaseConnectioncs();//Creates a new object from the Database connection class.
            objConnector.connection_string = ExamCreator.Properties.Settings.Default.DBConn;//passes the database's file path directory into the database connection class.
            objConnector.Sql = query;//passes the SQL query into the database connection object.

            ds = objConnector.GetConnection;//Connects to the database using the objConnector class.

            objConnector = new DatabaseConnectioncs();
            objConnector.connection_string = ExamCreator.Properties.Settings.Default.DBConn;
            objConnector.Sql = query2;

            ds2 = objConnector.GetConnection;

            maxIndex = ds.Tables[0].Rows.Count;//count all the lines defined by the first query and set the number of rows as the maxIndex

            //set all arrays with index value of maxIndex
            questions = new string[maxIndex];
            submittedAnswers = new string[maxIndex];
            questionIDs = new int[maxIndex];
            marksGiven = new int[maxIndex];
            maxMarks = new int[maxIndex];

            int i = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)//loop through each row
            {
                //pass each question into the question array
                questions[i] = dr["QuestionText"].ToString();
                
                //pass each mark value into the designated array
                Int32.TryParse(dr["Id"].ToString(), out questionIDs[i]);
                Int32.TryParse(dr["Mark"].ToString(), out maxMarks[i]);

                submittedAnswers[i] = dr["Answer"].ToString();
                i++;
            }
        }

        /// <summary>
        /// Subroutine that writes to the textboxes in the MarkingForm.
        /// </summary>
        private void WriteArray()
        {
            txt_StudentAnswer.Text = submittedAnswers[questionPointer];
            txt_Question.Text = questions[questionPointer];
        }

        /// <summary>
        /// Changes the values to correctly match the current question selected.
        /// </summary>
        public void ChangeResultValues()
        {
            lb_HighMark.Text = "Highest mark for this question: " + maxMarks[questionPointer];
            lb_QuestionNum.Text = "Question " + (questionPointer + 1).ToString() + " of " + maxIndex.ToString();

            num_Mark.Maximum = maxMarks[questionPointer];//Sets the max value of the numUpDown equal to the max marks of the current question.
            num_Mark.Value = marksGiven[questionPointer];//Sets the value of the numUpDown equal to the currently entered mark by the teacher (default is 1).
        }

        private void btn_RightArrow_Click(object sender, EventArgs e)
        {
            if (questionPointer < maxIndex - 1)//If the user is not on the final question of the test...
            {
                //...Change values in order for the information for the next question to be correct. 
                marksGiven[questionPointer] = Convert.ToInt32(num_Mark.Value);

                questionPointer++;
                WriteArray();
                ChangeResultValues();
            }
            else
            {
                MessageBox.Show("There are no more questions on this test.");//...Otherwise, send error message.
            }
        }

        private void btn_LeftArrow_Click(object sender, EventArgs e)
        {
            if (questionPointer > 0)//If the user is not on the first question of the test...
            {
                //...Change values in order for the information for the previous question to be correct. 
                marksGiven[questionPointer] = Convert.ToInt32(num_Mark.Value);

                questionPointer--;
                WriteArray();
                ChangeResultValues();
            }
            else
            {
                MessageBox.Show("There are no questions before this question.");//...Otherwise, send error message.
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            marksGiven[questionPointer] = Convert.ToInt32(num_Mark.Value);

            DialogResult res = MessageBox.Show("Are you sure you want to submit your the marks given in this test?", "Are you sure?", MessageBoxButtons.YesNo);

            if (res.Equals(DialogResult.Yes))
            {
                //Selects the table tblResults but does not select any of the values (as 1 never equals 2).
                string query = "SELECT * FROM tblResults WHERE 1 = 2";
                
                objConnector.Sql = query;//passes the query into the database connection object.

                ds = objConnector.GetConnection;//Connects to the database using the objconnector class.

                //Loops through each question in the table
                for (int i = 0; i < maxIndex; i++)
                {
                    DataRow dr = ds.Tables[0].NewRow();//Creates a new row in tblResults table.

                    dr[1] = questionIDs[i]; //Writes the question ID of the current quetion into the QuestionID column.
                    dr[2] = testID; //Writes the test ID of the current question into the QuestionID column.
                    dr[3] = maxMarks[i]; //Writes the maximum mark a student can have for the current question into the MaxMarks column.
                    dr[4] = marksGiven[i]; //Writes the marks given by the teacher for the current question into the MarksGiven column.

                    ds.Tables[0].Rows.Add(dr);//Adds the new row to the table.
                }
                objConnector.UpdateDatabase(ds);//Updates the database.
                

                MessageBox.Show("Marking successfully completed!");
                this.Hide();
            }
        }
    }
}