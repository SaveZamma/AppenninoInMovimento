using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento
{
    public static class ParametriSessione
    {
        private static string _usernameSuperUser = "";
        public static string UsernameSuperUser
        {
            get { return _usernameSuperUser; }
            set { _usernameSuperUser = value; }
        }

        private static string _username = "";
        public static string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        private static string _password = "";
        public static string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private static int _ID_ATTIVITA = 0;
        public static int ID_ATTIVITA
        {
            get { return _ID_ATTIVITA; }
            set { _ID_ATTIVITA = value; }
        }

        private static int _ID_EVENTO = 0;
        public static int ID_EVENTO
        {
            get { return _ID_EVENTO; }
            set { _ID_EVENTO = value; }
        }

        private static float _lat = 0;
        public static float Lat
        {
            get { return _lat; }
            set { _lat = value; }
        }
        private static float _lng = 0;
        public static float Lng
        {
            get { return _lng; }
            set { _lng = value; }
        }

        private static int _ID_INTRATTENIMENTO = 0;
        public static int ID_INTARTTENIMENTO
        {
            get { return _ID_INTRATTENIMENTO; }
            set { _ID_INTRATTENIMENTO = value; }
        }

        private static int _ID_GRUPPO = 0;
        public static int ID_GRUPPO
        {
            get { return _ID_GRUPPO; }
            set { _ID_GRUPPO = value; }
        }

        private static int _ID_TAPPA = 0;
        public static int ID_TAPPA
        {
            get { return _ID_TAPPA; }
            set { _ID_TAPPA = value; }
        }

        private static enum_TipoOperazioneDB _tipoOperazioneDB = enum_TipoOperazioneDB.READ;
        public static enum_TipoOperazioneDB TipoOperazioneDB
        {
            get { return _tipoOperazioneDB; }
            set { _tipoOperazioneDB = value; }
        }

        public static void ResetParams()
        {
            ID_ATTIVITA = 0;
            ID_EVENTO = 0;
            ID_GRUPPO = 0;
            ID_INTARTTENIMENTO = 0;
            ID_TAPPA = 0;
            Username = "";
            Lat = 0;
            Lng = 0;
            TipoOperazioneDB = enum_TipoOperazioneDB.READ;
        }
    }

    public enum enum_TipoOperazioneDB
    {
        READ = 0,
        WRITE = 1,        
        UPDATE = 2,
        DELETE = 3
    }
}
