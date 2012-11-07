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
            buttonGravar.Enabled = false;
            
            if (radio_Album.Checked)
            {
                textBoxInterprete.Enabled = true;
                textBoxAutor.Enabled = true;
                textBoxAlbum.Enabled = true;
                dateTimePickerAlbum.Enabled = true;
                dateTimePickerCompra.Enabled = true;
                textBoxOrigemCompra.Enabled = true;
                comboBoxMidia.Enabled = true;
                comboBoxNota.Enabled = true;
                textBoxObsevacoes.Enabled = true;
            }
            else
            {
                textBoxInterprete.Enabled = false;
                textBoxAutor.Enabled = false;
                textBoxAlbum.Enabled = false;
                dateTimePickerAlbum.Enabled = false;
                dateTimePickerCompra.Enabled = false;
                textBoxOrigemCompra.Enabled = false;
                comboBoxMidia.Enabled = false;
                comboBoxNota.Enabled = false;
            }
            textBoxInterprete.Focus();
            
        }

        private void radioButton_Musica_CheckedChanged(object sender, EventArgs e)
        {
            buttonGravar.Enabled = false;
            
            if (radioButton_Musica.Checked)
            {
                textBoxInterprete.Enabled = true;
                textBoxAutor.Enabled = true;
                textBox_nomeMusica.Enabled = true;
                dateTimePickerCompra.Enabled = true;
                textBoxOrigemCompra.Enabled = true;
                comboBoxMidia.Enabled = true;
                comboBoxNota.Enabled = true;
                textBoxObsevacoes.Enabled = true;
            }
            else
            {
                textBoxInterprete.Enabled = false;
                textBoxAutor.Enabled = false;
                textBox_nomeMusica.Enabled = false;
                dateTimePickerCompra.Enabled = false;
                textBoxOrigemCompra.Enabled = false;
                comboBoxMidia.Enabled = false;
                comboBoxNota.Enabled = false;
                textBoxObsevacoes.Enabled = false;
            }
            textBoxInterprete.Focus();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxInterprete.Text = null;
            textBoxAutor.Text = null;
            textBoxAlbum.Text = null;
            textBox_nomeMusica.Text = null;
            textBoxOrigemCompra.Text = null;
            comboBoxMidia.Text = null;
            comboBoxNota.Text = null;
            textBoxObsevacoes.Text = null;
            textBoxInterprete.Focus();
        }
    }
}
