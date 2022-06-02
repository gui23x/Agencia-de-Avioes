
namespace AdV.View.Cadastro
{
    partial class TelaCadastrarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastrarFuncionario));
            this.lblTituloFun = new System.Windows.Forms.Label();
            this.lblNomeFun = new System.Windows.Forms.Label();
            this.lblEmailFun = new System.Windows.Forms.Label();
            this.lblSenhaFun = new System.Windows.Forms.Label();
            this.tbxNomeFun = new System.Windows.Forms.TextBox();
            this.tbxEmailFun = new System.Windows.Forms.TextBox();
            this.tbxSenhaFun = new System.Windows.Forms.TextBox();
            this.btnSalvarFun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloFun
            // 
            this.lblTituloFun.AutoSize = true;
            this.lblTituloFun.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloFun.Font = new System.Drawing.Font("Segoe UI", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTituloFun.Location = new System.Drawing.Point(105, 46);
            this.lblTituloFun.Name = "lblTituloFun";
            this.lblTituloFun.Size = new System.Drawing.Size(386, 47);
            this.lblTituloFun.TabIndex = 0;
            this.lblTituloFun.Text = "Cadastrar Funcionário";
            // 
            // lblNomeFun
            // 
            this.lblNomeFun.AutoSize = true;
            this.lblNomeFun.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeFun.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblNomeFun.Location = new System.Drawing.Point(99, 137);
            this.lblNomeFun.Name = "lblNomeFun";
            this.lblNomeFun.Size = new System.Drawing.Size(57, 21);
            this.lblNomeFun.TabIndex = 1;
            this.lblNomeFun.Text = "Nome:";
            // 
            // lblEmailFun
            // 
            this.lblEmailFun.AutoSize = true;
            this.lblEmailFun.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailFun.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblEmailFun.Location = new System.Drawing.Point(99, 192);
            this.lblEmailFun.Name = "lblEmailFun";
            this.lblEmailFun.Size = new System.Drawing.Size(55, 21);
            this.lblEmailFun.TabIndex = 2;
            this.lblEmailFun.Text = "Email:";
            // 
            // lblSenhaFun
            // 
            this.lblSenhaFun.AutoSize = true;
            this.lblSenhaFun.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaFun.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSenhaFun.Location = new System.Drawing.Point(99, 242);
            this.lblSenhaFun.Name = "lblSenhaFun";
            this.lblSenhaFun.Size = new System.Drawing.Size(57, 21);
            this.lblSenhaFun.TabIndex = 3;
            this.lblSenhaFun.Text = "Senha:";
            // 
            // tbxNomeFun
            // 
            this.tbxNomeFun.Location = new System.Drawing.Point(173, 137);
            this.tbxNomeFun.Name = "tbxNomeFun";
            this.tbxNomeFun.Size = new System.Drawing.Size(309, 23);
            this.tbxNomeFun.TabIndex = 4;
            // 
            // tbxEmailFun
            // 
            this.tbxEmailFun.Location = new System.Drawing.Point(173, 192);
            this.tbxEmailFun.Name = "tbxEmailFun";
            this.tbxEmailFun.Size = new System.Drawing.Size(309, 23);
            this.tbxEmailFun.TabIndex = 5;
            // 
            // tbxSenhaFun
            // 
            this.tbxSenhaFun.Location = new System.Drawing.Point(173, 242);
            this.tbxSenhaFun.Name = "tbxSenhaFun";
            this.tbxSenhaFun.Size = new System.Drawing.Size(195, 23);
            this.tbxSenhaFun.TabIndex = 6;
            // 
            // btnSalvarFun
            // 
            this.btnSalvarFun.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSalvarFun.Location = new System.Drawing.Point(265, 313);
            this.btnSalvarFun.Name = "btnSalvarFun";
            this.btnSalvarFun.Size = new System.Drawing.Size(103, 49);
            this.btnSalvarFun.TabIndex = 7;
            this.btnSalvarFun.Text = "Salvar";
            this.btnSalvarFun.UseVisualStyleBackColor = true;
            this.btnSalvarFun.Click += new System.EventHandler(this.btnSalvarFun_Click);
            // 
            // TelaCadastrarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(599, 416);
            this.Controls.Add(this.btnSalvarFun);
            this.Controls.Add(this.tbxSenhaFun);
            this.Controls.Add(this.tbxEmailFun);
            this.Controls.Add(this.tbxNomeFun);
            this.Controls.Add(this.lblSenhaFun);
            this.Controls.Add(this.lblEmailFun);
            this.Controls.Add(this.lblNomeFun);
            this.Controls.Add(this.lblTituloFun);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaCadastrarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agência de Viagens- Cadastrar Funcionário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloFun;
        private System.Windows.Forms.Label lblNomeFun;
        private System.Windows.Forms.Label lblEmailFun;
        private System.Windows.Forms.Label lblSenhaFun;
        private System.Windows.Forms.TextBox tbxNomeFun;
        private System.Windows.Forms.TextBox tbxEmailFun;
        private System.Windows.Forms.TextBox tbxSenhaFun;
        private System.Windows.Forms.Button btnSalvarFun;
    }
}