using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppenninoInMovimento.MainPage
{
    public partial class MainPageForm : Form
    {
        public MainPageForm()
        {
            InitializeComponent();
        }

        private void modificaDatiUtente_btn_Click(object sender, EventArgs e)
        {
            ParametriSessione.TipoOperazioneDB = enum_TipoOperazioneDB.UPDATE;
            var uf = new UtenteForm();
            var res = uf.ShowDialog();
        }

        public enum enum_TipoRicerca
        {
            ATTIVITA = 0,
            EVENTO = 1,
            UTENTE = 2,
            GRUPPO = 3
        }
        private void MainPageForm_Load(object sender, EventArgs e)
        {

        }

        private void ricercaAttivita_btn_Click(object sender, EventArgs e)
        {
            var sql_string = new Utils.SQLString();
            sql_string.addNewLine("WHERE 1 = 1");
            sql_string.addNewLine("    AND descrizione LIKE '%" + this.descrizioneAttivita_txtbox.Text + "%'");
            sql_string.addNewLine("    AND periodoConsigliato LIKE '%" + this.periodo_tb.Text + "%'");
            if(this.numPartecipanti_num.Value > 0)
                sql_string.addNewLine("    AND partecipanti = " + Decimal.ToInt32(this.numPartecipanti_num.Value) + "");
            if(this.difficolta_num.Value > 0)
                sql_string.addNewLine("    AND difficolta = " + Decimal.ToInt32(this.difficolta_num.Value) + "");

            new MainPageFormService().OpenAttivitaSearchResult(sql_string.Sql);
        }

        private void createAttivita_btn_Click(object sender, EventArgs e)
        {
            ParametriSessione.TipoOperazioneDB = enum_TipoOperazioneDB.WRITE;
            var af = new Attivita.AttivitaForm();
            var res = af.ShowDialog();
        }

        private void searchUser_btn_Click(object sender, EventArgs e)
        {
            var sql_string = new Utils.SQLString();
            sql_string.addNewLine("WHERE 1 = 1");
            sql_string.addNewLine("    AND nome LIKE '%" + this.nome_tb.Text + "%'");
            sql_string.addNewLine("    AND cognome LIKE '%" + this.cognome_tb.Text + "%'");
            sql_string.addNewLine("    AND username LIKE '%" + this.username_tb.Text + "%'");

            new MainPageFormService().OpenUtentiSearchResult(sql_string.Sql);
        }

        private void searchEvents_btn_Click(object sender, EventArgs e)
        {
            var sql_string = new Utils.SQLString();
            sql_string.addNewLine("WHERE 1 = 1");
            sql_string.addNewLine("    AND descrizione LIKE '%" + this.eventoDescrizione_tb.Text + "%'");

            new MainPageFormService().OpenEventiSearchResult(sql_string.Sql);
        }

        private void searchGroup_btn_Click(object sender, EventArgs e)
        {
            var sql_string = new Utils.SQLString();
            sql_string.addNewLine("WHERE 1 = 1");
            sql_string.addNewLine("    AND nome LIKE '%" + this.descrizioneGruppo_tb.Text + "%'");

            new MainPageFormService().OpenGroupSearchResult(sql_string.Sql);
        }

        private void nuovoEvento_btn_Click(object sender, EventArgs e)
        {
            ParametriSessione.TipoOperazioneDB = enum_TipoOperazioneDB.WRITE;
            new Evento.EventoForm().ShowDialog();
        }

        private void nuovoGruppo_btn_Click(object sender, EventArgs e)
        {
            ParametriSessione.TipoOperazioneDB = enum_TipoOperazioneDB.WRITE;
            new Gruppo.GruppoForm().ShowDialog();
        }
    }
}
