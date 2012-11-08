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

        }

        public void button1_Click(object sender, EventArgs e)
        {
            ClassSQL InserirAmigo = new ClassSQL();
            ArrayList objArrayList = new ArrayList();

            objArrayList.Add(textBox_Apelido.Text);
            objArrayList.Add(textBoxNome.Text);
            objArrayList.Add(textBoxEndereco.Text);
            objArrayList.Add(textBoxBairro.Text);
            objArrayList.Add(textBoxCidade.Text);
            objArrayList.Add(comboBoxUF.Text);
            objArrayList.Add(maskedTextBoxTelefone.Text);
            objArrayList.Add(maskedText_celular.Text);
            objArrayList.Add(textBox_Email.Text);



            if (InserirAmigo.Insert(objArrayList))
            {
                MessageBox.Show("Legaaallll");
            }
            else
            {
                MessageBox.Show("Não deu");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}

