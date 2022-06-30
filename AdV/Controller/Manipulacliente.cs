using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using AdV.Model;

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
                MessageBox.Show("Pronto!!!");
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
        public void pesquisarcodigoCliente()
        {
            SqlConnection conectar = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand comando = new SqlCommand("pPesquisaCodCliente",conectar);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                comando.Parameters.AddWithValue("@codigoCli", Cliente.CodigoCli);
                conectar.Open();

                var arrayDados = comando.ExecuteReader();

                if (arrayDados.Read())
                {
                    Cliente.CodigoCli = Convert.ToInt32(arrayDados["codigoCli"]);
                    Cliente.NomeCli = arrayDados["nomeCli"].ToString();
                    Cliente.EmailCli = arrayDados["emailCli"].ToString();
                    Cliente.SenhaCli = arrayDados["senhaCli"].ToString();
                    Cliente.ImagemCli = (System.Array)arrayDados["imagemCli"];
                    Cliente.Retorno = "Sim";
                }
                else
                {
                    MessageBox.Show("Código não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Cliente.Retorno = "Não";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void deletarCliente()
        {
            SqlConnection conectar = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand comando = new SqlCommand("pDeletarCliente", conectar);
            comando.CommandType = CommandType.StoredProcedure;
            try
            {
                comando.Parameters.AddWithValue("@codigoCli", Cliente.CodigoCli);
                conectar.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente excluído com sucesso", "Exclução", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("O Cliente não pode ser excluído", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);            }
            finally
            {
                if (conectar.State != ConnectionState.Closed)
                {
                    conectar.Close();
                }
            }
        }

        public void alterarCliente()
        {
            SqlConnection conectar = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand comando = new SqlCommand("pAlterarCliente", conectar);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                comando.Parameters.AddWithValue("@codigoCli", Cliente.CodigoCli);
                comando.Parameters.AddWithValue("@nomeCli", Cliente.NomeCli);
                comando.Parameters.AddWithValue("@emailCli", Cliente.EmailCli);
                comando.Parameters.AddWithValue("@senhaCli", Cliente.SenhaCli);
                comando.Parameters.AddWithValue("@imagemCli", Cliente.ImagemCli);

                conectar.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("cliente alterado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("O Cliente não foi Alterado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conectar.State != ConnectionState.Closed)
                {
                    conectar.Close();
                }
            }

            
        }
        public static BindingSource pesquisarNomeCliente()
        {
            SqlConnection conectar = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand comando = new SqlCommand("pPesquisaNomeCliente", conectar);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nomeCli", Cliente.NomeCli);
            conectar.Open();
            comando.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(comando);

            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;
        }
    }
}