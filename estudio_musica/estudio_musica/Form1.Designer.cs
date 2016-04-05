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
            this.button_sair = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_leitor_musica = new System.Windows.Forms.PictureBox();
            this.button_leitor_radio = new System.Windows.Forms.PictureBox();
            this.button_artistas = new System.Windows.Forms.PictureBox();
            this.button_leitor_video = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.button_leitor_musica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_leitor_radio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_artistas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_leitor_video)).BeginInit();
            this.SuspendLayout();
            // 
            // button_sair
            // 
            this.button_sair.Location = new System.Drawing.Point(574, 426);
            this.button_sair.Name = "button_sair";
            this.button_sair.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_sair.Size = new System.Drawing.Size(75, 23);
            this.button_sair.TabIndex = 2;
            this.button_sair.Text = "Sair";
            this.button_sair.UseVisualStyleBackColor = false;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // button_leitor_musica
            // 
            this.button_leitor_musica.BackColor = System.Drawing.Color.Transparent;
            this.button_leitor_musica.Image = ((System.Drawing.Image)(resources.GetObject("button_leitor_musica.Image")));
            this.button_leitor_musica.Location = new System.Drawing.Point(93, 28);
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
            this.button_leitor_radio.Location = new System.Drawing.Point(415, 28);
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
            this.button_artistas.Location = new System.Drawing.Point(415, 212);
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
            this.button_leitor_video.Location = new System.Drawing.Point(93, 212);
            this.button_leitor_video.Name = "button_leitor_video";
            this.button_leitor_video.Size = new System.Drawing.Size(174, 147);
            this.button_leitor_video.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_leitor_video.TabIndex = 6;
            this.button_leitor_video.TabStop = false;
            this.button_leitor_video.Click += new System.EventHandler(this.button_leitor_video_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 461);
            this.Controls.Add(this.button_leitor_video);
            this.Controls.Add(this.button_artistas);
            this.Controls.Add(this.button_leitor_radio);
            this.Controls.Add(this.button_leitor_musica);
            this.Controls.Add(this.button_sair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Estúdio Música";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.button_leitor_musica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_leitor_radio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_artistas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_leitor_video)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox button_leitor_musica;
        private System.Windows.Forms.PictureBox button_leitor_radio;
        private System.Windows.Forms.PictureBox button_artistas;
        private System.Windows.Forms.PictureBox button_leitor_video;
    }
}

