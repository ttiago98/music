namespace estudio_musica
{
    partial class Leitor_video
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leitor_video));
            this.listBox_playlist = new System.Windows.Forms.ListBox();
            this.button_sair = new System.Windows.Forms.PictureBox();
            this.button_voltar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.button_sair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_voltar)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_playlist
            // 
            this.listBox_playlist.FormattingEnabled = true;
            this.listBox_playlist.Location = new System.Drawing.Point(12, 12);
            this.listBox_playlist.Name = "listBox_playlist";
            this.listBox_playlist.Size = new System.Drawing.Size(123, 199);
            this.listBox_playlist.TabIndex = 0;
            // 
            // button_sair
            // 
            this.button_sair.BackColor = System.Drawing.Color.Transparent;
            this.button_sair.Image = ((System.Drawing.Image)(resources.GetObject("button_sair.Image")));
            this.button_sair.Location = new System.Drawing.Point(563, 358);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(75, 41);
            this.button_sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_sair.TabIndex = 9;
            this.button_sair.TabStop = false;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // button_voltar
            // 
            this.button_voltar.BackColor = System.Drawing.Color.Transparent;
            this.button_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_voltar.Image = ((System.Drawing.Image)(resources.GetObject("button_voltar.Image")));
            this.button_voltar.Location = new System.Drawing.Point(12, 358);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(64, 41);
            this.button_voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_voltar.TabIndex = 14;
            this.button_voltar.TabStop = false;
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
            // 
            // Leitor_video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 411);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.listBox_playlist);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Leitor_video";
            this.Text = "Leitor de video";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Leitor_video_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.button_sair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_voltar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_playlist;
        private System.Windows.Forms.PictureBox button_sair;
        private System.Windows.Forms.PictureBox button_voltar;
    }
}