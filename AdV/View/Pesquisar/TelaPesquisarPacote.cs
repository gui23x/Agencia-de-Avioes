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
    public partial class TelaPesquisarPacote : Form
    {
        public TelaPesquisarPacote()
        {
            InitializeComponent();
        }

        private void btnCodPac_Click(object sender, EventArgs e)
        {
            if (tbxCodigoPac.Text == "")
            {
                MessageBox.Show("Digite um código do Pacote", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxCodigoPac.Text = string.Empty;
                tbxCodigoPac.Focus();
                tbxOriPac.SelectAll();
                tbxDescricaoPac.Text = string.Empty;
                dtpIdaPac.Text = string.Empty;
                dtpVoltaPac.Text = string.Empty;
                rtbDestinoPac.Text = string.Empty;
                tbxValorPac.Text = string.Empty;
                pbxImagemCodPac.Image = null;
            }
            else
            {
                Pacote.CodigoPac = Convert.ToInt32(tbxCodigoPac.Text);
                Manipulapacote manipulaPacote = new Manipulapacote();
                manipulaPacote.pesquisarcodigoPacote();

                tbxCodigoPac.Text = Pacote.CodigoPac.ToString();
                tbxOriPac.Text = Pacote.OrigemPac;
                tbxDescricaoPac.Text = Pacote.DescricaoPac;
                dtpIdaPac.Text = Convert.ToString(Pacote.DataPacVolta);
                dtpVoltaPac.Text = Convert.ToString(Pacote.DataPacVolta);
                rtbDestinoPac.Text = Pacote.DestinoPac;
                tbxValorPac.Text = Convert.ToString(Pacote.ValorPac);

                MemoryStream ms = new MemoryStream((byte[])Pacote.ImagemPac);
                pbxImagemCodPac.Image = Image.FromStream(ms);
            }

            if (Pacote.Retorno == "Não")
            {
                LimparTela();
            }
        }
        public void LimparTela()
        {
            tbxCodigoPac.Text = string.Empty;
            tbxCodigoPac.Focus();
            tbxCodigoPac.SelectAll();
            tbxOriPac.Text = string.Empty;
            tbxValorPac.Text = string.Empty;
            tbxDescricaoPac.Text = string.Empty;
            pbxImagemCodPac.Image = null;
        }
    }
}
