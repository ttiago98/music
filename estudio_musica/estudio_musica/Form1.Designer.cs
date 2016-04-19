namespace estudio_musica
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_sair = new System.Windows.Forms.PictureBox();
            this.button_leitor_musica = new System.Windows.Forms.PictureBox();
            this.button_leitor_radio = new System.Windows.Forms.PictureBox();
            this.button_artistas = new System.Windows.Forms.PictureBox();
            this.button_leitor_video = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fechar = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.button_sair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_leitor_musica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_leitor_radio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_artistas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_leitor_video)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // button_sair
            // 
            this.button_sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_sair.BackColor = System.Drawing.Color.Transparent;
            this.button_sair.Image = ((System.Drawing.Image)(resources.GetObject("button_sair.Image")));
            this.button_sair.Location = new System.Drawing.Point(574, 437);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(75, 41);
            this.button_sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_sair.TabIndex = 16;
            this.button_sair.TabStop = false;
            this.toolTip1.SetToolTip(this.button_sair, "Fechar o Programa");
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // button_leitor_musica
            // 
            this.button_leitor_musica.BackColor = System.Drawing.Color.Transparent;
            this.button_leitor_musica.Image = ((System.Drawing.Image)(resources.GetObject("button_leitor_musica.Image")));
            this.button_leitor_musica.Location = new System.Drawing.Point(93, 75);
            this.button_leitor_musica.Name = "button_leitor_musica";
            this.button_leitor_musica.Size = new System.Drawing.Size(174, 147);
            this.button_leitor_musica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_leitor_musica.TabIndex = 3;
            this.button_leitor_musica.TabStop = false;
            this.button_leitor_musica.Click += new System.EventHandler(this.button_leitor_musica_Click);
            // 
            // button_leitor_radio
            // 
            this.button_leitor_radio.BackColor = System.Drawing.Color.Transparent;
            this.button_leitor_radio.Image = ((System.Drawing.Image)(resources.GetObject("button_leitor_radio.Image")));
            this.button_leitor_radio.Location = new System.Drawing.Point(402, 75);
            this.button_leitor_radio.Name = "button_leitor_radio";
            this.button_leitor_radio.Size = new System.Drawing.Size(174, 147);
            this.button_leitor_radio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_leitor_radio.TabIndex = 4;
            this.button_leitor_radio.TabStop = false;
            this.button_leitor_radio.Click += new System.EventHandler(this.button_leitor_radio_Click);
            // 
            // button_artistas
            // 
            this.button_artistas.BackColor = System.Drawing.Color.Transparent;
            this.button_artistas.Image = ((System.Drawing.Image)(resources.GetObject("button_artistas.Image")));
            this.button_artistas.Location = new System.Drawing.Point(415, 274);
            this.button_artistas.Name = "button_artistas";
            this.button_artistas.Size = new System.Drawing.Size(174, 147);
            this.button_artistas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_artistas.TabIndex = 5;
            this.button_artistas.TabStop = false;
            this.button_artistas.Click += new System.EventHandler(this.button_artistas_Click);
            // 
            // button_leitor_video
            // 
            this.button_leitor_video.BackColor = System.Drawing.Color.Transparent;
            this.button_leitor_video.Image = ((System.Drawing.Image)(resources.GetObject("button_leitor_video.Image")));
            this.button_leitor_video.Location = new System.Drawing.Point(93, 274);
            this.button_leitor_video.Name = "button_leitor_video";
            this.button_leitor_video.Size = new System.Drawing.Size(174, 147);
            this.button_leitor_video.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_leitor_video.TabIndex = 6;
            this.button_leitor_video.TabStop = false;
            this.button_leitor_video.Click += new System.EventHandler(this.button_leitor_video_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(672, 28);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // fechar
            // 
            this.fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fechar.BackgroundImage")));
            this.fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fechar.Location = new System.Drawing.Point(623, 0);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(26, 28);
            this.fechar.TabIndex = 48;
            this.fechar.UseVisualStyleBackColor = false;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(46, 7);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(104, 15);
            this.label.TabIndex = 50;
            this.label.Text = "Estudio de Música";
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icon.Cursor = System.Windows.Forms.Cursors.Default;
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(12, 3);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(28, 19);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 49;
            this.icon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 490);
            this.ControlBox = false;
            this.Controls.Add(this.label);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.button_leitor_video);
            this.Controls.Add(this.button_artistas);
            this.Controls.Add(this.button_leitor_radio);
            this.Controls.Add(this.button_leitor_musica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estúdio Música";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.button_sair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_leitor_musica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_leitor_radio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_artistas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_leitor_video)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox button_leitor_musica;
        private System.Windows.Forms.PictureBox button_leitor_radio;
        private System.Windows.Forms.PictureBox button_artistas;
        private System.Windows.Forms.PictureBox button_leitor_video;
        private System.Windows.Forms.PictureBox button_sair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button fechar;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox icon;
    }
}

