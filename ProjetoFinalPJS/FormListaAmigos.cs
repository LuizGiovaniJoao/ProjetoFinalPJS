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
            FormCadastrarAmigo frm = new FormCadastrarAmigo();
            frm.ShowDialog();
        }

        private void FormListaAmigos_Load(object sender, EventArgs e)
        {
            ClassSQL PesquisaAmigo = new ClassSQL();
            string Apelido = txtPesquisaNome.Text;
            PesquisaAmigo.SelectAmigo(Apelido);
            
            

        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            ClassSQL DeletarAmigo = new ClassSQL();

            string Apelido = txtPesquisaNome.Text;

            if (DeletarAmigo.Delete(Apelido))
            {
                MessageBox.Show("Legaaallll");
            }
            else
            {
                MessageBox.Show("Não deu");
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            FormCadastrarAmigo frm = new FormCadastrarAmigo();
            frm.Show();


        }


    }
}
