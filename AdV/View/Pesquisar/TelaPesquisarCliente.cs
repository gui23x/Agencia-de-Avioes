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

namespace AdV.View.Pesquisar
{
    public partial class TelaPesquisarCliente : Form
    {
        public TelaPesquisarCliente()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCodigoCli_Click(object sender, EventArgs e)
        {
            if (tbxCodigoCli.Text == "")
            {
                MessageBox.Show("Digite um código do cliente", "Atenção",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                tbxCodigoCli.Text = string.Empty;
                tbxCodigoCli.Focus();
                tbxCodigoCli.SelectAll();
                tbxNomeCodCli.Text = string.Empty;
                tbxEmailCodCli.Text = string.Empty;
                tbxSenhaCodCli.Text = string.Empty;
                pbxImagemCodCli.Image = null;
            }
            else
            {
                Cliente.CodigoCli = Convert.ToInt32(tbxCodigoCli.Text);
                Manipulacliente manipulacliente = new Manipulacliente();
                manipulacliente.pesquisarcodigoCliente();

                tbxCodigoCli.Text = Cliente.CodigoCli.ToString();
                tbxNomeCodCli.Text = Cliente.NomeCli;
                tbxEmailCodCli.Text = Cliente.EmailCli;
                tbxSenhaCodCli.Text = Cliente.SenhaCli;

                MemoryStream ms = new MemoryStream((byte[])Cliente.ImagemCli);
                pbxImagemCodCli.Image = Image.FromStream(ms);
            }

            if (Cliente.Retorno == "Não")
            {
                LimparTela();
            }
        }
        public void LimparTela()
        {
            tbxCodigoCli.Text = string.Empty;
            tbxCodigoCli.Focus();
            tbxCodigoCli.SelectAll();
            tbxNomeCodCli.Text = string.Empty;
            tbxEmailCodCli.Text = string.Empty;
            tbxSenhaCodCli.Text = string.Empty;
            pbxImagemCodCli.Image = null;
        }

        private void btnNome_Click(object sender, EventArgs e)
        {

        }
    }
}
