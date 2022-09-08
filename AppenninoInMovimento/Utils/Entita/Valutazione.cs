using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento.Utils.Entita
{
    internal class Valutazione
    {
        private int _ID_ATTIVITA = 0;
        public int ID_ATTIVITA
        {
            get { return _ID_ATTIVITA; }
            set { _ID_ATTIVITA = value; }
        }
        private float _valore = 0;
        public float Valore
        {
            get { return _valore; }
            set { _valore = value; }
        }
        private int _nValutazioni = 0;
        public int NValutazioni
        {
            get { return _nValutazioni; }
            set { _nValutazioni = value; }
        }
    }
}
