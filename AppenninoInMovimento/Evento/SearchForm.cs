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
        public string attivitaEvento = "";
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
                if(item != "")
                {
                    if (Int32.Parse(item) == id) return;
                }                
            }
            new SearchFormService().AddAttivitaToEvento(id);

            this.attivitaEvento += "_" + id;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            var afs = new Attivita.AttivitaFormService();

            DataTable dt = afs.LeggiAttivita("");

            if(dt != null && dt.Rows.Count>0)
            {
                foreach(DataRow r in dt.Rows)
                {
                    this.results_lb.Items.Add(r["descrizione"] + " " + r["valutazione"].ToString() + " ID: " + r["ID"].ToString());
                }
            }
        }
    }
}
