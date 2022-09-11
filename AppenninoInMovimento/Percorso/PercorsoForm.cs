using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppenninoInMovimento.Percorso
{
    public partial class PercorsoForm : Form
    {
        public PercorsoForm()
        {
            InitializeComponent();
        }

        private void SetAccordingToTipoOperazione()
        {
            var fu = new Utils.FromUtils();

            if(ParametriSessione.TipoOperazioneDB == enum_TipoOperazioneDB.READ)
            {
                fu.DisableControls(this);
                fu.HideAndDisableControls(this.save_btn);
                fu.HideAndDisableControls(this.add_btn);
                fu.HideAndDisableControls(this.remove_btn);
            }
        }
    }
}
