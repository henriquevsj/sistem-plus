namespace SistemPlus.Telas_para_cadastro_de_produto
{
    partial class PesquisarEmbalagem
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgEmbalagem = new System.Windows.Forms.DataGridView();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.txtIdFornecedor = new System.Windows.Forms.TextBox();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.txtIdEmbalagem = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtEmbalagem = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmbalagem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione a embalagem:";
            // 
            // dtgEmbalagem
            // 
            this.dtgEmbalagem.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgEmbalagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmbalagem.Location = new System.Drawing.Point(12, 41);
            this.dtgEmbalagem.Name = "dtgEmbalagem";
            this.dtgEmbalagem.Size = new System.Drawing.Size(448, 251);
            this.dtgEmbalagem.TabIndex = 5;
            this.dtgEmbalagem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEmbalagens_CellContentClick);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSelecionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelecionar.Location = new System.Drawing.Point(356, 298);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(104, 34);
            this.btnSelecionar.TabIndex = 7;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // txtIdFornecedor
            // 
            this.txtIdFornecedor.Enabled = false;
            this.txtIdFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtIdFornecedor.Location = new System.Drawing.Point(22, 424);
            this.txtIdFornecedor.Name = "txtIdFornecedor";
            this.txtIdFornecedor.Size = new System.Drawing.Size(10, 24);
            this.txtIdFornecedor.TabIndex = 53;
            this.txtIdFornecedor.Visible = false;
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Enabled = false;
            this.txtIdCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtIdCategoria.Location = new System.Drawing.Point(22, 372);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(10, 24);
            this.txtIdCategoria.TabIndex = 51;
            this.txtIdCategoria.Visible = false;
            // 
            // txtIdEmbalagem
            // 
            this.txtIdEmbalagem.Enabled = false;
            this.txtIdEmbalagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtIdEmbalagem.Location = new System.Drawing.Point(22, 398);
            this.txtIdEmbalagem.Name = "txtIdEmbalagem";
            this.txtIdEmbalagem.Size = new System.Drawing.Size(10, 24);
            this.txtIdEmbalagem.TabIndex = 52;
            this.txtIdEmbalagem.Visible = false;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(60, 428);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(33, 20);
            this.txtFornecedor.TabIndex = 50;
            this.txtFornecedor.Visible = false;
            // 
            // txtEmbalagem
            // 
            this.txtEmbalagem.Location = new System.Drawing.Point(60, 402);
            this.txtEmbalagem.Name = "txtEmbalagem";
            this.txtEmbalagem.Size = new System.Drawing.Size(33, 20);
            this.txtEmbalagem.TabIndex = 49;
            this.txtEmbalagem.Visible = false;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(59, 376);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(33, 20);
            this.txtCategoria.TabIndex = 48;
            this.txtCategoria.Visible = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(59, 350);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(33, 20);
            this.txtDescricao.TabIndex = 47;
            this.txtDescricao.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(113, 350);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(30, 20);
            this.txtId.TabIndex = 54;
            this.txtId.Visible = false;
            // 
            // PesquisarEmbalagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(477, 336);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtIdFornecedor);
            this.Controls.Add(this.txtIdCategoria);
            this.Controls.Add(this.txtIdEmbalagem);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.txtEmbalagem);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.dtgEmbalagem);
            this.Controls.Add(this.label1);
            this.Name = "PesquisarEmbalagem";
            this.Text = "PesquisaEmbalagem";
            this.Load += new System.EventHandler(this.PesquisarEmbalagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmbalagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgEmbalagem;
        private System.Windows.Forms.Button btnSelecionar;
        public System.Windows.Forms.TextBox txtIdFornecedor;
        public System.Windows.Forms.TextBox txtIdCategoria;
        public System.Windows.Forms.TextBox txtIdEmbalagem;
        public System.Windows.Forms.TextBox txtFornecedor;
        public System.Windows.Forms.TextBox txtEmbalagem;
        public System.Windows.Forms.TextBox txtCategoria;
        public System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.TextBox txtId;
    }
}