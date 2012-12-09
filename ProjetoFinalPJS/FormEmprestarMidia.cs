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
    public partial class FormEmprestarMidia : Form
    {
        public FormEmprestarMidia()
        {
            InitializeComponent();
        }

        public FormPrincipal FormularioPrincipal;
        public ListViewItem Lista = new ListViewItem();

        private void FormEmprestarMidia_Load(object sender, EventArgs e)
        {
            listar("SELECT Apelido FROM AMIGO order by Apelido", cbxApelido, "Apelido");
            listar("SELECT Endereco FROM Amigo WHERE APELIDO = '" + cbxApelido.Text + "'", cbxEndereco, "Endereco");
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

        private void radioAlbum_CheckedChanged(object sender, EventArgs e)
        {
            listar("SELECT Musica FROM MIDIA WHERE NOT Album = ''", cbxMusica, "Musica");
            listar("SELECT Interprete FROM MIDIA WHERE NOT Album = '' ORDER BY Interprete", cbxInterprete, "interprete");
            listar("SELECT Album FROM MIDIA WHERE Interprete = '"+cbxInterprete.Text+"'", cbxAlbum, "Album");
            if (radioAlbum.Checked)
            {
                cbxInterprete.Enabled = true;
                cbxAlbum.Enabled = true;
                cbxMidia.Enabled = true;
                cbxMusica.Enabled = false;
            }

            else
            {
                cbxInterprete.Enabled = false;
                cbxAlbum.Enabled = false;
                cbxMidia.Enabled = false;
            }
            cbxInterprete.Focus();
        }

        private void radioMusica_CheckedChanged(object sender, EventArgs e)
        {
            listar("SELECT Album FROM MIDIA WHERE not Musica = '' ", cbxMusica, "Album");
            listar("SELECT Interprete FROM MIDIA WHERE NOT Musica = '' ORDER BY Interprete", cbxInterprete, "interprete");
            listar("SELECT ALBUM FROM MIDIA WHERE '" + cbxAlbum.Text + "' = ''", cbxAlbum, "Album");
            if (radioMusica.Checked)
            {
                cbxInterprete.Enabled = true;
                cbxAlbum.Enabled = false;
                cbxMidia.Enabled = true;
                cbxMusica.Enabled = true;
            }
            else
            {
                cbxInterprete.Enabled = false;
                cbxAlbum.Enabled = false;
                cbxMidia.Enabled = false;
                cbxMusica.Enabled = false;
            }
            cbxInterprete.Focus();
        }

        private void cbxApelido_SelectedIndexChanged(object sender, EventArgs e)
        {
            listar("SELECT Endereco FROM Amigo WHERE APELIDO = '" + cbxApelido.Text + "'", cbxEndereco, "Endereco");
        }

        private void cbxInterprete_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProviderEmprestimo.SetError(lbAlbum, "");
            btAdicionar.Enabled = true;
            if (radioMusica.Checked)
            {
                listar("SELECT Musica FROM Midia WHERE INTERPRETE = '" + cbxInterprete.Text + "'", cbxMusica, "Musica");

                listar("SELECT Tipo FROM Midia WHERE Musica = '" + cbxMusica.Text + "'", cbxMidia, "Tipo");
            }
            else if (radioAlbum.Checked)
            {
                listar("SELECT Album FROM Midia WHERE INTERPRETE = '" + cbxInterprete.Text + "'", cbxAlbum, "Album");
                listar("SELECT Tipo FROM Midia WHERE Album = '" + cbxAlbum.Text + "'", cbxMidia, "Tipo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbxApelido.Text != "" && cbxEndereco.Text != "" && cbxInterprete.Text != "" && (cbxAlbum.Text != "" || cbxMusica.Text != "") && cbxMidia.Text != "")
            {
                bool verifica = false;
                foreach (ListViewItem listViewItem in ListViewEmprestimos.Items)
                {
                    string indice = cbxAlbum.Text;
                    if (((listViewItem.SubItems[1].Text == cbxAlbum.Text) || (listViewItem.SubItems[0].Text == cbxMusica.Text)) && (listViewItem.SubItems[0].Text == cbxInterprete.Text))
                    {
                        verifica = true;
                    }
                }

                if (verifica == false)
                {
                    Lista = new ListViewItem(cbxInterprete.Text);

                    ListViewEmprestimos.Items.Add(Lista);
                    Lista.SubItems.Add(cbxAlbum.Text);
                    Lista.SubItems.Add(cbxMusica.Text);
                    Lista.SubItems.Add(cbxMidia.Text);
                    Lista.SubItems.Add(DtEmprestimo.Text);

                    btEmprestar.Enabled = true;
                    cbxApelido.Enabled = false;
                    cbxEndereco.Enabled = false;
                }
                else
                {
                    if(radioAlbum.Checked)
                       errorProviderEmprestimo.SetError(lbAlbum, "Item já adicionado á lista de empréstimos");
                    else
                        errorProviderEmprestimo.SetError(lbMusica, "Item já adicionado á lista de empréstimos");
                }
            }
            else
            {
                MessageBox.Show("", "");
            }
        }

        private void btEmprestar_Click(object sender, EventArgs e)
        {
            string[] dadosLV = new string[13];
            
            ClassSQL Emprestar = new ClassSQL();
            ArrayList objArrayList = new ArrayList();
            ArrayList objArrayListEmprestimo = new ArrayList();
            
            foreach (ListViewItem listViewItem in ListViewEmprestimos.Items)
            {
                int I = 1;
                dadosLV[0] = listViewItem.Text;                 //Intérprete
                dadosLV[1] = listViewItem.SubItems[1].Text;     //Álbum
                dadosLV[2] = listViewItem.SubItems[2].Text;     //Música
                dadosLV[3] = listViewItem.SubItems[3].Text;     //Mídia
                dadosLV[4] = listViewItem.SubItems[4].Text;     //Data Empréstimo     

                objArrayList.Add(I);
                objArrayList.Add(dadosLV[1]);
                objArrayList.Add(dadosLV[2]);
                objArrayList.Add(dadosLV[3]);

                if (cbxApelido.Text != "" && cbxEndereco.Text != "")
                {
                    if (Emprestar.ItemEmprestar(objArrayList))
                    {
                        MessageBox.Show("Legaaallll Item");
                        I++;
                    }
                    else
                    {
                        MessageBox.Show("Não deu");
                    }
                }
            }

            objArrayListEmprestimo.Add(cbxApelido.Text);
            objArrayListEmprestimo.Add(cbxEndereco.Text);
            objArrayListEmprestimo.Add(dadosLV[4]);
            if (Emprestar.Emprestimo(objArrayListEmprestimo))
            {
                MessageBox.Show("Legaaallll Empréstimo");
            }
        }

        private void cbxAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProviderEmprestimo.SetError(lbAlbum, "");
        }

        private void cbxMusica_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProviderEmprestimo.SetError(lbMusica, "");
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewItem in ListViewEmprestimos.SelectedItems)
            {
                if (listViewItem.Selected)
                {
                    listViewItem.Remove();
                }
            }
        }
    }
}