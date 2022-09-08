using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento.Utils.Entita
{
    internal class Partecipazione
    {
        private string _ID_UTENTE = "";
        public string ID_UTENTE
        {
            get { return _ID_UTENTE; }
            set { _ID_UTENTE = value; }
        }
        private int _ID_EVENTO= 0;
        public int ID_EVENTO
        {
            get { return _ID_EVENTO; }
            set { _ID_EVENTO = value; }
        }
    }
}
