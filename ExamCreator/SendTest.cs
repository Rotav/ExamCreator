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
    public partial class SendTest : Form
    {
        DatabaseConnectioncs objConnector;
        string stringConnector;

        public SendTest()
        {
            InitializeComponent();
        }

        private void SendTest_Load(object sender, EventArgs e)
        {
            objConnector = new DatabaseConnectioncs();
            stringConnector = Settings.Default.DBConn;
            objConnector.connection_string = stringConnector;
            objConnector.Sql = Settings.Default.SelectTeachers;
            dg_Students.DataSource = objConnector.StudentTableBindingSource(); 
        }

        private void btn_AddToList_Click(object sender, EventArgs e)
        {
            string ForenameValue = dg_Students["Forename", dg_Students.CurrentRow.Index].Value.ToString();
            string SurnameValue = dg_Students["Surname", dg_Students.CurrentRow.Index].Value.ToString();
            string UserValue = dg_Students["Username", dg_Students.CurrentRow.Index].Value.ToString();
            lb_SendUsers.Items.Add(UserValue + " (" + ForenameValue + " " + SurnameValue + ")");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            lb_SendUsers.Items.Remove(lb_SendUsers.SelectedItem);
        }
    }
}
