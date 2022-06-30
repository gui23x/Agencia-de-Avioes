
namespace AdV.View.Pesquisar
{
    partial class TelaPesquisarPacote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPesquisarPacote));
            this.pesquisarNomeFun = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvInfoDesPac = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDesPac = new System.Windows.Forms.Button();
            this.tbxNomeDesPac = new System.Windows.Forms.TextBox();
            this.lblDesPac = new System.Windows.Forms.Label();
            this.dgvInfoOriPac = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVolta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNomeOriPac = new System.Windows.Forms.Button();
            this.tbxNomeOriPac = new System.Windows.Forms.TextBox();
            this.lblNomeOriPac = new System.Windows.Forms.Label();
            this.pesquisarCodigo = new System.Windows.Forms.TabPage();
            this.dtpVoltaPac = new System.Windows.Forms.DateTimePicker();
            this.dtpIdaPac = new System.Windows.Forms.DateTimePicker();
            this.rtbDescricaoPac = new System.Windows.Forms.RichTextBox();
            this.lblPortifolioCodPac = new System.Windows.Forms.Label();
            this.btnBuscarImagemCodPac = new System.Windows.Forms.Button();
            this.pbxImagemCodPac = new System.Windows.Forms.PictureBox();
            this.tbxValorPac = new System.Windows.Forms.TextBox();
            this.lblValorPac = new System.Windows.Forms.Label();
            this.lblVoltaPac = new System.Windows.Forms.Label();
            this.lblIdaPac = new System.Windows.Forms.Label();
            this.btnDeletarCodPac = new System.Windows.Forms.Button();
            this.btnAlterarCodPac = new System.Windows.Forms.Button();
            this.tbxDestinoPac = new System.Windows.Forms.TextBox();
            this.tbxOriPac = new System.Windows.Forms.TextBox();
            this.lblSenhaCodPac = new System.Windows.Forms.Label();
            this.lblEmailCodPac = new System.Windows.Forms.Label();
            this.lblNomeCodPac = new System.Windows.Forms.Label();
            this.tbxCodigoPac = new System.Windows.Forms.TextBox();
            this.lblCodigoPac = new System.Windows.Forms.Label();
            this.btnCodPac = new System.Windows.Forms.Button();
            this.lblTituloPac = new System.Windows.Forms.Label();
            this.openFileDialogImagem = new System.Windows.Forms.OpenFileDialog();
            this.pesquisarNomeFun.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoDesPac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoOriPac)).BeginInit();
            this.pesquisarCodigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagemCodPac)).BeginInit();
            this.SuspendLayout();
            // 
            // pesquisarNomeFun
            // 
            this.pesquisarNomeFun.Controls.Add(this.tabPage1);
            this.pesquisarNomeFun.Controls.Add(this.pesquisarCodigo);
            this.pesquisarNomeFun.Location = new System.Drawing.Point(12, 67);
            this.pesquisarNomeFun.Name = "pesquisarNomeFun";
            this.pesquisarNomeFun.SelectedIndex = 0;
            this.pesquisarNomeFun.Size = new System.Drawing.Size(784, 443);
            this.pesquisarNomeFun.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.dgvInfoDesPac);
            this.tabPage1.Controls.Add(this.btnDesPac);
            this.tabPage1.Controls.Add(this.tbxNomeDesPac);
            this.tabPage1.Controls.Add(this.lblDesPac);
            this.tabPage1.Controls.Add(this.dgvInfoOriPac);
            this.tabPage1.Controls.Add(this.btnNomeOriPac);
            this.tabPage1.Controls.Add(this.tbxNomeOriPac);
            this.tabPage1.Controls.Add(this.lblNomeOriPac);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 415);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nome";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvInfoDesPac
            // 
            this.dgvInfoDesPac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfoDesPac.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvInfoDesPac.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dgvInfoDesPac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoDesPac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.destino,
            this.dataGridViewTextBoxColumn3});
            this.dgvInfoDesPac.Location = new System.Drawing.Point(10, 245);
            this.dgvInfoDesPac.Name = "dgvInfoDesPac";
            this.dgvInfoDesPac.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInfoDesPac.RowHeadersVisible = false;
            this.dgvInfoDesPac.RowTemplate.Height = 25;
            this.dgvInfoDesPac.Size = new System.Drawing.Size(763, 164);
            this.dgvInfoDesPac.TabIndex = 7;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Data de Ida";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Data de Volta";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // destino
            // 
            this.destino.HeaderText = "Destino";
            this.destino.Name = "destino";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // btnDesPac
            // 
            this.btnDesPac.Location = new System.Drawing.Point(474, 216);
            this.btnDesPac.Name = "btnDesPac";
            this.btnDesPac.Size = new System.Drawing.Size(75, 23);
            this.btnDesPac.TabIndex = 6;
            this.btnDesPac.Text = "Buscar";
            this.btnDesPac.UseVisualStyleBackColor = true;
            this.btnDesPac.Click += new System.EventHandler(this.btnDesPac_Click);
            // 
            // tbxNomeDesPac
            // 
            this.tbxNomeDesPac.Location = new System.Drawing.Point(164, 215);
            this.tbxNomeDesPac.Name = "tbxNomeDesPac";
            this.tbxNomeDesPac.Size = new System.Drawing.Size(288, 23);
            this.tbxNomeDesPac.TabIndex = 5;
            // 
            // lblDesPac
            // 
            this.lblDesPac.AutoSize = true;
            this.lblDesPac.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDesPac.Location = new System.Drawing.Point(10, 214);
            this.lblDesPac.Name = "lblDesPac";
            this.lblDesPac.Size = new System.Drawing.Size(156, 25);
            this.lblDesPac.TabIndex = 4;
            this.lblDesPac.Text = "Digite o Destino:";
            // 
            // dgvInfoOriPac
            // 
            this.dgvInfoOriPac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfoOriPac.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvInfoOriPac.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dgvInfoOriPac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoOriPac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.dataida,
            this.dataVolta,
            this.origm,
            this.Valor});
            this.dgvInfoOriPac.Location = new System.Drawing.Point(10, 55);
            this.dgvInfoOriPac.Name = "dgvInfoOriPac";
            this.dgvInfoOriPac.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInfoOriPac.RowHeadersVisible = false;
            this.dgvInfoOriPac.RowTemplate.Height = 25;
            this.dgvInfoOriPac.Size = new System.Drawing.Size(760, 154);
            this.dgvInfoOriPac.TabIndex = 3;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // dataida
            // 
            this.dataida.HeaderText = "Data de Ida";
            this.dataida.Name = "dataida";
            // 
            // dataVolta
            // 
            this.dataVolta.HeaderText = "Data de Volta";
            this.dataVolta.Name = "dataVolta";
            // 
            // origm
            // 
            this.origm.HeaderText = "Origem";
            this.origm.Name = "origm";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // btnNomeOriPac
            // 
            this.btnNomeOriPac.Location = new System.Drawing.Point(474, 26);
            this.btnNomeOriPac.Name = "btnNomeOriPac";
            this.btnNomeOriPac.Size = new System.Drawing.Size(75, 23);
            this.btnNomeOriPac.TabIndex = 2;
            this.btnNomeOriPac.Text = "Buscar";
            this.btnNomeOriPac.UseVisualStyleBackColor = true;
            this.btnNomeOriPac.Click += new System.EventHandler(this.btnNomeOriPac_Click);
            // 
            // tbxNomeOriPac
            // 
            this.tbxNomeOriPac.Location = new System.Drawing.Point(164, 25);
            this.tbxNomeOriPac.Name = "tbxNomeOriPac";
            this.tbxNomeOriPac.Size = new System.Drawing.Size(288, 23);
            this.tbxNomeOriPac.TabIndex = 1;
            // 
            // lblNomeOriPac
            // 
            this.lblNomeOriPac.AutoSize = true;
            this.lblNomeOriPac.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblNomeOriPac.Location = new System.Drawing.Point(10, 24);
            this.lblNomeOriPac.Name = "lblNomeOriPac";
            this.lblNomeOriPac.Size = new System.Drawing.Size(154, 25);
            this.lblNomeOriPac.TabIndex = 0;
            this.lblNomeOriPac.Text = "Digite o Origem:";
            // 
            // pesquisarCodigo
            // 
            this.pesquisarCodigo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pesquisarCodigo.BackgroundImage")));
            this.pesquisarCodigo.Controls.Add(this.dtpVoltaPac);
            this.pesquisarCodigo.Controls.Add(this.dtpIdaPac);
            this.pesquisarCodigo.Controls.Add(this.rtbDescricaoPac);
            this.pesquisarCodigo.Controls.Add(this.lblPortifolioCodPac);
            this.pesquisarCodigo.Controls.Add(this.btnBuscarImagemCodPac);
            this.pesquisarCodigo.Controls.Add(this.pbxImagemCodPac);
            this.pesquisarCodigo.Controls.Add(this.tbxValorPac);
            this.pesquisarCodigo.Controls.Add(this.lblValorPac);
            this.pesquisarCodigo.Controls.Add(this.lblVoltaPac);
            this.pesquisarCodigo.Controls.Add(this.lblIdaPac);
            this.pesquisarCodigo.Controls.Add(this.btnDeletarCodPac);
            this.pesquisarCodigo.Controls.Add(this.btnAlterarCodPac);
            this.pesquisarCodigo.Controls.Add(this.tbxDestinoPac);
            this.pesquisarCodigo.Controls.Add(this.tbxOriPac);
            this.pesquisarCodigo.Controls.Add(this.lblSenhaCodPac);
            this.pesquisarCodigo.Controls.Add(this.lblEmailCodPac);
            this.pesquisarCodigo.Controls.Add(this.lblNomeCodPac);
            this.pesquisarCodigo.Controls.Add(this.tbxCodigoPac);
            this.pesquisarCodigo.Controls.Add(this.lblCodigoPac);
            this.pesquisarCodigo.Controls.Add(this.btnCodPac);
            this.pesquisarCodigo.Location = new System.Drawing.Point(4, 24);
            this.pesquisarCodigo.Name = "pesquisarCodigo";
            this.pesquisarCodigo.Padding = new System.Windows.Forms.Padding(3);
            this.pesquisarCodigo.Size = new System.Drawing.Size(776, 415);
            this.pesquisarCodigo.TabIndex = 1;
            this.pesquisarCodigo.Text = "Código";
            this.pesquisarCodigo.UseVisualStyleBackColor = true;
            // 
            // dtpVoltaPac
            // 
            this.dtpVoltaPac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVoltaPac.Location = new System.Drawing.Point(193, 174);
            this.dtpVoltaPac.Name = "dtpVoltaPac";
            this.dtpVoltaPac.Size = new System.Drawing.Size(98, 23);
            this.dtpVoltaPac.TabIndex = 46;
            // 
            // dtpIdaPac
            // 
            this.dtpIdaPac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIdaPac.Location = new System.Drawing.Point(192, 142);
            this.dtpIdaPac.Name = "dtpIdaPac";
            this.dtpIdaPac.Size = new System.Drawing.Size(99, 23);
            this.dtpIdaPac.TabIndex = 45;
            // 
            // rtbDescricaoPac
            // 
            this.rtbDescricaoPac.Location = new System.Drawing.Point(390, 254);
            this.rtbDescricaoPac.Name = "rtbDescricaoPac";
            this.rtbDescricaoPac.Size = new System.Drawing.Size(380, 144);
            this.rtbDescricaoPac.TabIndex = 44;
            this.rtbDescricaoPac.Text = "";
            // 
            // lblPortifolioCodPac
            // 
            this.lblPortifolioCodPac.AutoSize = true;
            this.lblPortifolioCodPac.BackColor = System.Drawing.Color.Transparent;
            this.lblPortifolioCodPac.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPortifolioCodPac.Location = new System.Drawing.Point(628, 28);
            this.lblPortifolioCodPac.Name = "lblPortifolioCodPac";
            this.lblPortifolioCodPac.Size = new System.Drawing.Size(79, 21);
            this.lblPortifolioCodPac.TabIndex = 43;
            this.lblPortifolioCodPac.Text = "Portifólio";
            // 
            // btnBuscarImagemCodPac
            // 
            this.btnBuscarImagemCodPac.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnBuscarImagemCodPac.Location = new System.Drawing.Point(633, 220);
            this.btnBuscarImagemCodPac.Name = "btnBuscarImagemCodPac";
            this.btnBuscarImagemCodPac.Size = new System.Drawing.Size(74, 23);
            this.btnBuscarImagemCodPac.TabIndex = 42;
            this.btnBuscarImagemCodPac.Text = "Buscar Imagem";
            this.btnBuscarImagemCodPac.UseVisualStyleBackColor = true;
            this.btnBuscarImagemCodPac.Click += new System.EventHandler(this.btnBuscarImagemCodPac_Click);
            // 
            // pbxImagemCodPac
            // 
            this.pbxImagemCodPac.BackColor = System.Drawing.Color.Transparent;
            this.pbxImagemCodPac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImagemCodPac.Location = new System.Drawing.Point(581, 52);
            this.pbxImagemCodPac.Name = "pbxImagemCodPac";
            this.pbxImagemCodPac.Size = new System.Drawing.Size(169, 154);
            this.pbxImagemCodPac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxImagemCodPac.TabIndex = 41;
            this.pbxImagemCodPac.TabStop = false;
            // 
            // tbxValorPac
            // 
            this.tbxValorPac.Location = new System.Drawing.Point(192, 210);
            this.tbxValorPac.Name = "tbxValorPac";
            this.tbxValorPac.Size = new System.Drawing.Size(144, 23);
            this.tbxValorPac.TabIndex = 40;
            // 
            // lblValorPac
            // 
            this.lblValorPac.AutoSize = true;
            this.lblValorPac.BackColor = System.Drawing.Color.Transparent;
            this.lblValorPac.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblValorPac.Location = new System.Drawing.Point(72, 208);
            this.lblValorPac.Name = "lblValorPac";
            this.lblValorPac.Size = new System.Drawing.Size(53, 21);
            this.lblValorPac.TabIndex = 37;
            this.lblValorPac.Text = "Valor:";
            // 
            // lblVoltaPac
            // 
            this.lblVoltaPac.AutoSize = true;
            this.lblVoltaPac.BackColor = System.Drawing.Color.Transparent;
            this.lblVoltaPac.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblVoltaPac.Location = new System.Drawing.Point(72, 177);
            this.lblVoltaPac.Name = "lblVoltaPac";
            this.lblVoltaPac.Size = new System.Drawing.Size(114, 21);
            this.lblVoltaPac.TabIndex = 36;
            this.lblVoltaPac.Text = "Data de Volta:";
            // 
            // lblIdaPac
            // 
            this.lblIdaPac.AutoSize = true;
            this.lblIdaPac.BackColor = System.Drawing.Color.Transparent;
            this.lblIdaPac.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblIdaPac.Location = new System.Drawing.Point(72, 142);
            this.lblIdaPac.Name = "lblIdaPac";
            this.lblIdaPac.Size = new System.Drawing.Size(98, 21);
            this.lblIdaPac.TabIndex = 35;
            this.lblIdaPac.Text = "Data de Ida:";
            // 
            // btnDeletarCodPac
            // 
            this.btnDeletarCodPac.Location = new System.Drawing.Point(164, 270);
            this.btnDeletarCodPac.Name = "btnDeletarCodPac";
            this.btnDeletarCodPac.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarCodPac.TabIndex = 34;
            this.btnDeletarCodPac.Text = "Deletar";
            this.btnDeletarCodPac.UseVisualStyleBackColor = true;
            this.btnDeletarCodPac.Click += new System.EventHandler(this.btnDeletarCodPac_Click);
            // 
            // btnAlterarCodPac
            // 
            this.btnAlterarCodPac.Location = new System.Drawing.Point(72, 270);
            this.btnAlterarCodPac.Name = "btnAlterarCodPac";
            this.btnAlterarCodPac.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarCodPac.TabIndex = 33;
            this.btnAlterarCodPac.Text = "Alterar";
            this.btnAlterarCodPac.UseVisualStyleBackColor = true;
            this.btnAlterarCodPac.Click += new System.EventHandler(this.btnAlterarCodPac_Click);
            // 
            // tbxDestinoPac
            // 
            this.tbxDestinoPac.Location = new System.Drawing.Point(192, 107);
            this.tbxDestinoPac.Name = "tbxDestinoPac";
            this.tbxDestinoPac.Size = new System.Drawing.Size(257, 23);
            this.tbxDestinoPac.TabIndex = 29;
            // 
            // tbxOriPac
            // 
            this.tbxOriPac.Location = new System.Drawing.Point(192, 68);
            this.tbxOriPac.Name = "tbxOriPac";
            this.tbxOriPac.Size = new System.Drawing.Size(257, 23);
            this.tbxOriPac.TabIndex = 27;
            // 
            // lblSenhaCodPac
            // 
            this.lblSenhaCodPac.AutoSize = true;
            this.lblSenhaCodPac.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaCodPac.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSenhaCodPac.Location = new System.Drawing.Point(390, 230);
            this.lblSenhaCodPac.Name = "lblSenhaCodPac";
            this.lblSenhaCodPac.Size = new System.Drawing.Size(84, 21);
            this.lblSenhaCodPac.TabIndex = 26;
            this.lblSenhaCodPac.Text = "Descrição:";
            // 
            // lblEmailCodPac
            // 
            this.lblEmailCodPac.AutoSize = true;
            this.lblEmailCodPac.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailCodPac.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblEmailCodPac.Location = new System.Drawing.Point(72, 109);
            this.lblEmailCodPac.Name = "lblEmailCodPac";
            this.lblEmailCodPac.Size = new System.Drawing.Size(70, 21);
            this.lblEmailCodPac.TabIndex = 25;
            this.lblEmailCodPac.Text = "Destino:";
            // 
            // lblNomeCodPac
            // 
            this.lblNomeCodPac.AutoSize = true;
            this.lblNomeCodPac.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeCodPac.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblNomeCodPac.Location = new System.Drawing.Point(72, 70);
            this.lblNomeCodPac.Name = "lblNomeCodPac";
            this.lblNomeCodPac.Size = new System.Drawing.Size(68, 21);
            this.lblNomeCodPac.TabIndex = 24;
            this.lblNomeCodPac.Text = "Origem:";
            // 
            // tbxCodigoPac
            // 
            this.tbxCodigoPac.Location = new System.Drawing.Point(192, 31);
            this.tbxCodigoPac.Name = "tbxCodigoPac";
            this.tbxCodigoPac.Size = new System.Drawing.Size(257, 23);
            this.tbxCodigoPac.TabIndex = 2;
            // 
            // lblCodigoPac
            // 
            this.lblCodigoPac.AutoSize = true;
            this.lblCodigoPac.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCodigoPac.Location = new System.Drawing.Point(24, 32);
            this.lblCodigoPac.Name = "lblCodigoPac";
            this.lblCodigoPac.Size = new System.Drawing.Size(136, 21);
            this.lblCodigoPac.TabIndex = 1;
            this.lblCodigoPac.Text = "Código do Pacote";
            // 
            // btnCodPac
            // 
            this.btnCodPac.Location = new System.Drawing.Point(458, 30);
            this.btnCodPac.Name = "btnCodPac";
            this.btnCodPac.Size = new System.Drawing.Size(75, 23);
            this.btnCodPac.TabIndex = 47;
            this.btnCodPac.Text = "Buscar";
            this.btnCodPac.Click += new System.EventHandler(this.btnCodPac_Click);
            // 
            // lblTituloPac
            // 
            this.lblTituloPac.AutoSize = true;
            this.lblTituloPac.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloPac.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTituloPac.Location = new System.Drawing.Point(289, 24);
            this.lblTituloPac.Name = "lblTituloPac";
            this.lblTituloPac.Size = new System.Drawing.Size(260, 40);
            this.lblTituloPac.TabIndex = 4;
            this.lblTituloPac.Text = "Pesquisar Pacotes";
            // 
            // openFileDialogImagem
            // 
            this.openFileDialogImagem.FileName = "openFileDialogImagem";
            // 
            // TelaPesquisarPacote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(809, 520);
            this.Controls.Add(this.pesquisarNomeFun);
            this.Controls.Add(this.lblTituloPac);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaPesquisarPacote";
            this.Text = "Agência de Viagens- Pesquisar Pacotes";
            this.pesquisarNomeFun.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoDesPac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoOriPac)).EndInit();
            this.pesquisarCodigo.ResumeLayout(false);
            this.pesquisarCodigo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagemCodPac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl pesquisarNomeFun;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnNomeOriPac;
        private System.Windows.Forms.TextBox tbxNomeOriPac;
        private System.Windows.Forms.Label lblNomeOriPac;
        private System.Windows.Forms.TabPage pesquisarCodigo;
        private System.Windows.Forms.Button btnDeletarCodPac;
        private System.Windows.Forms.Button btnAlterarCodPac;
        private System.Windows.Forms.TextBox tbxDestinoPac;
        private System.Windows.Forms.TextBox tbxOriPac;
        private System.Windows.Forms.Label lblSenhaCodPac;
        private System.Windows.Forms.Label lblEmailCodPac;
        private System.Windows.Forms.Label lblNomeCodPac;
        private System.Windows.Forms.TextBox tbxCodigoPac;
        private System.Windows.Forms.Label lblCodigoPac;
        private System.Windows.Forms.Button btnCodPac;
        private System.Windows.Forms.Label lblTituloPac;
        private System.Windows.Forms.DataGridView dgvInfoDesPac;
        private System.Windows.Forms.Button btnDesPac;
        private System.Windows.Forms.TextBox tbxNomeDesPac;
        private System.Windows.Forms.Label lblDesPac;
        private System.Windows.Forms.DataGridView dgvInfoOriPac;
        private System.Windows.Forms.TextBox tbxValorPac;
        private System.Windows.Forms.Label lblValorPac;
        private System.Windows.Forms.Label lblVoltaPac;
        private System.Windows.Forms.Label lblIdaPac;
        private System.Windows.Forms.RichTextBox rtbDescricaoPac;
        private System.Windows.Forms.Label lblPortifolioCodPac;
        private System.Windows.Forms.Button btnBuscarImagemCodPac;
        private System.Windows.Forms.PictureBox pbxImagemCodPac;
        private System.Windows.Forms.DateTimePicker dtpVoltaPac;
        private System.Windows.Forms.DateTimePicker dtpIdaPac;
        private System.Windows.Forms.OpenFileDialog openFileDialogImagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVolta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn origm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}