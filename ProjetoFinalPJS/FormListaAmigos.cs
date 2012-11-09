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
            
        }
    }
}
