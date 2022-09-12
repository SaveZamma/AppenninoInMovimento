using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento.Utils.Entita
{
    internal class Eventi
    {
        private int _ID = 0;
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private int _ID_ITRATTENIMENTO = 0;
        public int ID_INTRATTENIMENTO
        {
            get { return _ID_ITRATTENIMENTO; }
            set { _ID_ITRATTENIMENTO = value; }
        }
        private string _attivitaSvolte = "";
        public string AttivitaSvolte
        {
            get { return _attivitaSvolte; }
            set { _attivitaSvolte = value; }
        }
        private string _elencoPartecipanti = "";
        public string ElencoPartecipanti
        {
            get { return _elencoPartecipanti; }
            set { _elencoPartecipanti = value; }
        }
        private int _pause = 0;
        public int Pause
        {
            get { return _pause; }
            set { _pause = value; }
        }
        private int _ID_QUOTA = 0;
        public int ID_QUOTA
        {
            get { return _ID_QUOTA; }
            set { _ID_QUOTA = value; }
        }
        private string _descrizione = "";
        public string Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }
    }
}
