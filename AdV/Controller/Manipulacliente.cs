using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AdV.Controller
{
    class Manipulacliente
    {
        public void cadastrarCliente()
        {
            SqlConnection conectar = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand comando = new SqlCommand("pCadastrarCliente",conectar);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                comando.Parameters.AddWithValue("@nomeCli");
                comando.Parameters.AddWithValue("@emailCli");
                comando.Parameters.AddWithValue("@senhaCli");
                comando.Parameters.AddWithValue("@imagemCli");
            }
        }


    }
}