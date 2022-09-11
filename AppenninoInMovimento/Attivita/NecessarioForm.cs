using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppenninoInMovimento.Attivita
{
    public partial class NecessarioForm : Form
    {
        public AttivitaForm.enum_TipologiaNecessario tipoNecessario = AttivitaForm.enum_TipologiaNecessario.MOVIMENTO;
        public NecessarioForm()
        {
            InitializeComponent();
        }
    }
}
