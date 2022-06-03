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
    public partial class TelaCadastrarPacote : Form
    {
        public TelaCadastrarPacote()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarPac_Click(object sender, EventArgs e)
        {
            if (tbxDestinoPac.Text == "" | tbxOrigemPac.Text == "" | tbxIdaPac.Text == "" | tbxVoltaPac.Text == "" | rtxDescricaoPac.Text == "" | tbxValorPac.Text == "" | tbxIdaPac.Value > tbxVoltaPac.Value | pbxImagemPac.Image == null)
            {
                MessageBox.Show("Preencha todas as infomações corretamente.");
            }
            else
            {

                Pacote.OrigemPac = tbxOrigemPac.Text;
                Pacote.DestinoPac = tbxDestinoPac.Text;
                Pacote.DataPac = tbxIdaPac.Value;
                Pacote.DataPacVolta = tbxVoltaPac.Value;
                Pacote.DescricaoPac = rtxDescricaoPac.Text;
                Pacote.ValorPac = Convert.ToDecimal(tbxValorPac.Text);

                MemoryStream memoryStream = new MemoryStream();
                pbxImagemPac.Image.Save(memoryStream, pbxImagemPac.Image.RawFormat);
                Pacote.ImagemPac = memoryStream.ToArray();

                Manipulapacote manipulaPacote = new Manipulapacote();
                manipulaPacote.cadastrarPacote();
            }

            if (Pacote.Retorno == "Sim")
            {
                limparTela();
            }
            else if (Pacote.Retorno == "Não")
            {
                this.Close();
            }
        }

        private void btnImagemPac_Click(object sender, EventArgs e)
        {
            openFileDialogImagem.Filter = "Escolha uma Imagem (*.jpg; *.png; *.jpeg)" + "| *.jpg;*.png;*.jpeg";

            if (openFileDialogImagem.ShowDialog() == DialogResult.OK)
            {
                pbxImagemPac.Image = Image.FromFile(openFileDialogImagem.FileName);
            }
        }

        public void limparTela()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox | ctl is ComboBox | ctl is DateTimePicker | ctl is RichTextBox)
                {
                    ctl.Text = string.Empty;
                }
            }

            pbxImagemPac.Image = null;
        }
    }
}
