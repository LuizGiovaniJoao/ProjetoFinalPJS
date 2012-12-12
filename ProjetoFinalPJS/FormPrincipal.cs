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
            AtualizaAutoCompletar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCadastrarMidia frm = new FormCadastrarMidia();
            frm.FormularioPrincipal = this;
            frm.Show();
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
            {
                tbxAutor.Enabled = true;
                btFiltral.Enabled = true;
                tbxAutor.Focus();
            }

            else
            {
                tbxAutor.Enabled = false;
                tbxAutor.Text = null;
            }
        }

        private void checkBox_album_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_album.Checked)
            {
                tbxAlbum.Enabled = true;
                btFiltral.Enabled = true;
                tbxAlbum.Focus();
            }
            else
            {
                tbxAlbum.Enabled = false;
                tbxAlbum.Text = null;
            }
        }

        private void checkBoxInterprete_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInterprete.Checked)
            {
                btFiltral.Enabled = true;
                tbxInterprete.Enabled = true;
                tbxInterprete.Focus();
            }
            else
            {
                tbxInterprete.Enabled = false;
                tbxInterprete.Text = null;
            }
        }

        private void checkBox_origemCompra_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_origemCompra.Checked)
            {
                btFiltral.Enabled = true;
                tbxOrigemCompra.Enabled = true;
                tbxOrigemCompra.Focus();
            }
            else
            {
                tbxOrigemCompra.Enabled = false;
                tbxOrigemCompra.Text = null;
            }
        }

        private void checkBox_dataAlbum_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_dataAlbum.Checked)
            {
                btFiltral.Enabled = true;
                dateTimeDataAlbum.Enabled = true;
            }
            else
            {
                dateTimeDataAlbum.Enabled = false;
            }
        }

        private void checkBox_dataCompra_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_dataCompra.Checked)
            {
                btFiltral.Enabled = true;
                dateTimeDataCompra.Enabled = true;
            }
            else
            {
                dateTimeDataCompra.Enabled = false;
            }
        }

        private void checkBox_midia_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_midia.Checked)
            {
                btFiltral.Enabled = true;
                cbxMidia.Enabled = true;
            }
            else
            {
                cbxMidia.Enabled = false;
                cbxMidia.Text = null;
            }
        }

        private void checkBox_nota_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_nota.Checked)
            {
                btFiltral.Enabled = true;
                cbxNota.Enabled = true;
            }
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
            checkBoxDataCompra1.Checked = false;
            checkBox_dataAlbum1.Checked = false;
            checkBoxSituacao.Checked = false;

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

            SqlCommand cmd = new SqlCommand("SELECT [Musica], [Album], [Autor], [Interprete], [DataAlbum], [DataAquisicao], [OrigemCompra], [Observacoes], [Tipo],  [Nota], [Situacao] FROM [Midia] ", conn);
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
                    dadosLV[0] = listViewItem.Text;
                    dadosLV[1] = listViewItem.SubItems[1].Text;
                    dadosLV[2] = listViewItem.SubItems[2].Text;
                    dadosLV[3] = listViewItem.SubItems[3].Text;
                    dadosLV[4] = listViewItem.SubItems[4].Text;
                    dadosLV[5] = listViewItem.SubItems[5].Text;
                    dadosLV[6] = listViewItem.SubItems[6].Text;
                    dadosLV[7] = listViewItem.SubItems[7].Text;
                    dadosLV[8] = listViewItem.SubItems[8].Text;
                    dadosLV[9] = listViewItem.SubItems[9].Text;

                }
            }
            FormCadastrarMidia frm = new FormCadastrarMidia(dadosLV);
            frm.Show();
            
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            ClassSQL DeletarMidia = new ClassSQL();
            ArrayList objArrayList = new ArrayList();
  
            foreach (ListViewItem listViewItem in listViewMidia.SelectedItems)
            {
                if (listViewItem.Selected)
                {
                    if (DeletarMidia.DeleteMidia(listViewItem.SubItems[3].Text, listViewItem.SubItems[1].Text, listViewItem.Text))
                    {
                        MessageBox.Show("Removido");
                        listViewItem.Remove();

                    }
                    else
                    {
                        MessageBox.Show("Não Removeu");
                    }
                }
            }
            
        }

        private void btFiltral_Click(object sender, EventArgs e)
        {
            ClassSQL conexao = new ClassSQL();
            SqlConnection conn = new SqlConnection(conexao.stringConexao);
            conn.Open();

            DataSet DataSetFiltro = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Midia", conn);
            da.Fill(DataSetFiltro, "Midias");
            conn.Close();
            DataTable TabelaDataSet = DataSetFiltro.Tables["Midias"];

            
            foreach (DataRow registro in DataSetFiltro.Tables["Midias"].Rows)
            {
                DateTime DataAlbum = Convert.ToDateTime(registro["DataAlbum"]);
                DateTime DataCompra = Convert.ToDateTime(registro["DataAquisicao"]);

                if (checkBoxInterprete.Checked)
                        if (registro.RowState != DataRowState.Deleted && registro["Interprete"].ToString() != tbxInterprete.Text)
                            registro.Delete();

                if (checkBox_Autor.Checked)
                        if (registro.RowState != DataRowState.Deleted && registro["Autor"].ToString() != tbxAutor.Text)
                            registro.Delete();

                if (checkBox_album.Checked)
                        if (registro.RowState != DataRowState.Deleted && registro["Album"].ToString() != tbxAlbum.Text && registro["Musica"].ToString() != tbxAlbum.Text)
                            registro.Delete();

                if (checkBox_origemCompra.Checked)
                        if (registro.RowState != DataRowState.Deleted && registro["OrigemCompra"].ToString() != tbxOrigemCompra.Text)
                            registro.Delete();

                if (checkBox_midia.Checked)
                        if (registro.RowState != DataRowState.Deleted && registro["Tipo"].ToString() != cbxMidia.Text)
                            registro.Delete();

                if (checkBox_nota.Checked)
                        if (registro.RowState != DataRowState.Deleted && registro["Nota"].ToString() != cbxNota.Text)
                            registro.Delete();

                    //Superior a data de album
                if (checkBox_dataAlbum.Checked)
                    if (registro.RowState != DataRowState.Deleted && DataAlbum < dateTimeDataAlbum.Value)
                        registro.Delete();

                    //Inferior a data de album
                if (checkBox_dataAlbum1.Checked)
                    if (registro.RowState != DataRowState.Deleted && DataAlbum > dateTimePickerDataAlbum1.Value)
                        registro.Delete();

                    //Superior a data da compra
                if (checkBox_dataCompra.Checked)
                    if (registro.RowState != DataRowState.Deleted && DataCompra < dateTimeDataCompra.Value)
                        registro.Delete();

                    //Inferior a data de album
                if (checkBoxDataCompra1.Checked)
                    if (registro.RowState != DataRowState.Deleted && DataCompra > dateTimePickerDataCompra1.Value)
                        registro.Delete();
            }
                
                listViewMidia.Items.Clear();

                for (int i = 0; i < TabelaDataSet.Rows.Count; i++)
                {
                    DataRow LinhaRegistro = TabelaDataSet.Rows[i];
                    // Somente as linhas que não foram deletadas
                    if (LinhaRegistro.RowState != DataRowState.Deleted)
                    {
                        // Define os itens da lista
                        ListViewItem item = new ListViewItem(LinhaRegistro["Musica"].ToString());
                        item.SubItems.Add(LinhaRegistro["Album"].ToString());
                        item.SubItems.Add(LinhaRegistro["Autor"].ToString());
                        item.SubItems.Add(LinhaRegistro["Interprete"].ToString());
                        item.SubItems.Add(LinhaRegistro["DataAlbum"].ToString());
                        item.SubItems.Add(LinhaRegistro["DataAquisicao"].ToString());
                        item.SubItems.Add(LinhaRegistro["OrigemCompra"].ToString());
                        item.SubItems.Add(LinhaRegistro["Observacoes"].ToString());
                        item.SubItems.Add(LinhaRegistro["Tipo"].ToString());
                        item.SubItems.Add(LinhaRegistro["Nota"].ToString());
                        item.SubItems.Add(LinhaRegistro["Situacao"].ToString());

                        // Inclui os itens no ListView
                        listViewMidia.Items.Add(item);
                    }
                }

                foreach (ListViewItem item in listViewMidia.Items)
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

            listViewMidia.Items.Clear();

            for (int i = 0; i < TabelaDataSet.Rows.Count; i++)
            {
                DataRow LinhaRegistro = TabelaDataSet.Rows[i];

                // Somente as linhas que não foram deletadas
                if (LinhaRegistro.RowState != DataRowState.Deleted)
                {
                    string PegaDataAlbum = LinhaRegistro["DataAlbum"].ToString();
                    DateTime DataAlbum = Convert.ToDateTime(PegaDataAlbum).Date;

                    string PegaDataAquisicao = LinhaRegistro["DataAquisicao"].ToString();
                    DateTime DataAquisicao = Convert.ToDateTime(PegaDataAquisicao).Date;

                    // Define os itens da lista
                    ListViewItem item = new ListViewItem(LinhaRegistro["Musica"].ToString());
                    item.SubItems.Add(LinhaRegistro["Album"].ToString());
                    item.SubItems.Add(LinhaRegistro["Autor"].ToString());
                    item.SubItems.Add(LinhaRegistro["Interprete"].ToString());
                    item.SubItems.Add(DataAlbum.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(DataAquisicao.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(LinhaRegistro["OrigemCompra"].ToString());
                    item.SubItems.Add(LinhaRegistro["Observacoes"].ToString());
                    item.SubItems.Add(LinhaRegistro["Tipo"].ToString());
                    item.SubItems.Add(LinhaRegistro["Nota"].ToString());
                    item.SubItems.Add(LinhaRegistro["Situacao"].ToString());

                    // Inclui os itens no ListView
                    listViewMidia.Items.Add(item);
                }
            }


            foreach (ListViewItem item in listViewMidia.Items)
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


        public void AtualizaAutoCompletar()
        {
            AutoCompletar("SELECT Interprete FROM Midia", "Interprete", tbxInterprete);
            AutoCompletar("SELECT Autor FROM Midia", "Autor", tbxAutor);
            AutoCompletar("SELECT Album FROM Midia", "Album", tbxAlbum);
            AutoCompletar("SELECT OrigemCompra FROM Midia", "OrigemCompra", tbxOrigemCompra);
        }

        public void AutoCompletar(string ComandoSQL, string Campo, TextBox CaixaTexto)
        {
            AutoCompleteStringCollection colecao = new AutoCompleteStringCollection();
            SqlConnection conexao = new SqlConnection((new ClassSQL()).stringConexao);
            SqlCommand cmd = new SqlCommand(ComandoSQL, conexao);
            conexao.Open();
            SqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
                colecao.Add(leitor[Campo].ToString());
            CaixaTexto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CaixaTexto.AutoCompleteSource = AutoCompleteSource.CustomSource;
            CaixaTexto.AutoCompleteCustomSource = colecao;
            leitor.Close();
            conexao.Close();
        }

        private void cbxNota_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gpbxFiltro_Enter(object sender, EventArgs e)
        {

        }

        private void checkBoxSituacao_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSituacao.Checked)
                comboBoxSituacao.Enabled = true;
            else
            {
                comboBoxSituacao.Enabled = false;
                comboBoxSituacao.Text = null;
            }
        }

        private void checkBox_dataAlbum1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_dataAlbum1.Checked)
                dateTimePickerDataAlbum1.Enabled = true;
            else
                dateTimePickerDataAlbum1.Enabled = false;
        }

        private void checkBoxDataCompra1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDataCompra1.Checked)
                dateTimePickerDataCompra1.Enabled = true;
            else
                dateTimePickerDataCompra1.Enabled = false;
        }
    }
}
