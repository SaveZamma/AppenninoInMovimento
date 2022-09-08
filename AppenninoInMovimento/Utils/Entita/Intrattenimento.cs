using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento.Utils.Entita
{
    internal class Intrattenimento
    {
        private int _ID = 0;
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private string _tipologia = "";
        public string Tipologia
        {
            get { return _tipologia; }
            set { _tipologia = value; }
        }
        private TimeSpan _durata = TimeSpan.Zero;
        public TimeSpan Durata
        {
            get { return _durata; }
            set { _durata = value; }
        }
        private string _staff = "";
        public string Staff
        {
            get { return _staff; }
            set { _staff = value; }
        }
    }
}
