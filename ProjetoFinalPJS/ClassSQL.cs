using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoFinalPJS
{
    class ClassSQL
    {
        //private const string conexao = @"Data Source=FAMILIAFURLAN;Initial Catalog=AcervoMusical;User ID=FamiliaFurlan;Password=12345";
        private const string conexao = @"Data Source=FAMILIAFURLAN;Initial Catalog=BD_AcervoMusical;User ID=FamiliaFurlan;Password=12345";
        
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

        public bool Update(ArrayList Update)
        {
            string stringComando = string.Empty;
            stringComando = "UPDATE FROM Amigo SET Apelido =@APELIDO, Nome = @NOME, Endereco = @ENDERECO, Bairro = @BAIRRO, Cidade = @CIDADE, UF = @UF,Telefone = @TELEFONE, Celular = @CELULAR, email = @EMAIL)";

            SqlCommand ObjComando = new SqlCommand();

            if (this.conectar())
            {

                try
                {
                    ObjComando = new SqlCommand(stringComando, ObjConexao);
                    ObjComando.Parameters.Add(new SqlParameter("@APELIDO", Update[0]));
                    ObjComando.Parameters.Add(new SqlParameter("@NOME", Update[1]));
                    ObjComando.Parameters.Add(new SqlParameter("@ENDERECO", Update[2]));
                    ObjComando.Parameters.Add(new SqlParameter("@BAIRRO", Update[3]));
                    ObjComando.Parameters.Add(new SqlParameter("@CIDADE", Update[4]));
                    ObjComando.Parameters.Add(new SqlParameter("@UF", Update[5]));
                    ObjComando.Parameters.Add(new SqlParameter("@TELEFONE", Update[6]));
                    ObjComando.Parameters.Add(new SqlParameter("@CELULAR", Update[7]));
                    ObjComando.Parameters.Add(new SqlParameter("@EMAIL", Update[8]));

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

        public bool SelectAmigo(string Apelido)
        {
            string stringComando = string.Empty;
            stringComando = "SELECT * FROM Amigo WHERE Apelido = @APELIDO";

            SqlCommand ObjComando = new SqlCommand();

            if (this.conectar())
            {

                try
                {
                    ObjComando = new SqlCommand(stringComando, ObjConexao);
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
    }
}
