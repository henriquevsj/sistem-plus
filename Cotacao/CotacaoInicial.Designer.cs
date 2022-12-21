namespace SistemPlus
{
    partial class Cotação
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cotação));
            this.btnSelecionarProduto = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnPlanilha = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dtgCotacao = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCotacao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelecionarProduto
            // 
            this.btnSelecionarProduto.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSelecionarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarProduto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSelecionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarProduto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSelecionarProduto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelecionarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarProduto.Image")));
            this.btnSelecionarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecionarProduto.Location = new System.Drawing.Point(8, 81);
            this.btnSelecionarProduto.Name = "btnSelecionarProduto";
            this.btnSelecionarProduto.Size = new System.Drawing.Size(203, 33);
            this.btnSelecionarProduto.TabIndex = 1;
            this.btnSelecionarProduto.Text = "Selecionar produtos";
            this.btnSelecionarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionarProduto.UseVisualStyleBackColor = false;
            this.btnSelecionarProduto.Click += new System.EventHandler(this.btnSelecionarProduto_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemover.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemover.Location = new System.Drawing.Point(589, 82);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(257, 33);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "Remover item selecionado";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnPlanilha
            // 
            this.btnPlanilha.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPlanilha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlanilha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanilha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnPlanilha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlanilha.Image = ((System.Drawing.Image)(resources.GetObject("btnPlanilha.Image")));
            this.btnPlanilha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlanilha.Location = new System.Drawing.Point(130, 635);
            this.btnPlanilha.Name = "btnPlanilha";
            this.btnPlanilha.Size = new System.Drawing.Size(163, 41);
            this.btnPlanilha.TabIndex = 9;
            this.btnPlanilha.Text = "Gerar planilha";
            this.btnPlanilha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanilha.UseVisualStyleBackColor = false;
            this.btnPlanilha.Click += new System.EventHandler(this.btnPlanilha_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(299, 635);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(139, 41);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar e sair";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.Location = new System.Drawing.Point(12, 635);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(116, 41);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(401, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cotação";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar.Location = new System.Drawing.Point(688, 640);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(158, 31);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "Sair sem salvar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dtgCotacao
            // 
            this.dtgCotacao.AllowUserToAddRows = false;
            this.dtgCotacao.AllowUserToDeleteRows = false;
            this.dtgCotacao.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgCotacao.Location = new System.Drawing.Point(12, 121);
            this.dtgCotacao.Name = "dtgCotacao";
            this.dtgCotacao.ReadOnly = true;
            this.dtgCotacao.Size = new System.Drawing.Size(841, 491);
            this.dtgCotacao.TabIndex = 18;
            this.dtgCotacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(791, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id:";
            this.label1.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(816, 33);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(37, 20);
            this.txtId.TabIndex = 6;
            this.txtId.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Cotação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(865, 688);
            this.Controls.Add(this.dtgCotacao);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnPlanilha);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnSelecionarProduto);
            this.MaximizeBox = false;
            this.Name = "Cotação";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotação";
            this.Load += new System.EventHandler(this.Cotação_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCotacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelecionarProduto;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnPlanilha;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVoltar;
        public System.Windows.Forms.DataGridView dtgCotacao;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtId;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}