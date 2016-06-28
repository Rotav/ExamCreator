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
        string stringConnector;

        DataSet ds;
        DataRow dr;

        int maxRows;
        int inc = 0;
        bool correct = false;
        DataRow dataResult;
        
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

        private void btn_UploadImage_Click(object sender, EventArgs e)
        {
             DialogResult result = openFileDialog1.ShowDialog();
             if (result == DialogResult.OK)
             {
                FileStream fsBLOBFile = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                 byteBLOBData = new Byte[fsBLOBFile.Length];

                 fsBLOBFile.Read(byteBLOBData, 0, byteBLOBData.Length);

                 fsBLOBFile.Close();

                 MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);

                 pb_QuestionImage.Image = Image.FromStream(stmBLOBData);
             }
        }

        public byte[] byteBLOBData { get; set; }

        private void btn_SubmitQuestion_Click(object sender, EventArgs e)
        {
            bool privacy = true;
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
             
        }
    }
}
