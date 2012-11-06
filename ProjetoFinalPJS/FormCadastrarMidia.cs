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
            
        }

        private void radioButton_Musica_CheckedChanged(object sender, EventArgs e)
        {
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
        }
    }
}
