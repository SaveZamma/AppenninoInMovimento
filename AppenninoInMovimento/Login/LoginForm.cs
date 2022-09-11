using Microsoft.Data.SqlClient;

namespace AppenninoInMovimento
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // how to get textBox values
                string pw = ((System.Windows.Forms.TextBox)((System.Windows.Forms.Control)sender).Parent.Controls.Find("pw_txtBox", true)[0]).Text;
                string us = ((System.Windows.Forms.TextBox)((System.Windows.Forms.Control)sender).Parent.Controls.Find("username_txtBox", true)[0]).Text;
                System.Data.DataTable dt = new LoginFormService.LoginFormService().checkUserInDB(us, pw);

                if (dt.Rows.Count > 0)
                {
                    var res = new MainPage.MainPageForm().ShowDialog();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Errore: " + ex.Message);
            }            
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            ParametriSessione.TipoOperazioneDB = enum_TipoOperazioneDB.WRITE;
            var res = new UtenteForm().ShowDialog();
        }

        private void username_txtBox_TextChanged(object sender, EventArgs e)
        {
            AppenninoInMovimento.ParametriSessione.UsernameSuperUser = username_txtBox.Text;
        }

        private void pw_txtBox_TextChanged(object sender, EventArgs e)
        {
            AppenninoInMovimento.ParametriSessione.Password = pw_txtBox.Text;
        }
    }
}