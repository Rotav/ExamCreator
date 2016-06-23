using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExamCreator
{
    class DatabaseConnectioncs
    {
        private string sql_string;
        private string strCon;
        System.Data.SqlClient.SqlDataAdapter da_1;

        int MaxRows;
        int inc = 0;

        public string Sql
        {
            set { sql_string = value; }
        }

        public string connection_string
        {
            set { strCon = value; }
        }

        public System.Data.DataSet GetConnection
        {
            get { return MyDataSet();  }
        }

        public System.Data.DataSet MyDataSet()
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(strCon);

            con.Open();
            
            da_1 = new System.Data.SqlClient.SqlDataAdapter(sql_string, con);

            System.Data.DataSet dat_set = new System.Data.DataSet();
            da_1.Fill(dat_set, "Table_Data_1");
            con.Close();

            return dat_set;
        }

        public BindingSource MyBindingSource() //make more efficient
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(strCon);

            con.Open();

            da_1 = new System.Data.SqlClient.SqlDataAdapter("SELECT * from tblTest", con);

            DataTable table = new DataTable();
            da_1.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            return bSource;
        }
        public BindingSource StudentBindingSource()
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(strCon);

            con.Open();

            da_1 = new System.Data.SqlClient.SqlDataAdapter("SELECT * from QuestionTable", con);

            DataTable table = new DataTable();
            da_1.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            return bSource;
        }

        public BindingSource StudentTableBindingSource()
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(strCon);

            con.Open();

            da_1 = new System.Data.SqlClient.SqlDataAdapter("SELECT * from tblStudent", con);

            DataTable table = new DataTable();
            da_1.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            return bSource;
        }

        public void UpdateDatabase(System.Data.DataSet ds)
        {
            System.Data.SqlClient.SqlCommandBuilder cb = new System.Data.SqlClient.SqlCommandBuilder(da_1);
            cb.QuotePrefix = "[";
            cb.QuoteSuffix = "]";
            cb.DataAdapter.Update(ds.Tables[0]);
            
        }


        /*public void AddQuestion(DataSet ds, int Difficulty, string qTitle, bool privacy, string image, string qText, int mark)
        {
            DataRow row = ds.Tables[0].NewRow();
            row[1] = Difficulty;
            row[2] = qTitle;
            row[3] = privacy;
            row[4] = null;
            row[5] = qText;
            row[6] = mark;

            ds.Tables[0].Rows.Add(row);
        } */
    }
}
