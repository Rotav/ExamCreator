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

    public partial class Test : Form
    {
        //Initialise variables
        DatabaseConnectioncs objConnector;
        DataSet ds;

        private int testID = 0;
        private int studentTestID = 0;
        private int studentID = 0;

        int questionPointer = 0;

        string[] questions;//stores the test's questions
        int[] questionIDs;//stores the questionIDs for the questions in the test.
        int maxIndex;
        string[] answers;//Stores the answers to the questions given by the user.

        public Test(int TestID, int StudentTestID, int StudentID)
        {
            studentTestID = StudentTestID;
            testID = TestID;
            studentID = StudentID;


            InitializeComponent();

            FindQuestions();
            OverWriteLabels();

            lb_QuestionNum.Text = "Question " + (questionPointer + 1).ToString() + " of " + maxIndex.ToString();
        }

        /// <summary>
        /// Generates the correct questions for the current test that the student is attempting.
        /// </summary>
        private void FindQuestions()
        {
            string query = "SELECT *, q.Id as QuestionID" +//Select all rows...
            " FROM QuestionTable q, tblTestQuestion t" +//...in the tables QuestionTable and tblTestQuestion.
            " WHERE t.QuestionID = q.Id" +//Limits results by checking that the ID in QuestionTable is equal to the Question ID in tblTestQuestion.
            " AND t.TestID = " + testID.ToString();//Limits results by checking that the Test ID in tblTestQuestion is equal to the ID of the test the student has clicked. 

            objConnector = new DatabaseConnectioncs();//Creates a new object from the Database connection class.
            objConnector.connection_string = ExamCreator.Properties.Settings.Default.DBConn;//passes through the Database's file path directory into the database connection object.
            objConnector.Sql = query;//passes the SQL query into the database connection object

            ds = objConnector.GetConnection;//Connects to the database using the objConnector class.

            maxIndex = ds.Tables[0].Rows.Count;//Counts the number of rows in the given query and passes the number of rows into maxIndex.
            questions = new string[maxIndex];//Makes the index of the questions array equal to the number of rows in the query.
            answers = new string[maxIndex];//Makes the index of the answers array equal to the number of rows in the query.
            questionIDs = new int[maxIndex];//Makes the index of the questionIDs array equal to the number of rows in the query.

            int i = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)//loops through every row in the query
            {
                questions[i] = dr["QuestionText"].ToString();//adds the current rows QuestionText value to the questions array.
                Int32.TryParse(dr["QuestionID"].ToString(), out questionIDs[i]);//adds the current rows QuestionID value to the questionIDs array.
                i++;
            }
        }
        
        /// <summary>
        /// Rewrites values to meet the corresponding question in the test.
        /// </summary>
        private void OverWriteLabels()
        {
            answers[questionPointer] = txt_AnswerBox.Text;
            lb_QuestionLabel.Text = questions[questionPointer];
        }

        /// <summary>
        /// Adds the answers submitted by the student to the tblTestAnswers table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
             answers[questionPointer] = txt_AnswerBox.Text;//adds currently entered answer to the answers array.
            
            //Confirm with the user that they are finished with the test.
            DialogResult res = MessageBox.Show("Are you sure you want to submit your answers? You cannot answer the test again once it is submitted.", "Are you sure?", MessageBoxButtons.YesNo);
            if(res.Equals(DialogResult.Yes))//If the user has selects yes...
            {
                //Selects no values from the table tblTestAnswers as we simply want to access the table (1 is never equal to 2).
                string query = "SELECT * FROM tblTestAnswers WHERE 1 = 2";

                objConnector.Sql = query;//passes the SQL query into the database connection object 

                ds = objConnector.GetConnection;//Connects to the database using the objConnector class.

                for (int i = 0; i < maxIndex; i++)//loop through every question in the test
                {
                    DataRow dr = ds.Tables[0].NewRow();//add a new row to tblTestAnswers

                    //Write the values into the table's current datarow
                    dr[1] = answers[i];
                    dr[2] = studentID;
                    dr[3] = 0; //value that determines whether the test has been marked or not (false as test has not been marked by teacher yet).
                    dr[4] = testID;
                    dr[5] = questionIDs[i];

                    ds.Tables[0].Rows.Add(dr);//add the row to tblTestAnswers
                }
                objConnector.UpdateDatabase(ds);//Update the database
                
                //update the table tblStudentTest by changing the value Completed to equal 1 (true) where the Id is the same as the studentTestID value
                string query2 = "UPDATE tblStudentTest SET Completed = 1 WHERE Id = " + studentTestID;

                MessageBox.Show("Test answers successfully sent!");
                this.Hide();
            }   
        }

        private void btn_RightArrow_Click(object sender, EventArgs e)
        {
            if (questionPointer < maxIndex - 1)//If the questionPointer is equal to the number of questions in the test...
            {
                //Change the values in order for the information for the next question to be correct.
                OverWriteLabels();
                questionPointer++;
                lb_QuestionNum.Text = "Question " + (questionPointer + 1).ToString() + " of " + maxIndex.ToString();
                txt_AnswerBox.Text = answers[questionPointer];
            }
            else
            {
                MessageBox.Show("There are no more questions on this test.");//...Otherwise, send error message.
            }
        }

        private void btn_LeftArrow_Click(object sender, EventArgs e)
        {
            if(questionPointer > 0)//If the user is not on question one...
            {
                //...Change values in order for the information for the previous question to be correct. 
                OverWriteLabels();
                questionPointer--;
                lb_QuestionNum.Text = "Question " + (questionPointer + 1).ToString() + " of " + maxIndex.ToString();
                txt_AnswerBox.Text = answers[questionPointer];
            }
            else
            {
                MessageBox.Show("There are no questions before this question.");//...Otherwise, send error message.
            }
        }
    }
}