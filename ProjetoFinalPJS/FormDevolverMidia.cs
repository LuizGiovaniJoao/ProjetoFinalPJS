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
    public partial class FormDevolverMidia : Form
    {
        public FormDevolverMidia()
        {
            InitializeComponent();
        }

        private void FormDevolverMidia_Load(object sender, EventArgs e)
        {
            listar("SELECT DISTINCT Apelido FROM Emprestimo", cbxApelido, "Apelido");
            // DISTINCT para impedir dados repetidos no select
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
    }
}
