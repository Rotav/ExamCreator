using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExamCreator
{
    class DatabaseConnectioncs
    {
        //Initialise variables:
        private string sql_string;
        private string strCon;
        System.Data.SqlClient.SqlDataAdapter da_1;

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
            get { return MyDataSet(); }
        }

        /// <summary>
        /// Creates a connection between the program and the database using the query that has been passed through.
        /// </summary>
        /// <returns></returns>
        public System.Data.DataSet MyDataSet()
        {
            //creates new SQL connection using the string connection value.
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(strCon);

            con.Open();//Opens a database connection.
            
            //uses the SQL string to collect the data the query has asked for.
            da_1 = new System.Data.SqlClient.SqlDataAdapter(sql_string, con);

            System.Data.DataSet dat_set = new System.Data.DataSet();

            try
            {
                da_1.Fill(dat_set, "Table_Data_1");//Stores the data inside the dataset.
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }


            con.Close();//Closes the connection to the database.

            return dat_set;
        }

        /// <summary>
        /// Creates a binding source for the table tblTest.
        /// </summary>
        /// <returns></returns>
        public BindingSource MyBindingSource()
        {
            //creates new SQL connection using the string connection value.
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(strCon);

            con.Open();//Opens a database connection.

            //uses the SQL string to collect the data of every value in tblTest.
            da_1 = new System.Data.SqlClient.SqlDataAdapter("SELECT * from tblTest", con);

            DataTable table = new DataTable();
            da_1.Fill(table);//Stores the datatable inside the SqlDataAdapter.

            BindingSource bSource = new BindingSource();//Creates the binding source.
            bSource.DataSource = table; //Sets the datasource to the datatable.
            return bSource;
        }

        /// <summary>
        /// Creates a binding source for the table QuestionTable
        /// </summary>
        /// <returns></returns>
        public BindingSource StudentBindingSource()
        {
            //creates new SQL connection using the string connection value.
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(strCon);

            con.Open();//Opens a database connection.

            //uses the SQL string to collect the data of every value in QuestionTable.
            da_1 = new System.Data.SqlClient.SqlDataAdapter("SELECT * from QuestionTable", con);

            DataTable table = new DataTable();
            da_1.Fill(table);//Stores the datatable inside the SqlDataAdapter.

            BindingSource bSource = new BindingSource();//Creates the binding source.
            bSource.DataSource = table;//Sets the datasource to the datatable.
            return bSource;
        }

        /// <summary>
        /// Creates a binding source for the table tblStudent
        /// </summary>
        /// <returns></returns>
        public BindingSource StudentTableBindingSource()
        {
            //creates new SQL connection using the string connection value.
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(strCon);

            con.Open();//Opens a database connection.

            //uses the SQL string to collect the data of every value in tblStudent.
            da_1 = new System.Data.SqlClient.SqlDataAdapter("SELECT * from tblStudent", con);

            DataTable table = new DataTable();
            da_1.Fill(table);//Stores the datatable inside the SqlDataAdapter.

            BindingSource bSource = new BindingSource();//Creates the binding source.
            bSource.DataSource = table;//Sets the datasource to the datatable.
            return bSource;
        }

        /// <summary>
        /// Updates the database when called by another class.
        /// </summary>
        /// <param name="ds"></param>
        public void UpdateDatabase(System.Data.DataSet ds)
        {
            //Creates a new SqlCommandBuilder using the SqlDataAdapter.
            System.Data.SqlClient.SqlCommandBuilder cb = new System.Data.SqlClient.SqlCommandBuilder(da_1);
            cb.QuotePrefix = "[";//Sets the starting character for the table.
            cb.QuoteSuffix = "]";//Sets the ending character for the table.
            cb.DataAdapter.Update(ds.Tables[0]);//Updates the database.

        }
    }
}
