using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento.Utils.Entita
{
    internal class Gruppo
    {
        private int _ID = 0;
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private string _partecipanti = "";
        public string Partecipanti
        {
            get { return _partecipanti; }
            set { _partecipanti = value; }
        }
        private string _nome = "";
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
    }
}
