using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento.Utils.Entita
{
    internal class Amicizia
    {
        private string _ID_UTENTE = "";
        public string ID_UTENTE
        {
            get { return _ID_UTENTE; }
            set { _ID_UTENTE = value; }
        }
        private string _ID_AMICO = "";
        public string ID_AMICO
        {
            get { return _ID_AMICO; }
            set { _ID_AMICO = value; }
        }
    }
}
