using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento.Utils.Entita
{
    internal class Utente
    {
        private string _CF = "";
        public string CF
        {
            get { return _CF; }
            set { _CF = value; }
        }
        private string _nome = "";
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private string _cognome = "";
        public string Cognome
        {
            get { return _cognome; }
            set { _cognome = value; }
        }
        private DateTime _dataNascita = DateTime.Now;
        public DateTime DataNascita
        {
            get { return _dataNascita; }
            set { _dataNascita = value; }
        }
        private string _telefono = "";
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        private DateTime _dataIscrizione = DateTime.Now;
        public DateTime DataIscrizione
        {
            get { return _dataIscrizione; }
            set { _dataIscrizione = value; }
        }
        private bool _organizzatore = false;
        public bool Organizzatore
        {
            get { return _organizzatore; }
            set { _organizzatore = value; }
        }
        private string _username = "";
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        private string _password = "";
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
