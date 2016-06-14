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
                DatabaseConnectioncs DbConnection = new DatabaseConnectioncs();
                DbConnection.connection_string = ExamCreator.Properties.Settings.Default.DBConn;
                DbConnection.Sql = "SELECT * FROM QuestionTable";

                ds = DbConnection.GetConnection;
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
            
            DataRow dr = ds.Tables[1].NewRow();
            /*
            dr[1] = tbar_Difficulty.Value; //difficulty
            dr[2] = txt_QuestionTitle.Text; //QTitle
            dr[3] = privacy; //privacy
            dr[4] = byteBLOBData;//image
            dr[5] = txt_Question.Text; //QText
            dr[6] = num_Mark.Value;//mark
            dr[7] = lb_Topics.SelectedItem;//topic
            */

            dr[1] = 3;
            dr[2] = "This is question";
            dr[3] = false;
            dr[4] = null;
            dr[5] = "This is what student sees";
            dr[6] = 4;
            dr[7] = "DataBases";

            ds.Tables[1].Rows.Add(dr);

            try
            {
                objConnector.UpdateDatabase(ds); //problem if ds.Tables[0]
                maxRows++;
                inc = maxRows - 1;

                MessageBox.Show("Your question has been added!");
                            
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
             
        }
    }
}
