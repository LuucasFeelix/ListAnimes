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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GunaPainelLateral = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAssistidos = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnAdicionar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnAssistindo = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnNaoAssistido = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PanelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.GunaPainelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // GunaPainelLateral
            // 
            this.GunaPainelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(128)))), ((int)(((byte)(144)))));
            this.GunaPainelLateral.Controls.Add(this.btnAssistidos);
            this.GunaPainelLateral.Controls.Add(this.btnAdicionar);
            this.GunaPainelLateral.Controls.Add(this.btnAssistindo);
            this.GunaPainelLateral.Controls.Add(this.btnNaoAssistido);
            this.GunaPainelLateral.Controls.Add(this.guna2PictureBox1);
            this.GunaPainelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.GunaPainelLateral.Location = new System.Drawing.Point(0, 0);
            this.GunaPainelLateral.Name = "GunaPainelLateral";
            this.GunaPainelLateral.Size = new System.Drawing.Size(57, 564);
            this.GunaPainelLateral.TabIndex = 1;
            // 
            // btnAssistidos
            // 
            this.btnAssistidos.BorderColor = System.Drawing.Color.Transparent;
            this.btnAssistidos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAssistidos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAssistidos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAssistidos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAssistidos.FillColor = System.Drawing.Color.Transparent;
            this.btnAssistidos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAssistidos.ForeColor = System.Drawing.Color.Transparent;
            this.btnAssistidos.Image = ((System.Drawing.Image)(resources.GetObject("btnAssistidos.Image")));
            this.btnAssistidos.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAssistidos.Location = new System.Drawing.Point(6, 257);
            this.btnAssistidos.Name = "btnAssistidos";
            this.btnAssistidos.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAssistidos.Size = new System.Drawing.Size(47, 46);
            this.btnAssistidos.TabIndex = 7;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BorderColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdicionar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdicionar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdicionar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdicionar.FillColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdicionar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAdicionar.Location = new System.Drawing.Point(6, 496);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAdicionar.Size = new System.Drawing.Size(47, 46);
            this.btnAdicionar.TabIndex = 6;
            // 
            // btnAssistindo
            // 
            this.btnAssistindo.BorderColor = System.Drawing.Color.Transparent;
            this.btnAssistindo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAssistindo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAssistindo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAssistindo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAssistindo.FillColor = System.Drawing.Color.Transparent;
            this.btnAssistindo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAssistindo.ForeColor = System.Drawing.Color.Transparent;
            this.btnAssistindo.Image = ((System.Drawing.Image)(resources.GetObject("btnAssistindo.Image")));
            this.btnAssistindo.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAssistindo.Location = new System.Drawing.Point(6, 146);
            this.btnAssistindo.Name = "btnAssistindo";
            this.btnAssistindo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAssistindo.Size = new System.Drawing.Size(47, 46);
            this.btnAssistindo.TabIndex = 5;
            // 
            // btnNaoAssistido
            // 
            this.btnNaoAssistido.BorderColor = System.Drawing.Color.Transparent;
            this.btnNaoAssistido.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNaoAssistido.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNaoAssistido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNaoAssistido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNaoAssistido.FillColor = System.Drawing.Color.Transparent;
            this.btnNaoAssistido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNaoAssistido.ForeColor = System.Drawing.Color.Transparent;
            this.btnNaoAssistido.Image = ((System.Drawing.Image)(resources.GetObject("btnNaoAssistido.Image")));
            this.btnNaoAssistido.ImageSize = new System.Drawing.Size(35, 35);
            this.btnNaoAssistido.Location = new System.Drawing.Point(6, 382);
            this.btnNaoAssistido.Name = "btnNaoAssistido";
            this.btnNaoAssistido.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnNaoAssistido.Size = new System.Drawing.Size(47, 46);
            this.btnNaoAssistido.TabIndex = 4;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(57, 60);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2PanelTop
            // 
            this.guna2PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(128)))), ((int)(((byte)(144)))));
            this.guna2PanelTop.Controls.Add(this.guna2TextBox1);
            this.guna2PanelTop.Controls.Add(this.guna2ControlBox3);
            this.guna2PanelTop.Controls.Add(this.guna2ControlBox2);
            this.guna2PanelTop.Controls.Add(this.guna2ControlBox1);
            this.guna2PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelTop.Location = new System.Drawing.Point(57, 0);
            this.guna2PanelTop.Name = "guna2PanelTop";
            this.guna2PanelTop.Size = new System.Drawing.Size(866, 45);
            this.guna2PanelTop.TabIndex = 2;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.BorderRadius = 12;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconLeft")));
            this.guna2TextBox1.IconLeftSize = new System.Drawing.Size(18, 18);
            this.guna2TextBox1.IconRightSize = new System.Drawing.Size(18, 18);
            this.guna2TextBox1.Location = new System.Drawing.Point(509, 6);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Search Anime";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(200, 27);
            this.guna2TextBox1.TabIndex = 4;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(749, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(35, 24);
            this.guna2ControlBox3.TabIndex = 3;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(790, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(35, 24);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(831, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(35, 24);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(383, 59);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 5;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(533, 500);
            this.guna2ShadowPanel1.TabIndex = 3;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2PanelTop;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(88, 63);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Radius = 5;
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Gray;
            this.guna2ShadowPanel2.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(254, 53);
            this.guna2ShadowPanel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(145)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(923, 564);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.guna2PanelTop);
            this.Controls.Add(this.GunaPainelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GunaPainelLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2PanelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Panel GunaPainelLateral;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelTop;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2CircleButton btnNaoAssistido;
        private Guna.UI2.WinForms.Guna2CircleButton btnAdicionar;
        private Guna.UI2.WinForms.Guna2CircleButton btnAssistindo;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2CircleButton btnAssistidos;
    }
}

