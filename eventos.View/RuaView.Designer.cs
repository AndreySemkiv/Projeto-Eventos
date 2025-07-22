namespace Eventos.View
{
    partial class frmRuaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRuaView));
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddBairro = new System.Windows.Forms.Button();
            this.lblBairro = new System.Windows.Forms.Label();
            this.cbbBairro = new System.Windows.Forms.ComboBox();
            this.lblCepRua = new System.Windows.Forms.Label();
            this.mskCepRua = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.AccessibleDescription = "";
            this.btnAdicionar.AccessibleName = "";
            this.btnAdicionar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(27, 44);
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
            this.btnSalvar.Location = new System.Drawing.Point(330, 44);
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
            this.btnEditar.Location = new System.Drawing.Point(229, 44);
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
            this.btnLocalizar.Location = new System.Drawing.Point(128, 44);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(83, 78);
            this.btnLocalizar.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnLocalizar, "Localizar");
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.Location = new System.Drawing.Point(59, 147);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(62, 25);
            this.lblRua.TabIndex = 4;
            this.lblRua.Text = "Rua :";
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(145, 146);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(350, 30);
            this.txtRua.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtRua, "Digite aqui o Rua");
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
            this.btnExcluir.Location = new System.Drawing.Point(438, 44);
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
            this.btnPesquisar.Location = new System.Drawing.Point(61, 281);
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
            this.btnSair.Location = new System.Drawing.Point(438, 396);
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
            this.btnLimpar.Location = new System.Drawing.Point(252, 281);
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
            this.dataGridView1.Location = new System.Drawing.Point(27, 380);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(398, 124);
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
            this.btnMostrarTodos.Location = new System.Drawing.Point(438, 281);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(83, 78);
            this.btnMostrarTodos.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnMostrarTodos, "Mostrar Todos");
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnAddBairro
            // 
            this.btnAddBairro.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBairro.Image")));
            this.btnAddBairro.Location = new System.Drawing.Point(499, 187);
            this.btnAddBairro.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddBairro.Name = "btnAddBairro";
            this.btnAddBairro.Size = new System.Drawing.Size(32, 30);
            this.btnAddBairro.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnAddBairro, "Adicionar Bairro");
            this.btnAddBairro.UseVisualStyleBackColor = true;
            this.btnAddBairro.Click += new System.EventHandler(this.btnAddBairro_Click);
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(59, 188);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(82, 25);
            this.lblBairro.TabIndex = 13;
            this.lblBairro.Text = "Bairro :";
            // 
            // cbbBairro
            // 
            this.cbbBairro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbBairro.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.cbbBairro.FormattingEnabled = true;
            this.cbbBairro.Location = new System.Drawing.Point(145, 187);
            this.cbbBairro.Margin = new System.Windows.Forms.Padding(2);
            this.cbbBairro.Name = "cbbBairro";
            this.cbbBairro.Size = new System.Drawing.Size(350, 31);
            this.cbbBairro.TabIndex = 14;
            // 
            // lblCepRua
            // 
            this.lblCepRua.AutoSize = true;
            this.lblCepRua.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCepRua.Location = new System.Drawing.Point(59, 231);
            this.lblCepRua.Name = "lblCepRua";
            this.lblCepRua.Size = new System.Drawing.Size(63, 25);
            this.lblCepRua.TabIndex = 16;
            this.lblCepRua.Text = "CEP :";
            // 
            // mskCepRua
            // 
            this.mskCepRua.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.mskCepRua.Location = new System.Drawing.Point(145, 230);
            this.mskCepRua.Mask = "00,000-000";
            this.mskCepRua.Name = "mskCepRua";
            this.mskCepRua.Size = new System.Drawing.Size(99, 30);
            this.mskCepRua.TabIndex = 17;
            // 
            // frmRuaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 524);
            this.Controls.Add(this.mskCepRua);
            this.Controls.Add(this.lblCepRua);
            this.Controls.Add(this.btnAddBairro);
            this.Controls.Add(this.cbbBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnAdicionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmRuaView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rua";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnMostrarTodos;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.ComboBox cbbBairro;
        private System.Windows.Forms.Button btnAddBairro;
        private System.Windows.Forms.Label lblCepRua;
        private System.Windows.Forms.MaskedTextBox mskCepRua;
    }
}