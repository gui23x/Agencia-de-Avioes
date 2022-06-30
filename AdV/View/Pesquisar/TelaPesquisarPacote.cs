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
                tbxCodigoPac.SelectAll();
                tbxOriPac.Text = string.Empty;
                tbxDestinoPac.Text = string.Empty;
                dtpIdaPac.Value = DateTime.Now;
                dtpVoltaPac.Value = DateTime.Now;
                rtbDescricaoPac.Text = string.Empty;
                tbxValorPac.Text = string.Empty;
                pbxImagemCodPac.Image = null;
            }
            else
            {
                Pacote.CodigoPac = Convert.ToInt32(tbxCodigoPac.Text);
                Manipulapacote manipulaPacote = new Manipulapacote();
                manipulaPacote.pesquisarcodigoPacote();
            
            }

            if (Pacote.Retorno == "Não")
            {
                tbxCodigoPac.Text = string.Empty;
                tbxCodigoPac.Focus();
                tbxValorPac.SelectAll();
                tbxOriPac.Text = string.Empty;
                tbxDestinoPac.Text = string.Empty;
                dtpIdaPac.Text = string.Empty;
                dtpVoltaPac.Text = string.Empty;
                rtbDescricaoPac.Text = string.Empty;
                pbxImagemCodPac.Image = null;
                return;
            }
            else
            {
                tbxCodigoPac.Text = Pacote.CodigoPac.ToString();
                tbxValorPac.Text = Convert.ToString(Pacote.ValorPac);
                tbxOriPac.Text = Pacote.OrigemPac;
                tbxDestinoPac.Text = Pacote.DestinoPac;
                dtpIdaPac.Text = Convert.ToString(Pacote.DataPac);
                dtpVoltaPac.Text = Convert.ToString(Pacote.DataPacVolta);
                rtbDescricaoPac.Text = Pacote.DescricaoPac;

                MemoryStream ms = new MemoryStream((byte[])Pacote.ImagemPac);
                pbxImagemCodPac.Image = Image.FromStream(ms);
            }
        }
        public void LimparTela()
        {
            tbxCodigoPac.Text = string.Empty;
            tbxCodigoPac.Focus();
            tbxCodigoPac.SelectAll();
            tbxOriPac.Text = string.Empty;
            tbxDestinoPac.Text = string.Empty;
            dtpIdaPac.Value = DateTime.Now;
            dtpVoltaPac.Value = DateTime.Now;
            rtbDescricaoPac.Text = string.Empty;
            tbxValorPac.Text = Convert.ToString(Pacote.ValorPac);
            pbxImagemCodPac.Image = null;
        }

        private void btnAlterarCodPac_Click(object sender, EventArgs e)
        {
            if (tbxCodigoPac.Text == "")
            {
                MessageBox.Show("Digite um código do Pacote", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxCodigoPac.Text = string.Empty;
                tbxCodigoPac.Focus();
                tbxCodigoPac.SelectAll();
                tbxOriPac.Text = string.Empty;
                tbxDestinoPac.Text = string.Empty;
                rtbDescricaoPac.Text = string.Empty;
                dtpIdaPac.Text = string.Empty;
                dtpVoltaPac.Text = string.Empty;
                tbxValorPac.Text = string.Empty;
            }
            else
            {
                var resposta = MessageBox.Show("Deseja alterar os dados do Pacote?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Pacote.CodigoPac = Convert.ToInt32(tbxCodigoPac.Text);
                    Pacote.OrigemPac = tbxOriPac.Text;
                    Pacote.DestinoPac = tbxDestinoPac.Text;
                    Pacote.DataPac = dtpIdaPac.Value;
                    Pacote.DataPacVolta = dtpVoltaPac.Value;
                    Pacote.DescricaoPac = tbxNomeDesPac.Text;
                    Pacote.ValorPac = Convert.ToInt32(tbxValorPac.Text);

                    MemoryStream ms = new MemoryStream((byte[])Pacote.ImagemPac);
                    pbxImagemCodPac.Image.Save(ms, pbxImagemCodPac.Image.RawFormat);
                    Pacote.ImagemPac = ms.ToArray();

                    Manipulapacote manipulapacote = new Manipulapacote();
                    manipulapacote.alterarPacote();
                }
                return;
            }
        }

        private void btnDeletarCodPac_Click(object sender, EventArgs e)
        {
            if (tbxCodigoPac.Text == "")
            {
                MessageBox.Show("Digite um código do Pacote", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxCodigoPac.Text = string.Empty;
                tbxCodigoPac.Focus();
                tbxCodigoPac.SelectAll();
                tbxOriPac.Text = string.Empty;
                tbxDestinoPac.Text = string.Empty;
                dtpIdaPac.Text = string.Empty;
                dtpVoltaPac.Text = string.Empty;
                rtbDescricaoPac.Text = string.Empty;
                tbxValorPac.Text = Convert.ToString(Pacote.ValorPac);
                pbxImagemCodPac.Image = null;
            }
            else
            {
                var resposta = MessageBox.Show("Deseja excluir o Pacote" + tbxCodigoPac.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Cliente.CodigoCli = Convert.ToInt32(tbxCodigoPac.Text);

                    Manipulapacote manipulapacote = new Manipulapacote();
                    manipulapacote.deletarPacote();
                }

                tbxCodigoPac.Text = string.Empty;
                tbxCodigoPac.Focus();
                tbxCodigoPac.SelectAll();
                tbxOriPac.Text = string.Empty;
                tbxDestinoPac.Text = string.Empty;
                dtpIdaPac.Text = string.Empty;
                dtpVoltaPac.Text = string.Empty;
                rtbDescricaoPac.Text = string.Empty;
                tbxValorPac.Text = Convert.ToString(Pacote.ValorPac);
                pbxImagemCodPac.Image = null;
                return;
            }
        }

        private void btnBuscarImagemCodPac_Click(object sender, EventArgs e)
        {
            openFileDialogImagem.Filter = "Escolha uma imagem (*.jpg;*.png;*.jpeg)" + "| *.jpg; *.jpeg;*.png";
            if (openFileDialogImagem.ShowDialog() == DialogResult.OK)
            {
                pbxImagemCodPac.Image = Image.FromFile(openFileDialogImagem.FileName);
            }
        }

        private void btnNomeOriPac_Click(object sender, EventArgs e)
        {
            if (tbxNomeOriPac.Text == "")
            {
                MessageBox.Show("Digite o nome do Pacote de Origem.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Pacote.OrigemPac = tbxNomeOriPac.Text;
            dgvInfoOriPac.DataSource = Manipulapacote.pesquisaOrigemPac();


            dgvInfoOriPac.Columns[0].Visible = false;
            dgvInfoOriPac.Columns[1].Visible = false;
            dgvInfoOriPac.Columns[2].Visible = false;
            dgvInfoOriPac.Columns[3].Visible = false;
            dgvInfoOriPac.Columns[4].Visible = false;
            dgvInfoOriPac.Columns[5].HeaderCell.Value = "Código";
            dgvInfoOriPac.Columns[6].HeaderCell.Value = "Valor";
            dgvInfoOriPac.Columns[7].HeaderCell.Value = "Origem";
            dgvInfoOriPac.Columns[8].Visible = false;
            dgvInfoOriPac.Columns[9].HeaderCell.Value = "Data de Ida";
            dgvInfoOriPac.Columns[10].HeaderCell.Value = "Data de Volta";
            dgvInfoOriPac.Columns[11].Visible = false;
            dgvInfoOriPac.Columns[12].Visible = false;
        }

        private void btnDesPac_Click(object sender, EventArgs e)
        {
            if (tbxNomeDesPac.Text == "")
            {
                MessageBox.Show("Digite o nome do Pacote de Destino.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Pacote.DestinoPac = tbxNomeDesPac.Text;
            dgvInfoDesPac.DataSource = Manipulapacote.pesquisaDestinoPac();


            dgvInfoDesPac.Columns[0].Visible = false;
            dgvInfoDesPac.Columns[1].Visible = false;
            dgvInfoDesPac.Columns[2].Visible = false;
            dgvInfoDesPac.Columns[3].Visible = false;
            dgvInfoDesPac.Columns[4].Visible = false;
            dgvInfoDesPac.Columns[5].HeaderCell.Value = "Código";
            dgvInfoDesPac.Columns[6].HeaderCell.Value = "Valor";
            dgvInfoDesPac.Columns[7].Visible = false;
            dgvInfoDesPac.Columns[8].HeaderCell.Value = "Destino";
            dgvInfoDesPac.Columns[9].HeaderCell.Value = "Data de Ida";
            dgvInfoDesPac.Columns[10].HeaderCell.Value = "Data de Volta";
            dgvInfoDesPac.Columns[11].Visible = false;
            dgvInfoDesPac.Columns[12].Visible = false;
        }
    }
}
