using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppenninoInMovimento.Gruppo
{
    public partial class GruppoForm : Form
    {
        public GruppoForm()
        {
            InitializeComponent();
            this.SetAccordingToTipoOperazione();
        }

        private void SetAccordingToTipoOperazione()
        {
            var fu = new Utils.FromUtils();

            if (ParametriSessione.TipoOperazioneDB == enum_TipoOperazioneDB.READ)
            {
                fu.HideAndDisableControls(this.save_btn);
                fu.DisableControls(this);
                this.join_btn.Enabled = true;
            }
            else if(ParametriSessione.TipoOperazioneDB == enum_TipoOperazioneDB.WRITE)
            {
                fu.HideAndDisableControls(this.join_btn);
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            var gruppo = new Utils.Entita.Gruppo();
            gruppo.Nome = this.nome_txtbox.Text;
            new GruppoFormService().SaveGroup(gruppo);
        }

        private void join_btn_Click(object sender, EventArgs e)
        {
            new GruppoFormService().JoinGroup();
        }

        private void GruppoForm_Load(object sender, EventArgs e)
        {
            if(ParametriSessione.TipoOperazioneDB == enum_TipoOperazioneDB.READ ||
                ParametriSessione.TipoOperazioneDB == enum_TipoOperazioneDB.UPDATE)
            {
                DataRow r = new GruppoFormService().ReadGroup();
                if (r != null)
                    this.PopolaForm(r);
            }            
        }

        private void PopolaForm(DataRow r)
        {
            this.nome_txtbox.Text = r["nome"].ToString();
            var partecipanti = r["partecipanti"].ToString().Split("_");

            foreach (string user in partecipanti)
            {
                ListViewItem item = new ListViewItem(user);                
                this.partecipanti_lv.Items.Add(item);
            }
        }
    }
}
