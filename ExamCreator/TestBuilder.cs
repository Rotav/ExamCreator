using ExamCreator.Properties;
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
    public partial class TestBuilder : Form
    {

        DatabaseConnectioncs objConnector;
        string stringConnector;

        public TestBuilder()
        {
            InitializeComponent();
        }

        private void btn_DeleteQuestion_Click(object sender, EventArgs e)
        {
            lb_QuestionList.Items.Remove(lb_QuestionList.SelectedItem);
        }

        private void TestBuilder_Load(object sender, EventArgs e)
        {
            objConnector = new DatabaseConnectioncs();
            stringConnector = Settings.Default.DBConn;

            objConnector.connection_string = stringConnector;
            objConnector.Sql = Settings.Default.SelectTeachers;
            dg_Public.DataSource = objConnector.StudentBindingSource(); 
        }

        private void btn_AddQuestion_Click(object sender, EventArgs e)
        {
            string cellValue = dg_Public["QuestionTitle", dg_Public.CurrentRow.Index].Value.ToString();
            lb_QuestionList.Items.Add(cellValue);            
        }

        private void btn_Complete_Click(object sender, EventArgs e)
        {
            if (lb_QuestionList.Items == null) //fix
            {
                MessageBox.Show("You must have at least one question in the test to complete it.");
            }
            else
            {
                SendTest sendtest = new SendTest();
                sendtest.Show();
            }
        }
    }
}
