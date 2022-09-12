using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppenninoInMovimento.Evento
{
    public partial class EventoForm : Form
    {
        public EventoForm()
        {
            InitializeComponent();
            this.SetAccordingToTipoOperazione();
        }

        private void SetAccordingToTipoOperazione()
        {
            var fu = new Utils.FromUtils();

            if (ParametriSessione.TipoOperazioneDB == enum_TipoOperazioneDB.WRITE)
            {                
                fu.HideAndDisableControls(this.subscribe_btn);
            }
            else if (ParametriSessione.TipoOperazioneDB == enum_TipoOperazioneDB.READ)
            {
                fu.DisableControls(this);
                fu.HideControls(this.modificaAttivita_btn);
                fu.HideControls(this.modificaIntrattenimento_btn);
                this.subscribe_btn.Enabled = true;
            }
        }

        private void salva_btn_Click(object sender, EventArgs e)
        {
            Utils.Entita.Eventi evento = new Utils.Entita.Eventi();

            foreach (string a in this.attivitaPreviste_lb.Items)
            {
                evento.AttivitaSvolte += (a + "_");
            }
            evento.Descrizione = this.nome_txtbox.Text;
            foreach (string p in this.elencoPartecipanti_lb.Items)
            {
                evento.ElencoPartecipanti += (p + "_");
            }
            if(this.intrattenimento_tb.Text != "")
                evento.ID_INTRATTENIMENTO = Int32.Parse(this.intrattenimento_tb.Text.Split(":")[1]);
            
            evento.ID_QUOTA = Int32.Parse(this.quota_txtbox.Text.Split(":")[1].Split("S")[0]);
            evento.Pause = Int32.Parse(this.pause_num.Value.ToString());

            new EventoFormService().ScriviEvento(evento);
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void subscribe_btn_Click(object sender, EventArgs e)
        {
            foreach (string p in this.elencoPartecipanti_lb.Items)
            {
                if (p == ParametriSessione.UsernameSuperUser) return;
            }
            new EventoFormService().JoinEvento();
        }

        private void modificaAttivita_btn_Click(object sender, EventArgs e)
        {
            string attivitaEvento = "";
            foreach(var i in this.attivitaPreviste_lb.Items)
            {
                attivitaEvento += i.ToString().Split(":")[1];
            }
            new SearchForm(attivitaEvento).ShowDialog();
        }

        private void modificaQuota_btn_Click(object sender, EventArgs e)
        {
            var form = new QuotaIscrizione.QuotaIscrizione();
            var res = form.ShowDialog();

            this.quota_txtbox.Text = "Prezzo: " + form.retPrezzo.ToString() + " Sconto: " + form.retSconto + "%";
        }

        private void EventoForm_Load(object sender, EventArgs e)
        {
            var efs = new EventoFormService();
            DataRow evento = efs.LeggiSingleEvento();

            if(evento != null)
            {
                this.pause_num.Value = Decimal.Parse(evento["pause"].ToString());
                this.attivitaPreviste_lb.DataSource = efs.LeggiElncoAttivita(evento["attivita"].ToString());
                this.elencoPartecipanti_lb.DataSource = efs.LeggiPartecipanti(evento["partecipanti"].ToString());
                DataRow row = new Intrattenimento.IntrattenimentoFormService().LeggiIntrattenimento(Int32.Parse(evento["ID_INTRATTENIMENTO"].ToString()));
                
                if(row != null)
                    this.intrattenimento_tb.Text = row["tipologia"] + "ID:" + row["ID"];

                DataRow quota = new QuotaIscrizione.QuotaIscrizioneFormService().LeggiSingleQuota( Decimal.Parse(evento["ID_QUOTA"].ToString()));
                this.quota_txtbox.Text = "Prezzo: " + quota["prezzo"] + " Sconto: " + quota["sconto"].ToString();
                this.nome_txtbox.Text = evento["descrizione"].ToString();
            }
        }
    }
}
