using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento.Utils.Entita
{
    internal class Percorso
    {
        private int _ID_ATTIVITA = 0;
        public int ID_ATTIVITA
        {
            get { return _ID_ATTIVITA; }
            set { _ID_ATTIVITA = value; }
        }
        private int _dislivello = 0;
        public int Dislivello
        {
            get { return _dislivello; }
            set { _dislivello = value; }
        }
        private float _lunghezza = 0;
        public float Lunghezza
        {
            get { return _lunghezza; }
            set { _lunghezza = value; }
        }
    }
}
