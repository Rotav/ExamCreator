﻿using ExamCreator.Properties;
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
    public partial class CreateATest : Form
    {
        DatabaseConnectioncs objConnector;
        string stringConnector;

        DataSet ds;
        DataRow dr;

        int maxRows;
        bool correct = false;
        DataRow dataResult;
        public CreateATest()
        {
            InitializeComponent();
        }

        private void btn_CreateTest_Click(object sender, EventArgs e)
        {
            if (txt_Title.Text == "")
            {
                MessageBox.Show("You must enter a test title in order to create a test");
            }
            else
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

                ds.Tables[0].Rows.Add(dr);

                dr[1] = txt_Title.Text; //Question Title
                dr[2] = privacy;//privacy

                ds.Tables[0].Rows.Add(dr);

                objConnector.UpdateDatabase(ds);
                maxRows++;
                inc = maxRows - 1;

                MessageBox.Show("Your test has been successfully created.");
                TestBuilder testbuilder = new TestBuilder();
                testbuilder.Show();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CreateATest_Load(object sender, EventArgs e)
        {
            objConnector = new DatabaseConnectioncs();
            stringConnector = Settings.Default.DBConn;

            objConnector.connection_string = stringConnector;
            objConnector.Sql = Settings.Default.SelectQuestions;
            dataGridView1.DataSource = objConnector.MyBindingSource(); 
        }
    }
}






/*bool privacy = true;
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
            dr[4] = byteBLOBData;//image
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
*/