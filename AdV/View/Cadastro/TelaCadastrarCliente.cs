using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                MessageBox.Show("Preencha todas as infomações corretamente.","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
