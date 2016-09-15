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
        DatabaseConnectioncs objConnector;
        DataSet ds;
        DataSet ds2;

        private int testID = 0;
        private int studentID = 1;

        int questionPointer = 0;
        int maxIndex = 0;
        int questionPercent = 0;

        string[] questions;
        int[] questionIDs;
        string[] answers;
        int[] marksGiven;
        int[] maxMarks;

        public ResultStats(int TestID, int StudentID)
        {
            TestID = testID;
            StudentID = studentID;

            InitializeComponent();

            FindMarkedTest();

            WriteText();
            TestStats();
            QuestionStats();
        }

        private void FindMarkedTest()
        {
            string query = "SELECT *" +
                           " FROM tblTestQuestion tq, tblResults r, QuestionTable q" +
                           " WHERE r.QuestionID = tq.QuestionID" +
                           " AND q.Id = r.QuestionID" +
                           " AND r.TestID = tq.TestID";
                           //" AND r.StudentID = " + studentID.ToString();
            //TODO: GENERATE STUDENT ID

            objConnector = new DatabaseConnectioncs();
            objConnector.connection_string = ExamCreator.Properties.Settings.Default.DBConn;
            objConnector.Sql = query;

            ds = objConnector.GetConnection;

            maxIndex = ds.Tables[0].Rows.Count;

            string query2 = "SELECT * FROM tblTestAnswer";

            objConnector = new DatabaseConnectioncs();
            objConnector.connection_string = ExamCreator.Properties.Settings.Default.DBConn;
            objConnector.Sql = query2;

            ds2 = objConnector.GetConnection;


            questions = new string[maxIndex];
            answers = new string[maxIndex];
            questionIDs = new int[maxIndex];
            marksGiven = new int[maxIndex];
            maxMarks = new int[maxIndex];

            int i = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                questions[i] = dr["QuestionText"].ToString();

                Int32.TryParse(dr["Id"].ToString(), out questionIDs[i]);
                Int32.TryParse(dr["MaxMark"].ToString(), out maxMarks[i]);
                Int32.TryParse(dr["GivenMark"].ToString(), out marksGiven[i]);

                answers[i] = dr["Answer"].ToString();
                i++;
            }
        }

        private void WriteText()
        {
            MessageBox.Show("questionPointer: " + questionPointer + "\nindex: " + questions[questionPointer]);
            txt_Question.Text = questions[questionPointer];
            lb_QuestionNum.Text = "Question " + (questionPointer + 1).ToString() + " of " + maxIndex.ToString();
            lb_QuestionHigh.Text = "Highest mark for this question: " + maxMarks[questionPointer];

            txt_StudentAnswer.Text = answers[questionPointer];
        }

        private void TestStats()
        {
            //TODO: GENERATE ALL VALUES
            int testMarks = 0;
            int testHigh = 0;
            int testPercent = 0;

            for (int i = 0; i < maxIndex; i++) //CHECK THIS
            {
                testMarks = testMarks + marksGiven[i];
                testHigh = testHigh + maxMarks[i];
                testPercent = 0; //TODO: GENERATE THIS
            }

            lb_TestMarks.Text = "Total marks recieved: " + testMarks;
            lb_TestHigh.Text = "Highest total mark achievable: " + testHigh;
            lb_TestPercent.Text = "Percentage scored: " + testPercent + "%"; 
        }

        private void QuestionStats()
        {
            questionPercent = (marksGiven[questionPointer] / maxMarks[questionPointer]) * 100; 

            lb_QuestionMarks.Text = "Marks recieved: " + marksGiven[questionPointer];
            lb_QuestionHigh.Text = "Highest mark achievable: " + maxMarks[questionPointer];
            lb_QuestionPercent.Text = "Percentage scored: " + questionPercent + "%"; // TODO: GENERATE %
        }

        private void btn_LeftArrow_Click(object sender, EventArgs e)
        {
            if (questionPointer > 0)
            {
                questionPointer--;
                WriteText();
            }
            else
            {
                MessageBox.Show("There are no questions before this question.");
            }
        }

        private void btn_RightArrow_Click(object sender, EventArgs e)
        {
            if (questionPointer < maxIndex - 1)
            {
                questionPointer++;
                WriteText();
            }
            else
            {
                MessageBox.Show("There are no more questions on this test.");
            }
        }
    }
}
