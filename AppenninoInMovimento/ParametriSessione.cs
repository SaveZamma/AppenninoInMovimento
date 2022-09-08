using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento
{
    public static class ParametriSessione
    {

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

        private static string _CF = "";
        public static string CF
        {
            get { return _CF; }
            set { _CF = value; }
        }
    }
}
