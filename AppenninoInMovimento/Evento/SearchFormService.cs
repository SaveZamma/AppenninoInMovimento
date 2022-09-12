using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento.Evento
{
    internal class SearchFormService
    {
        public void AddAttivitaToEvento(int ID_ATTIVITA)
        {
            var sql_string = new Utils.SQLString();
            var dbu = new Utils.DBUtils();

            sql_string.addNewLine("UPDATE Eventi");
            sql_string.addNewLine("SET attivita = attivita + '_' + '" + ID_ATTIVITA + "'");
            sql_string.addNewLine("WHERE ID = " + ParametriSessione.ID_EVENTO);

            sql_string.addNewLine("");

            sql_string.addNewLine("UPDATE Attivita");
            sql_string.addNewLine("SET ID_EVENTO = " + ParametriSessione.ID_EVENTO);
            sql_string.addNewLine("WHERE ID = " + ID_ATTIVITA);

            dbu.EseguiQuery(sql_string.Sql);
        }
    }
}
