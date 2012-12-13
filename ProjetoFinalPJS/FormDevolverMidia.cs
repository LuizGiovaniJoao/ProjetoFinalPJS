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
    public partial class FormDevolverMidia : Form
    {
        //abre ligacao
        ClassSQL conexao = new ClassSQL();
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

        private void cbxApelido_SelectedIndexChanged(object sender, EventArgs e)
        {
            listar("SELECT DISTINCT EnderecoAmigo FROM EMPRESTIMO WHERE Apelido = '" + cbxApelido.Text + "'", cbxEndereco, "EnderecoAmigo");
            listar("SELECT IdEmprestimo FROM Emprestimo WHERE APELIDO = '" + cbxApelido.Text + "'", cbxIdEmprestimo, "IdEmprestimo");
            SqlConnection conn = new SqlConnection(conexao.stringConexao);
            conn.Open();

            //limpa o listview
            listViewDevMidia.Items.Clear();

            SqlCommand cmd = new SqlCommand("SELECT Ite.Interprete, Ite.Album, Ite.Musica, Ite.TipoMidia, Emp.DataEmprestimo FROM ItemEmprestimo Ite INNER JOIN Emprestimo Emp ON Ite.IdEmprestimo = Emp.IdEmprestimo INNER JOIN Midia Mid ON Mid.Interprete = Ite.Interprete WHERE Emp.Apelido = '" + cbxApelido.Text + "'AND ((Mid.Album = Ite.Album AND Mid.Musica = ITE.MUSICA AND Mid.INTERPRETE = Ite.Interprete and Mid.Tipo = Ite.TipoMidia )AND (Mid.Situacao = 'Emprestado' ))", conn);

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
                    if (i == 4 || i == 5)
                    {
                        string PegaData = dr.GetValue(i).ToString();
                        DateTime DataAlbum = Convert.ToDateTime(PegaData).Date;
                        item.SubItems.Add(DataAlbum.ToString("dd/MM/yyyy"));
                    }
                    else
                    {
                        item.SubItems.Add(dr.GetValue(i).ToString());
                    }
                }
                listViewDevMidia.Items.Add(item);

            }
            conn.Close();
        }

        private void btDevolver_Click(object sender, EventArgs e)
        {
            string[] dadosListView = new string[6];
            ClassSQL Emprestar = new ClassSQL();

            //Item Empréstimo
            foreach (ListViewItem listViewItem in listViewDevMidia.SelectedItems)
            {
                dadosListView[0] = listViewItem.Text;//.................Intérprete
                dadosListView[1] = listViewItem.SubItems[1].Text;//....Álbum
                dadosListView[2] = listViewItem.SubItems[2].Text;//....Música
                dadosListView[3] = listViewItem.SubItems[3].Text;//....Mídia
                dadosListView[4] = listViewItem.SubItems[4].Text;//....Data Empréstimo

                ///////////////////////////////////////////////////////////////////////
                ArrayList objArrayDisponibilidade = new ArrayList();
                objArrayDisponibilidade.Add("Disponível");
                objArrayDisponibilidade.Add(dadosListView[0]);  //Intérprete
                objArrayDisponibilidade.Add(dadosListView[1]);  //Álbum
                objArrayDisponibilidade.Add(dadosListView[2]);  //Música

                if (Emprestar.AtualizaDisponibilidade(objArrayDisponibilidade))
                {
                    MessageBox.Show("Update", "");
                    ArrayList objDelete = new ArrayList();
                    objDelete.Add(dadosListView[0]);  //Intérprete
                    objDelete.Add(dadosListView[1]);  //Álbum
                    objDelete.Add(dadosListView[2]);  //Música
                    objDelete.Add(dadosListView[3]);  //Tipo de mídia
                    ///////////////////////
                    if (Emprestar.DeletaItens(objDelete))
                    {
                        MessageBox.Show("deletou", "");
                    }
                }
                ////////////////////////////////////////////////////////////////////////
                listViewItem.Remove();
            }
        }

        private void btDevolveTudo_Click(object sender, EventArgs e)
        {
            string[] dadosListView = new string[5];
            ClassSQL Emprestar = new ClassSQL();
            
            foreach (ListViewItem listViewItem in listViewDevMidia.Items)
            {
                listViewItem.Selected = true;

                dadosListView[0] = listViewItem.Text;//.................Intérprete
                dadosListView[1] = listViewItem.SubItems[1].Text;//....Álbum
                dadosListView[2] = listViewItem.SubItems[2].Text;//....Música
                dadosListView[3] = listViewItem.SubItems[3].Text;//....Mídia
                dadosListView[4] = listViewItem.SubItems[4].Text;//....Data Empréstimo

                ArrayList objArrayDisponibilidade = new ArrayList();
                objArrayDisponibilidade.Add("Disponível");
                objArrayDisponibilidade.Add(dadosListView[0]);  //Intérprete
                objArrayDisponibilidade.Add(dadosListView[1]);  //Álbum
                objArrayDisponibilidade.Add(dadosListView[2]);  //Música

                if (Emprestar.AtualizaDisponibilidade(objArrayDisponibilidade))
                {
                    //ArrayList InsertDevolucao();
                    //if(Emprestar.Devolucao())
                    //{

                    //}

                    MessageBox.Show("Update", "");
                    ArrayList objDelete = new ArrayList();
                    objDelete.Add(dadosListView[0]);  //Intérprete
                    objDelete.Add(dadosListView[1]);  //Álbum
                    objDelete.Add(dadosListView[2]);  //Música
                    objDelete.Add(dadosListView[3]);
                    ///////////////////////
                    if(Emprestar.DeletaItens(objDelete))
                    {
                        MessageBox.Show("deletou","");
                    }
                }
                listViewItem.Remove();
            }
        }
    }
}