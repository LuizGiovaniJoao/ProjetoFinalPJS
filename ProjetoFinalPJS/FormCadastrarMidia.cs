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

        private void checkBox_album_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_album.Checked)
            {
                checkBox_musica.Checked = false;
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
                textBoxObsevacoes.Enabled = false;
            }
        }

        private void checkBox_musica_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_musica.Checked)
            {
                checkBox_album.Checked = false;
                textBoxInterprete.Enabled = true;
                textBoxAutor.Enabled = true;
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
                dateTimePickerCompra.Enabled = false;
                textBoxOrigemCompra.Enabled = false;
                comboBoxMidia.Enabled = false;
                comboBoxNota.Enabled = false;
                textBoxObsevacoes.Enabled = false; 
            }
        }
    }
}
