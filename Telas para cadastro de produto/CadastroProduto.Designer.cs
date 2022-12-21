namespace SistemPlus
{
    partial class CadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProduto));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgProduto = new System.Windows.Forms.DataGridView();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesquisarCategoria = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPesquisarEmbalagem = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtEmbalagem = new System.Windows.Forms.TextBox();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.txtIdEmbalagem = new System.Windows.Forms.TextBox();
            this.txtIdFornecedor = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPesquisarFornecedor = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroDeEmbalagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduto)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição do produto:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtDescricao.Location = new System.Drawing.Point(25, 100);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(635, 24);
            this.txtDescricao.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.Location = new System.Drawing.Point(25, 293);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(127, 33);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar.Location = new System.Drawing.Point(684, 649);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(92, 31);
            this.btnVoltar.TabIndex = 14;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgProduto);
            this.groupBox1.Controls.Add(this.btnPesquisa);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Location = new System.Drawing.Point(12, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 311);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // dtgProduto
            // 
            this.dtgProduto.AllowUserToAddRows = false;
            this.dtgProduto.AllowUserToDeleteRows = false;
            this.dtgProduto.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProduto.Location = new System.Drawing.Point(7, 19);
            this.dtgProduto.Name = "dtgProduto";
            this.dtgProduto.ReadOnly = true;
            this.dtgProduto.Size = new System.Drawing.Size(752, 286);
            this.dtgProduto.TabIndex = 4;
            this.dtgProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProduto_CellContentClick_1);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnPesquisa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisa.Image")));
            this.btnPesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisa.Location = new System.Drawing.Point(637, 19);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(113, 28);
            this.btnPesquisa.TabIndex = 3;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Visible = false;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(6, 19);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(618, 26);
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.Location = new System.Drawing.Point(640, 293);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(122, 33);
            this.btnExcluir.TabIndex = 28;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.Location = new System.Drawing.Point(364, 293);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(122, 33);
            this.btnAtualizar.TabIndex = 27;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtId
            // 
            this.txtId.Cursor = System.Windows.Forms.Cursors.No;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(711, 61);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(50, 20);
            this.txtId.TabIndex = 31;
            this.txtId.Visible = false;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(687, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "ID";
            this.label5.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.label3.Location = new System.Drawing.Point(24, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Categoria do produto:";
            // 
            // btnPesquisarCategoria
            // 
            this.btnPesquisarCategoria.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPesquisarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarCategoria.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnPesquisarCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarCategoria.Image")));
            this.btnPesquisarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisarCategoria.Location = new System.Drawing.Point(442, 169);
            this.btnPesquisarCategoria.Name = "btnPesquisarCategoria";
            this.btnPesquisarCategoria.Size = new System.Drawing.Size(106, 26);
            this.btnPesquisarCategoria.TabIndex = 33;
            this.btnPesquisarCategoria.Text = "Pesquisar";
            this.btnPesquisarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarCategoria.UseVisualStyleBackColor = false;
            this.btnPesquisarCategoria.TextChanged += new System.EventHandler(this.btnPesquisarCategoria_TextChanged);
            this.btnPesquisarCategoria.Click += new System.EventHandler(this.btnPesquisarCategoria_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.label4.Location = new System.Drawing.Point(16, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Embalagem do produto:";
            // 
            // btnPesquisarEmbalagem
            // 
            this.btnPesquisarEmbalagem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPesquisarEmbalagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarEmbalagem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisarEmbalagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarEmbalagem.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnPesquisarEmbalagem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisarEmbalagem.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarEmbalagem.Image")));
            this.btnPesquisarEmbalagem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisarEmbalagem.Location = new System.Drawing.Point(443, 201);
            this.btnPesquisarEmbalagem.Name = "btnPesquisarEmbalagem";
            this.btnPesquisarEmbalagem.Size = new System.Drawing.Size(105, 26);
            this.btnPesquisarEmbalagem.TabIndex = 35;
            this.btnPesquisarEmbalagem.Text = "Pesquisar";
            this.btnPesquisarEmbalagem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarEmbalagem.UseVisualStyleBackColor = false;
            this.btnPesquisarEmbalagem.Click += new System.EventHandler(this.btnPesquisarEmbalagem_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtCategoria.Location = new System.Drawing.Point(199, 171);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(237, 24);
            this.txtCategoria.TabIndex = 36;
            // 
            // txtEmbalagem
            // 
            this.txtEmbalagem.Enabled = false;
            this.txtEmbalagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtEmbalagem.Location = new System.Drawing.Point(200, 203);
            this.txtEmbalagem.Name = "txtEmbalagem";
            this.txtEmbalagem.Size = new System.Drawing.Size(237, 24);
            this.txtEmbalagem.TabIndex = 37;
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Enabled = false;
            this.txtIdCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtIdCategoria.Location = new System.Drawing.Point(176, 172);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(17, 24);
            this.txtIdCategoria.TabIndex = 38;
            this.txtIdCategoria.Visible = false;
            // 
            // txtIdEmbalagem
            // 
            this.txtIdEmbalagem.Enabled = false;
            this.txtIdEmbalagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtIdEmbalagem.Location = new System.Drawing.Point(177, 203);
            this.txtIdEmbalagem.Name = "txtIdEmbalagem";
            this.txtIdEmbalagem.Size = new System.Drawing.Size(17, 24);
            this.txtIdEmbalagem.TabIndex = 39;
            this.txtIdEmbalagem.Visible = false;
            // 
            // txtIdFornecedor
            // 
            this.txtIdFornecedor.Enabled = false;
            this.txtIdFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtIdFornecedor.Location = new System.Drawing.Point(177, 234);
            this.txtIdFornecedor.Name = "txtIdFornecedor";
            this.txtIdFornecedor.Size = new System.Drawing.Size(17, 24);
            this.txtIdFornecedor.TabIndex = 43;
            this.txtIdFornecedor.Visible = false;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFornecedor.Location = new System.Drawing.Point(200, 234);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(237, 24);
            this.txtFornecedor.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.label6.Location = new System.Drawing.Point(12, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "Fornecedor do produto:";
            // 
            // btnPesquisarFornecedor
            // 
            this.btnPesquisarFornecedor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPesquisarFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarFornecedor.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnPesquisarFornecedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisarFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarFornecedor.Image")));
            this.btnPesquisarFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisarFornecedor.Location = new System.Drawing.Point(443, 233);
            this.btnPesquisarFornecedor.Name = "btnPesquisarFornecedor";
            this.btnPesquisarFornecedor.Size = new System.Drawing.Size(105, 26);
            this.btnPesquisarFornecedor.TabIndex = 44;
            this.btnPesquisarFornecedor.Text = "Pesquisar";
            this.btnPesquisarFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarFornecedor.UseVisualStyleBackColor = false;
            this.btnPesquisarFornecedor.Click += new System.EventHandler(this.btnPesquisarFornecedor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeEmbalagemToolStripMenuItem,
            this.cadastroDeFornecedoresToolStripMenuItem,
            this.cadastroDeCategoriasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroDeEmbalagemToolStripMenuItem
            // 
            this.cadastroDeEmbalagemToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cadastroDeEmbalagemToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cadastroDeEmbalagemToolStripMenuItem.Name = "cadastroDeEmbalagemToolStripMenuItem";
            this.cadastroDeEmbalagemToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.cadastroDeEmbalagemToolStripMenuItem.Text = "Cadastro de Embalagem";
            this.cadastroDeEmbalagemToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeEmbalagemToolStripMenuItem_Click);
            // 
            // cadastroDeFornecedoresToolStripMenuItem
            // 
            this.cadastroDeFornecedoresToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cadastroDeFornecedoresToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cadastroDeFornecedoresToolStripMenuItem.Name = "cadastroDeFornecedoresToolStripMenuItem";
            this.cadastroDeFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(156, 20);
            this.cadastroDeFornecedoresToolStripMenuItem.Text = "Cadastro de Fornecedores";
            this.cadastroDeFornecedoresToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeFornecedoresToolStripMenuItem_Click);
            // 
            // cadastroDeCategoriasToolStripMenuItem
            // 
            this.cadastroDeCategoriasToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cadastroDeCategoriasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cadastroDeCategoriasToolStripMenuItem.Name = "cadastroDeCategoriasToolStripMenuItem";
            this.cadastroDeCategoriasToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.cadastroDeCategoriasToolStripMenuItem.Text = "Cadastro de Categorias";
            this.cadastroDeCategoriasToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeCategoriasToolStripMenuItem_Click);
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(788, 689);
            this.Controls.Add(this.btnPesquisarFornecedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtIdFornecedor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.btnPesquisarEmbalagem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmbalagem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtIdCategoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPesquisarCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdEmbalagem);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CadastroProduto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroProduto";
            this.Load += new System.EventHandler(this.CadastroProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduto)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPesquisarCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPesquisarEmbalagem;
        public System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtEmbalagem;
        public System.Windows.Forms.TextBox txtIdCategoria;
        public System.Windows.Forms.TextBox txtIdEmbalagem;
        public System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.TextBox txtIdFornecedor;
        public System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Button btnPesquisarFornecedor;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeEmbalagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeCategoriasToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtgProduto;
    }
}