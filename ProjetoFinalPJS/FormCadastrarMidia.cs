using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoFinalPJS
{
    public partial class FormCadastrarMidia : Form
    {
        public FormCadastrarMidia()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radio_Album_CheckedChanged(object sender, EventArgs e)
        {
            btGravar.Enabled = false;
            
            if (radioAlbum.Checked)
            {
                tbxInterprete.Enabled = true;
                tbxAutor.Enabled = true;
                tbxAlbum.Enabled = true;
                dateTimePickerAlbum.Enabled = true;
                dateTimePickerCompra.Enabled = true;
                tbxOrigemCompra.Enabled = true;
                cbxMidia.Enabled = true;
                cbxNota.Enabled = true;
                tbxObsevacoes.Enabled = true;
            }
            else
            {
                tbxInterprete.Enabled = false;
                tbxAutor.Enabled = false;
                tbxAlbum.Enabled = false;
                dateTimePickerAlbum.Enabled = false;
                dateTimePickerCompra.Enabled = false;
                tbxOrigemCompra.Enabled = false;
                cbxMidia.Enabled = false;
                cbxNota.Enabled = false;
            }
            tbxInterprete.Focus();
            
        }

        private void radioButton_Musica_CheckedChanged(object sender, EventArgs e)
        {
            btGravar.Enabled = false;
            
            if (radioMusica.Checked)
            {
                tbxInterprete.Enabled = true;
                tbxAutor.Enabled = true;
                tbxMusica.Enabled = true;
                dateTimePickerCompra.Enabled = true;
                tbxOrigemCompra.Enabled = true;
                cbxMidia.Enabled = true;
                cbxNota.Enabled = true;
                tbxObsevacoes.Enabled = true;
            }
            else
            {
                tbxInterprete.Enabled = false;
                tbxAutor.Enabled = false;
                tbxMusica.Enabled = false;
                dateTimePickerCompra.Enabled = false;
                tbxOrigemCompra.Enabled = false;
                cbxMidia.Enabled = false;
                cbxNota.Enabled = false;
                tbxObsevacoes.Enabled = false;
            }
            tbxInterprete.Focus();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            tbxInterprete.Text = null;
            tbxAutor.Text = null;
            tbxAlbum.Text = null;
            tbxMusica.Text = null;
            tbxOrigemCompra.Text = null;
            cbxMidia.Text = null;
            cbxNota.Text = null;
            tbxObsevacoes.Text = null;
            tbxInterprete.Focus();
        }
    }
}
