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
    }
}
