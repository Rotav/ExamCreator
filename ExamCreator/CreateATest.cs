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
