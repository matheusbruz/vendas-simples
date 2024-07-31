namespace SistemaVendas
{
    partial class FrmAdmin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.barraMenu = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkLogin = new System.Windows.Forms.Label();
            this.nomeLogin = new System.Windows.Forms.Label();
            this.panelrodape = new System.Windows.Forms.Panel();
            this.cadastroDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devoluçãoDeVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formaDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraMenu.SuspendLayout();
            this.panelrodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraMenu
            // 
            this.barraMenu.BackColor = System.Drawing.Color.SeaGreen;
            this.barraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriasToolStripMenuItem,
            this.transaçõesToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.barraMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.barraMenu.Location = new System.Drawing.Point(0, 0);
            this.barraMenu.Name = "barraMenu";
            this.barraMenu.Size = new System.Drawing.Size(800, 24);
            this.barraMenu.TabIndex = 1;
            this.barraMenu.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeUsuariosToolStripMenuItem,
            this.formaDePagamentoToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.usuariosToolStripMenuItem.Text = "Configurações";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gruposToolStripMenuItem,
            this.cadastroDeProdutosToolStripMenuItem,
            this.cadastroDeClientesToolStripMenuItem});
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.categoriasToolStripMenuItem.Text = "Cadastro";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventário";
            // 
            // transaçõesToolStripMenuItem
            // 
            this.transaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caixaToolStripMenuItem,
            this.devoluçãoDeVendaToolStripMenuItem});
            this.transaçõesToolStripMenuItem.Name = "transaçõesToolStripMenuItem";
            this.transaçõesToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.transaçõesToolStripMenuItem.Text = "Vendas";
            // 
            // checkLogin
            // 
            this.checkLogin.AutoSize = true;
            this.checkLogin.Location = new System.Drawing.Point(652, 5);
            this.checkLogin.Name = "checkLogin";
            this.checkLogin.Size = new System.Drawing.Size(58, 14);
            this.checkLogin.TabIndex = 2;
            this.checkLogin.Text = "USUARIO:";
            // 
            // nomeLogin
            // 
            this.nomeLogin.AutoSize = true;
            this.nomeLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nomeLogin.Location = new System.Drawing.Point(716, 5);
            this.nomeLogin.Name = "nomeLogin";
            this.nomeLogin.Size = new System.Drawing.Size(59, 14);
            this.nomeLogin.TabIndex = 3;
            this.nomeLogin.Text = "BRUZACA";
            this.nomeLogin.Click += new System.EventHandler(this.nomeLogin_Click);
            // 
            // panelrodape
            // 
            this.panelrodape.BackColor = System.Drawing.Color.SeaGreen;
            this.panelrodape.Controls.Add(this.nomeLogin);
            this.panelrodape.Controls.Add(this.checkLogin);
            this.panelrodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelrodape.Location = new System.Drawing.Point(0, 524);
            this.panelrodape.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelrodape.Name = "panelrodape";
            this.panelrodape.Size = new System.Drawing.Size(800, 24);
            this.panelrodape.TabIndex = 0;
            // 
            // cadastroDeUsuariosToolStripMenuItem
            // 
            this.cadastroDeUsuariosToolStripMenuItem.Name = "cadastroDeUsuariosToolStripMenuItem";
            this.cadastroDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.cadastroDeUsuariosToolStripMenuItem.Text = "Cadastro de Usuarios";
            this.cadastroDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeUsuariosToolStripMenuItem_Click);
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.caixaToolStripMenuItem.Text = "Caixa";
            // 
            // devoluçãoDeVendaToolStripMenuItem
            // 
            this.devoluçãoDeVendaToolStripMenuItem.Name = "devoluçãoDeVendaToolStripMenuItem";
            this.devoluçãoDeVendaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.devoluçãoDeVendaToolStripMenuItem.Text = "Devolução de Venda";
            // 
            // cadastroDeProdutosToolStripMenuItem
            // 
            this.cadastroDeProdutosToolStripMenuItem.Name = "cadastroDeProdutosToolStripMenuItem";
            this.cadastroDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cadastroDeProdutosToolStripMenuItem.Text = "Cadastro de Produtos";
            // 
            // cadastroDeClientesToolStripMenuItem
            // 
            this.cadastroDeClientesToolStripMenuItem.Name = "cadastroDeClientesToolStripMenuItem";
            this.cadastroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cadastroDeClientesToolStripMenuItem.Text = "Cadastro de Clientes";
            // 
            // gruposToolStripMenuItem
            // 
            this.gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
            this.gruposToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.gruposToolStripMenuItem.Text = "Grupos";
            // 
            // formaDePagamentoToolStripMenuItem
            // 
            this.formaDePagamentoToolStripMenuItem.Name = "formaDePagamentoToolStripMenuItem";
            this.formaDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.formaDePagamentoToolStripMenuItem.Text = "Forma de Pagamento";
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.panelrodape);
            this.Controls.Add(this.barraMenu);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.barraMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel Administrativo";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.barraMenu.ResumeLayout(false);
            this.barraMenu.PerformLayout();
            this.panelrodape.ResumeLayout(false);
            this.panelrodape.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip barraMenu;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaçõesToolStripMenuItem;
        private System.Windows.Forms.Label checkLogin;
        private System.Windows.Forms.Label nomeLogin;
        private System.Windows.Forms.Panel panelrodape;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devoluçãoDeVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formaDePagamentoToolStripMenuItem;
    }
}

