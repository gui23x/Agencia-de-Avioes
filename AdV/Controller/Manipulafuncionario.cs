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

                SqlParameter nv = comando.Parameters.AddWithValue("@codigoFun", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                MessageBox.Show("Pronto!!!");
                conectar.Open();
                comando.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cadastro de Funcionário efetuada com sucesso,deseja efetuar um novo registro?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    Model.Funcionario.Retorno = "Sim";
                    return;
                }
                else
                {
                    Model.Funcionario.Retorno = "Não";
                    return;
                }
            }
            catch
            {

            }
        }
        public void pesquisarcodigoFuncionario()
        {
            SqlConnection conectar = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand comando = new SqlCommand("pPesquisaCodFuncionario", conectar);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                comando.Parameters.AddWithValue("@codigoFun", Funcionario.CodigoFun);
                conectar.Open();

                var arrayDados = comando.ExecuteReader();

                if (arrayDados.Read())
                {
                    Funcionario.CodigoFun = Convert.ToInt32(arrayDados["codigoFun"]);
                    Funcionario.NomeFun = arrayDados["nomeFun"].ToString();
                    Funcionario.EmailFun = arrayDados["emailFun"].ToString();
                    Funcionario.SenhaFun = arrayDados["senhaFun"].ToString();
                    Funcionario.Retorno = "Sim";
                }
                else
                {
                    MessageBox.Show("Código não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Funcionario.Retorno = "Não";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void deletarFuncionario()
        {
            SqlConnection conectar = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand comando = new SqlCommand("pDeletarFuncionario", conectar);
            comando.CommandType = CommandType.StoredProcedure;
            try
            {
                comando.Parameters.AddWithValue("@codigoFun", Funcionario.CodigoFun);
                conectar.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Funcionario excluído com sucesso", "Exclução", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (conectar.State != ConnectionState.Closed)
                {
                    conectar.Close();
                }
            }
        }

        public void alterarFuncionario()
        {
            SqlConnection conectar = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand comando = new SqlCommand("pAlterarfuncionario", conectar);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                comando.Parameters.AddWithValue("@codigoFun", Funcionario.CodigoFun);
                comando.Parameters.AddWithValue("@nomeFun", Funcionario.NomeFun);
                comando.Parameters.AddWithValue("@emailFun", Funcionario.EmailFun);
                comando.Parameters.AddWithValue("@senhaFun", Funcionario.SenhaFun);

                conectar.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Funcionario alterado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("O Funcionario não foi Alterado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conectar.State != ConnectionState.Closed)
                {
                    conectar.Close();
                }
            }


        }
        public static BindingSource pesquisarNomeFuncionario()
        {
            SqlConnection conectar = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand comando = new SqlCommand("pPesquisaNomeFuncionario", conectar);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nomeFun", Funcionario.NomeFun);
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
