using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento.Utils
{
    
    public class DBUtils
    {
        public System.Data.DataTable queryLetturaDT(String sql_string)
        {
            var dt = new System.Data.DataTable();
            try
            { 
                using (var connection = new ConnectionParameters().getSqlConnection())
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sql_string, connection))
                    {
                        // create data adapter
                        SqlDataAdapter da = new SqlDataAdapter(command);
                        // this will query your database and return the result to your datatable
                        da.Fill(dt);
                        //connection.Close();
                        da.Dispose();
                    }

                    connection.Close();
                }
            } 
            catch (SqlException e)
            {
                throw e;
            }                     

            return dt;
        }

        public bool EseguiQuery(String sql_string)
        {
            try
            {
                using (var connection = new ConnectionParameters().getSqlConnection())
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sql_string, connection))
                    {
                        // Let's ask the db to execute the query
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Query eseguita con successo.");
                            return true;
                        }                            
                        else
                        {
                            // Well this should never really happen
                            MessageBox.Show("Errore durante l'esecuzione della query: " + sql_string);
                            return false;
                        }
                    }                    
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Errore durante la scrittura: " + ex.Message);
                return false;
            }
        }

        public int NewIntID(string tableName, string IDColName)
        {
            var sql_string = new Utils.SQLString();

            int newId = 1;

            sql_string.addNewLine("SELECT TOP 1 " + IDColName + " FROM " + tableName + "");
            sql_string.addNewLine("ORDER BY " + IDColName + " DESC");

            var dt = this.queryLetturaDT(sql_string.Sql);

            foreach (System.Data.DataRow r in dt.Rows)
            {
                newId += this.GetRowInt(r, "ID");
            }

            return newId;
        }

        private int GetRowInt(System.Data.DataRow row, string fieldName)
        {
            return Convert.ToInt32(row[fieldName]);
        }

        internal class ConnectionParameters
        {
            public SqlConnection getSqlConnection()
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.DataSource = "localhost";
                builder.IntegratedSecurity = true;
                builder.InitialCatalog = "DB2022";
                builder.Encrypt = false;

                SqlConnection connection = new SqlConnection(builder.ConnectionString);

                return connection;
            }
        }
    }

    public class SQLString
    {
        private string _sql = "";
        public string Sql
        {
            get { return _sql; }
            set { _sql = value; }
        }
        public void addNewLine(string newLine)
        {
            _sql += Environment.NewLine + newLine;
        }
    }
}
