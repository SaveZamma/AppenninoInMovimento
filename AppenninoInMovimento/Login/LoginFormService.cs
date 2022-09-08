using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento.LoginFormService
{
    internal class LoginFormService
    {
        public System.Data.DataTable checkUserInDB(string username, string password)
        {
            Utils.SQLString sql_string = new Utils.SQLString();
            sql_string.addNewLine("SELECT * FROM CredenzialiAccesso");
            sql_string.addNewLine("WHERE username = '" + username + "'");
            sql_string.addNewLine("AND password = '" + password + "'");

            return new Utils.DBUtils().queryLetturaDT(sql_string.Sql);
        }
    }
}
