using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdV.Model;
using AdV.Controller;
using System.IO;

namespace AdV.View.Cadastro
{
    public partial class TelaCadastrarFuncionario : Form
    {
        public TelaCadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void btnSalvarFun_Click(object sender, EventArgs e)
        {
            if(tbxNomeFun.Text == "" | tbxEmailFun.Text == "" | tbxSenhaFun.Text == "")
            {
                MessageBox.Show("Preencha todos os Dados.");
            }
            else
            {
                Funcionario.NomeFun = tbxNomeFun.Text;
                Funcionario.EmailFun = tbxEmailFun.Text;
                Funcionario.SenhaFun = tbxSenhaFun.Text;

                Manipulafuncionario manipulaFuncionario = new Manipulafuncionario();
                manipulaFuncionario.cadastrarFuncionario();
            }

            if(Funcionario.Retorno == "Sim")
            {
                LimparTela();
            }
            else if (Funcionario.Retorno == "Não")
            {
                this.Close();
            }
        }
        public void LimparTela()
        {
            tbxNomeFun.Clear();
            tbxEmailFun.Clear();
            tbxSenhaFun.Clear();
        }
    }
}
