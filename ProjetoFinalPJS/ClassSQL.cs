using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace ProjetoFinalPJS
{
    class ClassSQL
    {
        //private const string conexao = @"Data Source=FAMILIAFURLAN;Initial Catalog=BD_AcervoMusical;User ID=FamiliaFurlan;Password=12345";
        // String do João
        //private const string conexao = @"Data Source=JOÃOCÍCERO-PC\JOÃOCÍCERO;Initial Catalog=BD_AcervoMusical;User ID=JoaoCicero;Password=5077005077";
        // String do Giovani
        private const string conexao = @"Data Source=GIOVANIAPARRECI;Initial Catalog=BD_AcervoMusical;Integrated Security=True";
        // String do Marcos
        //private const string conexao = @"Data Source=FAMILIAFURLAN;Initial Catalog=BD_AcervoMusical;User ID=FamiliaFurlan;Password=12345";

        SqlConnection ObjConexao = null;
        //DataSet dados = new DataSet();
        //SqlDataAdapter adaptador = new SqlDataAdapter();

        #region "Metodos de conexão e desconexão"
        public bool conectar()
        {
            ObjConexao = new SqlConnection(conexao);

            try
            {
                ObjConexao.Open();
                return true;

            }
            catch
            {
                return false;

            }

        }

        #region "Métodos de listagem de Cidades e Estados"

        public void ListaEstados(SqlCommand comandoListEstados, DataTable dtTabelaEstado)
        {
            //define a conexão
            SqlConnection objetoConexao = new SqlConnection(conexao);
            //cria um adaptador
            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM estados", conexao);
            //preenche o dataTable
            adaptador.Fill(dtTabelaEstado);

            return;
        }

        public void ListaCidades(SqlCommand comandoListCidades, DataTable dtTabelaCidade, string estSelecionado)
        {
            //define a conexao
            SqlConnection objetoConexao = new SqlConnection(conexao);
            //criar um adaptador
            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT C.cidade FROM cidades C INNER JOIN estados E ON C.id_estado = E.id_estado WHERE E.uf = '"+estSelecionado+"' ", conexao);
            //preenche o DataTable
            adaptador.Fill(dtTabelaCidade);

            return;
        }

        #endregion


        private bool desconectar()
        {
            if (ObjConexao.State != ConnectionState.Closed)
            {
                ObjConexao.Close();
                ObjConexao.Dispose(); //Tira o objeto da memória
                return true;
            }
            else
            {
                ObjConexao.Dispose();
                return false;
            }
        }

        #endregion

        #region "Metodos manipulação de dados do formulário Amigos"

        #region "Metodos manipulação de dados"
        public bool Insert(ArrayList Insert)
        {
            string stringComando = string.Empty;
            stringComando = "INSERT INTO Amigo VALUES (@APELIDO, @NOME, @ENDERECO,@BAIRRO, @CIDADE, @UF, @TELEFONE,@CELULAR,@EMAIL)";

            SqlCommand ObjComando = new SqlCommand();

            if (this.conectar())
            {

                try
                {
                    ObjComando = new SqlCommand(stringComando, ObjConexao);
                    ObjComando.Parameters.Add(new SqlParameter("@APELIDO", Insert[0]));
                    ObjComando.Parameters.Add(new SqlParameter("@NOME", Insert[1]));
                    ObjComando.Parameters.Add(new SqlParameter("@ENDERECO", Insert[2]));
                    ObjComando.Parameters.Add(new SqlParameter("@BAIRRO", Insert[3]));
                    ObjComando.Parameters.Add(new SqlParameter("@CIDADE", Insert[4]));
                    ObjComando.Parameters.Add(new SqlParameter("@UF", Insert[5]));
                    ObjComando.Parameters.Add(new SqlParameter("@TELEFONE", Insert[6]));
                    ObjComando.Parameters.Add(new SqlParameter("@CELULAR", Insert[7]));
                    ObjComando.Parameters.Add(new SqlParameter("@EMAIL", Insert[8]));

                    ObjComando.ExecuteNonQuery();

                    return true;
                }
                catch (SqlException erro)
                {
                    throw erro;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return false;
            }

        }

        public bool Update(ArrayList Update, string Apelido)
        {
            string stringComando = string.Empty;
            stringComando = "UPDATE Amigo SET  Nome = @NOME, Endereco = @ENDERECO, Bairro = @BAIRRO, Cidade = @CIDADE, UF = @UF,Telefone = @TELEFONE, Celular = @CELULAR, email = @EMAIL WHERE Apelido = @APELIDO";

            SqlCommand ObjComando = new SqlCommand();

            if (this.conectar())
            {

                try
                {
                    ObjComando = new SqlCommand(stringComando, ObjConexao);
                    ObjComando.Parameters.Add(new SqlParameter("@NOME", Update[0]));
                    ObjComando.Parameters.Add(new SqlParameter("@ENDERECO", Update[1]));
                    ObjComando.Parameters.Add(new SqlParameter("@BAIRRO", Update[2]));
                    ObjComando.Parameters.Add(new SqlParameter("@CIDADE", Update[3]));
                    ObjComando.Parameters.Add(new SqlParameter("@UF", Update[4]));
                    ObjComando.Parameters.Add(new SqlParameter("@TELEFONE", Update[5]));
                    ObjComando.Parameters.Add(new SqlParameter("@CELULAR", Update[6]));
                    ObjComando.Parameters.Add(new SqlParameter("@EMAIL", Update[7]));
                    ObjComando.Parameters.Add(new SqlParameter("@APELIDO", Apelido));

                    ObjComando.ExecuteNonQuery();

                    return true;
                }
                catch (SqlException erro)
                {
                    throw erro;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return false;
            }
        }

        public bool Delete(string Apelido)
        {
            string stringComando = string.Empty;
            stringComando = "DELETE FROM Amigo WHERE Apelido = @APELIDO";

            SqlCommand ObjComando = new SqlCommand();

            if (this.conectar())
            {

                try
                {
                    ObjComando = new SqlCommand(stringComando, ObjConexao);
                    ObjComando.Parameters.AddWithValue("@APELIDO", Apelido);
                    ObjComando.ExecuteNonQuery();

                    return true;
                }
                catch (SqlException erro)
                {
                    throw erro;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return false;
            }

        }


        #endregion

        # region "Apresentação dos Dados Armazenados no Banco"

        public DataTable Listar()
        {
            string stringComando = string.Empty;
            stringComando = "SELECT  [Nome], [Apelido],[Endereco] AS Endereço, [Bairro], [Cidade], [UF], [Telefone], [Celular], [Email] FROM AMIGO";

            SqlCommand ObjComando = new SqlCommand();

            if (this.conectar())
            {

                try
                {
                    ObjComando = new SqlCommand(stringComando, ObjConexao);
                    SqlDataAdapter adaptador = new SqlDataAdapter(ObjComando);
                    DataTable dtListar = new DataTable();
                    adaptador.Fill(dtListar);

                    return dtListar;
                }
                catch (SqlException erro)
                {
                    throw erro;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return null;
            }

        }

        public DataTable Pesquisar(string Nome)
        {
            string stringComando = string.Empty;
            stringComando = "SELECT [Nome], [Apelido] ,[Endereco] AS Endereço , [Bairro], [Cidade], [UF], [Telefone], [Celular], [Email] FROM AMIGO WHERE NOME LIKE @NOME";

            SqlCommand ObjComando = new SqlCommand();

            if (this.conectar())
            {

                try
                {
                    ObjComando = new SqlCommand(stringComando, ObjConexao);
                    ObjComando.Parameters.Add(new SqlParameter("@NOME", Nome));
                    SqlDataAdapter adaptador = new SqlDataAdapter(ObjComando);
                    DataTable dtPesquisar = new DataTable();
                    adaptador.Fill(dtPesquisar);

                    return dtPesquisar;
                }
                catch (SqlException erro)
                {
                    throw erro;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return null;
            }

        }

        #endregion

        # region Métodos manipulação de dados do formulário Midias
        public bool InsertMidia(ArrayList Insert)
        {
            string stringComando = string.Empty;
            stringComando = "INSERT INTO Midias VALUES (@INTERPRETE, @AUTOR,@ALBUM, @MUSICA, @DATAALBUM, @DATAAQUISICAO, @ORIGEMCOMPRA, @TIPO, @OBSERVACOES, @NOTA)";

            SqlCommand ObjComando = new SqlCommand();

            if (this.conectar())
            {

                try
                {
                    ObjComando = new SqlCommand(stringComando, ObjConexao);
                    ObjComando.Parameters.Add(new SqlParameter("@INTERPRETE", Insert[0]));
                    ObjComando.Parameters.Add(new SqlParameter("@AUTOR", Insert[1]));
                    ObjComando.Parameters.Add(new SqlParameter("@ALBUM", Insert[2]));
                    ObjComando.Parameters.Add(new SqlParameter("@MUSICA", Insert[3]));
                    ObjComando.Parameters.Add(new SqlParameter("@DATAALBUM", Insert[4]));
                    ObjComando.Parameters.Add(new SqlParameter("@DATAAQUISICAO", Insert[5]));
                    ObjComando.Parameters.Add(new SqlParameter("@ORIGEMCOMPRA", Insert[6]));
                    ObjComando.Parameters.Add(new SqlParameter("@TIPO", Insert[7]));
                    ObjComando.Parameters.Add(new SqlParameter("@OBSERVACOES", Insert[8]));
                    ObjComando.Parameters.Add(new SqlParameter("@NOTA", Insert[9]));

                    ObjComando.ExecuteNonQuery();

                    return true;
                }
                catch (SqlException erro)
                {
                    throw erro;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return false;
            }

        }
        public bool UpdateMidia(ArrayList Update, string Apelido)
        {
            string stringComando = string.Empty;
            stringComando = "UPDATE Midias SET  Interprete = @INTERPRETE, Autor = @AUTOR, Album = @ALBUM, Musica = @MUSICA, DataAlbum = @DATAALBUM, DataAquisicao = @DATAAQUISICAO, OrigemCompra = @ORIGEMCOMPRA, Tipo = @TIPO, Observações = @OBSERVACOES, Nota = @NOTA WHERE Interprete = @INTERPRETE AND Autor = @AUTOR";

            SqlCommand ObjComando = new SqlCommand();

            if (this.conectar())
            {

                try
                {
                    ObjComando = new SqlCommand(stringComando, ObjConexao);
                    ObjComando.Parameters.Add(new SqlParameter("@INTERPRETE", Update[0]));
                    ObjComando.Parameters.Add(new SqlParameter("@AUTOR", Update[1]));
                    ObjComando.Parameters.Add(new SqlParameter("@ALBUM", Update[2]));
                    ObjComando.Parameters.Add(new SqlParameter("@MUSICA", Update[3]));
                    ObjComando.Parameters.Add(new SqlParameter("@DATAALBUM", Update[4]));
                    ObjComando.Parameters.Add(new SqlParameter("@DATAAQUISICAO", Update[5]));
                    ObjComando.Parameters.Add(new SqlParameter("@ORIGEMCOMPRA", Update[6]));
                    ObjComando.Parameters.Add(new SqlParameter("@TIPO", Update[7]));
                    ObjComando.Parameters.Add(new SqlParameter("@OBSERVACOES", Update[8]));
                    ObjComando.Parameters.Add(new SqlParameter("@NOTA", Update[9]));

                    ObjComando.ExecuteNonQuery();

                    return true;
                }
                catch (SqlException erro)
                {
                    throw erro;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return false;
            }
        }


        # endregion
        # endregion
    }
}
