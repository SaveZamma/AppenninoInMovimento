using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppenninoInMovimento.QuotaIscrizione
{
    public partial class QuotaIscrizione : Form
    {
        public decimal retPrezzo = 0;
        public int retSconto = 0;
        public QuotaIscrizione()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            new QuotaIscrizioneFormService().ScriviQuotaIscrizione(this.prezzo_num.Value,
                Int32.Parse(this.sconto_num.Value.ToString()));
            
            this.DialogResult = DialogResult.OK;
            this.retPrezzo = this.prezzo_num.Value;
            this.retSconto = Int32.Parse(this.sconto_num.Value.ToString());

            this.Close();
        }
    }
}
