using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento.Utils.Entita
{
    internal class Segue
    {
        private int _ID_TAPPA1 = 0;
        public int ID_TAPPA1
        {
            get { return _ID_TAPPA1; }
            set { _ID_TAPPA1 = value; }
        }
        private int _ID_TAPPA2 = 0;
        public int ID_TAPPA2
        {
            get { return _ID_TAPPA2; }
            set { _ID_TAPPA2 = value; }
        }
        private int _ID_PERCORSO = 0;
        public int ID_PERCORSO
        {
            get { return _ID_PERCORSO; }
            set { _ID_PERCORSO = value; }
        }
    }
}
