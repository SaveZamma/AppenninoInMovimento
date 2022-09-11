﻿using System;
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
    public partial class AttivitaForm : Form
    {
        public AttivitaForm()
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
                fu.HideAndDisableControls(this.exit_btn);
                fu.HideAndDisableControls(this.mdificaAttrezzaturaRiposo_btn);
                fu.HideAndDisableControls(this.modificaAttrezzaturaMovimento_btn);
                fu.HideAndDisableControls(this.modificaPasti_btn);
                fu.HideAndDisableControls(this.modificaVestiario_btn);
                fu.HideAndDisableControls(this.save_btn);
            }
        }

        private void modificaPercorso_btn_Click(object sender, EventArgs e)
        {
            var res = new Percorso.PercorsoForm().ShowDialog();
        }

        public enum enum_TipologiaNecessario
        {
            PASTI = 0,
            MOVIMENTO = 1,
            VESTIARIO = 2,
            RIPOSO = 3
        }

        private void modificaPasti_btn_Click(object sender, EventArgs e)
        {
            var nf = new NecessarioForm();
            nf.tipoNecessario = enum_TipologiaNecessario.PASTI;
            var res = nf.ShowDialog();
        }

        private void modificaVestiario_btn_Click(object sender, EventArgs e)
        {
            var nf = new NecessarioForm();
            nf.tipoNecessario = enum_TipologiaNecessario.VESTIARIO;
            var res = nf.ShowDialog();
        }

        private void modificaAttrezzaturaMovimento_btn_Click(object sender, EventArgs e)
        {
            var nf = new NecessarioForm();
            nf.tipoNecessario = enum_TipologiaNecessario.MOVIMENTO;
            var res = nf.ShowDialog();
        }

        private void mdificaAttrezzaturaRiposo_btn_Click(object sender, EventArgs e)
        {
            var nf = new NecessarioForm();
            nf.tipoNecessario = enum_TipologiaNecessario.RIPOSO;
            var res = nf.ShowDialog();
        }
    }
}