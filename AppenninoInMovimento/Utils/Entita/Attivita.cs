using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento.Utils.Entita
{
    internal class Attivita
    {
        private int _ID = 0;
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private string _descrizione = "";
        public string Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }
        private DateTime _dataInizio = DateTime.Today;
        public DateTime DataInizio
        {
            get { return _dataInizio; }
            set { _dataInizio = value; }
        }
        private DateTime _dataFine = DateTime.Today;
        public DateTime DataFine
        {
            get { return _dataFine; }
            set { _dataFine = value; }
        }
        private TimeSpan _durata = TimeSpan.Zero;
        public TimeSpan Durata
        {
            get { return _durata; }
            set { _durata = value; }
        }
        private int _difficolta = 0;
        public int Difficolata
        {
            get { return _difficolta; }
            set { _difficolta = value; }
        }
        private TimeSpan _periodoConsigliato = TimeSpan.Zero;
        public TimeSpan PeriodoConsigliato
        {
            get { return _periodoConsigliato; }
            set { _periodoConsigliato = value; }
        }
        private int _numeroPartecipanti = 0;
        public int NumeroPartecipanti
        {
            get { return _numeroPartecipanti; }
            set { _numeroPartecipanti = value; }
        }
        private string _vestiario = "";
        public string Vestiario
        {
            get { return _vestiario; }
            set { _vestiario = value; }
        }
        private string _attrezziMovimento = "";
        public string AttrezziMovimento
        {
            get { return _attrezziMovimento; }
            set { _attrezziMovimento = value; }
        }
        private string _attrezziRiposo = "";
        public string AttrezziRiposo
        {
            get { return _attrezziRiposo; }
            set { _attrezziRiposo = value; }
        }
        private string _pasti = "";
        public string Pasti
        {
            get { return _pasti; }
            set { _pasti = value; }
        }
        private float _pesoTotale = 0;
        public float PesoTotale
        {
            get { return _pesoTotale; }
            set { _pesoTotale = value; }
        }
        private string _tipologiaZaino = "";
        public string TipologiaZaino
        {
            get { return _tipologiaZaino; }
            set { _tipologiaZaino = value; }
        }
        private string _eventi = "";
        public string Eventi
        {
            get { return _eventi; }
            set { _eventi = value; }
        }
        private int _ID_LUOGO = 0;
        public int ID_LUOGO
        {
            get { return _ID_LUOGO; }
            set { _ID_LUOGO = value; }
        }
    }
}
