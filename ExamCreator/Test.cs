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

        int questionPointer = 0;

        string[] questions;
        int[] questionIDs;
        int maxIndex;
        string[] answers;

        public Test(int TestID, int StudentTestID)
        {
            studentTestID = StudentTestID;
            testID = TestID;
            MessageBox.Show(testID.ToString());
            InitializeComponent();

            FindQuestions();
            lb_QuestionNum.Text = "Question " + (questionPointer+1).ToString() + " of " + maxIndex.ToString();
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

                    dr[1] = studentTestID; //studentTest IDs
                    dr[2] = questionIDs[i]; //questions
                    dr[3] = answers[i]; //answers

                    ds.Tables[0].Rows.Add(dr);
                }
                objConnector.UpdateDatabase(ds);
                string query2 = "UPDATE tblStudentTest SET Completed = 1 WHERE Id = " + studentTestID;


                MessageBox.Show("Test answers successfully sent!" + testID + studentTestID);
                this.Hide();
            }   
        }

        private void btn_RightArrow_Click(object sender, EventArgs e)
        {
            if (questionPointer < maxIndex-1)
            {
                answers[questionPointer] = txt_AnswerBox.Text;

                questionPointer++;

                lb_QuestionNum.Text = "Question " + (questionPointer+1).ToString() + " of " + maxIndex.ToString();
                lb_QuestionLabel.Text = questions[questionPointer];
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
                answers[questionPointer] = txt_AnswerBox.Text;
                
                questionPointer--;

                lb_QuestionLabel.Text = questions[questionPointer];
                lb_QuestionNum.Text = "Question " + (questionPointer+1).ToString() + " of " + maxIndex.ToString();
                txt_AnswerBox.Text = answers[questionPointer];
            }
            else
            {
                MessageBox.Show("There are no questions before this question.");
            }
        }
    }
}