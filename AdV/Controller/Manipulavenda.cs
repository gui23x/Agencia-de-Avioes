using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using AdV.Model;
using System.Windows.Forms;

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
                comando.Parameters.AddWithValue("@codigoCliFK", Cliente.CodigoCli);
                comando.Parameters.AddWithValue("@codigoFunFK", Funcionario.CodigoFun);
                comando.Parameters.AddWithValue("@codigoPacoteFK", Pacote.CodigoPac);
                comando.Parameters.AddWithValue("@pagoVenda", Venda.PagoVenda);


                SqlParameter nv = comando.Parameters.AddWithValue("@codigoVenda", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                conectar.Open();
                comando.ExecuteNonQuery();
                var resposta = MessageBox.Show("Cadastro da Venda efetuada com sucesso,deseja efetuar um novo registro?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }

            catch
            {

            }
        }
    }
}
