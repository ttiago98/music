namespace estudio_musica
{
    partial class leitor_video2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(leitor_video2));
            this.youtube_player = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.textBox_pesquisa = new System.Windows.Forms.TextBox();
            this.button_voltar = new System.Windows.Forms.PictureBox();
            this.button_sair = new System.Windows.Forms.PictureBox();
            this.button_richie_campbell = new System.Windows.Forms.Button();
            this.button_metalica = new System.Windows.Forms.Button();
            this.button_arctic_monkeys = new System.Windows.Forms.Button();
            this.button_pesquisar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.youtube_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_sair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_pesquisar)).BeginInit();
            this.SuspendLayout();
            // 
            // youtube_player
            // 
            this.youtube_player.Enabled = true;
            this.youtube_player.Location = new System.Drawing.Point(44, 39);
            this.youtube_player.Name = "youtube_player";
            this.youtube_player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("youtube_player.OcxState")));
            this.youtube_player.Size = new System.Drawing.Size(506, 326);
            this.youtube_player.TabIndex = 0;
            // 
            // textBox_pesquisa
            // 
            this.textBox_pesquisa.Location = new System.Drawing.Point(588, 284);
            this.textBox_pesquisa.Name = "textBox_pesquisa";
            this.textBox_pesquisa.Size = new System.Drawing.Size(335, 20);
            this.textBox_pesquisa.TabIndex = 5;
            // 
            // button_voltar
            // 
            this.button_voltar.BackColor = System.Drawing.Color.Transparent;
            this.button_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_voltar.Image = ((System.Drawing.Image)(resources.GetObject("button_voltar.Image")));
            this.button_voltar.Location = new System.Drawing.Point(12, 395);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(65, 41);
            this.button_voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_voltar.TabIndex = 14;
            this.button_voltar.TabStop = false;
            this.toolTip1.SetToolTip(this.button_voltar, "Voltar atrás");
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
            // 
            // button_sair
            // 
            this.button_sair.BackColor = System.Drawing.Color.Transparent;
            this.button_sair.Image = ((System.Drawing.Image)(resources.GetObject("button_sair.Image")));
            this.button_sair.Location = new System.Drawing.Point(865, 395);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(75, 41);
            this.button_sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_sair.TabIndex = 15;
            this.button_sair.TabStop = false;
            this.toolTip1.SetToolTip(this.button_sair, "Sair do porgrama");
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // button_richie_campbell
            // 
            this.button_richie_campbell.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_richie_campbell.BackgroundImage")));
            this.button_richie_campbell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_richie_campbell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_richie_campbell.ForeColor = System.Drawing.Color.White;
            this.button_richie_campbell.Location = new System.Drawing.Point(588, 169);
            this.button_richie_campbell.Name = "button_richie_campbell";
            this.button_richie_campbell.Size = new System.Drawing.Size(148, 72);
            this.button_richie_campbell.TabIndex = 21;
            this.button_richie_campbell.Text = "Richie Campbell";
            this.button_richie_campbell.UseVisualStyleBackColor = true;
            this.button_richie_campbell.Click += new System.EventHandler(this.button_richie_campbell_Click);
            // 
            // button_metalica
            // 
            this.button_metalica.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_metalica.BackgroundImage")));
            this.button_metalica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_metalica.Location = new System.Drawing.Point(775, 39);
            this.button_metalica.Name = "button_metalica";
            this.button_metalica.Size = new System.Drawing.Size(148, 72);
            this.button_metalica.TabIndex = 20;
            this.button_metalica.UseVisualStyleBackColor = true;
            this.button_metalica.Click += new System.EventHandler(this.button_metalica_Click);
            // 
            // button_arctic_monkeys
            // 
            this.button_arctic_monkeys.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_arctic_monkeys.BackgroundImage")));
            this.button_arctic_monkeys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_arctic_monkeys.Location = new System.Drawing.Point(588, 39);
            this.button_arctic_monkeys.Name = "button_arctic_monkeys";
            this.button_arctic_monkeys.Size = new System.Drawing.Size(148, 72);
            this.button_arctic_monkeys.TabIndex = 19;
            this.button_arctic_monkeys.UseVisualStyleBackColor = true;
            this.button_arctic_monkeys.Click += new System.EventHandler(this.button_arctic_monkeys_Click);
            // 
            // button_pesquisar
            // 
            this.button_pesquisar.BackColor = System.Drawing.Color.Transparent;
            this.button_pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("button_pesquisar.Image")));
            this.button_pesquisar.Location = new System.Drawing.Point(667, 310);
            this.button_pesquisar.Name = "button_pesquisar";
            this.button_pesquisar.Size = new System.Drawing.Size(196, 68);
            this.button_pesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_pesquisar.TabIndex = 27;
            this.button_pesquisar.TabStop = false;
            this.button_pesquisar.Click += new System.EventHandler(this.button_pesquisar_Click);
            // 
            // leitor_video2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(952, 448);
            this.Controls.Add(this.button_pesquisar);
            this.Controls.Add(this.button_richie_campbell);
            this.Controls.Add(this.button_metalica);
            this.Controls.Add(this.button_arctic_monkeys);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.textBox_pesquisa);
            this.Controls.Add(this.youtube_player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "leitor_video2";
            this.Text = "Leitor de Vídeo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.leitor_video2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.youtube_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_voltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_sair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_pesquisar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxShockwaveFlashObjects.AxShockwaveFlash youtube_player;
        private System.Windows.Forms.TextBox textBox_pesquisa;
        private System.Windows.Forms.PictureBox button_voltar;
        private System.Windows.Forms.PictureBox button_sair;
        private System.Windows.Forms.Button button_richie_campbell;
        private System.Windows.Forms.Button button_metalica;
        private System.Windows.Forms.Button button_arctic_monkeys;
        private System.Windows.Forms.PictureBox button_pesquisar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}