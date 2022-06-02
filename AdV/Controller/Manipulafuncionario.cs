﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

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
    }
}