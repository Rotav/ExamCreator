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

        DataSet ds;
        DataRow dr;

        int maxRows;
        bool correct = false;
        DataRow dataResult;

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
            
        }
    }
}
