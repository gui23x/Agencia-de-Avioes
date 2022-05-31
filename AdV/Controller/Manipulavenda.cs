using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AdV.Controller
{
    class Manipulavenda
    {
        public void cadastrarVenda()
        {
            SqlConnection conectar = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand comando = new SqlCommand("pCadastrarVenda", conectar);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                comando.Parameters.AddWithValue("@codigoCliFK", "");
                comando.Parameters.AddWithValue("@codigoFunFK", "");
                comando.Parameters.AddWithValue("@codigoPacoteFK", "");
                comando.Parameters.AddWithValue("@pagoVenda", "");
                comando.Parameters.AddWithValue("@codigoVenda", "");
            }
            catch 
            { 
            
            }
        }
    }
}
