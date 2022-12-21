namespace SistemPlus.Telas_para_cadastro_de_produto
{
    partial class PesquisarFornecedor
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
            this.txtIdFornecedor = new System.Windows.Forms.TextBox();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.txtIdEmbalagem = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtEmbalagem = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgFornecedor = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdFornecedor
            // 
            this.txtIdFornecedor.Enabled = false;
            this.txtIdFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtIdFornecedor.Location = new System.Drawing.Point(16, 419);
            this.txtIdFornecedor.Name = "txtIdFornecedor";
            this.txtIdFornecedor.Size = new System.Drawing.Size(10, 24);
            this.txtIdFornecedor.TabIndex = 56;
            this.txtIdFornecedor.Visible = false;
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Enabled = false;
            this.txtIdCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtIdCategoria.Location = new System.Drawing.Point(16, 367);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(10, 24);
            this.txtIdCategoria.TabIndex = 54;
            this.txtIdCategoria.Visible = false;
            // 
            // txtIdEmbalagem
            // 
            this.txtIdEmbalagem.Enabled = false;
            this.txtIdEmbalagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtIdEmbalagem.Location = new System.Drawing.Point(16, 393);
            this.txtIdEmbalagem.Name = "txtIdEmbalagem";
            this.txtIdEmbalagem.Size = new System.Drawing.Size(10, 24);
            this.txtIdEmbalagem.TabIndex = 55;
            this.txtIdEmbalagem.Visible = false;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(54, 423);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(30, 20);
            this.txtFornecedor.TabIndex = 53;
            this.txtFornecedor.Visible = false;
            // 
            // txtEmbalagem
            // 
            this.txtEmbalagem.Location = new System.Drawing.Point(54, 397);
            this.txtEmbalagem.Name = "txtEmbalagem";
            this.txtEmbalagem.Size = new System.Drawing.Size(30, 20);
            this.txtEmbalagem.TabIndex = 52;
            this.txtEmbalagem.Visible = false;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(53, 371);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(30, 20);
            this.txtCategoria.TabIndex = 51;
            this.txtCategoria.Visible = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(53, 345);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(30, 20);
            this.txtDescricao.TabIndex = 50;
            this.txtDescricao.Visible = false;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSelecionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelecionar.Location = new System.Drawing.Point(364, 294);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(104, 36);
            this.btnSelecionar.TabIndex = 49;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Selecione o fornecedor:";
            // 
            // dtgFornecedor
            // 
            this.dtgFornecedor.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFornecedor.Location = new System.Drawing.Point(12, 32);
            this.dtgFornecedor.Name = "dtgFornecedor";
            this.dtgFornecedor.Size = new System.Drawing.Size(456, 256);
            this.dtgFornecedor.TabIndex = 47;
            this.dtgFornecedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCategoria_CellContentClick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(122, 345);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(30, 20);
            this.txtId.TabIndex = 57;
            this.txtId.Visible = false;
            // 
            // PesquisarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(480, 338);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtIdFornecedor);
            this.Controls.Add(this.txtIdCategoria);
            this.Controls.Add(this.txtIdEmbalagem);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.txtEmbalagem);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgFornecedor);
            this.Name = "PesquisarFornecedor";
            this.Text = "PesquisarFornecedor";
            this.Load += new System.EventHandler(this.PesquisarFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtIdFornecedor;
        public System.Windows.Forms.TextBox txtIdCategoria;
        public System.Windows.Forms.TextBox txtIdEmbalagem;
        public System.Windows.Forms.TextBox txtFornecedor;
        public System.Windows.Forms.TextBox txtEmbalagem;
        public System.Windows.Forms.TextBox txtCategoria;
        public System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgFornecedor;
        public System.Windows.Forms.TextBox txtId;
    }
}