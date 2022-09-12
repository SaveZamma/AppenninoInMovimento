using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppenninoInMovimento
{
    public partial class UtenteForm : Form
    {
        public UtenteForm()
        {
            InitializeComponent();
            this.SetAccordingToDBOperation();
        }

        private void SetAccordingToDBOperation()
        {
            var fu = new Utils.FromUtils();

            fu.HideAndDisableControls(this.amicizia_btn);

            if (ParametriSessione.TipoOperazioneDB == enum_TipoOperazioneDB.READ)
            {
                fu.DisableControls(this);
                //this.amicizia_btn.Enabled = true;
                //this.amicizia_btn.Show();
            }
            else if (ParametriSessione.TipoOperazioneDB == enum_TipoOperazioneDB.WRITE)
            {                
                fu.HideAndDisableControls(this.amici_lbl);
                fu.HideAndDisableControls(this.amici_lv);
                fu.HideAndDisableControls(this.modificaAmici_btn);
                fu.HideAndDisableControls(this.gruppi_lbl);
                fu.HideAndDisableControls(this.gruppi_lv);
                fu.HideAndDisableControls(this.modificaGruppi_btn);
            }                
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var objUser = new Utils.Entita.Utente();

                objUser.CF = CF_txtbox.Text;
                objUser.DataIscrizione = DateTime.Today;
                objUser.DataNascita = DataNascita_datePk.Value;
                objUser.Username = ParametriSessione.Username;
                objUser.Password = ParametriSessione.Password;
                objUser.Nome = nome_txtbox.Text;
                objUser.Cognome = cognome_txtbox.Text;
                objUser.Organizzatore = false;
                objUser.Telefono = cel_txtBox.Text;

                new Utente.UtenteFormService().registerNewUser(objUser);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message);
            }
        }

        private void amicizia_btn_Click(object sender, EventArgs e)
        {

        }

        private void UtenteForm_Load(object sender, EventArgs e)
        {
            var res = new Utente.UtenteFormService().ReadSingleUser();

            if(res != null)
            {
                this.nome_txtbox.Text = res["nome"].ToString();
                this.cognome_txtbox.Text = res["cognome"].ToString();
                this.DataNascita_datePk.Value = DateTime.Parse(res["dataNascita"].ToString());
                this.nome_txtbox.Text = res["numeroTelefono"].ToString();
                this.nome_txtbox.Text = res["nome"].ToString();
                this.CF_txtbox.Text = res["CF"].ToString();
            }
        }
    }
}
