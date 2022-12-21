namespace SistemPlus.Cotacao
{
    partial class SelecionarProdutoCotacao
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
            this.dtgSelecionarProduto = new System.Windows.Forms.DataGridView();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.txtIdCotacao = new System.Windows.Forms.TextBox();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdEmbalagem = new System.Windows.Forms.TextBox();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSelecionarProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgSelecionarProduto
            // 
            this.dtgSelecionarProduto.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgSelecionarProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSelecionarProduto.Location = new System.Drawing.Point(13, 58);
            this.dtgSelecionarProduto.Name = "dtgSelecionarProduto";
            this.dtgSelecionarProduto.Size = new System.Drawing.Size(776, 392);
            this.dtgSelecionarProduto.TabIndex = 0;
            this.dtgSelecionarProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSelecionarProduto_CellContentClick);

            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSelecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSelecionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelecionar.Location = new System.Drawing.Point(673, 456);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(116, 31);
            this.btnSelecionar.TabIndex = 16;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // txtIdCotacao
            // 
            this.txtIdCotacao.Location = new System.Drawing.Point(112, 467);
            this.txtIdCotacao.Name = "txtIdCotacao";
            this.txtIdCotacao.Size = new System.Drawing.Size(100, 20);
            this.txtIdCotacao.TabIndex = 17;
            this.txtIdCotacao.Visible = false;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(112, 493);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(100, 20);
            this.txtIdProduto.TabIndex = 18;
            this.txtIdProduto.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Selecionar Produto";
            // 
            // txtIdEmbalagem
            // 
            this.txtIdEmbalagem.Location = new System.Drawing.Point(112, 548);
            this.txtIdEmbalagem.Name = "txtIdEmbalagem";
            this.txtIdEmbalagem.Size = new System.Drawing.Size(100, 20);
            this.txtIdEmbalagem.TabIndex = 21;
            this.txtIdEmbalagem.Visible = false;
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Location = new System.Drawing.Point(112, 522);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtIdCategoria.TabIndex = 20;
            this.txtIdCategoria.Visible = false;
            // 
            // SelecionarProdutoCotacao
            // 
            this.AcceptButton = this.btnSelecionar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(801, 493);
            this.Controls.Add(this.txtIdEmbalagem);
            this.Controls.Add(this.txtIdCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.txtIdCotacao);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.dtgSelecionarProduto);
            this.MaximizeBox = false;
            this.Name = "SelecionarProdutoCotacao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Selecionar_produto";
            this.Load += new System.EventHandler(this.SelecionarProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSelecionarProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgSelecionarProduto;
        private System.Windows.Forms.Button btnSelecionar;
        public System.Windows.Forms.TextBox txtIdCotacao;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdEmbalagem;
        public System.Windows.Forms.TextBox txtIdCategoria;
    }
}