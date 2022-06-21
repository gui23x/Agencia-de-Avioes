using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdV.Model;
using AdV.Controller;

namespace AdV.View.Cadastro
{
    public partial class TelaCadastrarCliente : Form
    {
        public TelaCadastrarCliente()
        {
            InitializeComponent();
        }

        private void btnSalvarCli_Click(object sender, EventArgs e)
        {
            if(tbxNomeCli.Text == "" | tbxEmailCli.Text == "" | tbxSenhaCli.Text == "" | pbxImagemCli.Image == null)
            {
                MessageBox.Show("Preencha todas as infomações corretamente.");
            }
            else {

            Cliente.NomeCli = tbxNomeCli.Text;
            Cliente.EmailCli = tbxEmailCli.Text;
            Cliente.SenhaCli = tbxSenhaCli.Text;
           
            MemoryStream memoryStream = new MemoryStream();
            pbxImagemCli.Image.Save(memoryStream, pbxImagemCli.Image.RawFormat);
            Cliente.ImagemCli = memoryStream.ToArray();

            Manipulacliente manipulaCliente = new Manipulacliente();
            manipulaCliente.cadastrarCliente();
            }

            if (Cliente.Retorno == "Não")
            {
                LimparTela();
            }
        }

        private void btnBuscarImagemCli_Click(object sender, EventArgs e)
        {
            openFileDialogImagem.Filter = "Escolha uma Imagem (*.jpg; *.png; *.jpeg)" + "| *.jpg;*.png;*.jpeg";

            if (openFileDialogImagem.ShowDialog() == DialogResult.OK)
            {
                pbxImagemCli.Image = Image.FromFile(openFileDialogImagem.FileName);
            }
        }

        public void LimparTela()
        {
            tbxNomeCli.Clear();
            tbxEmailCli.Clear();
            tbxSenhaCli.Clear();
            pbxImagemCli.Image = null;
        }
    }
}
