using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoFinalPJS
{
    public partial class FormEmprestarMidia : Form
    {
        public FormEmprestarMidia()
        {
            InitializeComponent();
        }

        private void FormEmprestarMidia_Load(object sender, EventArgs e)
        {
            listar("SELECT Apelido FROM AMIGO order by Apelido", cbxApelido, "Apelido");
            listar("SELECT Interprete FROM MIDIA ORDER BY Interprete", cbxInterprete, "interprete");
        }

        private void listar(string Codigo, ComboBox caixaTexto, string Campo)
        {
            DataTable dtTabelas = new DataTable();
            SqlConnection conexao = new SqlConnection((new ClassSQL()).stringConexao);
            //criar um adaptador
            SqlDataAdapter adaptador = new SqlDataAdapter(Codigo, conexao);
            //preenche o DataTable
            adaptador.Fill(dtTabelas);
            //carrega as informacoes no combobox
            caixaTexto.DataSource = dtTabelas;
            caixaTexto.DisplayMember = Campo;
            caixaTexto.ValueMember = Campo;
        }

        public void camposVisiveis()
        {

        }

        private void radioAlbum_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAlbum.Checked)
            {
                cbxInterprete.Enabled = true;
                cbxAlbum.Enabled = true;
                cbxMidia.Enabled = true;
                cbxMusica.Enabled = false;
                DtDevolucao.Enabled = true;
                DtEmprestimo.Enabled = true;
            }

            else
            {
                cbxInterprete.Enabled = false;
                cbxAlbum.Enabled = false;
                cbxMidia.Enabled = false;
                DtDevolucao.Enabled = false;
                DtEmprestimo.Enabled = false;
            }
            cbxInterprete.Focus();
        }

        private void radioMusica_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMusica.Checked)
            {
                cbxInterprete.Enabled = true;
                cbxAlbum.Enabled = false;
                cbxMidia.Enabled = true;
                cbxMusica.Enabled = true;
                DtDevolucao.Enabled = true;
                DtEmprestimo.Enabled = true;
            }

            else
            {
                cbxInterprete.Enabled = false;
                cbxAlbum.Enabled = false;
                cbxMidia.Enabled = false;
                cbxMusica.Enabled = false;
                DtDevolucao.Enabled = false;
                DtEmprestimo.Enabled = false;
            }
            cbxInterprete.Focus();
        }
    }
}
