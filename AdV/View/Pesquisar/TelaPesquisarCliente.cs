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
            if(tbxNome.Text == "")
            {
                MessageBox.Show("Digite o nome do cliente.","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            Cliente.NomeCli = tbxNome.Text;
            dgvInfoCli.DataSource = Manipulacliente.pesquisarNomeCliente();

            dgvInfoCli.Columns[0].Visible = false;
            dgvInfoCli.Columns[1].Visible = false;
            dgvInfoCli.Columns[2].Visible = false;
            dgvInfoCli.Columns[3].Visible = false;
            dgvInfoCli.Columns[4].HeaderCell.Value = "Código";
            dgvInfoCli.Columns[5].HeaderCell.Value = "Nome";
            dgvInfoCli.Columns[6].HeaderCell.Value = "E-mail";
            dgvInfoCli.Columns[7].Visible = false;
            dgvInfoCli.Columns[8].Visible = false;


        }

        private void btnDeletarCodCli_Click(object sender, EventArgs e)
        {
            if (tbxCodigoCli.Text == "")
            {
                MessageBox.Show("Digite um código do cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                var resposta = MessageBox.Show("Deseja excluir o Cliente" + tbxCodigoCli.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if(resposta == DialogResult.Yes)
                {
                    Cliente.CodigoCli = Convert.ToInt32(tbxCodigoCli.Text);

                    Manipulacliente manipulacliente = new Manipulacliente();
                    manipulacliente.deletarCliente();
                }

                tbxCodigoCli.Text = string.Empty;
                tbxCodigoCli.Focus();
                tbxCodigoCli.SelectAll();
                tbxNomeCodCli.Text = string.Empty;
                tbxEmailCodCli.Text = string.Empty;
                tbxSenhaCodCli.Text = string.Empty;
                pbxImagemCodCli.Image = null;
                return;

            }
        }

        private void btnAlterarCodCli_Click(object sender, EventArgs e)
        {
            if (tbxCodigoCli.Text == "")
            {
                MessageBox.Show("Digite um código do cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                var resposta = MessageBox.Show("Deseja alterar os dados do Cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Cliente.CodigoCli = Convert.ToInt32(tbxCodigoCli.Text);
                    Cliente.NomeCli = tbxNomeCodCli.Text;
                    Cliente.EmailCli = tbxEmailCodCli.Text;
                    Cliente.SenhaCli = tbxSenhaCodCli.Text;

                    MemoryStream ms = new MemoryStream((byte[])Cliente.ImagemCli);
                    pbxImagemCodCli.Image.Save(ms,pbxImagemCodCli.Image.RawFormat);
                    Cliente.ImagemCli = ms.ToArray();

                    Manipulacliente manipulacliente = new Manipulacliente();
                    manipulacliente.alterarCliente();
                }
                return;
            }
        }

        private void btnBuscarImagemCodCli_Click(object sender, EventArgs e)
        {
            openFileDialogImagem.Filter = "Escolha uma imagem (*.jpg;*.png;*.jpeg)" + "| *.jpg; *.jpeg;*.png";
            if (openFileDialogImagem.ShowDialog() == DialogResult.OK)
            {
                pbxImagemCodCli.Image = Image.FromFile(openFileDialogImagem.FileName);
            }
        }
    }
}
