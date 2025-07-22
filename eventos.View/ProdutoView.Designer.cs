namespace Eventos.View
{
    partial class frmProdutoView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutoView));
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddCategoria = new System.Windows.Forms.Button();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtAluguel = new System.Windows.Forms.TextBox();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.btnAddCor = new System.Windows.Forms.Button();
            this.btnAddTema = new System.Windows.Forms.Button();
            this.cbbTema = new System.Windows.Forms.ComboBox();
            this.cbbCor = new System.Windows.Forms.ComboBox();
            this.cbbCategoria = new System.Windows.Forms.ComboBox();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.lblAluguel = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblCusto = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblTema = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.AccessibleDescription = "";
            this.btnAdicionar.AccessibleName = "";
            this.btnAdicionar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(13, 11);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(83, 78);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Tag = "";
            this.toolTip1.SetToolTip(this.btnAdicionar, "Adicionar");
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(370, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(83, 78);
            this.btnSalvar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(280, 11);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(83, 78);
            this.btnEditar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizar.Image")));
            this.btnLocalizar.Location = new System.Drawing.Point(102, 11);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(83, 78);
            this.btnLocalizar.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnLocalizar, "Localizar");
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(8, 104);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(242, 28);
            this.lblProduto.TabIndex = 4;
            this.lblProduto.Text = "Descrição do Produto :";
            this.lblProduto.UseMnemonic = false;
            // 
            // txtProduto
            // 
            this.txtProduto.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(246, 102);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(562, 36);
            this.txtProduto.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtProduto, "Digite a Descrição do Protudo");
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(314, 326);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 29);
            this.lblMensagem.TabIndex = 6;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(547, 11);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(83, 78);
            this.btnExcluir.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnExcluir, "Excluir");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(191, 11);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(83, 78);
            this.btnPesquisar.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnPesquisar, "Pesquisar");
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(725, 11);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(83, 78);
            this.btnSair.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnSair, "Sair");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(458, 11);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(83, 78);
            this.btnLimpar.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnLimpar, "Limpar");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 287);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(797, 199);
            this.dataGridView1.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Target";
            this.dataGridViewTextBoxColumn1.HeaderText = "Target";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodos.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarTodos.Image")));
            this.btnMostrarTodos.Location = new System.Drawing.Point(636, 11);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(83, 78);
            this.btnMostrarTodos.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnMostrarTodos, "Mostrar Todos");
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnAddCategoria
            // 
            this.btnAddCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCategoria.Image")));
            this.btnAddCategoria.Location = new System.Drawing.Point(280, 182);
            this.btnAddCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCategoria.Name = "btnAddCategoria";
            this.btnAddCategoria.Size = new System.Drawing.Size(39, 34);
            this.btnAddCategoria.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnAddCategoria, "Adicionar Nova Categoria");
            this.btnAddCategoria.UseVisualStyleBackColor = true;
            this.btnAddCategoria.Click += new System.EventHandler(this.btnAddCategoria_Click);
            // 
            // txtTamanho
            // 
            this.txtTamanho.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamanho.Location = new System.Drawing.Point(134, 145);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(421, 36);
            this.txtTamanho.TabIndex = 19;
            this.toolTip1.SetToolTip(this.txtTamanho, "Digite aqui o Tamanho");
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(448, 185);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(97, 36);
            this.txtQuantidade.TabIndex = 27;
            this.toolTip1.SetToolTip(this.txtQuantidade, "Digite a Quantidade");
            // 
            // txtAluguel
            // 
            this.txtAluguel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAluguel.Location = new System.Drawing.Point(680, 184);
            this.txtAluguel.Name = "txtAluguel";
            this.txtAluguel.Size = new System.Drawing.Size(128, 36);
            this.txtAluguel.TabIndex = 25;
            this.toolTip1.SetToolTip(this.txtAluguel, "Informe o Valor Unitário do Aluguel");
            // 
            // txtCusto
            // 
            this.txtCusto.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto.Location = new System.Drawing.Point(642, 146);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(166, 36);
            this.txtCusto.TabIndex = 32;
            this.toolTip1.SetToolTip(this.txtCusto, "Informe o Custo Unitário do Produto");
            // 
            // btnAddCor
            // 
            this.btnAddCor.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCor.Image")));
            this.btnAddCor.Location = new System.Drawing.Point(324, 229);
            this.btnAddCor.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCor.Name = "btnAddCor";
            this.btnAddCor.Size = new System.Drawing.Size(39, 34);
            this.btnAddCor.TabIndex = 38;
            this.toolTip1.SetToolTip(this.btnAddCor, "Adicionar Nova Cor");
            this.btnAddCor.UseVisualStyleBackColor = true;
            this.btnAddCor.Click += new System.EventHandler(this.btnAddCor_Click);
            // 
            // btnAddTema
            // 
            this.btnAddTema.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTema.Image")));
            this.btnAddTema.Location = new System.Drawing.Point(769, 229);
            this.btnAddTema.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTema.Name = "btnAddTema";
            this.btnAddTema.Size = new System.Drawing.Size(39, 34);
            this.btnAddTema.TabIndex = 39;
            this.toolTip1.SetToolTip(this.btnAddTema, "Adicionar Novo Tema");
            this.btnAddTema.UseVisualStyleBackColor = true;
            this.btnAddTema.Click += new System.EventHandler(this.btnAddTema_Click);
            // 
            // cbbTema
            // 
            this.cbbTema.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.cbbTema.FormattingEnabled = true;
            this.cbbTema.Location = new System.Drawing.Point(448, 232);
            this.cbbTema.Name = "cbbTema";
            this.cbbTema.Size = new System.Drawing.Size(316, 37);
            this.cbbTema.TabIndex = 40;
            this.toolTip1.SetToolTip(this.cbbTema, "Selecione o Tema");
            // 
            // cbbCor
            // 
            this.cbbCor.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.cbbCor.FormattingEnabled = true;
            this.cbbCor.Location = new System.Drawing.Point(66, 232);
            this.cbbCor.Name = "cbbCor";
            this.cbbCor.Size = new System.Drawing.Size(248, 37);
            this.cbbCor.TabIndex = 41;
            this.toolTip1.SetToolTip(this.cbbCor, "Selecione a Cor");
            // 
            // cbbCategoria
            // 
            this.cbbCategoria.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.cbbCategoria.FormattingEnabled = true;
            this.cbbCategoria.Location = new System.Drawing.Point(66, 185);
            this.cbbCategoria.Name = "cbbCategoria";
            this.cbbCategoria.Size = new System.Drawing.Size(208, 37);
            this.cbbCategoria.TabIndex = 42;
            this.toolTip1.SetToolTip(this.cbbCategoria, "Selecione a Categoria");
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.lblTamanho.Location = new System.Drawing.Point(12, 147);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(121, 28);
            this.lblTamanho.TabIndex = 18;
            this.lblTamanho.Text = "Tamanho :";
            // 
            // lblAluguel
            // 
            this.lblAluguel.AutoSize = true;
            this.lblAluguel.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.lblAluguel.Location = new System.Drawing.Point(551, 186);
            this.lblAluguel.Name = "lblAluguel";
            this.lblAluguel.Size = new System.Drawing.Size(136, 28);
            this.lblAluguel.TabIndex = 24;
            this.lblAluguel.Text = "R$ Aluguel :";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.lblQuantidade.Location = new System.Drawing.Point(319, 186);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(144, 28);
            this.lblQuantidade.TabIndex = 26;
            this.lblQuantidade.Text = "Quantidade :";
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.lblCusto.Location = new System.Drawing.Point(561, 147);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(84, 28);
            this.lblCusto.TabIndex = 31;
            this.lblCusto.Text = "Custo :";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.lblCategoria.Location = new System.Drawing.Point(12, 191);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(61, 28);
            this.lblCategoria.TabIndex = 33;
            this.lblCategoria.Text = "Cat.:";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.lblCor.Location = new System.Drawing.Point(13, 238);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(61, 28);
            this.lblCor.TabIndex = 36;
            this.lblCor.Text = "Cor :";
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.lblTema.Location = new System.Drawing.Point(367, 238);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(83, 28);
            this.lblTema.TabIndex = 37;
            this.lblTema.Text = "Tema :";
            // 
            // frmProdutoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 497);
            this.Controls.Add(this.cbbCategoria);
            this.Controls.Add(this.cbbCor);
            this.Controls.Add(this.cbbTema);
            this.Controls.Add(this.btnAddTema);
            this.Controls.Add(this.btnAddCor);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.lblCusto);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txtAluguel);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.lblTamanho);
            this.Controls.Add(this.btnAddCategoria);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblAluguel);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmProdutoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnMostrarTodos;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAddCategoria;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Label lblAluguel;
        private System.Windows.Forms.TextBox txtAluguel;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Button btnAddCor;
        private System.Windows.Forms.Button btnAddTema;
        private System.Windows.Forms.ComboBox cbbTema;
        private System.Windows.Forms.ComboBox cbbCor;
        private System.Windows.Forms.ComboBox cbbCategoria;
    }
}