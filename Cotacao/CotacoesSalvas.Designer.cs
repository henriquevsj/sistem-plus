namespace SistemPlus.Cotacao
{
    partial class CotacoesSalvas
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
            this.dtgCotacoesSalvas = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCotacoesSalvas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCotacoesSalvas
            // 
            this.dtgCotacoesSalvas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgCotacoesSalvas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCotacoesSalvas.Location = new System.Drawing.Point(12, 46);
            this.dtgCotacoesSalvas.Name = "dtgCotacoesSalvas";
            this.dtgCotacoesSalvas.Size = new System.Drawing.Size(776, 392);
            this.dtgCotacoesSalvas.TabIndex = 0;
            this.dtgCotacoesSalvas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCotacoesSalvas_CellContentClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar.Location = new System.Drawing.Point(696, 444);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(92, 31);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Selecione a cotação que deseja abrir:";
            // 
            // CotacoesSalvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dtgCotacoesSalvas);
            this.MaximizeBox = false;
            this.Name = "CotacoesSalvas";
            this.ShowIcon = false;
            this.Text = "CotacoesSalvas";
            this.Load += new System.EventHandler(this.CotacoesSalvas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCotacoesSalvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCotacoesSalvas;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
    }
}