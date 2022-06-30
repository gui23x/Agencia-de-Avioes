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
        public void pesquisarcodigoPacote()
        {
            SqlConnection conectar = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand comando = new SqlCommand("pPesquisaCodPacote", conectar);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                comando.Parameters.AddWithValue("@codigoPac", Pacote.CodigoPac);
                conectar.Open();

                var arrayDados = comando.ExecuteReader();

                if (arrayDados.Read())
                {
                    Pacote.CodigoPac = Convert.ToInt32(arrayDados["codigoPac"]);
                    Pacote.ValorPac = Convert.ToDecimal(arrayDados["valorPac"]);
                    Pacote.OrigemPac = arrayDados["origemPac"].ToString();
                    Pacote.DestinoPac = arrayDados["destinoPac"].ToString();
                    Pacote.DataPac = Convert.ToDateTime(arrayDados["dataPac"]);
                    Pacote.DataPacVolta = Convert.ToDateTime(arrayDados["dataPacVolta"]);
                    Pacote.DescricaoPac = arrayDados["descricaoPac"].ToString();
                    Pacote.ImagemPac = (System.Array)arrayDados["imagemPac"];
                    Pacote.Retorno = "Sim";
                }
                else
                {
                    MessageBox.Show("Código não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Pacote.Retorno = "Não";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void deletarPacote()
        {
            SqlConnection conectar = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand comando = new SqlCommand("pDeletarPacote", conectar);
            comando.CommandType = CommandType.StoredProcedure;
            try
            {
                comando.Parameters.AddWithValue("@codigoPac", Pacote.CodigoPac);
                conectar.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Pacote excluído com sucesso", "Exclução", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (conectar.State != ConnectionState.Closed)
                {
                    conectar.Close();
                }
            }
        }

        public void alterarPacote()
        {
            SqlConnection conectar = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand comando = new SqlCommand("pAlterarPacotes", conectar);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                comando.Parameters.AddWithValue("@codigoPac", Pacote.CodigoPac);
                comando.Parameters.AddWithValue("@valorPac", Pacote.ValorPac);
                comando.Parameters.AddWithValue("@origemPac", Pacote.OrigemPac);
                comando.Parameters.AddWithValue("@destinoPac", Pacote.DestinoPac);
                comando.Parameters.AddWithValue("@dataPac", Pacote.DataPac);
                comando.Parameters.AddWithValue("@dataPacVolta", Pacote.DataPacVolta);
                comando.Parameters.AddWithValue("@descricaoPac", Pacote.DescricaoPac);
                comando.Parameters.AddWithValue("@imagemPac", Pacote.ImagemPac);

                conectar.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Pacote alterado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("O Pacote não foi Alterado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conectar.State != ConnectionState.Closed)
                {
                    conectar.Close();
                }
            }
        }
        public static BindingSource pesquisaDestinoPac()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisaDestinoPacote", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@destinoPac", Pacote.DestinoPac);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;
        }
        public static BindingSource pesquisaOrigemPac()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisaOrigemPacote", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@origemPac", Pacote.OrigemPac);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;
        }
    }
}
