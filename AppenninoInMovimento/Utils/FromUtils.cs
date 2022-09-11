using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppenninoInMovimento.Utils
{
    internal class FromUtils
    {
        public void HideAndDisableControls(Control con)
        {
            this.DisableControls(con);
            this.HideControls(con);
        }

        public void DisableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                DisableControls(c);
                c.Enabled = false;
            }
        }

        public void HideControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                HideControls(c);
            }
            con.Hide();
        }
    }
}
