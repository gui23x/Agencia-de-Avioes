using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

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
                comando.Parameters.AddWithValue("@nomeCli",Model.Cliente.NomeCli);
                comando.Parameters.AddWithValue("@emailCli",Model.Cliente.EmailCli);
                comando.Parameters.AddWithValue("@senhaCli",Model.Cliente.SenhaCli);
                comando.Parameters.AddWithValue("@imagemCli",Model.Cliente.ImagemCli);

                SqlParameter nv = comando.Parameters.AddWithValue("@codigoCli", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                conectar.Open();
                comando.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cadastro de Cliente efetuada com sucesso,deseja efetuar um novo registro?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if(resposta == DialogResult.Yes)
                {
                    Model.Cliente.Retorno = "Sim";
                    return;
                }
                else
                {
                    Model.Cliente.Retorno = "Não";
                    return;
                }
            }
            catch
            {

            }
           
        }


    }
}