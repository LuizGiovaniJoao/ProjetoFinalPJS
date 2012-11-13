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
        private const string conexao = @"Data Source=(Local);Initial Catalog=AcervoMusical;Integrated Security=SSPI";
        
        private string stringComando = string.Empty;
        SqlConnection ObjConexao = null;

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
                    DataSet dados = new DataSet();
                    SqlDataAdapter adaptador = new SqlDataAdapter(); 
                    adaptador.InsertCommand = ObjComando;
                    ObjComando.CommandText = "SELECT * FROM Amigo";
                    adaptador.SelectCommand = ObjComando;
                    adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    adaptador.Fill(dados, "ProcessosCompleta");
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

        //public bool Update()
        //{

        //}

        //public bool Delete()
        //{
        //}
        #endregion
    }
}
