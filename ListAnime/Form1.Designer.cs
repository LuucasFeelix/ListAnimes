namespace ListAnime
{
    partial class Form1
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
            this.painelLateral = new System.Windows.Forms.Panel();
            this.imgListAnime = new System.Windows.Forms.PictureBox();
            this.btnAssistido = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.painelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgListAnime)).BeginInit();
            this.SuspendLayout();
            // 
            // painelLateral
            // 
            this.painelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(128)))), ((int)(((byte)(144)))));
            this.painelLateral.Controls.Add(this.button2);
            this.painelLateral.Controls.Add(this.button1);
            this.painelLateral.Controls.Add(this.btnAssistido);
            this.painelLateral.Controls.Add(this.imgListAnime);
            this.painelLateral.Location = new System.Drawing.Point(0, 0);
            this.painelLateral.Name = "painelLateral";
            this.painelLateral.Size = new System.Drawing.Size(215, 604);
            this.painelLateral.TabIndex = 0;
            // 
            // imgListAnime
            // 
            this.imgListAnime.Image = global::ListAnime.Properties.Resources.Logo1;
            this.imgListAnime.Location = new System.Drawing.Point(12, 22);
            this.imgListAnime.Name = "imgListAnime";
            this.imgListAnime.Size = new System.Drawing.Size(175, 47);
            this.imgListAnime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgListAnime.TabIndex = 0;
            this.imgListAnime.TabStop = false;
            // 
            // btnAssistido
            // 
            this.btnAssistido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(145)))), ((int)(((byte)(161)))));
            this.btnAssistido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAssistido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAssistido.ForeColor = System.Drawing.Color.White;
            this.btnAssistido.Location = new System.Drawing.Point(0, 152);
            this.btnAssistido.Name = "btnAssistido";
            this.btnAssistido.Size = new System.Drawing.Size(187, 47);
            this.btnAssistido.TabIndex = 1;
            this.btnAssistido.Text = "Animes Assistidos";
            this.btnAssistido.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(145)))), ((int)(((byte)(161)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Animes Para Assistir";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(145)))), ((int)(((byte)(161)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "Adicionar Anime";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(145)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(553, 604);
            this.Controls.Add(this.painelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.painelLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgListAnime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelLateral;
        private System.Windows.Forms.PictureBox imgListAnime;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAssistido;
    }
}

