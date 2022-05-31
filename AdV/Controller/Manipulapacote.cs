using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using AdV.Model;

namespace AdV.Controller
{
    class Manipulapacote
    {
        public void cadastrarPacote()
        {
            SqlConnection conectar = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand comando = new SqlCommand("pCadastrarPacote", conectar);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                comando.Parameters.AddWithValue("@valorPac", Pacote.ValorPac);
                comando.Parameters.AddWithValue("@origemPac","");
                comando.Parameters.AddWithValue("@destinoPac", "");
                comando.Parameters.AddWithValue("@dataPac", "");
                comando.Parameters.AddWithValue("@dataPacVolta", "");
                comando.Parameters.AddWithValue("@descricaoPac", "");
                comando.Parameters.AddWithValue("@imagemPac", "");
                comando.Parameters.AddWithValue("@codigoPac", "");
            }
            catch
            {

            }
        }
    }
}
