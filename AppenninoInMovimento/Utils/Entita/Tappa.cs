using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento.Utils.Entita
{
    internal class Tappa
    {
        private int _ID = 0;
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private int _ID_PERCORSO = 0;
        public int ID_PERCORSO
        {
            get { return _ID_PERCORSO; }
            set { _ID_PERCORSO = value; }
        }
        private float _lunghezza = 0;
        public float Lunghezza
        {
            get { return _lunghezza; }
            set { _lunghezza = value; }
        }
    }
}
