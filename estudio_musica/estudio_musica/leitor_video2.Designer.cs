namespace estudio_musica
{
    partial class leitor_video
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(leitor_video));
            this.youtube_player = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.textBox_pesquisa = new System.Windows.Forms.TextBox();
            this.button_voltar = new System.Windows.Forms.PictureBox();
            this.button_sair = new System.Windows.Forms.PictureBox();
            this.button_richie_campbell = new System.Windows.Forms.Button();
            this.button_metalica = new System.Windows.Forms.Button();
            this.button_arctic_monkeys = new System.Windows.Forms.Button();
            this.button_pesquisar = new System.Windows.Forms.PictureBox();
            this.video_player = new AxWMPLib.AxWindowsMediaPlayer();
            this.button_youtube_player = new System.Windows.Forms.PictureBox();
            this.button_video_player = new System.Windows.Forms.PictureBox();
            this.trackBar_volume = new System.Windows.Forms.TrackBar();
            this.label_volume = new System.Windows.Forms.Label();
            this.button_play = new System.Windows.Forms.PictureBox();
            this.button_recuar = new System.Windows.Forms.PictureBox();
            this.button_avancar = new System.Windows.Forms.PictureBox();
            this.button_pausa = new System.Windows.Forms.PictureBox();
            this.button_mute = new System.Windows.Forms.PictureBox();
            this.button_abrir = new System.Windows.Forms.PictureBox();
            this.trackBar_video = new System.Windows.Forms.TrackBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_duracao = new System.Windows.Forms.Label();
            this.label_tempo = new System.Windows.Forms.Label();
            this.label_separador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.youtube_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_sair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_pesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.video_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_youtube_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_video_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_recuar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_avancar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_pausa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_mute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_abrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_video)).BeginInit();
            this.SuspendLayout();
            // 
            // youtube_player
            // 
            this.youtube_player.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.youtube_player.Enabled = true;
            this.youtube_player.Location = new System.Drawing.Point(43, 169);
            this.youtube_player.Name = "youtube_player";
            this.youtube_player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("youtube_player.OcxState")));
            this.youtube_player.Size = new System.Drawing.Size(622, 372);
            this.youtube_player.TabIndex = 0;
            // 
            // textBox_pesquisa
            // 
            this.textBox_pesquisa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox_pesquisa.Location = new System.Drawing.Point(711, 438);
            this.textBox_pesquisa.Name = "textBox_pesquisa";
            this.textBox_pesquisa.Size = new System.Drawing.Size(335, 20);
            this.textBox_pesquisa.TabIndex = 5;
            // 
            // button_voltar
            // 
            this.button_voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_voltar.BackColor = System.Drawing.Color.Transparent;
            this.button_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_voltar.Image = ((System.Drawing.Image)(resources.GetObject("button_voltar.Image")));
            this.button_voltar.Location = new System.Drawing.Point(12, 605);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(65, 41);
            this.button_voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_voltar.TabIndex = 14;
            this.button_voltar.TabStop = false;
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
            // 
            // button_sair
            // 
            this.button_sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_sair.BackColor = System.Drawing.Color.Transparent;
            this.button_sair.Image = ((System.Drawing.Image)(resources.GetObject("button_sair.Image")));
            this.button_sair.Location = new System.Drawing.Point(985, 605);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(75, 41);
            this.button_sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_sair.TabIndex = 15;
            this.button_sair.TabStop = false;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // button_richie_campbell
            // 
            this.button_richie_campbell.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_richie_campbell.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_richie_campbell.BackgroundImage")));
            this.button_richie_campbell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_richie_campbell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_richie_campbell.ForeColor = System.Drawing.Color.White;
            this.button_richie_campbell.Location = new System.Drawing.Point(711, 327);
            this.button_richie_campbell.Name = "button_richie_campbell";
            this.button_richie_campbell.Size = new System.Drawing.Size(148, 72);
            this.button_richie_campbell.TabIndex = 21;
            this.button_richie_campbell.Text = "Richie Campbell";
            this.button_richie_campbell.UseVisualStyleBackColor = true;
            this.button_richie_campbell.Click += new System.EventHandler(this.button_richie_campbell_Click);
            // 
            // button_metalica
            // 
            this.button_metalica.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_metalica.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_metalica.BackgroundImage")));
            this.button_metalica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_metalica.Location = new System.Drawing.Point(898, 191);
            this.button_metalica.Name = "button_metalica";
            this.button_metalica.Size = new System.Drawing.Size(148, 72);
            this.button_metalica.TabIndex = 20;
            this.button_metalica.UseVisualStyleBackColor = true;
            this.button_metalica.Click += new System.EventHandler(this.button_metalica_Click);
            // 
            // button_arctic_monkeys
            // 
            this.button_arctic_monkeys.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_arctic_monkeys.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_arctic_monkeys.BackgroundImage")));
            this.button_arctic_monkeys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_arctic_monkeys.Location = new System.Drawing.Point(711, 191);
            this.button_arctic_monkeys.Name = "button_arctic_monkeys";
            this.button_arctic_monkeys.Size = new System.Drawing.Size(148, 72);
            this.button_arctic_monkeys.TabIndex = 19;
            this.button_arctic_monkeys.UseVisualStyleBackColor = true;
            this.button_arctic_monkeys.Click += new System.EventHandler(this.button_arctic_monkeys_Click);
            // 
            // button_pesquisar
            // 
            this.button_pesquisar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_pesquisar.BackColor = System.Drawing.Color.Transparent;
            this.button_pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("button_pesquisar.Image")));
            this.button_pesquisar.Location = new System.Drawing.Point(771, 473);
            this.button_pesquisar.Name = "button_pesquisar";
            this.button_pesquisar.Size = new System.Drawing.Size(196, 68);
            this.button_pesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_pesquisar.TabIndex = 27;
            this.button_pesquisar.TabStop = false;
            this.button_pesquisar.Click += new System.EventHandler(this.button_pesquisar_Click);
            // 
            // video_player
            // 
            this.video_player.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.video_player.Enabled = true;
            this.video_player.Location = new System.Drawing.Point(12, 118);
            this.video_player.Name = "video_player";
            this.video_player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("video_player.OcxState")));
            this.video_player.Size = new System.Drawing.Size(1048, 431);
            this.video_player.TabIndex = 30;
            this.video_player.Visible = false;
            this.video_player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.video_player_PlayStateChange);
            // 
            // button_youtube_player
            // 
            this.button_youtube_player.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_youtube_player.BackColor = System.Drawing.Color.Transparent;
            this.button_youtube_player.Enabled = false;
            this.button_youtube_player.Image = ((System.Drawing.Image)(resources.GetObject("button_youtube_player.Image")));
            this.button_youtube_player.Location = new System.Drawing.Point(365, 12);
            this.button_youtube_player.Name = "button_youtube_player";
            this.button_youtube_player.Size = new System.Drawing.Size(87, 72);
            this.button_youtube_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_youtube_player.TabIndex = 31;
            this.button_youtube_player.TabStop = false;
            this.button_youtube_player.Click += new System.EventHandler(this.button_youtube_player_Click);
            // 
            // button_video_player
            // 
            this.button_video_player.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_video_player.BackColor = System.Drawing.Color.Transparent;
            this.button_video_player.Image = ((System.Drawing.Image)(resources.GetObject("button_video_player.Image")));
            this.button_video_player.Location = new System.Drawing.Point(610, 12);
            this.button_video_player.Name = "button_video_player";
            this.button_video_player.Size = new System.Drawing.Size(87, 72);
            this.button_video_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_video_player.TabIndex = 32;
            this.button_video_player.TabStop = false;
            this.button_video_player.Click += new System.EventHandler(this.button_video_player_Click);
            // 
            // trackBar_volume
            // 
            this.trackBar_volume.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackBar_volume.AutoSize = false;
            this.trackBar_volume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trackBar_volume.Location = new System.Drawing.Point(835, 602);
            this.trackBar_volume.Maximum = 100;
            this.trackBar_volume.Name = "trackBar_volume";
            this.trackBar_volume.Size = new System.Drawing.Size(120, 23);
            this.trackBar_volume.TabIndex = 0;
            this.trackBar_volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_volume.Value = 50;
            this.trackBar_volume.Visible = false;
            this.trackBar_volume.ValueChanged += new System.EventHandler(this.trackBar_volume_ValueChanged);
            // 
            // label_volume
            // 
            this.label_volume.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_volume.AutoSize = true;
            this.label_volume.BackColor = System.Drawing.Color.Transparent;
            this.label_volume.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_volume.ForeColor = System.Drawing.Color.White;
            this.label_volume.Location = new System.Drawing.Point(879, 628);
            this.label_volume.Name = "label_volume";
            this.label_volume.Size = new System.Drawing.Size(33, 18);
            this.label_volume.TabIndex = 33;
            this.label_volume.Text = "50%";
            this.label_volume.Visible = false;
            // 
            // button_play
            // 
            this.button_play.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_play.BackColor = System.Drawing.Color.Transparent;
            this.button_play.Image = ((System.Drawing.Image)(resources.GetObject("button_play.Image")));
            this.button_play.Location = new System.Drawing.Point(493, 578);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(77, 68);
            this.button_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_play.TabIndex = 34;
            this.button_play.TabStop = false;
            this.button_play.Visible = false;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_recuar
            // 
            this.button_recuar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_recuar.BackColor = System.Drawing.Color.Transparent;
            this.button_recuar.Image = ((System.Drawing.Image)(resources.GetObject("button_recuar.Image")));
            this.button_recuar.Location = new System.Drawing.Point(397, 591);
            this.button_recuar.Name = "button_recuar";
            this.button_recuar.Size = new System.Drawing.Size(55, 45);
            this.button_recuar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_recuar.TabIndex = 35;
            this.button_recuar.TabStop = false;
            this.button_recuar.Visible = false;
            this.button_recuar.Click += new System.EventHandler(this.button_recuar_Click);
            // 
            // button_avancar
            // 
            this.button_avancar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_avancar.BackColor = System.Drawing.Color.Transparent;
            this.button_avancar.Image = ((System.Drawing.Image)(resources.GetObject("button_avancar.Image")));
            this.button_avancar.Location = new System.Drawing.Point(610, 591);
            this.button_avancar.Name = "button_avancar";
            this.button_avancar.Size = new System.Drawing.Size(55, 45);
            this.button_avancar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_avancar.TabIndex = 36;
            this.button_avancar.TabStop = false;
            this.button_avancar.Visible = false;
            this.button_avancar.Click += new System.EventHandler(this.button_avancar_Click);
            // 
            // button_pausa
            // 
            this.button_pausa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_pausa.BackColor = System.Drawing.Color.Transparent;
            this.button_pausa.Enabled = false;
            this.button_pausa.Image = ((System.Drawing.Image)(resources.GetObject("button_pausa.Image")));
            this.button_pausa.Location = new System.Drawing.Point(493, 578);
            this.button_pausa.Name = "button_pausa";
            this.button_pausa.Size = new System.Drawing.Size(77, 68);
            this.button_pausa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_pausa.TabIndex = 37;
            this.button_pausa.TabStop = false;
            this.button_pausa.Visible = false;
            this.button_pausa.Click += new System.EventHandler(this.button_pausa_Click);
            // 
            // button_mute
            // 
            this.button_mute.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_mute.BackColor = System.Drawing.Color.Transparent;
            this.button_mute.Image = ((System.Drawing.Image)(resources.GetObject("button_mute.Image")));
            this.button_mute.Location = new System.Drawing.Point(758, 591);
            this.button_mute.Name = "button_mute";
            this.button_mute.Size = new System.Drawing.Size(55, 45);
            this.button_mute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_mute.TabIndex = 38;
            this.button_mute.TabStop = false;
            this.button_mute.Visible = false;
            this.button_mute.Click += new System.EventHandler(this.button_mute_Click);
            // 
            // button_abrir
            // 
            this.button_abrir.BackColor = System.Drawing.Color.Transparent;
            this.button_abrir.Image = ((System.Drawing.Image)(resources.GetObject("button_abrir.Image")));
            this.button_abrir.Location = new System.Drawing.Point(12, 62);
            this.button_abrir.Name = "button_abrir";
            this.button_abrir.Size = new System.Drawing.Size(60, 50);
            this.button_abrir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_abrir.TabIndex = 39;
            this.button_abrir.TabStop = false;
            this.button_abrir.Visible = false;
            this.button_abrir.Click += new System.EventHandler(this.button_abrir_Click);
            // 
            // trackBar_video
            // 
            this.trackBar_video.AllowDrop = true;
            this.trackBar_video.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_video.AutoSize = false;
            this.trackBar_video.Location = new System.Drawing.Point(12, 547);
            this.trackBar_video.Maximum = 100;
            this.trackBar_video.Name = "trackBar_video";
            this.trackBar_video.Size = new System.Drawing.Size(1048, 25);
            this.trackBar_video.TabIndex = 40;
            this.trackBar_video.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_video.Visible = false;
            this.trackBar_video.Scroll += new System.EventHandler(this.trackBar_video_Scroll);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "MP4 files|*.mp4|AVI files|*.avi";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_duracao
            // 
            this.label_duracao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_duracao.AutoSize = true;
            this.label_duracao.BackColor = System.Drawing.Color.Transparent;
            this.label_duracao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_duracao.ForeColor = System.Drawing.Color.White;
            this.label_duracao.Location = new System.Drawing.Point(1015, 93);
            this.label_duracao.Name = "label_duracao";
            this.label_duracao.Size = new System.Drawing.Size(45, 19);
            this.label_duracao.TabIndex = 41;
            this.label_duracao.Text = "00:00";
            this.label_duracao.Visible = false;
            // 
            // label_tempo
            // 
            this.label_tempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_tempo.AutoSize = true;
            this.label_tempo.BackColor = System.Drawing.Color.Transparent;
            this.label_tempo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tempo.ForeColor = System.Drawing.Color.White;
            this.label_tempo.Location = new System.Drawing.Point(939, 93);
            this.label_tempo.Name = "label_tempo";
            this.label_tempo.Size = new System.Drawing.Size(45, 19);
            this.label_tempo.TabIndex = 42;
            this.label_tempo.Text = "00:00";
            this.label_tempo.Visible = false;
            // 
            // label_separador
            // 
            this.label_separador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_separador.AutoSize = true;
            this.label_separador.BackColor = System.Drawing.Color.Transparent;
            this.label_separador.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_separador.ForeColor = System.Drawing.Color.White;
            this.label_separador.Location = new System.Drawing.Point(990, 93);
            this.label_separador.Name = "label_separador";
            this.label_separador.Size = new System.Drawing.Size(16, 19);
            this.label_separador.TabIndex = 44;
            this.label_separador.Text = "/";
            this.label_separador.Visible = false;
            // 
            // leitor_video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 658);
            this.Controls.Add(this.label_separador);
            this.Controls.Add(this.label_tempo);
            this.Controls.Add(this.label_duracao);
            this.Controls.Add(this.trackBar_video);
            this.Controls.Add(this.button_abrir);
            this.Controls.Add(this.button_mute);
            this.Controls.Add(this.button_pausa);
            this.Controls.Add(this.button_avancar);
            this.Controls.Add(this.button_recuar);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.label_volume);
            this.Controls.Add(this.trackBar_volume);
            this.Controls.Add(this.button_video_player);
            this.Controls.Add(this.button_youtube_player);
            this.Controls.Add(this.video_player);
            this.Controls.Add(this.button_pesquisar);
            this.Controls.Add(this.button_richie_campbell);
            this.Controls.Add(this.button_metalica);
            this.Controls.Add(this.button_arctic_monkeys);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.textBox_pesquisa);
            this.Controls.Add(this.youtube_player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "leitor_video";
            this.Text = "Leitor de Vídeo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.leitor_video2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.youtube_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_voltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_sair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_pesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.video_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_youtube_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_video_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_recuar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_avancar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_pausa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_mute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_abrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_video)).EndInit();
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
        private System.Windows.Forms.PictureBox button_youtube_player;
        private System.Windows.Forms.PictureBox button_video_player;
        private System.Windows.Forms.TrackBar trackBar_volume;
        private AxWMPLib.AxWindowsMediaPlayer video_player;
        private System.Windows.Forms.Label label_volume;
        private System.Windows.Forms.PictureBox button_play;
        private System.Windows.Forms.PictureBox button_recuar;
        private System.Windows.Forms.PictureBox button_avancar;
        private System.Windows.Forms.PictureBox button_pausa;
        private System.Windows.Forms.PictureBox button_mute;
        private System.Windows.Forms.PictureBox button_abrir;
        private System.Windows.Forms.TrackBar trackBar_video;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_duracao;
        private System.Windows.Forms.Label label_tempo;
        private System.Windows.Forms.Label label_separador;
    }
}