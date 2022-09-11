using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento.Utils
{
    
    internal class DBUtils
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

        public bool queryScrittura(String sql_string)
        {
            try
            {
                using (var connection = new ConnectionParameters().getSqlConnection())
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sql_string, connection))
                    {
                        // Let's ask the db to execute the query
                        int rowsAdded = command.ExecuteNonQuery();
                        connection.Close();
                        if (rowsAdded > 0)
                        {
                            MessageBox.Show("Scrittura avvenuta con successo.");
                            return true;
                        }                            
                        else
                        {
                            // Well this should never really happen
                            MessageBox.Show("Errore durante la scrittura: " + sql_string);
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

    internal class SQLString
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
