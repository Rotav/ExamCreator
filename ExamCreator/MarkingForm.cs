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
        DatabaseConnectioncs objConnector;
        DataSet ds;
        DataSet ds2;

        private int testID = 0;
        private int studentID = 1;

        int questionPointer = 0;

        string[] questions;
        int[] questionIDs;
        int maxIndex;
        string[] submittedAnswers;
        int[] marksGiven;
        int[] maxMarks;

        public MarkingForm(int TestID, int StudentID)
        {
            testID = TestID;
            studentID = StudentID;

            MessageBox.Show("studentID: " + studentID + "\ntestID: " + testID);
            
            InitializeComponent();
            
            FindResults();
            MessageBox.Show("questionPointer: " + questionPointer);
            WriteArray();
            ChangeResultValues();
        }

        private void FindResults()
        {
            string query2 = "SELECT *" +
                            " FROM tblTestQuestion tq, tblTestAnswers a" +
                            " WHERE a.QuestionID = tq.QuestionID" +
                            " AND a.TestID = tq.TestID" +
                            " AND a.StudentID = " + studentID.ToString();

            string query = "SELECT *" +
                           " FROM tblTestQuestion tq, tblTestAnswers a, QuestionTable q" +
                           " WHERE a.QuestionID = tq.QuestionID" +
                           " AND q.Id = a.QuestionID" +
                           " AND a.TestID = tq.TestID" +
                           " AND a.StudentID = " + studentID.ToString();

            objConnector = new DatabaseConnectioncs();
            objConnector.connection_string = ExamCreator.Properties.Settings.Default.DBConn;
            objConnector.Sql = query;

            ds = objConnector.GetConnection;

            objConnector = new DatabaseConnectioncs();
            objConnector.connection_string = ExamCreator.Properties.Settings.Default.DBConn;
            objConnector.Sql = query2;

            ds2 = objConnector.GetConnection;

            maxIndex = ds.Tables[0].Rows.Count;

            MessageBox.Show("maxIndex: " + maxIndex);

            questions = new string[maxIndex];
            submittedAnswers = new string[maxIndex];
            questionIDs = new int[maxIndex];
            marksGiven = new int[maxIndex];
            maxMarks = new int[maxIndex];

            int i = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                questions[i] = dr["QuestionText"].ToString();
                
                Int32.TryParse(dr["Id"].ToString(), out questionIDs[i]);
                Int32.TryParse(dr["Mark"].ToString(), out maxMarks[i]);

                submittedAnswers[i] = dr["Answer"].ToString();
                i++;
            }
        }

        private void WriteArray()
        {
            marksGiven[questionPointer] = Convert.ToInt32(num_Mark.Value);
            txt_StudentAnswer.Text = submittedAnswers[questionPointer];
            txt_Question.Text = questions[questionPointer];
        }

        public void ChangeResultValues()
        {
            lb_HighMark.Text = "Highest mark for this question: " + maxMarks[questionPointer];
            lb_QuestionNum.Text = "Question " + (questionPointer + 1).ToString() + " of " + maxIndex.ToString();

            num_Mark.Maximum = maxMarks[questionPointer];
            num_Mark.Value = marksGiven[questionPointer];
        }

        private void btn_RightArrow_Click(object sender, EventArgs e)
        {
            if (questionPointer < maxIndex - 1)
            {

                WriteArray();
                questionPointer++;
                ChangeResultValues();
            }
            else
            {
                MessageBox.Show("There are no more questions on this test.");
            }
        }

        private void btn_LeftArrow_Click(object sender, EventArgs e)
        {
            if (questionPointer > 0)
            {
                marksGiven[questionPointer] = Convert.ToInt32(num_Mark.Value);

                WriteArray();
                questionPointer--;
                ChangeResultValues();
            }
            else
            {
                MessageBox.Show("There are no questions before this question.");
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            marksGiven[questionPointer] = Convert.ToInt32(num_Mark.Value);

            DialogResult res = MessageBox.Show("Are you sure you want to submit your the marks given in this test?", "Are you sure?", MessageBoxButtons.YesNo);

            if (res.Equals(DialogResult.Yes))
            {
                //user clicks yes
                //Send results to result table
                //Check as marked test in 
                string query = "SELECT * FROM tblResults WHERE 1 = 2";

                objConnector.Sql = query;

                ds = objConnector.GetConnection;

                for (int i = 0; i < maxIndex; i++)
                {
                    DataRow dr = ds.Tables[0].NewRow();

                    dr[1] = questionIDs[i]; //question IDs
                    dr[2] = testID; //test ID
                    dr[3] = marksGiven[i]; //marks given by teacher
                    dr[4] = maxMarks[i]; //maximum mark per question

                    ds.Tables[0].Rows.Add(dr);
                }
                objConnector.UpdateDatabase(ds);
                

                MessageBox.Show("Marking successfully completed!");
                this.Hide();
            }
        }
    }
}
