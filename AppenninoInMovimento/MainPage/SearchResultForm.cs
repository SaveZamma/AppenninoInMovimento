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
    public partial class SearchResultForm : Form
    {
        public MainPageForm.enum_TipoRicerca tipoRicerca = MainPageForm.enum_TipoRicerca.ATTIVITA;
        public SearchResultForm()
        {
            InitializeComponent();
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            ParametriSessione.TipoOperazioneDB = enum_TipoOperazioneDB.DELETE;
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            ParametriSessione.TipoOperazioneDB = enum_TipoOperazioneDB.UPDATE;
            var form = this.OpenCorrespodingFrom();
            form.ShowDialog();
        }

        private void look_btn_Click(object sender, EventArgs e)
        {
            ParametriSessione.TipoOperazioneDB = enum_TipoOperazioneDB.READ;
            var form = this.OpenCorrespodingFrom();
            form.ShowDialog();
        }

        private Form OpenCorrespodingFrom()
        {
            try
            {
                switch (this.tipoRicerca)
                {
                    case MainPageForm.enum_TipoRicerca.ATTIVITA:
                        {
                            return new Attivita.AttivitaForm();
                        }
                    case MainPageForm.enum_TipoRicerca.UTENTE:
                        {
                            return new UtenteForm();
                        }
                    case MainPageForm.enum_TipoRicerca.GRUPPO:
                        {
                            return new Gruppo.GruppoForm();
                        }
                    case MainPageForm.enum_TipoRicerca.EVENTO:
                        {
                            return new Evento.EventoForm();
                        }
                    default: throw new NotImplementedException("Valore non presente in enum_TipoRicerca: OpenCorrespondingForm()");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
    }
}
