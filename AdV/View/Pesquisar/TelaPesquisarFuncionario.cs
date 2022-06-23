using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AdV.Controller;
using AdV.Model;

namespace AdV.View.Pesquisar
{
    public partial class TelaPesquisarFuncionario : Form
    {
        public TelaPesquisarFuncionario()
        {
            InitializeComponent();
        }

        private void btnCodigoFun_Funck(object sender, EventArgs e)
        {

        }

        private void btnNomeFun_Click(object sender, EventArgs e)
        {
          
        }
       

        private void btnCodigoFun_Click(object sender, EventArgs e)
        {
            if (tbxCodigoFun.Text == "")
            {
                MessageBox.Show("Digite um código do Funcionario", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxCodigoFun.Text = string.Empty;
                tbxCodigoFun.Focus();
                tbxCodigoFun.SelectAll();
                tbxNomeCodFun.Text = string.Empty;
                tbxEmailCodFun.Text = string.Empty;
                tbxSenhaCodFun.Text = string.Empty;
            }
            else
            {
                Funcionario.CodigoFun = Convert.ToInt32(tbxCodigoFun.Text);
                Manipulafuncionario manipulaFuncionario = new Manipulafuncionario();
                manipulaFuncionario.pesquisarcodigoFuncionario();

                tbxCodigoFun.Text = Funcionario.CodigoFun.ToString();
                tbxNomeCodFun.Text = Funcionario.NomeFun;
                tbxEmailCodFun.Text = Funcionario.EmailFun;
                tbxSenhaCodFun.Text = Funcionario.SenhaFun;
            }

            if (Funcionario.Retorno == "Não")
            {
                LimparTela();
            }
        }
        public void LimparTela()
        {
            tbxCodigoFun.Text = string.Empty;
            tbxCodigoFun.Focus();
            tbxCodigoFun.SelectAll();
            tbxNomeCodFun.Text = string.Empty;
            tbxEmailCodFun.Text = string.Empty;
            tbxSenhaCodFun.Text = string.Empty;
        }

        private void tbxEmailCodFun_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
