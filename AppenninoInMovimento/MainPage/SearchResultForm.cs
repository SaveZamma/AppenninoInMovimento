using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppenninoInMovimento.MainPage
{
    public partial class SearchResultForm : Form
    {
        public MainPageForm.enum_TipoRicerca tipoRicerca = MainPageForm.enum_TipoRicerca.ATTIVITA;
        private string parametriLettura = "";
        public SearchResultForm(string parametriLettura)
        {
            this.parametriLettura = parametriLettura;
            InitializeComponent();
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            ParametriSessione.TipoOperazioneDB = enum_TipoOperazioneDB.DELETE;
            string s = "";
            if(this.result_lb.SelectedItem != null)
            {
                s = this.result_lb.SelectedItem.ToString();
                var ID = s.Split(":")[1];
                new SearchResultFormService().RemoveSelectedItem(ID, this.tipoRicerca);
            }

            ParametriSessione.ResetParams();
            this.Close();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            ParametriSessione.TipoOperazioneDB = enum_TipoOperazioneDB.UPDATE;
            if (this.SetCorrespondingParamsID())
            {
                var form = this.GetCorrespodingForm();
                form.ShowDialog();
            }
        }

        private void look_btn_Click(object sender, EventArgs e)
        {
            ParametriSessione.TipoOperazioneDB = enum_TipoOperazioneDB.READ;
            if (this.SetCorrespondingParamsID())
            {
                var form = this.GetCorrespodingForm();
                form.ShowDialog();
            }
        }

        private Form GetCorrespodingForm()
        {
            try
            {
                string s = "";
                string ID = "";
                if (this.result_lb.SelectedItem != null)
                {
                    s = this.result_lb.SelectedItem.ToString();
                    ID = s.Split(":")[1];                    
                }

                switch (this.tipoRicerca)
                {
                    case MainPageForm.enum_TipoRicerca.ATTIVITA:
                        {
                            ParametriSessione.ID_ATTIVITA = Int32.Parse(ID);
                            return new Attivita.AttivitaForm();
                        }
                    case MainPageForm.enum_TipoRicerca.UTENTE:
                        {
                            ParametriSessione.Username = ID;
                            return new UtenteForm();
                        }
                    case MainPageForm.enum_TipoRicerca.GRUPPO:
                        {
                            ParametriSessione.ID_GRUPPO = Int32.Parse(ID);
                            return new Gruppo.GruppoForm();
                        }
                    case MainPageForm.enum_TipoRicerca.EVENTO:
                        {
                            ParametriSessione.ID_EVENTO = Int32.Parse(ID);
                            return new Evento.EventoForm();
                        }
                    default: throw new NotImplementedException("Valore non presente in enum_TipoRicerca: OpenCorrespondingForm()");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        private bool SetCorrespondingParamsID()
        {
            try
            {
                string s = "";
                string ID = "";
                if (this.result_lb.SelectedItem != null)
                {
                    s = this.result_lb.SelectedItem.ToString();
                    ID = s.Split(":")[1];

                    switch (this.tipoRicerca)
                    {
                        case MainPageForm.enum_TipoRicerca.ATTIVITA:
                            {
                                ParametriSessione.ID_ATTIVITA = Int32.Parse(ID);
                                return true;
                            }
                        case MainPageForm.enum_TipoRicerca.UTENTE:
                            {
                                ParametriSessione.Username = ID;
                                return true;
                            }
                        case MainPageForm.enum_TipoRicerca.GRUPPO:
                            {
                                ParametriSessione.ID_GRUPPO = Int32.Parse(ID);
                                return true;
                            }
                        case MainPageForm.enum_TipoRicerca.EVENTO:
                            {
                                ParametriSessione.ID_EVENTO = Int32.Parse(ID);
                                return true;
                            }
                        default: throw new NotImplementedException("Valore non presente in enum_TipoRicerca: SetCorrespondingParamsID()");
                    }
                }
                else
                {
                    MessageBox.Show("Nessun Item Selezionato");
                    return false;
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SearchResultForm_Load(object sender, EventArgs e)
        {
            DataTable results = new SearchResultFormService().LeggiDatiDT(this.parametriLettura, this.tipoRicerca);

            foreach (DataRow r in results.Rows)
            {
                if(this.tipoRicerca == MainPageForm.enum_TipoRicerca.ATTIVITA)
                    this.result_lb.Items.Add(r["descrizione"] + " " + r["valutazione"].ToString() + " ID: " + r["ID"].ToString());
                if (this.tipoRicerca == MainPageForm.enum_TipoRicerca.UTENTE)
                {
                    this.result_lb.Items.Add(r["nome"] + " " + r["cognome"] + " username: " + r["username"]);
                    new Utils.FromUtils().HideAndDisableControls(this.update_btn);
                    new Utils.FromUtils().HideAndDisableControls(this.remove_btn);
                }
                    
                if (this.tipoRicerca == MainPageForm.enum_TipoRicerca.GRUPPO)
                    this.result_lb.Items.Add(r["nome"] + " ID: " + r["idGruppo"].ToString());
                if (this.tipoRicerca == MainPageForm.enum_TipoRicerca.EVENTO)
                    this.result_lb.Items.Add(r["descrizione"] + " ID: " + r["ID"].ToString());
            }
        }
    }
}
