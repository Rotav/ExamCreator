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
    public partial class ResultStats : Form
    {
        //Initialise variables
        DatabaseConnectioncs objConnector;
        DataSet ds;

        private int testID;
        private int studentID;

        int questionPointer = 0;
        int maxIndex = 0;
        double questionPercent;

        string[] questions; //stores the test's questions
        double[] questionIDs; //stores the questionIDs for the questions in the test.
        string[] answers; //stores the answers to the questions inputted by the user in the test.
        double[] marksGiven; //stores the marks given by the teacher for each question in the test.
        double[] maxMarks; //stores the maximum marks achievable for each question in the test.

        public ResultStats(int TestID, int StudentID)
        {
            testID = TestID;
            studentID = StudentID;

            InitializeComponent();

            FindMarkedTest();

            WriteText();
            TestStats();
            QuestionStats();
        }

        /// <summary>
        /// Finds the test that the user wants to view.
        /// </summary>
        private void FindMarkedTest()
        {
            string query2 = "SELECT *" +//selects all values 
                           " FROM tblTestQuestion tq, tblResults r, QuestionTable q" + //...from these tables
                           " WHERE r.QuestionID = tq.QuestionID" + //limits results by selecting values with the same QuestionID in tblResults and tblTestQuestion
                           " AND q.Id = r.QuestionID" +//limits results by selecting values with the same QuestionID in tblResults and QuestionTable
                           " AND r.TestID = tq.TestID" +//limits results by selecting values with the same TestID in tblResults and tblTestQuestion
                           " AND r.StudentID = " + studentID.ToString();//limits results by selecting values with the same StudentID as the student the teacher has selected

            string query = "SELECT * " +//selects all values 
                           " FROM tblTestQuestion tq, tblResults r, QuestionTable q, tblTestAnswers a" + //...from these tables
                           " WHERE r.QuestionID = tq.QuestionID" +//limits results by selecting rows with the same QuestionID in tblResults and tblTestQuestion
                           " AND q.Id = r.QuestionID" +//limits results by selecting rows with the same QuestionID in tblResults and QuestionTable
                           " AND r.TestID = tq.TestID" +//limits results by selecting rows with the same TestID in tblResults and tblTestQuestion
                           " AND a.TestID = " + testID.ToString() +
                           " AND a.QuestionID = tq.QuestionID" +//limits results by selecting rows with the same QuestionID in tblTestAnswers and tblTestQuestion
                           " AND r.StudentID = " + studentID.ToString();//limits results by selecting rows with the same StudentID as the student the teacher has selected 

            objConnector = new DatabaseConnectioncs();//Creates a new object from the database connection class.
            objConnector.connection_string = ExamCreator.Properties.Settings.Default.DBConn;//passes the database's file path directory into the database connection class.
            objConnector.Sql = query;//passes the SQL query into the database connection object.

            ds = objConnector.GetConnection;//Connects to the database using the objConnector class.

            maxIndex = ds.Tables[0].Rows.Count;//count all the lines defined by the first query and set the number of rows as the maxIndex

            //set all array's with index value of maxIndex
            questions = new string[maxIndex];
            answers = new string[maxIndex];
            questionIDs = new double[maxIndex];
            marksGiven = new double[maxIndex];
            maxMarks = new double[maxIndex];

            int i = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)//loop through each row
            {
                //pass each question into the question array
                questions[i] = dr["QuestionText"].ToString();

                Double.TryParse(dr["Id"].ToString(), out questionIDs[i]);
                
                //pass each mark value into the designated array
                Double.TryParse(dr["MaxMark"].ToString(), out maxMarks[i]);
                Double.TryParse(dr["GivenMark"].ToString(), out marksGiven[i]);

                //set each answer into the answer array 
                answers[i] = dr["Answer"].ToString();
                i++;
            }
        }

        /// <summary>
        /// Set the text values of different textboxes and labels in windows form
        /// </summary>
        private void WriteText()
        {
            txt_Question.Text = questions[questionPointer];
            lb_QuestionNum.Text = "Question " + (questionPointer + 1).ToString() + " of " + maxIndex.ToString();
            lb_QuestionHigh.Text = "Highest mark for this question: " + maxMarks[questionPointer];

            txt_StudentAnswer.Text = answers[questionPointer];
        }
        
        /// <summary>
        /// set text labels related to the total of the test
        /// </summary>
        private void TestStats()
        {
            double testMarks = 0;
            double testHigh = 0;
            double testPercent = 0;

            //generate mark values
            for (int i = 0; i < maxIndex; i++)
            {
                testMarks = testMarks + marksGiven[i];
                testHigh = testHigh + maxMarks[i];
            }

            testPercent = (testMarks / testHigh) * 100; //works out the percentage of correct marks for the test.

            lb_TestMarks.Text = "Total marks recieved: " + testMarks;
            lb_TestHigh.Text = "Highest total mark achievable: " + testHigh;
            lb_TestPercent.Text = "Percentage scored: " + testPercent + "%"; 
        }

        /// <summary>
        /// set the text labels related to the current question selected
        /// </summary>
        private void QuestionStats()
        {
            questionPercent = (marksGiven[questionPointer] / maxMarks[questionPointer]) * 100;//generate percentage value for the current question.

            lb_QuestionMarks.Text = "Marks recieved: " + marksGiven[questionPointer];
            lb_QuestionHigh.Text = "Highest mark achievable: " + maxMarks[questionPointer];
            lb_QuestionPercent.Text = "Percentage scored: " + questionPercent + "%";
        }

        private void btn_LeftArrow_Click(object sender, EventArgs e)
        {
            if (questionPointer > 0)//If the user is not on question one...
            {
                questionPointer--;
                WriteText();
                QuestionStats();
            }
            else
            {
                MessageBox.Show("There are no questions before this question.");
            }
        }

        private void btn_RightArrow_Click(object sender, EventArgs e)
        {
            if (questionPointer < maxIndex - 1)//If the questionPointer is equal to the number of questions in the test...
            {
                questionPointer++;
                WriteText();
                QuestionStats();
            }
            else
            {
                MessageBox.Show("There are no more questions on this test.");
            }
        }
    }
}
