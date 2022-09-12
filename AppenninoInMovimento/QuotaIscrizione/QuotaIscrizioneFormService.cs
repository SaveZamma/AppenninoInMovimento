using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento.QuotaIscrizione
{
    internal class QuotaIscrizioneFormService
    {
        public void ScriviQuotaIscrizione(decimal prezzo, int sconto)
        {
            var sql_string = new Utils.SQLString();
            var dbu = new Utils.DBUtils();

            sql_string.addNewLine("INSERT INTO QuotaIscrizioni");
            sql_string.addNewLine("VALUES (");
            sql_string.addNewLine("    " + prezzo.ToString().Replace(",", ".") + ",");
            sql_string.addNewLine("    " + sconto);
            sql_string.addNewLine(")");

            dbu.EseguiQuery(sql_string.Sql);
        }

        public System.Data.DataRow LeggiSingleQuota(decimal prezzo)
        {
            var sql_string = new Utils.SQLString();
            var dbu = new Utils.DBUtils();

            sql_string.addNewLine("SELECT * FROM QuotaIscrizioni");
            sql_string.addNewLine("WHERE prezzo = " + prezzo.ToString().Replace(",", "."));

            var dt = dbu.queryLetturaDT(sql_string.Sql);

            if(dt.Rows.Count>0)
                return dt.Rows[0];
            return null;
        }
    }
}
