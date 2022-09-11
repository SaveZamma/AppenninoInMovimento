using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppenninoInMovimento.Attivita
{
    public partial class AttivitaForm : Form
    {
        public AttivitaForm()
        {
            InitializeComponent();
            this.SetAccordingToTipoOperazione();
        }

        private void SetAccordingToTipoOperazione()
        {
            var fu = new Utils.FromUtils();

            if(ParametriSessione.TipoOperazioneDB == enum_TipoOperazioneDB.READ)
            {
                fu.DisableControls(this);
                fu.HideAndDisableControls(this.exit_btn);
                fu.HideAndDisableControls(this.mdificaAttrezzaturaRiposo_btn);
                fu.HideAndDisableControls(this.modificaAttrezzaturaMovimento_btn);
                fu.HideAndDisableControls(this.modificaPasti_btn);
                fu.HideAndDisableControls(this.modificaVestiario_btn);
                fu.HideAndDisableControls(this.save_btn);
            }
        }

        private void modificaPercorso_btn_Click(object sender, EventArgs e)
        {
            var res = new Percorso.PercorsoForm().ShowDialog();
        }

        public enum enum_TipologiaNecessario
        {
            PASTI = 0,
            MOVIMENTO = 1,
            VESTIARIO = 2,
            RIPOSO = 3
        }

        private void modificaPasti_btn_Click(object sender, EventArgs e)
        {
            var nf = new NecessarioForm();
            nf.tipoNecessario = enum_TipologiaNecessario.PASTI;
            var res = nf.ShowDialog();
        }

        private void modificaVestiario_btn_Click(object sender, EventArgs e)
        {
            var nf = new NecessarioForm();
            nf.tipoNecessario = enum_TipologiaNecessario.VESTIARIO;
            var res = nf.ShowDialog();
        }

        private void modificaAttrezzaturaMovimento_btn_Click(object sender, EventArgs e)
        {
            var nf = new NecessarioForm();
            nf.tipoNecessario = enum_TipologiaNecessario.MOVIMENTO;
            var res = nf.ShowDialog();
        }

        private void mdificaAttrezzaturaRiposo_btn_Click(object sender, EventArgs e)
        {
            var nf = new NecessarioForm();
            nf.tipoNecessario = enum_TipologiaNecessario.RIPOSO;
            var res = nf.ShowDialog();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            Utils.Entita.Attivita attivita = new Utils.Entita.Attivita();

            attivita.Pasti = this.pasti_tb.Text;
            attivita.Durata = this.durata_num.Value;
            attivita.Difficolata = Decimal.ToInt32(this.difficolta_num.Value);
            attivita.DataInizio = this.dataInizio_datepk.Value;
            attivita.DataFine = this.dataFine_datepk.Value;
            attivita.AttrezziMovimento = this.movimento_tb.Text;
            attivita.AttrezziRiposo = this.riposo_tb.Text;
            attivita.Descrizione = this.descrizione_txtbox.Text;
            attivita.NumeroPartecipanti = Decimal.ToInt32(this.numPartecipanti_num.Value);
            attivita.PeriodoConsigliato = this.periodoConsigliato_txtbox.Text;
            attivita.PesoTotale = this.pesoZaino_num.Value;
            attivita.TipologiaZaino = this.zaino_txtbox.Text;
            attivita.Vestiario = this.vestiario_tb.Text;

            new AttivitaFormService().ScriviAttivita(attivita);
        }
    }
}
