
namespace AdV.View.Pesquisar
{
    partial class TelaPesquisarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPesquisarCliente));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pesquisarNome = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNome = new System.Windows.Forms.Button();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gbxInfoCli = new System.Windows.Forms.GroupBox();
            this.dgvInfoCli = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesquisarCodigo = new System.Windows.Forms.TabPage();
            this.btnDeletarCodCli = new System.Windows.Forms.Button();
            this.btnAlterarCodCli = new System.Windows.Forms.Button();
            this.lblPortifolioCodCli = new System.Windows.Forms.Label();
            this.btnBuscarImagemCodCli = new System.Windows.Forms.Button();
            this.pbxImagemCodCli = new System.Windows.Forms.PictureBox();
            this.tbxSenhaCodCli = new System.Windows.Forms.TextBox();
            this.tbxEmailCodCli = new System.Windows.Forms.TextBox();
            this.tbxNomeCodCli = new System.Windows.Forms.TextBox();
            this.lblSenhaCodCli = new System.Windows.Forms.Label();
            this.lblEmailCodCli = new System.Windows.Forms.Label();
            this.lblNomeCodCli = new System.Windows.Forms.Label();
            this.tbxCodigoCli = new System.Windows.Forms.TextBox();
            this.lblCodigoCli = new System.Windows.Forms.Label();
            this.btnCodigoCli = new System.Windows.Forms.Button();
            this.openFileDialogImagem = new System.Windows.Forms.OpenFileDialog();
            this.pesquisarNome.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbxInfoCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoCli)).BeginInit();
            this.pesquisarCodigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagemCodCli)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(169, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(263, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Pesquisar Clientes";
            // 
            // pesquisarNome
            // 
            this.pesquisarNome.Controls.Add(this.tabPage1);
            this.pesquisarNome.Controls.Add(this.pesquisarCodigo);
            this.pesquisarNome.Location = new System.Drawing.Point(12, 79);
            this.pesquisarNome.Name = "pesquisarNome";
            this.pesquisarNome.SelectedIndex = 0;
            this.pesquisarNome.Size = new System.Drawing.Size(575, 325);
            this.pesquisarNome.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.btnNome);
            this.tabPage1.Controls.Add(this.tbxNome);
            this.tabPage1.Controls.Add(this.lblNome);
            this.tabPage1.Controls.Add(this.gbxInfoCli);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(567, 297);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nome";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNome
            // 
            this.btnNome.Location = new System.Drawing.Point(474, 28);
            this.btnNome.Name = "btnNome";
            this.btnNome.Size = new System.Drawing.Size(75, 23);
            this.btnNome.TabIndex = 2;
            this.btnNome.Text = "Buscar";
            this.btnNome.UseVisualStyleBackColor = true;
            this.btnNome.Click += new System.EventHandler(this.btnNome_Click);
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(155, 28);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(302, 23);
            this.tbxNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(6, 26);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(143, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Digite o Nome:";
            // 
            // gbxInfoCli
            // 
            this.gbxInfoCli.BackColor = System.Drawing.Color.Transparent;
            this.gbxInfoCli.Controls.Add(this.dgvInfoCli);
            this.gbxInfoCli.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.gbxInfoCli.Location = new System.Drawing.Point(10, 57);
            this.gbxInfoCli.Name = "gbxInfoCli";
            this.gbxInfoCli.Size = new System.Drawing.Size(551, 234);
            this.gbxInfoCli.TabIndex = 4;
            this.gbxInfoCli.TabStop = false;
            this.gbxInfoCli.Text = "Informações";
            // 
            // dgvInfoCli
            // 
            this.dgvInfoCli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfoCli.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvInfoCli.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dgvInfoCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoCli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Email,
            this.Foto});
            this.dgvInfoCli.Location = new System.Drawing.Point(6, 26);
            this.dgvInfoCli.Name = "dgvInfoCli";
            this.dgvInfoCli.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInfoCli.RowHeadersVisible = false;
            this.dgvInfoCli.RowTemplate.Height = 25;
            this.dgvInfoCli.Size = new System.Drawing.Size(539, 202);
            this.dgvInfoCli.TabIndex = 3;
            this.dgvInfoCli.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Foto
            // 
            this.Foto.HeaderText = "Foto";
            this.Foto.Name = "Foto";
            // 
            // pesquisarCodigo
            // 
            this.pesquisarCodigo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pesquisarCodigo.BackgroundImage")));
            this.pesquisarCodigo.Controls.Add(this.btnDeletarCodCli);
            this.pesquisarCodigo.Controls.Add(this.btnAlterarCodCli);
            this.pesquisarCodigo.Controls.Add(this.lblPortifolioCodCli);
            this.pesquisarCodigo.Controls.Add(this.btnBuscarImagemCodCli);
            this.pesquisarCodigo.Controls.Add(this.pbxImagemCodCli);
            this.pesquisarCodigo.Controls.Add(this.tbxSenhaCodCli);
            this.pesquisarCodigo.Controls.Add(this.tbxEmailCodCli);
            this.pesquisarCodigo.Controls.Add(this.tbxNomeCodCli);
            this.pesquisarCodigo.Controls.Add(this.lblSenhaCodCli);
            this.pesquisarCodigo.Controls.Add(this.lblEmailCodCli);
            this.pesquisarCodigo.Controls.Add(this.lblNomeCodCli);
            this.pesquisarCodigo.Controls.Add(this.tbxCodigoCli);
            this.pesquisarCodigo.Controls.Add(this.lblCodigoCli);
            this.pesquisarCodigo.Controls.Add(this.btnCodigoCli);
            this.pesquisarCodigo.Location = new System.Drawing.Point(4, 24);
            this.pesquisarCodigo.Name = "pesquisarCodigo";
            this.pesquisarCodigo.Padding = new System.Windows.Forms.Padding(3);
            this.pesquisarCodigo.Size = new System.Drawing.Size(567, 297);
            this.pesquisarCodigo.TabIndex = 1;
            this.pesquisarCodigo.Text = "Código";
            this.pesquisarCodigo.UseVisualStyleBackColor = true;
            // 
            // btnDeletarCodCli
            // 
            this.btnDeletarCodCli.Location = new System.Drawing.Point(150, 247);
            this.btnDeletarCodCli.Name = "btnDeletarCodCli";
            this.btnDeletarCodCli.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarCodCli.TabIndex = 34;
            this.btnDeletarCodCli.Text = "Deletar";
            this.btnDeletarCodCli.UseVisualStyleBackColor = true;
            this.btnDeletarCodCli.Click += new System.EventHandler(this.btnDeletarCodCli_Click);
            // 
            // btnAlterarCodCli
            // 
            this.btnAlterarCodCli.Location = new System.Drawing.Point(69, 247);
            this.btnAlterarCodCli.Name = "btnAlterarCodCli";
            this.btnAlterarCodCli.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarCodCli.TabIndex = 33;
            this.btnAlterarCodCli.Text = "Alterar";
            this.btnAlterarCodCli.UseVisualStyleBackColor = true;
            this.btnAlterarCodCli.Click += new System.EventHandler(this.btnAlterarCodCli_Click);
            // 
            // lblPortifolioCodCli
            // 
            this.lblPortifolioCodCli.AutoSize = true;
            this.lblPortifolioCodCli.BackColor = System.Drawing.Color.Transparent;
            this.lblPortifolioCodCli.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPortifolioCodCli.Location = new System.Drawing.Point(449, 73);
            this.lblPortifolioCodCli.Name = "lblPortifolioCodCli";
            this.lblPortifolioCodCli.Size = new System.Drawing.Size(79, 21);
            this.lblPortifolioCodCli.TabIndex = 32;
            this.lblPortifolioCodCli.Text = "Portifólio";
            // 
            // btnBuscarImagemCodCli
            // 
            this.btnBuscarImagemCodCli.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnBuscarImagemCodCli.Location = new System.Drawing.Point(449, 206);
            this.btnBuscarImagemCodCli.Name = "btnBuscarImagemCodCli";
            this.btnBuscarImagemCodCli.Size = new System.Drawing.Size(74, 23);
            this.btnBuscarImagemCodCli.TabIndex = 31;
            this.btnBuscarImagemCodCli.Text = "Buscar Imagem";
            this.btnBuscarImagemCodCli.UseVisualStyleBackColor = true;
            this.btnBuscarImagemCodCli.Click += new System.EventHandler(this.btnBuscarImagemCodCli_Click);
            // 
            // pbxImagemCodCli
            // 
            this.pbxImagemCodCli.BackColor = System.Drawing.Color.Transparent;
            this.pbxImagemCodCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImagemCodCli.Location = new System.Drawing.Point(435, 99);
            this.pbxImagemCodCli.Name = "pbxImagemCodCli";
            this.pbxImagemCodCli.Size = new System.Drawing.Size(109, 101);
            this.pbxImagemCodCli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxImagemCodCli.TabIndex = 30;
            this.pbxImagemCodCli.TabStop = false;
            // 
            // tbxSenhaCodCli
            // 
            this.tbxSenhaCodCli.Location = new System.Drawing.Point(86, 164);
            this.tbxSenhaCodCli.Name = "tbxSenhaCodCli";
            this.tbxSenhaCodCli.Size = new System.Drawing.Size(119, 23);
            this.tbxSenhaCodCli.TabIndex = 29;
            // 
            // tbxEmailCodCli
            // 
            this.tbxEmailCodCli.Location = new System.Drawing.Point(86, 128);
            this.tbxEmailCodCli.Name = "tbxEmailCodCli";
            this.tbxEmailCodCli.Size = new System.Drawing.Size(207, 23);
            this.tbxEmailCodCli.TabIndex = 28;
            // 
            // tbxNomeCodCli
            // 
            this.tbxNomeCodCli.Location = new System.Drawing.Point(86, 92);
            this.tbxNomeCodCli.Name = "tbxNomeCodCli";
            this.tbxNomeCodCli.Size = new System.Drawing.Size(207, 23);
            this.tbxNomeCodCli.TabIndex = 27;
            // 
            // lblSenhaCodCli
            // 
            this.lblSenhaCodCli.AutoSize = true;
            this.lblSenhaCodCli.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaCodCli.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSenhaCodCli.Location = new System.Drawing.Point(25, 162);
            this.lblSenhaCodCli.Name = "lblSenhaCodCli";
            this.lblSenhaCodCli.Size = new System.Drawing.Size(57, 21);
            this.lblSenhaCodCli.TabIndex = 26;
            this.lblSenhaCodCli.Text = "Senha:";
            // 
            // lblEmailCodCli
            // 
            this.lblEmailCodCli.AutoSize = true;
            this.lblEmailCodCli.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailCodCli.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblEmailCodCli.Location = new System.Drawing.Point(25, 126);
            this.lblEmailCodCli.Name = "lblEmailCodCli";
            this.lblEmailCodCli.Size = new System.Drawing.Size(55, 21);
            this.lblEmailCodCli.TabIndex = 25;
            this.lblEmailCodCli.Text = "Email:";
            // 
            // lblNomeCodCli
            // 
            this.lblNomeCodCli.AutoSize = true;
            this.lblNomeCodCli.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeCodCli.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblNomeCodCli.Location = new System.Drawing.Point(25, 90);
            this.lblNomeCodCli.Name = "lblNomeCodCli";
            this.lblNomeCodCli.Size = new System.Drawing.Size(57, 21);
            this.lblNomeCodCli.TabIndex = 24;
            this.lblNomeCodCli.Text = "Nome:";
            // 
            // tbxCodigoCli
            // 
            this.tbxCodigoCli.Location = new System.Drawing.Point(151, 30);
            this.tbxCodigoCli.Name = "tbxCodigoCli";
            this.tbxCodigoCli.Size = new System.Drawing.Size(314, 23);
            this.tbxCodigoCli.TabIndex = 2;
            // 
            // lblCodigoCli
            // 
            this.lblCodigoCli.AutoSize = true;
            this.lblCodigoCli.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCodigoCli.Location = new System.Drawing.Point(6, 33);
            this.lblCodigoCli.Name = "lblCodigoCli";
            this.lblCodigoCli.Size = new System.Drawing.Size(138, 21);
            this.lblCodigoCli.TabIndex = 1;
            this.lblCodigoCli.Text = "Código do Cliente";
            // 
            // btnCodigoCli
            // 
            this.btnCodigoCli.Location = new System.Drawing.Point(486, 30);
            this.btnCodigoCli.Name = "btnCodigoCli";
            this.btnCodigoCli.Size = new System.Drawing.Size(75, 23);
            this.btnCodigoCli.TabIndex = 0;
            this.btnCodigoCli.Text = "Buscar";
            this.btnCodigoCli.UseVisualStyleBackColor = true;
            this.btnCodigoCli.Click += new System.EventHandler(this.btnCodigoCli_Click);
            // 
            // openFileDialogImagem
            // 
            this.openFileDialogImagem.FileName = "openFileDialogImagem";
            // 
            // TelaPesquisarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(599, 416);
            this.Controls.Add(this.pesquisarNome);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaPesquisarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agência de Viagens- Pesquisar Cliente";
            this.pesquisarNome.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbxInfoCli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoCli)).EndInit();
            this.pesquisarCodigo.ResumeLayout(false);
            this.pesquisarCodigo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagemCodCli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl pesquisarNome;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage pesquisarCodigo;
        private System.Windows.Forms.Button btnNome;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbxCodigoCli;
        private System.Windows.Forms.Label lblCodigoCli;
        private System.Windows.Forms.Button btnCodigoCli;
        private System.Windows.Forms.DataGridView dgvInfoCli;
        private System.Windows.Forms.Button btnDeletarCodCli;
        private System.Windows.Forms.Button btnAlterarCodCli;
        private System.Windows.Forms.Label lblPortifolioCodCli;
        private System.Windows.Forms.Button btnBuscarImagemCodCli;
        private System.Windows.Forms.PictureBox pbxImagemCodCli;
        private System.Windows.Forms.TextBox tbxSenhaCodCli;
        private System.Windows.Forms.TextBox tbxEmailCodCli;
        private System.Windows.Forms.TextBox tbxNomeCodCli;
        private System.Windows.Forms.Label lblSenhaCodCli;
        private System.Windows.Forms.Label lblEmailCodCli;
        private System.Windows.Forms.Label lblNomeCodCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Foto;
        private System.Windows.Forms.GroupBox gbxInfoCli;
        private System.Windows.Forms.OpenFileDialog openFileDialogImagem;
    }
}