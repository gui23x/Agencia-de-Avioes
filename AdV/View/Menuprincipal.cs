using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
