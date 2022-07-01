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

namespace AdV.View.Registrar
{
    public partial class RegistrarVen : Form
    {
        public RegistrarVen()
        {
            InitializeComponent();
        }

        private void btnfun_Click(object sender, EventArgs e)
        {
            if (tbxcodfun.Text == "")
            {
                MessageBox.Show("Digite um código do Funcionário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxcodfun.Text = string.Empty;
                tbxcodfun.Focus();
                tbxcodfun.SelectAll();
                tbxfun.Text = string.Empty;
            }
            else
            {
                Funcionario.CodigoFun = Convert.ToInt32(tbxcodfun.Text);
                Manipulafuncionario manipulafuncionario = new Manipulafuncionario();
                manipulafuncionario.pesquisarcodigoFuncionario();

                tbxcodfun.Text = Funcionario.CodigoFun.ToString();
                tbxfun.Text = Funcionario.NomeFun;

            }
        }

        private void btncli_Click(object sender, EventArgs e)
        {
            if (tbxcodcli.Text == "")
            {
                MessageBox.Show("Digite um código do Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxcodcli.Text = string.Empty;
                tbxcodcli.Focus();
                tbxcodcli.SelectAll();
                tbxfun.Text = string.Empty;
            }
            else
            {
                Cliente.CodigoCli = Convert.ToInt32(tbxcodcli.Text);
                Manipulacliente manipulaCliente = new Manipulacliente();
                manipulaCliente.pesquisarcodigoCliente();

                tbxcodcli.Text = Cliente.CodigoCli.ToString();
                tbxcli.Text = Cliente.NomeCli;

            }
        }

        private void btnpac_Click(object sender, EventArgs e)
        {
            if (tbxcodpac.Text == "")
            {
                MessageBox.Show("Digite um código do Pacote", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxcodpac.Text = string.Empty;
                tbxcodpac.Focus();
                tbxcodpac.SelectAll();
                tbxvalorpac.Text = string.Empty;
                tbxregori.Text = string.Empty;
                tbxregdes.Text = string.Empty;
            }
            else
            {
                Pacote.CodigoPac = Convert.ToInt32(tbxcodpac.Text);
                Manipulapacote manipulaPacote = new Manipulapacote();
                manipulaPacote.pesquisarcodigoPacote();

                tbxcodpac.Text = Pacote.CodigoPac.ToString();
                tbxregori.Text = Pacote.OrigemPac;
                tbxregdes.Text = Pacote.DestinoPac;
                tbxvalorpac.Text = Convert.ToString(Pacote.ValorPac);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxvalorpac.Text == "")
            {
                MessageBox.Show("Preencha as informações corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               
              

                Venda.PagoVenda = "Sim";
                Cliente.CodigoCli = Convert.ToInt32(tbxcodcli.Text);
                Funcionario.CodigoFun = Convert.ToInt32(tbxcodfun.Text);
                Pacote.CodigoPac = Convert.ToInt32(tbxcodpac.Text);

                Manipulavenda manipulaVenda = new Manipulavenda();
                manipulaVenda.cadastrarVenda();

            }

        }

    }
}
