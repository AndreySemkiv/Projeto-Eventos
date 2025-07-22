namespace Eventos.View
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.grdPendente = new System.Windows.Forms.DataGridView();
            this.lbl_receber = new System.Windows.Forms.Label();
            this.lbl_Semana = new System.Windows.Forms.Label();
            this.grdAgenda = new System.Windows.Forms.DataGridView();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.temasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orcamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orçamentosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contratosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdPendente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgenda)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdPendente
            // 
            this.grdPendente.AllowUserToOrderColumns = true;
            this.grdPendente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPendente.Location = new System.Drawing.Point(106, 490);
            this.grdPendente.Margin = new System.Windows.Forms.Padding(2);
            this.grdPendente.Name = "grdPendente";
            this.grdPendente.RowHeadersWidth = 51;
            this.grdPendente.Size = new System.Drawing.Size(923, 259);
            this.grdPendente.TabIndex = 11;
            // 
            // lbl_receber
            // 
            this.lbl_receber.AutoSize = true;
            this.lbl_receber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.lbl_receber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_receber.Location = new System.Drawing.Point(455, 446);
            this.lbl_receber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_receber.Name = "lbl_receber";
            this.lbl_receber.Size = new System.Drawing.Size(223, 22);
            this.lbl_receber.TabIndex = 10;
            this.lbl_receber.Text = "Recebimento Pendente";
            // 
            // lbl_Semana
            // 
            this.lbl_Semana.AutoSize = true;
            this.lbl_Semana.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.lbl_Semana.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Semana.Location = new System.Drawing.Point(476, 92);
            this.lbl_Semana.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Semana.Name = "lbl_Semana";
            this.lbl_Semana.Size = new System.Drawing.Size(188, 22);
            this.lbl_Semana.TabIndex = 9;
            this.lbl_Semana.Text = "Agenda da Semana";
            // 
            // grdAgenda
            // 
            this.grdAgenda.AllowUserToOrderColumns = true;
            this.grdAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAgenda.Location = new System.Drawing.Point(58, 122);
            this.grdAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.grdAgenda.Name = "grdAgenda";
            this.grdAgenda.RowHeadersWidth = 51;
            this.grdAgenda.Size = new System.Drawing.Size(1028, 313);
            this.grdAgenda.TabIndex = 8;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_titulo.Location = new System.Drawing.Point(294, 42);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(484, 30);
            this.lbl_titulo.TabIndex = 7;
            this.lbl_titulo.Text = "Bem Vindo a sua Agenda de Eventos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.produtosToolStripMenuItem2,
            this.temasToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.orcamentosToolStripMenuItem,
            this.agendamentosToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.ajudaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1155, 25);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(79, 21);
            this.cadastrosToolStripMenuItem.Text = "Clientes";
            this.cadastrosToolStripMenuItem.Click += new System.EventHandler(this.cadastrosToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem2
            // 
            this.produtosToolStripMenuItem2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.produtosToolStripMenuItem2.Name = "produtosToolStripMenuItem2";
            this.produtosToolStripMenuItem2.Size = new System.Drawing.Size(86, 21);
            this.produtosToolStripMenuItem2.Text = "Produtos";
            this.produtosToolStripMenuItem2.Click += new System.EventHandler(this.produtosToolStripMenuItem2_Click);
            // 
            // temasToolStripMenuItem
            // 
            this.temasToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temasToolStripMenuItem.Name = "temasToolStripMenuItem";
            this.temasToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.temasToolStripMenuItem.Text = "Temas";
            this.temasToolStripMenuItem.Click += new System.EventHandler(this.temasToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(100, 21);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // orcamentosToolStripMenuItem
            // 
            this.orcamentosToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orcamentosToolStripMenuItem.Name = "orcamentosToolStripMenuItem";
            this.orcamentosToolStripMenuItem.Size = new System.Drawing.Size(110, 21);
            this.orcamentosToolStripMenuItem.Text = "Orçamentos";
            // 
            // agendamentosToolStripMenuItem
            // 
            this.agendamentosToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agendamentosToolStripMenuItem.Name = "agendamentosToolStripMenuItem";
            this.agendamentosToolStripMenuItem.Size = new System.Drawing.Size(129, 21);
            this.agendamentosToolStripMenuItem.Text = "Agendamentos";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orçamentosToolStripMenuItem1,
            this.agendamentosToolStripMenuItem1,
            this.contratosToolStripMenuItem,
            this.financeiroToolStripMenuItem1,
            this.clientesToolStripMenuItem1,
            this.produtosToolStripMenuItem});
            this.ajudaToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(95, 21);
            this.ajudaToolStripMenuItem.Text = "Relatórios";
            // 
            // orçamentosToolStripMenuItem1
            // 
            this.orçamentosToolStripMenuItem1.Name = "orçamentosToolStripMenuItem1";
            this.orçamentosToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.orçamentosToolStripMenuItem1.Text = "Orçamentos";
            // 
            // agendamentosToolStripMenuItem1
            // 
            this.agendamentosToolStripMenuItem1.Name = "agendamentosToolStripMenuItem1";
            this.agendamentosToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.agendamentosToolStripMenuItem1.Text = "Agendamentos";
            // 
            // contratosToolStripMenuItem
            // 
            this.contratosToolStripMenuItem.Name = "contratosToolStripMenuItem";
            this.contratosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.contratosToolStripMenuItem.Text = "Contratos";
            // 
            // financeiroToolStripMenuItem1
            // 
            this.financeiroToolStripMenuItem1.Name = "financeiroToolStripMenuItem1";
            this.financeiroToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.financeiroToolStripMenuItem1.Text = "Financeiro";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(98, 21);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem1
            // 
            this.ajudaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem1.Name = "ajudaToolStripMenuItem1";
            this.ajudaToolStripMenuItem1.Size = new System.Drawing.Size(24, 21);
            this.ajudaToolStripMenuItem1.Text = "?";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.grdPendente);
            this.Controls.Add(this.lbl_receber);
            this.Controls.Add(this.lbl_Semana);
            this.Controls.Add(this.grdAgenda);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda de Eventos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grdPendente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgenda)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPendente;
        private System.Windows.Forms.Label lbl_receber;
        private System.Windows.Forms.Label lbl_Semana;
        private System.Windows.Forms.DataGridView grdAgenda;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem temasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orcamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orçamentosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agendamentosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contratosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}