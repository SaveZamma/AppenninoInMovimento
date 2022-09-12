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
            sql_string.addNewLine("    " + newactivity.Durata.ToString().Replace(",",".") + ",");
            sql_string.addNewLine("    " + newactivity.Difficolata + ",");
            sql_string.addNewLine("    '" + newactivity.PeriodoConsigliato + "',");
            sql_string.addNewLine("    " + newactivity.NumeroPartecipanti + ",");
            sql_string.addNewLine("    '" + newactivity.Vestiario + "',");
            sql_string.addNewLine("    '" + newactivity.AttrezziMovimento + "',");
            sql_string.addNewLine("    '" + newactivity.AttrezziRiposo + "',");
            sql_string.addNewLine("    '" + newactivity.Pasti + "',");
            sql_string.addNewLine("    " + newactivity.PesoTotale + ",");
            sql_string.addNewLine("    '" + newactivity.TipologiaZaino + "',");
            sql_string.addNewLine("    0,");
            sql_string.addNewLine("    " + newactivity.ID_LUOGO + "");
            sql_string.addNewLine(")");

            //TODO: inserire scrittura percorso

            var res = dbu.EseguiQuery(sql_string.Sql);
        }

        internal void ModificaAttivita(Utils.Entita.Attivita newactivity)
        {
            var sql_string = new Utils.SQLString();
            var dbu = new Utils.DBUtils();
            var ID = ParametriSessione.ID_ATTIVITA;

            sql_string.addNewLine("UPDATE Attivita");
            sql_string.addNewLine("SET");
            sql_string.addNewLine("    descrizione = '" + newactivity.Descrizione + "',");
            sql_string.addNewLine("    dataInizio = '" + newactivity.DataInizio + "',");
            sql_string.addNewLine("    datafine = '" + newactivity.DataFine + "',");
            sql_string.addNewLine("    durata = " + newactivity.Durata + ",");
            sql_string.addNewLine("    difficolta = " + newactivity.Difficolata + ",");
            sql_string.addNewLine("    periodoConsigliato = '" + newactivity.PeriodoConsigliato + "',");
            sql_string.addNewLine("    partecipanti = " + newactivity.NumeroPartecipanti + ",");
            sql_string.addNewLine("    vestiario = '" + newactivity.Vestiario + "',");
            sql_string.addNewLine("    attrezzaturaMovimento = '" + newactivity.AttrezziMovimento + "',");
            sql_string.addNewLine("    attrezzaturaRiposo = '" + newactivity.AttrezziRiposo + "',");
            sql_string.addNewLine("    pasti = '" + newactivity.Pasti + "',");
            sql_string.addNewLine("    pesoZaino = " + newactivity.PesoTotale + ",");
            sql_string.addNewLine("    zaino = '" + newactivity.TipologiaZaino + "',");
            sql_string.addNewLine("    ID_LUOGO = " + newactivity.ID_LUOGO + "");

            sql_string.addNewLine("WHERE ID = " + ID);

            //TODO: inserire scrittura percorso

            var res = dbu.EseguiQuery(sql_string.Sql);
        }

        internal System.Data.DataRow LeggiSingleAttivita()
        {
            var sql_string = new Utils.SQLString();
            var dbu = new Utils.DBUtils();
            var ID = ParametriSessione.ID_ATTIVITA;

            sql_string.addNewLine("SELECT * FROM Attivita");
            sql_string.addNewLine("WHERE ID = " + ID);

            return dbu.queryLetturaDT(sql_string.Sql).Rows[0];
        }
        internal System.Data.DataTable LeggiAttivita(string parametriRicerca)
        {
            var sql_string = new Utils.SQLString();
            var dbu = new Utils.DBUtils();

            sql_string.addNewLine("SELECT Attivita.*, Valutazioni.valutazione FROM Attivita");
            sql_string.addNewLine("LEFT JOIN Valutazioni");
            sql_string.addNewLine("ON Attivita.ID = Valutazioni.ID_ATTIVITA");
            sql_string.addNewLine(parametriRicerca);
            sql_string.addNewLine("ORDER BY Valutazioni.valutazione DESC");

            return dbu.queryLetturaDT(sql_string.Sql);
        }

        internal void EliminaAttivita()
        {
            var DR_attivita = this.LeggiSingleAttivita();
            ParametriSessione.ID_EVENTO = Int32.Parse(DR_attivita["ID_EVENTO"].ToString());

            var sql_string = new Utils.SQLString();
            if (ParametriSessione.ID_EVENTO != 0)
            {
                new Evento.EventoFormService().EliminaEvento();
            }
            sql_string.addNewLine("DELETE FROM Attivita");
            sql_string.addNewLine("WHERE ID = " + ParametriSessione.ID_ATTIVITA);

            sql_string.addNewLine("DELETE FROM Iscrizioni");
            sql_string.addNewLine("WHERE ID_ATTIVITA = " + ParametriSessione.ID_ATTIVITA);

            new Utils.DBUtils().EseguiQuery(sql_string.Sql);
        }

        internal void JoinAttivita()
        {
            var sql_string = new Utils.SQLString();
            sql_string.addNewLine("INSERT INTO Iscrizioni");
            sql_string.addNewLine("VALUES (");
            sql_string.addNewLine("    '" + ParametriSessione.UsernameSuperUser + "',");
            sql_string.addNewLine("    " + ParametriSessione.ID_ATTIVITA + "");
            sql_string.addNewLine(")");

            new Utils.DBUtils().EseguiQuery(sql_string.Sql);
        }
    }
}
