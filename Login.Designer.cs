namespace SistemPlus
{
    partial class Login
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
            this.ButtonLogar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxUser = new System.Windows.Forms.TextBox();
            this.TextBoxSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonLogar
            // 
            this.ButtonLogar.Location = new System.Drawing.Point(223, 80);
            this.ButtonLogar.Name = "ButtonLogar";
            this.ButtonLogar.Size = new System.Drawing.Size(75, 23);
            this.ButtonLogar.TabIndex = 0;
            this.ButtonLogar.Text = "Logar";
            this.ButtonLogar.UseVisualStyleBackColor = true;
            this.ButtonLogar.Click += new System.EventHandler(this.ButtonLogar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User:";
            // 
            // TextBoxUser
            // 
            this.TextBoxUser.Location = new System.Drawing.Point(71, 27);
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.Size = new System.Drawing.Size(100, 20);
            this.TextBoxUser.TabIndex = 2;
            // 
            // TextBoxSenha
            // 
            this.TextBoxSenha.Location = new System.Drawing.Point(71, 80);
            this.TextBoxSenha.Name = "TextBoxSenha";
            this.TextBoxSenha.Size = new System.Drawing.Size(100, 20);
            this.TextBoxSenha.TabIndex = 3;
            this.TextBoxSenha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 148);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxSenha);
            this.Controls.Add(this.TextBoxUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonLogar);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonLogar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxUser;
        private System.Windows.Forms.TextBox TextBoxSenha;
        private System.Windows.Forms.Label label2;
    }
}