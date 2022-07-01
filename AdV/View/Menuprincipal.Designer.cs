
namespace AdV.View
{
    partial class Menuprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menuprincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cliCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.cliCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.cliPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.funFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.funCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.funPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.pacPacote = new System.Windows.Forms.ToolStripMenuItem();
            this.pacCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.pacPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.venVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.venCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.sair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cliCliente,
            this.funFuncionario,
            this.pacPacote,
            this.venVendas,
            this.sair});
            this.menuStrip1.Location = new System.Drawing.Point(106, 420);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(526, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cliCliente
            // 
            this.cliCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cliCadastrar,
            this.cliPesquisar});
            this.cliCliente.Name = "cliCliente";
            this.cliCliente.Size = new System.Drawing.Size(74, 25);
            this.cliCliente.Text = "Cliente";
            // 
            // cliCadastrar
            // 
            this.cliCadastrar.Name = "cliCadastrar";
            this.cliCadastrar.Size = new System.Drawing.Size(151, 26);
            this.cliCadastrar.Text = "Cadastrar";
            this.cliCadastrar.Click += new System.EventHandler(this.cliCadastrar_Click);
            // 
            // cliPesquisar
            // 
            this.cliPesquisar.Name = "cliPesquisar";
            this.cliPesquisar.Size = new System.Drawing.Size(151, 26);
            this.cliPesquisar.Text = "Pesquisar";
            this.cliPesquisar.Click += new System.EventHandler(this.cliPesquisar_Click);
            // 
            // funFuncionario
            // 
            this.funFuncionario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funCadastrar,
            this.funPesquisar});
            this.funFuncionario.Name = "funFuncionario";
            this.funFuncionario.Size = new System.Drawing.Size(110, 25);
            this.funFuncionario.Text = "Funcionário";
            this.funFuncionario.Click += new System.EventHandler(this.funFuncionario_Click);
            // 
            // funCadastrar
            // 
            this.funCadastrar.Name = "funCadastrar";
            this.funCadastrar.Size = new System.Drawing.Size(151, 26);
            this.funCadastrar.Text = "Cadastrar";
            this.funCadastrar.Click += new System.EventHandler(this.funCadastrar_Click);
            // 
            // funPesquisar
            // 
            this.funPesquisar.Name = "funPesquisar";
            this.funPesquisar.Size = new System.Drawing.Size(151, 26);
            this.funPesquisar.Text = "Pesquisar";
            this.funPesquisar.Click += new System.EventHandler(this.funPesquisar_Click);
            // 
            // pacPacote
            // 
            this.pacPacote.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacCadastrar,
            this.pacPesquisar});
            this.pacPacote.Name = "pacPacote";
            this.pacPacote.Size = new System.Drawing.Size(78, 25);
            this.pacPacote.Text = "Pacotes";
            // 
            // pacCadastrar
            // 
            this.pacCadastrar.Name = "pacCadastrar";
            this.pacCadastrar.Size = new System.Drawing.Size(151, 26);
            this.pacCadastrar.Text = "Cadastrar";
            this.pacCadastrar.Click += new System.EventHandler(this.pacCadastrar_Click);
            // 
            // pacPesquisar
            // 
            this.pacPesquisar.Name = "pacPesquisar";
            this.pacPesquisar.Size = new System.Drawing.Size(151, 26);
            this.pacPesquisar.Text = "Pesquisar";
            this.pacPesquisar.Click += new System.EventHandler(this.pacPesquisar_Click);
            // 
            // venVendas
            // 
            this.venVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.venCadastrar});
            this.venVendas.Name = "venVendas";
            this.venVendas.Size = new System.Drawing.Size(76, 25);
            this.venVendas.Text = "Vendas";
            // 
            // venCadastrar
            // 
            this.venCadastrar.Name = "venCadastrar";
            this.venCadastrar.Size = new System.Drawing.Size(180, 26);
            this.venCadastrar.Text = "Resgistrar";
            this.venCadastrar.Click += new System.EventHandler(this.venCadastrar_Click);
            // 
            // sair
            // 
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(51, 25);
            this.sair.Text = "Sair";
            this.sair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Menuprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(664, 451);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Menuprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agência de Viagens";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cliCliente;
        private System.Windows.Forms.ToolStripMenuItem cliCadastrar;
        private System.Windows.Forms.ToolStripMenuItem cliPesquisar;
        private System.Windows.Forms.ToolStripMenuItem funFuncionario;
        private System.Windows.Forms.ToolStripMenuItem funCadastrar;
        private System.Windows.Forms.ToolStripMenuItem funPesquisar;
        private System.Windows.Forms.ToolStripMenuItem pacPacote;
        private System.Windows.Forms.ToolStripMenuItem pacCadastrar;
        private System.Windows.Forms.ToolStripMenuItem pacPesquisar;
        private System.Windows.Forms.ToolStripMenuItem venVendas;
        private System.Windows.Forms.ToolStripMenuItem venCadastrar;
        private System.Windows.Forms.ToolStripMenuItem sair;
    }
}