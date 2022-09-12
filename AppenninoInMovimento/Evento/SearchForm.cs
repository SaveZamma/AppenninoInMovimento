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
    public partial class SearchForm : Form
    {
        private string attivitaEvento = "";
        public SearchForm(string attivitaEvento)
        {
            InitializeComponent();
            this.attivitaEvento = attivitaEvento;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (this.results_lb.SelectedItem == null) return;

            int id = Int32.Parse(this.results_lb.SelectedItem.ToString().Split(":")[1]);
            foreach (var item in this.attivitaEvento.Split("_"))
            {
                if (Int32.Parse(item) == id) return;
            }
            new SearchFormService().AddAttivitaToEvento(id);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
