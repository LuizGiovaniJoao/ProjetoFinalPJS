﻿using System;
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

        public FormPrincipal FormularioPrincipal;

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
            string Situacao = dadosLV[10];

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
            tbxAlbum.TabIndex = 3;

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
            tbxMusica.TabIndex = 3;
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
            if (tbxAutor.Text != "" && cbxMidia.Text != "")
            {

                ClassSQL InserirMidia = new ClassSQL();
                
                if (InserirMidia.InsertMidia(Salvar_Gravar_Midia()))
                {
                    MessageBox.Show("Legaaallll");
                    FormularioPrincipal.AtualizaAutoCompletar();
                    FormularioPrincipal.Exibicao_ListViewMidia();
                }
                else
                    MessageBox.Show("Não deu");
            }
            else
            {
                string tootip = "Este campo é obrigatório";

                if (tbxAutor.Text == "")
                    errorProviderMidia.SetError(lbNomeAutor, tootip);
                else
                    errorProviderMidia.SetError(lbNomeAutor, "");
                if (cbxMidia.Text == "")
                    errorProviderMidia.SetError(lbTipoMidia, tootip);
                else
                    errorProviderMidia.SetError(lbTipoMidia, "");
            }
        }

        public void btGravar_Click(object sender, EventArgs e)
        {
            FormPrincipal frm = new FormPrincipal();

            if (tbxAutor.Text != "" && cbxMidia.Text != "")
            {
                ClassSQL InserirMidia = new ClassSQL();

                if (InserirMidia.UpdateMidia(Salvar_Gravar_Midia()))
                {
                    MessageBox.Show("Legaaallll");
                    FormPrincipal teste = new FormPrincipal();
                    teste.AtualizaAutoCompletar();
                }
                else
                {
                    MessageBox.Show("Não deu");
                }
            }

        }
        public ArrayList Salvar_Gravar_Midia()
        {
            ArrayList objArrayList = new ArrayList();

            objArrayList.Add(tbxInterprete.Text);//.................... Interprete
            objArrayList.Add(tbxAutor.Text);//......................... Autor
            objArrayList.Add(tbxAlbum.Text);//......................... Album
            objArrayList.Add(tbxMusica.Text);//........................ Música
            objArrayList.Add(dateTimePickerAlbum.Value);//............. Data do Album
            objArrayList.Add(dateTimePickerCompra.Value);//............ Data da Compra
            objArrayList.Add(tbxOrigemCompra.Text);//.................. Origem da Compra
            objArrayList.Add(cbxMidia.Text);//......................... Tipo de Mídia
            objArrayList.Add(tbxObsevacoes.Text);//.................... Observações
            objArrayList.Add(cbxNota.Text);//.......................... Nota
            //objArrayList.Add("Disponível");//.......................... Situação

            return(objArrayList);
       }
    }

}


