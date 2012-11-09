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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            FormCadastrarMidia frm = new FormCadastrarMidia();
            frm.Show();
        }

        private void inserirMídiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormListaAmigos frm = new FormListaAmigos();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormEmprestarMidia frm = new FormEmprestarMidia();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormDevolverMidia frm = new FormDevolverMidia();
            frm.Show();
        }

        private void checkBox_Autor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Autor.Checked)
                tbxAutor.Enabled = true;
            else
            {
                tbxAutor.Enabled = false;
                tbxAutor.Text = null;
            }
        }

        private void checkBox_album_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_album.Checked)
                tbxAlbum.Enabled = true;
            else
            {
                tbxAlbum.Enabled = false;
                tbxAlbum.Text = null;
            }
        }

        private void checkBoxInterprete_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInterprete.Checked)
                tbxInterprete.Enabled = true;
            else
            {
                tbxInterprete.Enabled = false;
                tbxInterprete.Text = null;
            }
        }

        private void checkBox_origemCompra_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_origemCompra.Checked)
                tbxOrigemCompra.Enabled = true;
            else
            {
                tbxOrigemCompra.Enabled = false;
                tbxOrigemCompra.Text = null;
            }
        }

        private void checkBox_dataAlbum_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_dataAlbum.Checked)
                dateTimeDataAlbum.Enabled = true;
            else
                dateTimeDataAlbum.Enabled = false;
        }

        private void checkBox_dataCompra_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_dataCompra.Checked)
                dateTimeDataCompra.Enabled = true;
            else
                dateTimeDataCompra.Enabled = false;
        }

        private void checkBox_midia_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_midia.Checked)
                cbxMidia.Enabled = true;
            else
            {
                cbxMidia.Enabled = false;
                cbxMidia.Text = null;
            }
        }

        private void checkBox_nota_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_nota.Checked)
                cbxNota.Enabled = true;
            else
            {
                cbxNota.Enabled = false;
                cbxNota.Text = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBoxInterprete.Checked = false;
            checkBox_album.Checked = false;
            checkBox_Autor.Checked = false;
            checkBox_origemCompra.Checked = false;
            checkBox_dataCompra.Checked = false;
            checkBox_dataAlbum.Checked = false;
            checkBox_midia.Checked = false;
            checkBox_nota.Checked = false;
        }
    }
}
