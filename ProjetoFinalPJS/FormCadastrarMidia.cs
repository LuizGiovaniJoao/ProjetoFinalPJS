using System;
using System.Collections.Generic;
using System.Collections;
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
        public FormCadastrarMidia(string[] dadosLV)
        {
            InitializeComponent();
            //tbxApelido.Enabled = false;
            //btSalvar.Enabled = false;
            if (dadosLV[1] == "")
            {
                radioMusica.Checked = true;
                radioAlbum.Checked = false;
            }
            else
            {
                radioAlbum.Checked = true;
                radioMusica.Checked = false;
            }

            tbxMusica.Text = dadosLV[0];
            tbxAlbum.Text = dadosLV[1];
            tbxAutor.Text = dadosLV[2];
            tbxInterprete.Text = dadosLV[3];          
            dateTimePickerAlbum.Text = dadosLV[4];
            dateTimePickerCompra.Text = dadosLV[5];
            tbxOrigemCompra.Text = dadosLV[6];
            tbxObsevacoes.Text = dadosLV[7];
            cbxMidia.Text = dadosLV[8];
            cbxNota.Text = dadosLV[9];

            radioAlbum.Enabled = false;
            radioMusica.Enabled = false;
            btSalvar.Enabled = false;
            btGravar.Enabled = true;

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

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string situacao = " ";

            ClassSQL InserirMidia = new ClassSQL();
            ArrayList objArrayList = new ArrayList();

            objArrayList.Add(tbxInterprete.Text);
            objArrayList.Add(tbxAutor.Text);
            objArrayList.Add(tbxAlbum.Text);
            objArrayList.Add(tbxMusica.Text);
            objArrayList.Add(dateTimePickerAlbum.Value);
            objArrayList.Add(dateTimePickerCompra.Value);
            objArrayList.Add(tbxOrigemCompra.Text);
            objArrayList.Add(cbxMidia.Text);
            objArrayList.Add(tbxObsevacoes.Text);
            objArrayList.Add(cbxNota.Text);
            objArrayList.Add(situacao);

            if (InserirMidia.InsertMidia(objArrayList))
            {
                MessageBox.Show("Legaaallll");
            }
            else
            {
                MessageBox.Show("Não deu");
            }
            
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            if (tbxAutor.Text != "" && cbxMidia.Text != "")
            {
                ClassSQL AtualizarAmigo = new ClassSQL();
                ArrayList objArrayList = new ArrayList();

                string Apelido = tbxInterprete.Text;
                objArrayList.Add(tbxAutor.Text);
                objArrayList.Add(tbxAlbum.Text);
                objArrayList.Add(tbxMusica.Text);
                objArrayList.Add(dateTimePickerAlbum.Value);
                objArrayList.Add(dateTimePickerCompra.Value);
                objArrayList.Add(tbxOrigemCompra.Text);
                objArrayList.Add(cbxMidia.Text);
                objArrayList.Add(tbxObsevacoes.Text);
                objArrayList.Add(cbxNota.Text);

                if (AtualizarAmigo.Update(objArrayList, Apelido))
                {
                    MessageBox.Show("Legaaallll");

                }
                else
                {
                    MessageBox.Show("Não deu");
                }
            }

        }

        private void FormCadastrarMidia_Load(object sender, EventArgs e)
        {

        }
    }

}


