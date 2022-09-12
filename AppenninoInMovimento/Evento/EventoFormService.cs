using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento.Evento
{
    internal class EventoFormService
    {
        public System.Data.DataRow LeggiSingleEvento()
        {
            var sql_string = new Utils.SQLString();
            sql_string.addNewLine("SELECT * FROM Eventi");
            sql_string.addNewLine("WHERE ID = " + ParametriSessione.ID_EVENTO);

            var evento = new Utils.DBUtils().queryLetturaDT(sql_string.Sql);
            return evento.Rows.Count > 0 ? evento.Rows[0] : null;

        }
        public void EliminaEvento()
        {
            var sql_string = new Utils.SQLString();
            sql_string.addNewLine("UPDATE Attivita");
            sql_string.addNewLine("SET ID_EVENTO = 0");
            sql_string.addNewLine("WHERE ID_EVENTO = " + ParametriSessione.ID_EVENTO);
            
            sql_string.addNewLine("");

            var intrattenimentoCollegato = this.LeggiSingleEvento()["ID_INTRATTENIMENTO"];
            if (intrattenimentoCollegato != null)
            {
                sql_string.addNewLine("DELETE FROM Intrattenimenti");
                sql_string.addNewLine("WHERE ID = " + intrattenimentoCollegato);
                sql_string.addNewLine("");
            }

            sql_string.addNewLine("DELETE FROM Eventi");
            sql_string.addNewLine("WHERE ID = " + ParametriSessione.ID_EVENTO);

            new Utils.DBUtils().EseguiQuery(sql_string.Sql);
        }

        public System.Data.DataTable LeggiEventi(string parametriRicerca)
        {
            var sql_string = new Utils.SQLString();
            var dbu = new Utils.DBUtils();

            sql_string.addNewLine("SELECT * FROM Eventi");
            sql_string.addNewLine(parametriRicerca);

            return dbu.queryLetturaDT(sql_string.Sql);
        }

        public void ScriviEvento(Utils.Entita.Eventi evento)
        {
            var sql_string = new Utils.SQLString();
            var dbu = new Utils.DBUtils();

            sql_string.addNewLine("INSERT INTO Eventi");
            sql_string.addNewLine("VALUES (");
            sql_string.addNewLine("    " + dbu.NewIntID("Eventi", "ID") + ",");
            sql_string.addNewLine("    " + evento.Pause + ",");
            sql_string.addNewLine("    '" + evento.Descrizione + "',");
            sql_string.addNewLine("    '" + evento.AttivitaSvolte + "',");
            sql_string.addNewLine("    '',");
            sql_string.addNewLine("    " + evento.ID_INTRATTENIMENTO + ",");
            sql_string.addNewLine("    '" + evento.ID_QUOTA + "'");
            
            sql_string.addNewLine(")");

            dbu.EseguiQuery(sql_string.Sql);
        }

        public void ModificaEvento(Utils.Entita.Eventi evento)
        {
            var sql_string = new Utils.SQLString();
            var dbu = new Utils.DBUtils();

            sql_string.addNewLine("UPDATE Eventi");
            sql_string.addNewLine("SET");
            sql_string.addNewLine("    numpause = " + evento.Pause + ",");
            sql_string.addNewLine("    attivita = '" + evento.AttivitaSvolte + "',");
            sql_string.addNewLine("    partecipanti = '"+evento.ElencoPartecipanti+"',");
            sql_string.addNewLine("    ID_INTRATTENIMENTO = " + evento.ID_INTRATTENIMENTO + ",");
            sql_string.addNewLine("    ID_QUOTA = " + evento.ID_QUOTA.ToString().Replace(",",".") + ",");
            sql_string.addNewLine("    descrizione = '" + evento.Descrizione + "'");

            sql_string.addNewLine("WHERE ID = " + ParametriSessione.ID_EVENTO);

            dbu.EseguiQuery(sql_string.Sql);
        }

        public void JoinEvento()
        {
            var sql_string = new Utils.SQLString();
            var dbu = new Utils.DBUtils();

            sql_string.addNewLine("UPDATE Eventi");
            sql_string.addNewLine("SET partecipanti = partecipanti + '_' + '" 
                + ParametriSessione.UsernameSuperUser + "'");
            sql_string.addNewLine("WHERE ID = " + ParametriSessione.ID_EVENTO);

            dbu.EseguiQuery(sql_string.Sql);
        }

        public string[] LeggiElncoAttivita(string id_attivita)
        {
            var sql_string = new Utils.SQLString();
            sql_string.addNewLine("WHERE ID IN ( 0");
            foreach(var a in id_attivita.Split('_'))
            {
                if(a != "")
                sql_string.addNewLine("    ," + a);
            }
            sql_string.addNewLine(")");

            var res = new Attivita.AttivitaFormService().LeggiAttivita(sql_string.Sql);

            string[] retVal = {};
            foreach(System.Data.DataRow row in res.Rows)
            {
                retVal.Append(row["descrizione"].ToString()+" ID: "+ row["ID"].ToString());
            }

            return retVal;
        }

        public string[] LeggiPartecipanti(string usernamePartecipanti)
        {
            var sql_string = new Utils.SQLString();
            sql_string.addNewLine("WHERE username IN ( '0'");
            foreach (var p in usernamePartecipanti.Split('_'))
            {
                sql_string.addNewLine("    ,'" + p + "'");
            }
            sql_string.addNewLine(")");

            var res = new Utente.UtenteFormService().LeggiUtenti(sql_string.Sql);

            string[] retVal = { };
            string[] returnString = { };
            foreach (System.Data.DataRow row in res.Rows)
            {
                returnString = retVal.Append("username: " + row["username"].ToString()).ToArray();
            }

            return returnString;
        }
    }
}