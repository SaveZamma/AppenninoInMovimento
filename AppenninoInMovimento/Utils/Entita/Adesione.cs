using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento.Utils.Entita
{
    internal class Adesione
    {
        private string _ID_UTENTE = "";
        public string ID_UTENTE
        {
            get { return _ID_UTENTE; }
            set { _ID_UTENTE = value; }
        }
        private int _ID_GRUPPO = 0;
        public int ID_GRUPPO
        {
            get { return _ID_GRUPPO; }
            set { _ID_GRUPPO = value; }
        }
    }
}
