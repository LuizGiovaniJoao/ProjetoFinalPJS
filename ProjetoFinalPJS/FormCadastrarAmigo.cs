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
    public partial class FormCadastrarAmigo : Form
    {
        public FormCadastrarAmigo()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
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
            // 
        }

    }
}
