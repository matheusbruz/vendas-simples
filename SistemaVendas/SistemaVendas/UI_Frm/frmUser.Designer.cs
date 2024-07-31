namespace SistemaVendas
{
    partial class frmUser
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
            this.menuPUser = new System.Windows.Forms.MenuStrip();
            this.comprarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomeLogin = new System.Windows.Forms.Label();
            this.checkLogin = new System.Windows.Forms.Label();
            this.creditos = new System.Windows.Forms.Label();
            this.panelrodape = new System.Windows.Forms.Panel();
            this.menuPUser.SuspendLayout();
            this.panelrodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPUser
            // 
            this.menuPUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprarToolStripMenuItem,
            this.relatórioDeVendasToolStripMenuItem,
            this.inventarioToolStripMenuItem});
            this.menuPUser.Location = new System.Drawing.Point(0, 0);
            this.menuPUser.Name = "menuPUser";
            this.menuPUser.Size = new System.Drawing.Size(800, 24);
            this.menuPUser.TabIndex = 0;
            this.menuPUser.Text = "menuStrip1";
            // 
            // comprarToolStripMenuItem
            // 
            this.comprarToolStripMenuItem.Name = "comprarToolStripMenuItem";
            this.comprarToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.comprarToolStripMenuItem.Text = "Comprar";
            // 
            // relatórioDeVendasToolStripMenuItem
            // 
            this.relatórioDeVendasToolStripMenuItem.Name = "relatórioDeVendasToolStripMenuItem";
            this.relatórioDeVendasToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.relatórioDeVendasToolStripMenuItem.Text = "Relatório de Vendas";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // nomeLogin
            // 
            this.nomeLogin.AutoSize = true;
            this.nomeLogin.ForeColor = System.Drawing.Color.Crimson;
            this.nomeLogin.Location = new System.Drawing.Point(714, 34);
            this.nomeLogin.Name = "nomeLogin";
            this.nomeLogin.Size = new System.Drawing.Size(58, 13);
            this.nomeLogin.TabIndex = 6;
            this.nomeLogin.Text = "BRUZACA";
            // 
            // checkLogin
            // 
            this.checkLogin.AutoSize = true;
            this.checkLogin.Location = new System.Drawing.Point(662, 34);
            this.checkLogin.Name = "checkLogin";
            this.checkLogin.Size = new System.Drawing.Size(46, 13);
            this.checkLogin.TabIndex = 5;
            this.checkLogin.Text = "Usuario:";
            this.checkLogin.Click += new System.EventHandler(this.checkLogin_Click);
            // 
            // creditos
            // 
            this.creditos.AutoSize = true;
            this.creditos.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditos.Location = new System.Drawing.Point(606, 35);
            this.creditos.Name = "creditos";
            this.creditos.Size = new System.Drawing.Size(191, 16);
            this.creditos.TabIndex = 0;
            this.creditos.Text = "Desenvolvido por @MAISUMLAB";
            // 
            // panelrodape
            // 
            this.panelrodape.BackColor = System.Drawing.Color.DarkCyan;
            this.panelrodape.Controls.Add(this.creditos);
            this.panelrodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelrodape.Location = new System.Drawing.Point(0, 390);
            this.panelrodape.Name = "panelrodape";
            this.panelrodape.Size = new System.Drawing.Size(800, 60);
            this.panelrodape.TabIndex = 4;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nomeLogin);
            this.Controls.Add(this.checkLogin);
            this.Controls.Add(this.panelrodape);
            this.Controls.Add(this.menuPUser);
            this.MainMenuStrip = this.menuPUser;
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel de  Usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.menuPUser.ResumeLayout(false);
            this.menuPUser.PerformLayout();
            this.panelrodape.ResumeLayout(false);
            this.panelrodape.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPUser;
        private System.Windows.Forms.ToolStripMenuItem comprarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.Label nomeLogin;
        private System.Windows.Forms.Label checkLogin;
        private System.Windows.Forms.Label creditos;
        private System.Windows.Forms.Panel panelrodape;
    }
}