using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento.Intrattenimento
{
    internal class IntrattenimentoFormService
    {
        public System.Data.DataRow LeggiIntrattenimento(int id)
        {
            var sql_string = new Utils.SQLString();
            sql_string.addNewLine("SELECT * FROM Intrattenimenti");
            sql_string.addNewLine("WHERE ID = " + id);

            System.Data.DataTable dt = new Utils.DBUtils().queryLetturaDT(sql_string.Sql);

            if(dt.Rows.Count > 0)
                return dt.Rows[0];
            return null;
        }
    }
}
