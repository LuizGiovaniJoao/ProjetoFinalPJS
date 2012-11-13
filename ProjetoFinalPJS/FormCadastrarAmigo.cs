using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoFinalPJS
{
    public partial class FormCadastrarAmigo : Form
    {
        public FormCadastrarAmigo()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbxApelido.Text = null;
            tbxNome.Text = null;
            tbxBairro.Text = null;
            tbxCidade.Text = null;
            tbxEndereco.Text = null;
            cbxUF.Text = null;
            tbxEmail.Text = null;
            tbxCelularMasc.Text = null;
            tbxTelefoneMasc.Text = null;
            tbxEmail.Text = null;
            tbxNome.Focus();
        }

        private void FormCadastrarAmigo_Load(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (tbxApelido.Text != "" && tbxNome.Text != "" && tbxCidade.Text != "" && cbxUF.Text != "")
            {
                ClassSQL InserirAmigo = new ClassSQL();
                ArrayList objArrayList = new ArrayList();

                objArrayList.Add(tbxApelido.Text);
                objArrayList.Add(tbxNome.Text);
                objArrayList.Add(tbxEndereco.Text);
                objArrayList.Add(tbxBairro.Text);
                objArrayList.Add(tbxCidade.Text);
                objArrayList.Add(cbxUF.Text);
                objArrayList.Add(tbxTelefoneMasc.Text);
                objArrayList.Add(tbxCelularMasc.Text);
                objArrayList.Add(tbxEmail.Text);

                if (InserirAmigo.Insert(objArrayList))
                {
                    MessageBox.Show("Legaaallll");
                }
                else
                {
                    MessageBox.Show("Não deu");
                }
            }
            else
            {
                string tooltip = "Este campo é obrigatório.";

                if (tbxApelido.Text == "")
                    errorProviderAmigo.SetError(lbApelido, tooltip);
                else
                    errorProviderAmigo.SetError(lbApelido, "");
                if (tbxNome.Text == "")
                    errorProviderAmigo.SetError(lbNome, tooltip);
                else
                    errorProviderAmigo.SetError(lbNome, "");
                if (tbxCidade.Text == "")
                    errorProviderAmigo.SetError(lbCidade, tooltip);
                else
                    errorProviderAmigo.SetError(lbCidade, "");
                if (cbxUF.Text == "")
                    errorProviderAmigo.SetError(lbUf, tooltip);
                else
                    errorProviderAmigo.SetError(lbUf, "");
                }
        }
    }
}

