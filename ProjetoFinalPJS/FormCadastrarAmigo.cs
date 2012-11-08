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
            textBoxNome.Text = null;
            textBoxBairro.Text = null;
            textBoxCidade.Text = null;
            textBoxEndereco.Text = null;
            comboBoxUF.Text = null;
            textBox_Email.Text = null;
            maskedText_celular.Text = null;
            maskedTextBoxTelefone.Text = null;
            textBox_Email.Text = null;
            textBoxNome.Focus();
        }

        private void FormCadastrarAmigo_Load(object sender, EventArgs e)
        {
            // 
        }
    }
}
