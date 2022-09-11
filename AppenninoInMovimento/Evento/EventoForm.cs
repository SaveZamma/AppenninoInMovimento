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
    }
}
