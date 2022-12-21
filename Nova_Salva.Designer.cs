namespace SistemPlus
{
    partial class Nova_Salva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nova_Salva));
            this.btnNovaCotação = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCotSalvas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNovaCotação
            // 
            this.btnNovaCotação.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNovaCotação.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovaCotação.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovaCotação.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNovaCotação.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaCotação.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnNovaCotação.Image = ((System.Drawing.Image)(resources.GetObject("btnNovaCotação.Image")));
            this.btnNovaCotação.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovaCotação.Location = new System.Drawing.Point(225, 31);
            this.btnNovaCotação.Name = "btnNovaCotação";
            this.btnNovaCotação.Size = new System.Drawing.Size(116, 130);
            this.btnNovaCotação.TabIndex = 0;
            this.btnNovaCotação.Text = "Nova Cotação";
            this.btnNovaCotação.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovaCotação.UseVisualStyleBackColor = false;
            this.btnNovaCotação.Click += new System.EventHandler(this.btnNovaCotação_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnVoltar.Location = new System.Drawing.Point(140, 196);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(92, 31);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCotSalvas
            // 
            this.btnCotSalvas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCotSalvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCotSalvas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCotSalvas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCotSalvas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCotSalvas.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCotSalvas.Image = ((System.Drawing.Image)(resources.GetObject("btnCotSalvas.Image")));
            this.btnCotSalvas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCotSalvas.Location = new System.Drawing.Point(32, 31);
            this.btnCotSalvas.Name = "btnCotSalvas";
            this.btnCotSalvas.Size = new System.Drawing.Size(116, 130);
            this.btnCotSalvas.TabIndex = 6;
            this.btnCotSalvas.Text = "Cotações salvas";
            this.btnCotSalvas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCotSalvas.UseVisualStyleBackColor = false;
            this.btnCotSalvas.Click += new System.EventHandler(this.btnCotSalvas_Click);
            // 
            // Nova_Salva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(373, 239);
            this.Controls.Add(this.btnCotSalvas);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnNovaCotação);
            this.MaximizeBox = false;
            this.Name = "Nova_Salva";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova_Salva";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovaCotação;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCotSalvas;
    }
}