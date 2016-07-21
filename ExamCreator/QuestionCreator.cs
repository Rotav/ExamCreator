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
                objConnector = new DatabaseConnectioncs();
                objConnector.connection_string = ExamCreator.Properties.Settings.Default.DBConn;
                objConnector.Sql = "SELECT * FROM QuestionTable";

                ds = objConnector.GetConnection;
                MessageBox.Show("QuestionTable Connection reached");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_SubmitQuestion_Click(object sender, EventArgs e)
        {
            bool privacy = true;
            int inc = 0;

            if (rb_Public.Checked == true)
            {
                privacy = true;
            }
            else
            {
                privacy = false;
            }
            
            DataRow dr = ds.Tables[0].NewRow();
            
            dr[1] = tbar_Difficulty.Value; //difficulty
            dr[2] = txt_QuestionTitle.Text; //QTitle
            dr[3] = privacy; //privacy
            dr[5] = txt_Question.Text; //QText
            dr[6] = num_Mark.Value;//mark
            dr[7] = lb_Topics.SelectedItem;//topic
            

            ds.Tables[0].Rows.Add(dr);

            try
            {
                objConnector.UpdateDatabase(ds);
                maxRows++;
                inc = maxRows - 1;

                MessageBox.Show("Your question has been added!");
            }
            catch
            {
                MessageBox.Show("Please fill in all of the empty fields");
            }
             
        }
    }
}
