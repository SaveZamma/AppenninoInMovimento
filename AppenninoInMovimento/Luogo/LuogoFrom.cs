using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppenninoInMovimento.Luogo
{
    public partial class LuogoFrom : Form
    {
        public LuogoFrom()
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
            }
        }
    }
}
