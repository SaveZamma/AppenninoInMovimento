using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento.Gruppo
{
    internal class GruppoFormService
    {
        public void SaveGroup(Utils.Entita.Gruppo gruppo)
        {
            if (ParametriSessione.TipoOperazioneDB == enum_TipoOperazioneDB.WRITE)
                this.WriteGroup(gruppo);
            if (ParametriSessione.TipoOperazioneDB == enum_TipoOperazioneDB.UPDATE)
                this.UpdateGruop(gruppo);
        }

        private void WriteGroup(Utils.Entita.Gruppo gruppo)
        {
            var sql_string = new Utils.SQLString();

            sql_string.addNewLine("INSERT INTO Gruppi");
            sql_string.addNewLine("VALUES (");
            sql_string.addNewLine("    " + new Utils.DBUtils().NewIntID("Gruppi", "idGruppo") + ",");
            sql_string.addNewLine("    '" + gruppo.Nome + "',");
            sql_string.addNewLine("    ''");
            sql_string.addNewLine(")");

            new Utils.DBUtils().EseguiQuery(sql_string.Sql);
        }

        private void UpdateGruop(Utils.Entita.Gruppo gruppo)
        {
            var sql_string = new Utils.SQLString();

            sql_string.addNewLine("UPDATE Gruppi");
            sql_string.addNewLine("SET");
            sql_string.addNewLine("    nome = '" + gruppo.Nome + "'");
            sql_string.addNewLine("WHERE idGruppo = " + ParametriSessione.ID_GRUPPO);

            new Utils.DBUtils().EseguiQuery(sql_string.Sql);
        }

        public void DeleteGroup()
        {
            var sql_string = new Utils.SQLString();

            sql_string.addNewLine("DELETE FROM Gruppi");
            sql_string.addNewLine("WHERE idGruppo = " + ParametriSessione.ID_GRUPPO);

            new Utils.DBUtils().EseguiQuery(sql_string.Sql);
        }

        public void JoinGroup()
        {
            var sql_string = new Utils.SQLString();

            sql_string.addNewLine("UPDATE Gruppi");
            sql_string.addNewLine("SET partecipanti = partecipanti + '_' + '" +ParametriSessione.UsernameSuperUser + "'");
            sql_string.addNewLine("WHERE idGruppo = " + ParametriSessione.ID_GRUPPO);

            new Utils.DBUtils().EseguiQuery(sql_string.Sql);
        }

        public System.Data.DataRow ReadGroup()
        {
            var sql_string = new Utils.SQLString();

            sql_string.addNewLine("SELECT * FROM Gruppi");
            sql_string.addNewLine("WHERE idGruppo = " + ParametriSessione.ID_GRUPPO);

            var res = new Utils.DBUtils().queryLetturaDT(sql_string.Sql).Rows;

            if (res.Count > 0)
                return res[0];
            else
            {
                MessageBox.Show("Nessun gruppo trovato");
                return null;
            }            
        }

        public System.Data.DataTable ReadsGroups(string parametriRicerca)
        {
            var sql_string = new Utils.SQLString();
            var dbu = new Utils.DBUtils();

            sql_string.addNewLine("SELECT * FROM Gruppi");
            sql_string.addNewLine(parametriRicerca);

            return dbu.queryLetturaDT(sql_string.Sql);
        }
    }
}
