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
    public partial class FormHistoricoDevolucao : Form
    {
        ClassSQL conexao = new ClassSQL();

        public FormHistoricoDevolucao()
        {
            InitializeComponent();
        }

        private void FormHistoricoDevolucao_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(conexao.stringConexao);
            cnn.Open();
            SqlCommand comando = new SqlCommand("SELECT Apelido, DataEmprestimo, Interprete, Tipo, Musica, Album, DataDevolucao FROM Devolucao", cnn);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable dataLista = new DataTable();
            adaptador.Fill(dataLista);
            dGVHistoricoDevolucao.DataSource = dataLista;
        }
    }
}
