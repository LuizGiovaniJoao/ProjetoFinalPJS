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
        public FormListaAmigos FormularioListaAmigos;

        public FormCadastrarAmigo()
        {
            InitializeComponent();
        }
        public FormCadastrarAmigo(bool Verifica)
        {
            InitializeComponent();
            btGravar.Enabled = false;
        }
        public FormCadastrarAmigo(string[] dadosDGV)
        {
            InitializeComponent();
            tbxApelido.Enabled = false;
            btSalvar.Enabled = false;
            tbxNome.Text = dadosDGV[0];
            tbxApelido.Text = dadosDGV[1];
            tbxEndereco.Text = dadosDGV[2];
            tbxBairro.Text = dadosDGV[3];
            cbxCidade.Text = dadosDGV[4];
            cbxUF.Text = dadosDGV[5];
            tbxTelefoneMasc.Text = dadosDGV[6];
            tbxCelularMasc.Text = dadosDGV[7];
            tbxEmail.Text = dadosDGV[8];           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbxApelido.Text = null;
            tbxNome.Text = null;
            tbxBairro.Text = null;
            cbxCidade.Text = null;
            tbxEndereco.Text = null;
            cbxUF.Text = null;
            tbxEmail.Text = null;
            tbxCelularMasc.Text = null;
            tbxTelefoneMasc.Text = null;
            tbxEmail.Text = null;
            tbxApelido.Focus();
            errorProviderAmigo.SetError(lbApelido, "");
            errorProviderAmigo.SetError(lbNome, "");
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (tbxApelido.Text != "" && tbxNome.Text != "" && cbxCidade.Text != "" && cbxUF.Text != "" && tbxEndereco.Text != "")
            {
                ClassSQL InserirAmigo = new ClassSQL();
                ArrayList objArrayList = new ArrayList();

                objArrayList.Add(tbxApelido.Text);
                objArrayList.Add(tbxNome.Text);
                objArrayList.Add(tbxEndereco.Text);
                objArrayList.Add(tbxBairro.Text);
                objArrayList.Add(cbxCidade.Text);
                objArrayList.Add(cbxUF.Text);
                objArrayList.Add(tbxTelefoneMasc.Text);
                objArrayList.Add(tbxCelularMasc.Text);
                objArrayList.Add(tbxEmail.Text);

                if (InserirAmigo.Insert(objArrayList))
                {
                    this.Close();
                    //FormularioListaAmigos.atualizaGridView();
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
                if (cbxCidade.Text == "")
                    errorProviderAmigo.SetError(lbCidade, tooltip);
                else
                    errorProviderAmigo.SetError(lbCidade, "");
                if (cbxUF.Text == "")
                    errorProviderAmigo.SetError(lbUf, tooltip);
                else
                    errorProviderAmigo.SetError(lbUf, "");
                if (tbxEndereco.Text == "")
                    errorProviderAmigo.SetError(lbEndereco, tooltip);
                else
                    errorProviderAmigo.SetError(lbEndereco, "");
                }
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            if (tbxApelido.Text != "" && tbxNome.Text != "" && cbxCidade.Text != "" && cbxUF.Text != "")
            {
                ClassSQL AtualizarAmigo = new ClassSQL();
                ArrayList objArrayList = new ArrayList();

                string Apelido = tbxApelido.Text;
                objArrayList.Add(tbxNome.Text);
                objArrayList.Add(tbxEndereco.Text);
                objArrayList.Add(tbxBairro.Text);
                objArrayList.Add(cbxCidade.Text);
                objArrayList.Add(cbxUF.Text);
                objArrayList.Add(tbxTelefoneMasc.Text);
                objArrayList.Add(tbxCelularMasc.Text);
                objArrayList.Add(tbxEmail.Text);

                if (AtualizarAmigo.Update(objArrayList, Apelido))
                {
                    this.Close();
                    //FormularioListaAmigos.atualizaGridView();
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
                if (cbxCidade.Text == "")
                    errorProviderAmigo.SetError(lbCidade, tooltip);
                else
                    errorProviderAmigo.SetError(lbCidade, "");
                if (cbxUF.Text == "")
                    errorProviderAmigo.SetError(lbUf, tooltip);
                else
                    errorProviderAmigo.SetError(lbUf, "");
            }
        }

        private void FormCadastrarAmigo_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormListaAmigos frm = new FormListaAmigos();
        }

        public void ListaCid()
        {
            ClassSQL ListaDados = new ClassSQL();
            //Bloco para listagem de Cidades no cbxCidades
            SqlCommand comandoListCidades = new SqlCommand();
            DataTable dtTabelaCidade = new DataTable();
            string estSelecionado = cbxUF.Text;
            ListaDados.ListaCidades(comandoListCidades, dtTabelaCidade, estSelecionado);
            cbxCidade.DataSource = dtTabelaCidade;
            cbxCidade.DisplayMember = "cidade";
            cbxCidade.ValueMember = "cidade";
            return;
        }

        private void FormCadastrarAmigo_Load(object sender, EventArgs e)
        {
            ClassSQL ListaDados = new ClassSQL();
            
            //Bloco para listagem de estados no cbxEstados
            SqlCommand comandoListEstados = new SqlCommand();
            DataTable dtTabelaEstado = new DataTable();
            ListaDados.ListaEstados(comandoListEstados, dtTabelaEstado);
            cbxUF.DataSource = dtTabelaEstado;
            cbxUF.DisplayMember = "Uf";
            cbxUF.ValueMember = "Uf";

            ListaCid();
        }

        private void cbxUF_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ClassSQL ListaDados = new ClassSQL();
            ListaCid();
        }
    }
}

