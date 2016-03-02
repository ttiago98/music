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
            this.button_sair = new System.Windows.Forms.PictureBox();
            this.button_arctic_monkeys = new System.Windows.Forms.Button();
            this.button_metalica = new System.Windows.Forms.Button();
            this.button_richie_campbell = new System.Windows.Forms.Button();
            this.youtube_player = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.button_voltar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.button_sair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.youtube_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_voltar)).BeginInit();
            this.SuspendLayout();
            // 
            // button_sair
            // 
            this.button_sair.BackColor = System.Drawing.Color.Transparent;
            this.button_sair.Image = ((System.Drawing.Image)(resources.GetObject("button_sair.Image")));
            this.button_sair.Location = new System.Drawing.Point(611, 349);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(75, 41);
            this.button_sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_sair.TabIndex = 15;
            this.button_sair.TabStop = false;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // button_arctic_monkeys
            // 
            this.button_arctic_monkeys.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_arctic_monkeys.BackgroundImage")));
            this.button_arctic_monkeys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_arctic_monkeys.Location = new System.Drawing.Point(565, 226);
            this.button_arctic_monkeys.Name = "button_arctic_monkeys";
            this.button_arctic_monkeys.Size = new System.Drawing.Size(121, 73);
            this.button_arctic_monkeys.TabIndex = 16;
            this.button_arctic_monkeys.UseVisualStyleBackColor = true;
            this.button_arctic_monkeys.Click += new System.EventHandler(this.button_arctic_monkeys_Click);
            // 
            // button_metalica
            // 
            this.button_metalica.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_metalica.BackgroundImage")));
            this.button_metalica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_metalica.Location = new System.Drawing.Point(565, 118);
            this.button_metalica.Name = "button_metalica";
            this.button_metalica.Size = new System.Drawing.Size(121, 73);
            this.button_metalica.TabIndex = 17;
            this.button_metalica.UseVisualStyleBackColor = true;
            this.button_metalica.Click += new System.EventHandler(this.button_metalica_Click);
            // 
            // button_richie_campbell
            // 
            this.button_richie_campbell.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_richie_campbell.BackgroundImage")));
            this.button_richie_campbell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_richie_campbell.ForeColor = System.Drawing.Color.White;
            this.button_richie_campbell.Location = new System.Drawing.Point(565, 12);
            this.button_richie_campbell.Name = "button_richie_campbell";
            this.button_richie_campbell.Size = new System.Drawing.Size(121, 73);
            this.button_richie_campbell.TabIndex = 18;
            this.button_richie_campbell.Text = "Richie Campbell";
            this.button_richie_campbell.UseVisualStyleBackColor = true;
            this.button_richie_campbell.Click += new System.EventHandler(this.button_richie_campbell_Click);
            // 
            // youtube_player
            // 
            this.youtube_player.Enabled = true;
            this.youtube_player.Location = new System.Drawing.Point(12, 12);
            this.youtube_player.Name = "youtube_player";
            this.youtube_player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("youtube_player.OcxState")));
            this.youtube_player.Size = new System.Drawing.Size(514, 287);
            this.youtube_player.TabIndex = 22;
            // 
            // button_voltar
            // 
            this.button_voltar.BackColor = System.Drawing.Color.Transparent;
            this.button_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_voltar.Image = ((System.Drawing.Image)(resources.GetObject("button_voltar.Image")));
            this.button_voltar.Location = new System.Drawing.Point(12, 349);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(65, 41);
            this.button_voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_voltar.TabIndex = 23;
            this.button_voltar.TabStop = false;
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
            // 
            // Leitor_video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(698, 402);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.youtube_player);
            this.Controls.Add(this.button_richie_campbell);
            this.Controls.Add(this.button_metalica);
            this.Controls.Add(this.button_arctic_monkeys);
            this.Controls.Add(this.button_sair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Leitor_video";
            this.Text = "Leitor de Vídeo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Leitor_video_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.button_sair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.youtube_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_voltar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox button_sair;
        private System.Windows.Forms.Button button_arctic_monkeys;
        private System.Windows.Forms.Button button_metalica;
        private System.Windows.Forms.Button button_richie_campbell;
        private AxShockwaveFlashObjects.AxShockwaveFlash youtube_player;
        private System.Windows.Forms.PictureBox button_voltar;
    }
}