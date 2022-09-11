using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento.MainPage
{
    internal class MainPageFormService
    {
        public void OpenAttivitaSearchResult(string parametriLettura)
        {
            var srf = new MainPage.SearchResultForm(parametriLettura);
            srf.tipoRicerca = MainPage.MainPageForm.enum_TipoRicerca.ATTIVITA;

            srf.ShowDialog();
        }

        public void OpenGroupSearchResult(string parametriLettura)
        {
            var srf = new MainPage.SearchResultForm(parametriLettura);
            srf.tipoRicerca = MainPage.MainPageForm.enum_TipoRicerca.GRUPPO;

            srf.ShowDialog();
        }

        public void OpenEventiSearchResult(string parametriLettura)
        {
            var srf = new MainPage.SearchResultForm(parametriLettura);
            srf.tipoRicerca = MainPage.MainPageForm.enum_TipoRicerca.EVENTO;

            srf.ShowDialog();
        }

        public void OpenUtentiSearchResult(string parametriLettura)
        {
            var srf = new MainPage.SearchResultForm(parametriLettura);
            srf.tipoRicerca = MainPage.MainPageForm.enum_TipoRicerca.UTENTE;

            srf.ShowDialog();
        }
    }
}
