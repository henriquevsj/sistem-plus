namespace SistemPlus
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btnTelaCadastros = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCotacao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTelaCadastros
            // 
            this.btnTelaCadastros.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTelaCadastros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTelaCadastros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTelaCadastros.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTelaCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelaCadastros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaCadastros.ForeColor = System.Drawing.Color.Black;
            this.btnTelaCadastros.Image = ((System.Drawing.Image)(resources.GetObject("btnTelaCadastros.Image")));
            this.btnTelaCadastros.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTelaCadastros.Location = new System.Drawing.Point(12, 59);
            this.btnTelaCadastros.Name = "btnTelaCadastros";
            this.btnTelaCadastros.Size = new System.Drawing.Size(113, 109);
            this.btnTelaCadastros.TabIndex = 2;
            this.btnTelaCadastros.Text = "Cadastros";
            this.btnTelaCadastros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTelaCadastros.UseVisualStyleBackColor = false;
            this.btnTelaCadastros.Click += new System.EventHandler(this.btnTelaCadastros_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(131, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSair.Location = new System.Drawing.Point(676, 328);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(92, 31);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCotacao
            // 
            this.btnCotacao.BackColor = System.Drawing.Color.White;
            this.btnCotacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCotacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCotacao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCotacao.FlatAppearance.BorderSize = 3;
            this.btnCotacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCotacao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotacao.ForeColor = System.Drawing.Color.Black;
            this.btnCotacao.Image = ((System.Drawing.Image)(resources.GetObject("btnCotacao.Image")));
            this.btnCotacao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCotacao.Location = new System.Drawing.Point(655, 72);
            this.btnCotacao.Name = "btnCotacao";
            this.btnCotacao.Size = new System.Drawing.Size(113, 96);
            this.btnCotacao.TabIndex = 5;
            this.btnCotacao.Text = "Cotações";
            this.btnCotacao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCotacao.UseVisualStyleBackColor = false;
            this.btnCotacao.Click += new System.EventHandler(this.btnCotacao_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(780, 371);
            this.Controls.Add(this.btnCotacao);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnTelaCadastros);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTelaCadastros;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCotacao;
    }
}

