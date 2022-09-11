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

        private void ricercaAttivita_btn_Click(object sender, EventArgs e)
        {
            var srf = new SearchResultForm();
            srf.tipoRicerca = enum_TipoRicerca.ATTIVITA;
            var res = srf.ShowDialog();
        }

        private void createAttivita_btn_Click(object sender, EventArgs e)
        {
            ParametriSessione.TipoOperazioneDB = enum_TipoOperazioneDB.WRITE;
            var af = new Attivita.AttivitaForm();
            var res = af.ShowDialog();
        }

        private void searchUser_btn_Click(object sender, EventArgs e)
        {
            var srf = new SearchResultForm();
            srf.tipoRicerca = enum_TipoRicerca.UTENTE;
            var res = srf.ShowDialog();
        }

        private void searchEvents_btn_Click(object sender, EventArgs e)
        {
            var srf = new SearchResultForm();
            srf.tipoRicerca = enum_TipoRicerca.EVENTO;
            var res = srf.ShowDialog();
        }
    }
}
