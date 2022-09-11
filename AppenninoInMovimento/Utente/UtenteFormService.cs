using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento.Utente
{
    internal class UtenteFormService
    {
        public void registerNewUser(Utils.Entita.Utente newUser)
        {
            try
            {
                var sql_string = new Utils.SQLString();
                sql_string.addNewLine("INSERT INTO Utenti");
                sql_string.addNewLine("VALUES (");
                sql_string.addNewLine("    '" + newUser.CF + "',");
                sql_string.addNewLine("    '" + newUser.Nome + "',");
                sql_string.addNewLine("    '" + newUser.Cognome + "',");
                sql_string.addNewLine("    '" + newUser.DataNascita + "',");
                sql_string.addNewLine("    '" + newUser.Telefono + "',");
                sql_string.addNewLine("    '" + newUser.DataIscrizione + "',");
                sql_string.addNewLine("    " + (newUser.Organizzatore ? 1 : 0) + ",");
                sql_string.addNewLine("    '" + newUser.Username + "',");
                sql_string.addNewLine("    '" + newUser.Password + "'");
                sql_string.addNewLine(")");

                new Utils.DBUtils().queryScrittura(sql_string.Sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message);
            }
        }
    }
}
