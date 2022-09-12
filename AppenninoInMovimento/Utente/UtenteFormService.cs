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
                if (this.ReadSingleUser() == null)
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

                    new Utils.DBUtils().EseguiQuery(sql_string.Sql);
                }
                else
                {
                    MessageBox.Show("Username già presente in DB, sceglierne uno differente");
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message);
            }
        }

        public System.Data.DataRow ReadSingleUser()
        {
            var sql_string = new Utils.SQLString();
            sql_string.addNewLine("SELECT * FROM Utenti");
            sql_string.addNewLine("WHERE username = '" + ParametriSessione.Username.Trim() + "'");

            var r = new Utils.DBUtils().queryLetturaDT(sql_string.Sql).Rows;

            return r.Count > 0 ? r[0] : null;
        }

        public System.Data.DataTable LeggiUtenti(string parametriRicerca)
        {
            var sql_string = new Utils.SQLString();
            var dbu = new Utils.DBUtils();

            sql_string.addNewLine("SELECT * FROM Utenti");
            sql_string.addNewLine(parametriRicerca);

            return dbu.queryLetturaDT(sql_string.Sql);
        }

        public void DeleteUser()
        {
            var sql_string = new Utils.SQLString();
            var dbu = new Utils.DBUtils();

            sql_string.addNewLine("DELETE FROM Utenti");
            sql_string.addNewLine("WHERE username = '" + ParametriSessione.Username + "'");

            dbu.EseguiQuery(sql_string.Sql);
        }

        public void AddFriend()
        {
            var sql_string = new Utils.SQLString();
            var dbu = new Utils.DBUtils();

            sql_string.addNewLine("INSERT INTO Amicizie");
            sql_string.addNewLine("VALUES (");
            sql_string.addNewLine("    '" + ParametriSessione.UsernameSuperUser.Trim() + "',");
            sql_string.addNewLine("    '" + ParametriSessione.Username.Trim() + "'");
            sql_string.addNewLine(")");

            dbu.EseguiQuery(sql_string.Sql);
        }
    }


}
