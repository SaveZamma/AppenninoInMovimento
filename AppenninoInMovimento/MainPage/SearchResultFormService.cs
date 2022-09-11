using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento.MainPage
{
    internal class SearchResultFormService
    {
        public System.Data.DataTable LeggiDatiDT(string parametriLettura)
        {
            return new Attivita.AttivitaFormService().LeggiAttivita(parametriLettura); 
        }

        public void RemoveSelectedItem(string ID, MainPage.MainPageForm.enum_TipoRicerca tipoRicerca)
        {
            if (tipoRicerca == MainPageForm.enum_TipoRicerca.ATTIVITA)
            {
                ParametriSessione.ID_ATTIVITA = Int32.Parse(ID);
                new Attivita.AttivitaFormService().EliminaAttivita();
            }
            else if(tipoRicerca == MainPageForm.enum_TipoRicerca.UTENTE)
            {
                var sql_string = new Utils.SQLString();
                sql_string.addNewLine("DELETE FROM Utenti");
                sql_string.addNewLine("WHERE username = '" + ID + "'");

                new Utils.DBUtils().EseguiQuery(sql_string.Sql);
            }
            else if (tipoRicerca == MainPageForm.enum_TipoRicerca.EVENTO)
            {
                ParametriSessione.ID_EVENTO = Int32.Parse(ID);
                new Evento.EventoFormService().EliminaEvento();                
            }
            else if (tipoRicerca == MainPageForm.enum_TipoRicerca.GRUPPO)
            {
                ParametriSessione.ID_GRUPPO = Int32.Parse(ID);

                var sql_string = new Utils.SQLString();
                sql_string.addNewLine("DELETE FROM Attivita");
                sql_string.addNewLine("WHERE idGruppo = " + ID);

                new Utils.DBUtils().EseguiQuery(sql_string.Sql);
            }
        }
    }
}
