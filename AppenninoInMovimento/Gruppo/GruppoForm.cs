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
        }

        private void SetAccordingToTipoOperazione()
        {
            var fu = new Utils.FromUtils();

            if (ParametriSessione.TipoOperazioneDB == enum_TipoOperazioneDB.READ)
            {
                fu.HideAndDisableControls(this.save_btn);
                fu.DisableControls(this.nome_txtbox);
            }
            else if(ParametriSessione.TipoOperazioneDB == enum_TipoOperazioneDB.WRITE)
            {
                fu.HideAndDisableControls(this.join_btn);
            }
        }
    }
}
