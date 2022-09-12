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
                fu.HideAndDisableControls(this.save_btn);

                this.join_btn.Enabled =  true;
                this.exit_btn.Enabled = true;
            }
            fu.HideAndDisableControls(this.percorso_lbl);
            fu.HideAndDisableControls(this.percorso_lv);
            fu.HideAndDisableControls(this.luogo_lbl);
            fu.HideAndDisableControls(this.luogo_tb);
            fu.HideAndDisableControls(this.modificaLuogo_btn);
            fu.HideAndDisableControls(this.modificaPercorso_btn);
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

            if(ParametriSessione.TipoOperazioneDB == enum_TipoOperazioneDB.WRITE)
                new AttivitaFormService().ScriviAttivita(attivita);
            if (ParametriSessione.TipoOperazioneDB == enum_TipoOperazioneDB.UPDATE)
                new AttivitaFormService().ModificaAttivita(attivita);
        }

        private void modificaLuogo_btn_Click(object sender, EventArgs e)
        {
            new Luogo.LuogoFrom().ShowDialog();
        }

        private void AttivitaForm_Load(object sender, EventArgs e)
        {
            if(ParametriSessione.TipoOperazioneDB == enum_TipoOperazioneDB.READ ||
                ParametriSessione.TipoOperazioneDB == enum_TipoOperazioneDB.UPDATE)
            {
                this.PopolaPagina();
            }
        }

        private void PopolaPagina()
        {
            DataRow res = new AttivitaFormService().LeggiSingleAttivita();

            this.descrizione_txtbox.Text = res["descrizione"].ToString();
            this.dataInizio_datepk.Value = DateTime.Parse(res["dataInizio"].ToString());
            this.dataFine_datepk.Value = DateTime.Parse(res["dataFine"].ToString());
            this.durata_num.Value = Int32.Parse( res["durata"].ToString());
            this.difficolta_num.Value = Int32.Parse(res["difficolta"].ToString());
            this.periodoConsigliato_txtbox.Text = res["periodoConsigliato"].ToString();
            this.numPartecipanti_num.Value = Int32.Parse(res["partecipanti"].ToString());
            this.vestiario_tb.Text = res["vestiario"].ToString();
            this.movimento_tb.Text = res["attrezzaturaMovimento"].ToString();
            this.riposo_tb.Text = res["attrezzaturaRiposo"].ToString();
            this.pasti_tb.Text = res["pasti"].ToString();
            this.pesoZaino_num.Value = Int32.Parse(res["pesoZaino"].ToString());
            this.zaino_txtbox.Text = res["zaino"].ToString();
            this.luogo_tb.Text = "";
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void join_btn_Click(object sender, EventArgs e)
        {
            new AttivitaFormService().JoinAttivita();
        }
    }
}
