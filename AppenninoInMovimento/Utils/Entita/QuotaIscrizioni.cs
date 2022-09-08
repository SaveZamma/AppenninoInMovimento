using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento.Utils.Entita
{
    internal class QuotaIscrizioni
    {
        private float _prezzo = 0;
        public float Prezzo
        {
            get { return _prezzo; }
            set { _prezzo = value; }
        }
        private float _sconto = 0;
        public float Sconto
        {
            get { return _sconto; }
            set { _sconto = value; }
        }
    }
}
