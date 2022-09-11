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
    }
}
