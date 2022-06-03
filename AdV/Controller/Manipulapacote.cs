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
                comando.Parameters.AddWithValue("@origemPac", Pacote.OrigemPac);
                comando.Parameters.AddWithValue("@destinoPac", Pacote.DestinoPac);
                comando.Parameters.AddWithValue("@dataPac", Pacote.DataPac);
                comando.Parameters.AddWithValue("@dataPacVolta", Pacote.DataPacVolta);
                comando.Parameters.AddWithValue("@descricaoPac", Pacote.DescricaoPac);
                comando.Parameters.AddWithValue("@imagemPac", Pacote.ImagemPac);

                SqlParameter nv = comando.Parameters.AddWithValue("@codigoPac", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                MessageBox.Show("Pronto!!!");
                conectar.Open();
                comando.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cadastro do Pacote efetuada com sucesso,deseja efetuar um novo registro?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    Pacote.Retorno = "Sim";
                    return;
                }
                else
                {
                    Pacote.Retorno = "Não";
                    return;
                }
            }
            catch
            {

            }
        }
    }
}
