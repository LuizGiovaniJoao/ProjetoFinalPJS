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


    public partial class FormListaAmigos : Form
    {
        public FormListaAmigos()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            bool Verifica = true;
            
            FormCadastrarAmigo frm = new FormCadastrarAmigo(Verifica);
            frm.ShowDialog();

        }

        private void FormListaAmigos_Load(object sender, EventArgs e)
        {
            ClassSQL ApresentaAmigos = new ClassSQL();
            dGridViewListaNomes.DataSource = ApresentaAmigos.Listar();
            

        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            ClassSQL DeletarAmigo = new ClassSQL();

            string Apelido = dGridViewListaNomes.CurrentRow.Cells[1].Value.ToString();
            

            if (DeletarAmigo.Delete(Apelido))
            {
                dGridViewListaNomes.Rows.RemoveAt(dGridViewListaNomes.CurrentRow.Index);
                MessageBox.Show("Removido");
            }
            else
            {
                MessageBox.Show("Não Removeu");
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            
            string[] dadosDGV = new string[10];
            for (int I = 0; I < dGridViewListaNomes.ColumnCount; I++)
            {
                 dadosDGV[I] = dGridViewListaNomes.CurrentRow.Cells[I].Value.ToString();
            }
                FormCadastrarAmigo frm = new FormCadastrarAmigo(dadosDGV);
                frm.Show();
                

        }

        private void txtPesquisaNome_TextChanged(object sender, EventArgs e)
        {
            ClassSQL PesquisaAmigos = new ClassSQL();
            dGridViewListaNomes.DataSource = PesquisaAmigos.Pesquisar("%" +txtPesquisaNome.Text+ "%");
        }


    }
}
