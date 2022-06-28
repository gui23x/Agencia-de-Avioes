
namespace AdV.View.Pesquisar
{
    partial class TelaPesquisarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPesquisarFuncionario));
            this.pesquisarNomeFun = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNomeFun = new System.Windows.Forms.Button();
            this.tbxNomeFun = new System.Windows.Forms.TextBox();
            this.lblNomeFun = new System.Windows.Forms.Label();
            this.gbxInfoFun = new System.Windows.Forms.GroupBox();
            this.dgvInfoFun = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesquisarCodigo = new System.Windows.Forms.TabPage();
            this.btnDeletarCodFun = new System.Windows.Forms.Button();
            this.btnAlterarCodFun = new System.Windows.Forms.Button();
            this.tbxSenhaCodFun = new System.Windows.Forms.TextBox();
            this.tbxEmailCodFun = new System.Windows.Forms.TextBox();
            this.tbxNomeCodFun = new System.Windows.Forms.TextBox();
            this.lblSenhaCodFun = new System.Windows.Forms.Label();
            this.lblEmailCodFun = new System.Windows.Forms.Label();
            this.lblNomeCodFun = new System.Windows.Forms.Label();
            this.tbxCodigoFun = new System.Windows.Forms.TextBox();
            this.lblCodigoFun = new System.Windows.Forms.Label();
            this.btnCodigoFun = new System.Windows.Forms.Button();
            this.lblTituloFun = new System.Windows.Forms.Label();
            this.pesquisarNomeFun.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbxInfoFun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoFun)).BeginInit();
            this.pesquisarCodigo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pesquisarNomeFun
            // 
            this.pesquisarNomeFun.Controls.Add(this.tabPage1);
            this.pesquisarNomeFun.Controls.Add(this.pesquisarCodigo);
            this.pesquisarNomeFun.Location = new System.Drawing.Point(12, 67);
            this.pesquisarNomeFun.Name = "pesquisarNomeFun";
            this.pesquisarNomeFun.SelectedIndex = 0;
            this.pesquisarNomeFun.Size = new System.Drawing.Size(575, 325);
            this.pesquisarNomeFun.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.btnNomeFun);
            this.tabPage1.Controls.Add(this.tbxNomeFun);
            this.tabPage1.Controls.Add(this.lblNomeFun);
            this.tabPage1.Controls.Add(this.gbxInfoFun);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(567, 297);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nome";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNomeFun
            // 
            this.btnNomeFun.Location = new System.Drawing.Point(474, 28);
            this.btnNomeFun.Name = "btnNomeFun";
            this.btnNomeFun.Size = new System.Drawing.Size(75, 23);
            this.btnNomeFun.TabIndex = 2;
            this.btnNomeFun.Text = "Buscar";
            this.btnNomeFun.UseVisualStyleBackColor = true;
            this.btnNomeFun.Click += new System.EventHandler(this.btnNomeFun_Click);
            // 
            // tbxNomeFun
            // 
            this.tbxNomeFun.Location = new System.Drawing.Point(155, 28);
            this.tbxNomeFun.Name = "tbxNomeFun";
            this.tbxNomeFun.Size = new System.Drawing.Size(302, 23);
            this.tbxNomeFun.TabIndex = 1;
            // 
            // lblNomeFun
            // 
            this.lblNomeFun.AutoSize = true;
            this.lblNomeFun.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblNomeFun.Location = new System.Drawing.Point(9, 29);
            this.lblNomeFun.Name = "lblNomeFun";
            this.lblNomeFun.Size = new System.Drawing.Size(143, 25);
            this.lblNomeFun.TabIndex = 0;
            this.lblNomeFun.Text = "Digite o Nome:";
            // 
            // gbxInfoFun
            // 
            this.gbxInfoFun.BackColor = System.Drawing.Color.Transparent;
            this.gbxInfoFun.Controls.Add(this.dgvInfoFun);
            this.gbxInfoFun.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.gbxInfoFun.Location = new System.Drawing.Point(10, 57);
            this.gbxInfoFun.Name = "gbxInfoFun";
            this.gbxInfoFun.Size = new System.Drawing.Size(551, 234);
            this.gbxInfoFun.TabIndex = 4;
            this.gbxInfoFun.TabStop = false;
            this.gbxInfoFun.Text = "Informações";
            // 
            // dgvInfoFun
            // 
            this.dgvInfoFun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfoFun.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvInfoFun.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dgvInfoFun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoFun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Email});
            this.dgvInfoFun.Location = new System.Drawing.Point(6, 26);
            this.dgvInfoFun.Name = "dgvInfoFun";
            this.dgvInfoFun.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInfoFun.RowHeadersVisible = false;
            this.dgvInfoFun.RowTemplate.Height = 25;
            this.dgvInfoFun.Size = new System.Drawing.Size(539, 202);
            this.dgvInfoFun.TabIndex = 3;
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
            // pesquisarCodigo
            // 
            this.pesquisarCodigo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pesquisarCodigo.BackgroundImage")));
            this.pesquisarCodigo.Controls.Add(this.btnDeletarCodFun);
            this.pesquisarCodigo.Controls.Add(this.btnAlterarCodFun);
            this.pesquisarCodigo.Controls.Add(this.tbxSenhaCodFun);
            this.pesquisarCodigo.Controls.Add(this.tbxEmailCodFun);
            this.pesquisarCodigo.Controls.Add(this.tbxNomeCodFun);
            this.pesquisarCodigo.Controls.Add(this.lblSenhaCodFun);
            this.pesquisarCodigo.Controls.Add(this.lblEmailCodFun);
            this.pesquisarCodigo.Controls.Add(this.lblNomeCodFun);
            this.pesquisarCodigo.Controls.Add(this.tbxCodigoFun);
            this.pesquisarCodigo.Controls.Add(this.lblCodigoFun);
            this.pesquisarCodigo.Controls.Add(this.btnCodigoFun);
            this.pesquisarCodigo.Location = new System.Drawing.Point(4, 24);
            this.pesquisarCodigo.Name = "pesquisarCodigo";
            this.pesquisarCodigo.Padding = new System.Windows.Forms.Padding(3);
            this.pesquisarCodigo.Size = new System.Drawing.Size(567, 297);
            this.pesquisarCodigo.TabIndex = 1;
            this.pesquisarCodigo.Text = "Código";
            this.pesquisarCodigo.UseVisualStyleBackColor = true;
            // 
            // btnDeletarCodFun
            // 
            this.btnDeletarCodFun.Location = new System.Drawing.Point(314, 208);
            this.btnDeletarCodFun.Name = "btnDeletarCodFun";
            this.btnDeletarCodFun.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarCodFun.TabIndex = 34;
            this.btnDeletarCodFun.Text = "Deletar";
            this.btnDeletarCodFun.UseVisualStyleBackColor = true;
            this.btnDeletarCodFun.Click += new System.EventHandler(this.btnDeletarCodFun_Click);
            // 
            // btnAlterarCodFun
            // 
            this.btnAlterarCodFun.Location = new System.Drawing.Point(233, 208);
            this.btnAlterarCodFun.Name = "btnAlterarCodFun";
            this.btnAlterarCodFun.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarCodFun.TabIndex = 33;
            this.btnAlterarCodFun.Text = "Alterar";
            this.btnAlterarCodFun.UseVisualStyleBackColor = true;
            this.btnAlterarCodFun.Click += new System.EventHandler(this.btnAlterarCodFun_Click);
            // 
            // tbxSenhaCodFun
            // 
            this.tbxSenhaCodFun.Location = new System.Drawing.Point(176, 158);
            this.tbxSenhaCodFun.Name = "tbxSenhaCodFun";
            this.tbxSenhaCodFun.Size = new System.Drawing.Size(169, 23);
            this.tbxSenhaCodFun.TabIndex = 29;
            // 
            // tbxEmailCodFun
            // 
            this.tbxEmailCodFun.Location = new System.Drawing.Point(176, 122);
            this.tbxEmailCodFun.Name = "tbxEmailCodFun";
            this.tbxEmailCodFun.Size = new System.Drawing.Size(257, 23);
            this.tbxEmailCodFun.TabIndex = 28;
            this.tbxEmailCodFun.TextChanged += new System.EventHandler(this.tbxEmailCodFun_TextChanged);
            // 
            // tbxNomeCodFun
            // 
            this.tbxNomeCodFun.Location = new System.Drawing.Point(176, 86);
            this.tbxNomeCodFun.Name = "tbxNomeCodFun";
            this.tbxNomeCodFun.Size = new System.Drawing.Size(257, 23);
            this.tbxNomeCodFun.TabIndex = 27;
            // 
            // lblSenhaCodFun
            // 
            this.lblSenhaCodFun.AutoSize = true;
            this.lblSenhaCodFun.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaCodFun.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSenhaCodFun.Location = new System.Drawing.Point(118, 159);
            this.lblSenhaCodFun.Name = "lblSenhaCodFun";
            this.lblSenhaCodFun.Size = new System.Drawing.Size(57, 21);
            this.lblSenhaCodFun.TabIndex = 26;
            this.lblSenhaCodFun.Text = "Senha:";
            // 
            // lblEmailCodFun
            // 
            this.lblEmailCodFun.AutoSize = true;
            this.lblEmailCodFun.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailCodFun.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblEmailCodFun.Location = new System.Drawing.Point(118, 123);
            this.lblEmailCodFun.Name = "lblEmailCodFun";
            this.lblEmailCodFun.Size = new System.Drawing.Size(55, 21);
            this.lblEmailCodFun.TabIndex = 25;
            this.lblEmailCodFun.Text = "Email:";
            // 
            // lblNomeCodFun
            // 
            this.lblNomeCodFun.AutoSize = true;
            this.lblNomeCodFun.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeCodFun.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblNomeCodFun.Location = new System.Drawing.Point(118, 87);
            this.lblNomeCodFun.Name = "lblNomeCodFun";
            this.lblNomeCodFun.Size = new System.Drawing.Size(57, 21);
            this.lblNomeCodFun.TabIndex = 24;
            this.lblNomeCodFun.Text = "Nome:";
            // 
            // tbxCodigoFun
            // 
            this.tbxCodigoFun.Location = new System.Drawing.Point(181, 30);
            this.tbxCodigoFun.Name = "tbxCodigoFun";
            this.tbxCodigoFun.Size = new System.Drawing.Size(284, 23);
            this.tbxCodigoFun.TabIndex = 2;
            // 
            // lblCodigoFun
            // 
            this.lblCodigoFun.AutoSize = true;
            this.lblCodigoFun.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCodigoFun.Location = new System.Drawing.Point(3, 32);
            this.lblCodigoFun.Name = "lblCodigoFun";
            this.lblCodigoFun.Size = new System.Drawing.Size(172, 21);
            this.lblCodigoFun.TabIndex = 1;
            this.lblCodigoFun.Text = "Código do Funcionário";
            // 
            // btnCodigoFun
            // 
            this.btnCodigoFun.Location = new System.Drawing.Point(486, 30);
            this.btnCodigoFun.Name = "btnCodigoFun";
            this.btnCodigoFun.Size = new System.Drawing.Size(75, 23);
            this.btnCodigoFun.TabIndex = 0;
            this.btnCodigoFun.Text = "Buscar";
            this.btnCodigoFun.UseVisualStyleBackColor = true;
            this.btnCodigoFun.Click += new System.EventHandler(this.btnCodigoFun_Click);
            // 
            // lblTituloFun
            // 
            this.lblTituloFun.AutoSize = true;
            this.lblTituloFun.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloFun.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTituloFun.Location = new System.Drawing.Point(144, 24);
            this.lblTituloFun.Name = "lblTituloFun";
            this.lblTituloFun.Size = new System.Drawing.Size(329, 40);
            this.lblTituloFun.TabIndex = 2;
            this.lblTituloFun.Text = "Pesquisar Funcionários";
            // 
            // TelaPesquisarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(599, 416);
            this.Controls.Add(this.pesquisarNomeFun);
            this.Controls.Add(this.lblTituloFun);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPesquisarFuncionario";
            this.Text = "Agência de Viagens- Pesquisar Funcionários";
            this.pesquisarNomeFun.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbxInfoFun.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoFun)).EndInit();
            this.pesquisarCodigo.ResumeLayout(false);
            this.pesquisarCodigo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl pesquisarNomeFun;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnNomeFun;
        private System.Windows.Forms.TextBox tbxNomeFun;
        private System.Windows.Forms.Label lblNomeFun;
        private System.Windows.Forms.GroupBox gbxInfoFun;
        private System.Windows.Forms.DataGridView dgvInfoFun;
        private System.Windows.Forms.TabPage pesquisarCodigo;
        private System.Windows.Forms.Button btnDeletarCodFun;
        private System.Windows.Forms.Button btnAlterarCodFun;
        private System.Windows.Forms.TextBox tbxSenhaCodFun;
        private System.Windows.Forms.TextBox tbxEmailCodFun;
        private System.Windows.Forms.TextBox tbxNomeCodFun;
        private System.Windows.Forms.Label lblSenhaCodFun;
        private System.Windows.Forms.Label lblEmailCodFun;
        private System.Windows.Forms.Label lblNomeCodFun;
        private System.Windows.Forms.TextBox tbxCodigoFun;
        private System.Windows.Forms.Label lblCodigoFun;
        private System.Windows.Forms.Button btnCodigoFun;
        private System.Windows.Forms.Label lblTituloFun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}