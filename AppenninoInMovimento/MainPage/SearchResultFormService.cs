using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento.MainPage
{
    internal class SearchResultFormService
    {
        public System.Data.DataTable LeggiDatiDT(string parametriLettura, MainPage.MainPageForm.enum_TipoRicerca tipoRicerca)
        {
            if (tipoRicerca == MainPageForm.enum_TipoRicerca.ATTIVITA)
                return new Attivita.AttivitaFormService().LeggiAttivita(parametriLettura);
            if (tipoRicerca == MainPageForm.enum_TipoRicerca.UTENTE)
                return new Utente.UtenteFormService().LeggiUtenti(parametriLettura);
            if (tipoRicerca == MainPageForm.enum_TipoRicerca.GRUPPO)
                return new Gruppo.GruppoFormService().ReadsGroups(parametriLettura);
            if (tipoRicerca == MainPageForm.enum_TipoRicerca.EVENTO)
                return new Evento.EventoFormService().LeggiEventi(parametriLettura);

            return new System.Data.DataTable();
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
                ParametriSessione.Username = ID.TrimStart();
                new Utente.UtenteFormService().DeleteUser();
            }
            else if (tipoRicerca == MainPageForm.enum_TipoRicerca.EVENTO)
            {
                ParametriSessione.ID_EVENTO = Int32.Parse(ID);
                new Evento.EventoFormService().EliminaEvento();                
            }
            else if (tipoRicerca == MainPageForm.enum_TipoRicerca.GRUPPO)
            {
                ParametriSessione.ID_GRUPPO = Int32.Parse(ID);
                new Gruppo.GruppoFormService().DeleteGroup();
            }
        }
    }
}
