namespace Eventos.View
{
    partial class frmClienteView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClienteView));
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddEndereco = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnBuscaCep = new System.Windows.Forms.Button();
            this.txtBairroCliente = new System.Windows.Forms.TextBox();
            this.txtCidadeCliente = new System.Windows.Forms.TextBox();
            this.txtIdRua = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblBairroCliente = new System.Windows.Forms.Label();
            this.lblCidadeCliente = new System.Windows.Forms.Label();
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
            this.btnSalvar.Location = new System.Drawing.Point(369, 11);
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
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(10, 104);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(175, 25);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome Completo :";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(183, 103);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(412, 30);
            this.txtNome.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtNome, "Digite o Nome do Cliente");
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(314, 326);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 23);
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
            // btnAddEndereco
            // 
            this.btnAddEndereco.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEndereco.Image")));
            this.btnAddEndereco.Location = new System.Drawing.Point(241, 231);
            this.btnAddEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEndereco.Name = "btnAddEndereco";
            this.btnAddEndereco.Size = new System.Drawing.Size(46, 47);
            this.btnAddEndereco.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnAddEndereco, "Adicionar Novo Endereço");
            this.btnAddEndereco.UseVisualStyleBackColor = true;
            this.btnAddEndereco.Click += new System.EventHandler(this.btnAddEndereco_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(91, 148);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(429, 30);
            this.txtEmail.TabIndex = 19;
            this.toolTip1.SetToolTip(this.txtEmail, "Digite aqui o E-mail");
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(131, 193);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(474, 30);
            this.txtEndereco.TabIndex = 25;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(718, 193);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(90, 30);
            this.txtNumero.TabIndex = 27;
            this.toolTip1.SetToolTip(this.txtNumero, "Digite o Número Residencial");
            // 
            // btnBuscaCep
            // 
            this.btnBuscaCep.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaCep.Image")));
            this.btnBuscaCep.Location = new System.Drawing.Point(191, 231);
            this.btnBuscaCep.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscaCep.Name = "btnBuscaCep";
            this.btnBuscaCep.Size = new System.Drawing.Size(46, 47);
            this.btnBuscaCep.TabIndex = 30;
            this.toolTip1.SetToolTip(this.btnBuscaCep, "Buscar Endereço");
            this.btnBuscaCep.UseVisualStyleBackColor = true;
            this.btnBuscaCep.Click += new System.EventHandler(this.btnBuscaCep_Click);
            // 
            // txtBairroCliente
            // 
            this.txtBairroCliente.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroCliente.Location = new System.Drawing.Point(369, 237);
            this.txtBairroCliente.Name = "txtBairroCliente";
            this.txtBairroCliente.Size = new System.Drawing.Size(166, 30);
            this.txtBairroCliente.TabIndex = 32;
            // 
            // txtCidadeCliente
            // 
            this.txtCidadeCliente.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeCliente.Location = new System.Drawing.Point(623, 238);
            this.txtCidadeCliente.Name = "txtCidadeCliente";
            this.txtCidadeCliente.Size = new System.Drawing.Size(186, 30);
            this.txtCidadeCliente.TabIndex = 34;
            // 
            // txtIdRua
            // 
            this.txtIdRua.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdRua.Location = new System.Drawing.Point(15, 198);
            this.txtIdRua.Name = "txtIdRua";
            this.txtIdRua.Size = new System.Drawing.Size(72, 21);
            this.txtIdRua.TabIndex = 35;
            this.toolTip1.SetToolTip(this.txtIdRua, "Digite aqui o Estado");
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(601, 104);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(62, 25);
            this.lblCpf.TabIndex = 16;
            this.lblCpf.Text = "CPF :";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(526, 148);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(91, 25);
            this.lblCelular.TabIndex = 20;
            this.lblCelular.Text = "Celular :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(10, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(85, 25);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "E-mail :";
            // 
            // mskCpf
            // 
            this.mskCpf.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.mskCpf.Location = new System.Drawing.Point(669, 104);
            this.mskCpf.Mask = "000,000,000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(140, 30);
            this.mskCpf.TabIndex = 22;
            this.toolTip1.SetToolTip(this.mskCpf, "Digite somente os números do CPF");
            // 
            // mskCelular
            // 
            this.mskCelular.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.mskCelular.Location = new System.Drawing.Point(623, 148);
            this.mskCelular.Mask = "+00 00 0 0000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(186, 30);
            this.mskCelular.TabIndex = 23;
            this.toolTip1.SetToolTip(this.mskCelular, "Digite o Celular");
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(12, 194);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(113, 25);
            this.lblEndereco.TabIndex = 24;
            this.lblEndereco.Text = "Endereço :";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(621, 194);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(100, 25);
            this.lblNumero.TabIndex = 26;
            this.lblNumero.Text = "Número :";
            // 
            // mskCep
            // 
            this.mskCep.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.mskCep.Location = new System.Drawing.Point(69, 237);
            this.mskCep.Mask = "00,000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(112, 30);
            this.mskCep.TabIndex = 29;
            this.toolTip1.SetToolTip(this.mskCep, "Digite o CEP");
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(9, 239);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(63, 25);
            this.lblCep.TabIndex = 28;
            this.lblCep.Text = "CEP :";
            // 
            // lblBairroCliente
            // 
            this.lblBairroCliente.AutoSize = true;
            this.lblBairroCliente.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairroCliente.Location = new System.Drawing.Point(287, 239);
            this.lblBairroCliente.Name = "lblBairroCliente";
            this.lblBairroCliente.Size = new System.Drawing.Size(82, 25);
            this.lblBairroCliente.TabIndex = 31;
            this.lblBairroCliente.Text = "Bairro :";
            // 
            // lblCidadeCliente
            // 
            this.lblCidadeCliente.AutoSize = true;
            this.lblCidadeCliente.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeCliente.Location = new System.Drawing.Point(536, 239);
            this.lblCidadeCliente.Name = "lblCidadeCliente";
            this.lblCidadeCliente.Size = new System.Drawing.Size(90, 25);
            this.lblCidadeCliente.TabIndex = 33;
            this.lblCidadeCliente.Text = "Cidade :";
            // 
            // frmClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 497);
            this.Controls.Add(this.txtCidadeCliente);
            this.Controls.Add(this.lblCidadeCliente);
            this.Controls.Add(this.txtBairroCliente);
            this.Controls.Add(this.lblBairroCliente);
            this.Controls.Add(this.mskCep);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.mskCelular);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.btnAddEndereco);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtIdRua);
            this.Controls.Add(this.btnBuscaCep);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmClienteView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnMostrarTodos;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAddEndereco;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Button btnBuscaCep;
        private System.Windows.Forms.TextBox txtBairroCliente;
        private System.Windows.Forms.Label lblBairroCliente;
        private System.Windows.Forms.TextBox txtCidadeCliente;
        private System.Windows.Forms.Label lblCidadeCliente;
        private System.Windows.Forms.TextBox txtIdRua;
    }
}