using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AdV.Controller
{
    class Manipulafuncionario
    {
        public void cadastrarFuncionario()
        {
            SqlConnection conectar = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand comando = new SqlCommand("pCadastrarFuncionario", conectar);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                comando.Parameters.AddWithValue("@nomeFun", Model.Funcionario.NomeFun);
                comando.Parameters.AddWithValue("@emailFun", Model.Funcionario.EmailFun);
                comando.Parameters.AddWithValue("@senhaFun", Model.Funcionario.SenhaFun);
            }
            catch
            {

            }
        }
    }
}
