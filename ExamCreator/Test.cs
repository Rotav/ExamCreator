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
        DatabaseConnectioncs objConnector;
        DataSet ds;

        private int testID = 0;
        private int studentTestID = 0;
        private int studentID = 0;

        int questionPointer = 0;

        string[] questions;
        int[] questionIDs;
        int maxIndex;
        string[] answers;

        public Test(int TestID, int StudentTestID, int StudentID)
        {
            studentTestID = StudentTestID;
            testID = TestID;
            studentID = StudentID;

            MessageBox.Show("studentTestID: " + studentTestID +"\nStudent ID: " + studentID);

            InitializeComponent();

            FindQuestions();
            OverWriteLabels();

            lb_QuestionNum.Text = "Question " + (questionPointer + 1).ToString() + " of " + maxIndex.ToString();
        }

        private void FindQuestions()
        {
            string query = "SELECT *, q.Id as QuestionID" +
            " FROM QuestionTable q, tblTestQuestion t" +
            " WHERE t.QuestionID = q.Id" +
            " AND t.TestID = " + testID.ToString();

            objConnector = new DatabaseConnectioncs();
            objConnector.connection_string = ExamCreator.Properties.Settings.Default.DBConn;
            objConnector.Sql = query;

            ds = objConnector.GetConnection;

            maxIndex = ds.Tables[0].Rows.Count;
            questions = new string[maxIndex];
            answers = new string[maxIndex];
            questionIDs = new int[maxIndex];

            int i = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                questions[i] = dr["QuestionText"].ToString();
                Int32.TryParse(dr["QuestionID"].ToString(), out questionIDs[i]);
                i++;
                
            }
        }
        
        private void OverWriteLabels()
        {
            answers[questionPointer] = txt_AnswerBox.Text;
            lb_QuestionLabel.Text = questions[questionPointer];
        }

        private void button3_Click(object sender, EventArgs e)
        {
             answers[questionPointer] = txt_AnswerBox.Text;
            DialogResult res = MessageBox.Show("Are you sure you want to submit your answers? You cannot answer the test again once it is submitted.", "Are you sure?", MessageBoxButtons.YesNo);
            if(res.Equals(DialogResult.Yes))
            {
                //user clicks yes
                //Write all answers to table
                //delete record of test given to user
                string query = "SELECT * FROM tblTestAnswers WHERE 1 = 2";

                objConnector.Sql = query;

                ds = objConnector.GetConnection;

                for (int i = 0; i < maxIndex; i++)
                {
                    DataRow dr = ds.Tables[0].NewRow();

                    dr[1] = answers[i]; //answers
                    dr[2] = studentID;//Student ID
                    dr[3] = 0; //test is not marked
                    dr[4] = testID; //test ID
                    dr[5] = questionIDs[i]; //questions

                    MessageBox.Show("Student ID: " + studentID);

                    ds.Tables[0].Rows.Add(dr);
                }
                objConnector.UpdateDatabase(ds);
                
                string query2 = "UPDATE tblStudentTest SET Completed = 1 WHERE Id = " + studentTestID;

                MessageBox.Show("Test answers successfully sent!");
                this.Hide();
            }   
        }

        private void btn_RightArrow_Click(object sender, EventArgs e)
        {
            if (questionPointer < maxIndex-1)
            {
                OverWriteLabels();
                questionPointer++;
                lb_QuestionNum.Text = "Question " + (questionPointer + 1).ToString() + " of " + maxIndex.ToString();
                txt_AnswerBox.Text = answers[questionPointer];
            }
            else
            {
                MessageBox.Show("There are no more questions on this test.");
            }
        }

        private void btn_LeftArrow_Click(object sender, EventArgs e)
        {
            if(questionPointer > 0)
            {
                OverWriteLabels();
                questionPointer--;
                lb_QuestionNum.Text = "Question " + (questionPointer + 1).ToString() + " of " + maxIndex.ToString();
                txt_AnswerBox.Text = answers[questionPointer];
            }
            else
            {
                MessageBox.Show("There are no questions before this question.");
            }
        }
    }
}