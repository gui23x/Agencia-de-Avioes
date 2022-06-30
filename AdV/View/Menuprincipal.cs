using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdV.View.Pesquisar;
using AdV.View.Registrar;

namespace AdV.View
{
    public partial class Menuprincipal : Form
    {
        public Menuprincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cliCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro.TelaCadastrarCliente cliente = new Cadastro.TelaCadastrarCliente();
            cliente.ShowDialog();
        }

        private void funFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void funCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro.TelaCadastrarFuncionario funcionario = new Cadastro.TelaCadastrarFuncionario();
            funcionario.ShowDialog();
        }

        private void pacCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro.TelaCadastrarPacote pacote = new Cadastro.TelaCadastrarPacote();
            pacote.ShowDialog();
        }

        private void cliPesquisar_Click(object sender, EventArgs e)
        {
            TelaPesquisarCliente pesquisarCliente = new TelaPesquisarCliente();
            pesquisarCliente.ShowDialog();
        }

        private void funPesquisar_Click(object sender, EventArgs e)
        {
            TelaPesquisarFuncionario pesquisarFuncionario = new TelaPesquisarFuncionario();
            pesquisarFuncionario.ShowDialog();
        }

        private void pacPesquisar_Click(object sender, EventArgs e)
        {
            TelaPesquisarPacote pesquisarPacote = new TelaPesquisarPacote();
            pesquisarPacote.ShowDialog();
        }

        private void venCadastrar_Click(object sender, EventArgs e)
        {
            RegistrarVen registrarVendas = new RegistrarVen();
            registrarVendas.ShowDialog();
        }
    }
}
