using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento.Attivita
{
    internal class AttivitaFormService
    {
        internal void ScriviAttivita(Utils.Entita.Attivita newactivity)
        {
            var sql_string = new Utils.SQLString();
            var dbu = new Utils.DBUtils();

            sql_string.addNewLine("INSERT INTO Attivita");
            sql_string.addNewLine("VALUES (");
            sql_string.addNewLine("    " + dbu.NewIntID("Attivita", "ID") + ",");
            sql_string.addNewLine("    '" + newactivity.Descrizione + "',");
            sql_string.addNewLine("    '" + newactivity.DataInizio + "',");
            sql_string.addNewLine("    '" + newactivity.DataFine + "',");
            sql_string.addNewLine("    " + newactivity.Durata + ",");
            sql_string.addNewLine("    " + newactivity.Difficolata + ",");
            sql_string.addNewLine("    '" + newactivity.PeriodoConsigliato + "',");
            sql_string.addNewLine("    " + newactivity.NumeroPartecipanti + ",");
            sql_string.addNewLine("    '" + newactivity.Vestiario + "',");
            sql_string.addNewLine("    '" + newactivity.AttrezziMovimento + "',");
            sql_string.addNewLine("    '" + newactivity.AttrezziRiposo + "',");
            sql_string.addNewLine("    '" + newactivity.Pasti + "',");
            sql_string.addNewLine("    " + newactivity.PesoTotale + ",");
            sql_string.addNewLine("    '" + newactivity.TipologiaZaino + "',");
            sql_string.addNewLine("    NULL,");
            sql_string.addNewLine("    " + newactivity.ID_LUOGO + "");
            sql_string.addNewLine(")");

            //TODO: inserire scrittura percorso

            dbu.queryScrittura(sql_string.Sql);
        }
    }
}
