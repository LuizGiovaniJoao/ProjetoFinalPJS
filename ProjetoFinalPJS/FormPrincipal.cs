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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            Exibicao_ListViewMidia();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            FormCadastrarMidia frm = new FormCadastrarMidia();
            frm.Show();
        }

        private void inserirMídiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormListaAmigos frm = new FormListaAmigos();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormEmprestarMidia frm = new FormEmprestarMidia();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormDevolverMidia frm = new FormDevolverMidia();
            frm.Show();
        }

        private void checkBox_Autor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Autor.Checked)
                tbxAutor.Enabled = true;
            else
            {
                tbxAutor.Enabled = false;
                tbxAutor.Text = null;
            }
        }

        private void checkBox_album_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_album.Checked)
                tbxAlbum.Enabled = true;
            else
            {
                tbxAlbum.Enabled = false;
                tbxAlbum.Text = null;
            }
        }

        private void checkBoxInterprete_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInterprete.Checked)
                tbxInterprete.Enabled = true;
            else
            {
                tbxInterprete.Enabled = false;
                tbxInterprete.Text = null;
            }
        }

        private void checkBox_origemCompra_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_origemCompra.Checked)
                tbxOrigemCompra.Enabled = true;
            else
            {
                tbxOrigemCompra.Enabled = false;
                tbxOrigemCompra.Text = null;
            }
        }

        private void checkBox_dataAlbum_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_dataAlbum.Checked)
                dateTimeDataAlbum.Enabled = true;
            else
                dateTimeDataAlbum.Enabled = false;
        }

        private void checkBox_dataCompra_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_dataCompra.Checked)
                dateTimeDataCompra.Enabled = true;
            else
                dateTimeDataCompra.Enabled = false;
        }

        private void checkBox_midia_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_midia.Checked)
                cbxMidia.Enabled = true;
            else
            {
                cbxMidia.Enabled = false;
                cbxMidia.Text = null;
            }
        }

        private void checkBox_nota_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_nota.Checked)
                cbxNota.Enabled = true;
            else
            {
                cbxNota.Enabled = false;
                cbxNota.Text = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBoxInterprete.Checked = false;
            checkBox_album.Checked = false;
            checkBox_Autor.Checked = false;
            checkBox_origemCompra.Checked = false;
            checkBox_dataCompra.Checked = false;
            checkBox_dataAlbum.Checked = false;
            checkBox_midia.Checked = false;
            checkBox_nota.Checked = false;

            Exibicao_ListViewMidia();
        }
        public void Exibicao_ListViewMidia()
        {
            //abre ligacao
            ClassSQL conexao = new ClassSQL();
            conexao.conectar();
            SqlConnection conn = new SqlConnection(conexao.stringConexao);
            conn.Open();
            //pesquisa na BD

            //limpa o listview
            listViewMidia.Items.Clear();

            SqlCommand cmd = new SqlCommand("SELECT [ID], [Musica], [Album], [Autor], [Interprete], [DataAlbum], [DataAquisicao], [OrigemCompra], [Observacoes], [Tipo],  [Nota] FROM [Midia] ", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            ListViewItem item;
            
            //percorre o sqldatareader para obter os dados
            while (dr.Read())
            {
                item = new ListViewItem();
                item.Text = dr.GetValue(0).ToString();

                //preenche o listview com itens
                for (int i = 1; i < dr.FieldCount; i++)
                {
                    item.SubItems.Add(dr.GetValue(i).ToString());
                }
                listViewMidia.Items.Add(item);
                foreach (ListViewItem itemx in listViewMidia.Items)
                {
                    if ((item.Index % 2) == 0)
                    {
                        item.BackColor = Color.Gainsboro;
                    }
                    else
                    {
                        item.BackColor = Color.WhiteSmoke;
                    }
                }

            }
            conn.Close();

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            string[] dadosLV = new string[13];

            //percorre todo o ListView pra achar iten selecionado
            foreach (ListViewItem listViewItem in listViewMidia.SelectedItems)
            {
                if (listViewItem.Selected)
                {
                    // Os campos serão iguais aos itens e subitens selecionado
                    dadosLV[0] = listViewItem.SubItems[1].Text;
                    dadosLV[1] = listViewItem.SubItems[2].Text;
                    dadosLV[2] = listViewItem.SubItems[3].Text;
                    dadosLV[3] = listViewItem.SubItems[4].Text;
                    dadosLV[4] = listViewItem.SubItems[5].Text;
                    dadosLV[5] = listViewItem.SubItems[6].Text;
                    dadosLV[6] = listViewItem.SubItems[7].Text;
                    dadosLV[7] = listViewItem.SubItems[8].Text;
                    dadosLV[8] = listViewItem.SubItems[9].Text;
                    dadosLV[9] = listViewItem.SubItems[10].Text;
                    // passar ID pra o Label invisivel
                    dadosLV[10] = listViewItem.Text;
                }
            }
            FormCadastrarMidia frm = new FormCadastrarMidia(dadosLV);
            frm.Show();
            
        }

        private void btRemover_Click(object sender, EventArgs e)
        {

        }
    }
}
