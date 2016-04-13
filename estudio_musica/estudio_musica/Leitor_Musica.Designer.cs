namespace estudio_musica
{
    partial class Leitor_Musica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leitor_Musica));
            this.button_play = new System.Windows.Forms.PictureBox();
            this.button_musica_anterior = new System.Windows.Forms.PictureBox();
            this.button_proxima_musica = new System.Windows.Forms.PictureBox();
            this.button_pausa = new System.Windows.Forms.PictureBox();
            this.button_sair = new System.Windows.Forms.PictureBox();
            this.button_voltar = new System.Windows.Forms.PictureBox();
            this.player_musica = new AxWMPLib.AxWindowsMediaPlayer();
            this.lista_musicas = new System.Windows.Forms.ListBox();
            this.button_abrir = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_stop = new System.Windows.Forms.PictureBox();
            this.button_mute = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_limpar_tudo = new System.Windows.Forms.PictureBox();
            this.trackBar_volume = new System.Windows.Forms.TrackBar();
            this.label_volume = new System.Windows.Forms.Label();
            this.trackBar_musica = new System.Windows.Forms.TrackBar();
            this.label_duracao = new System.Windows.Forms.Label();
            this.label_tempo = new System.Windows.Forms.Label();
            this.label_separador = new System.Windows.Forms.Label();
            this.button_limpar_selecionado = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fechar = new System.Windows.Forms.Button();
            this.minimizar = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.button_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_musica_anterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_proxima_musica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_pausa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_sair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_musica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_abrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_mute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_limpar_tudo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_musica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_limpar_selecionado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_play
            // 
            this.button_play.BackColor = System.Drawing.Color.Transparent;
            this.button_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_play.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_play.Enabled = false;
            this.button_play.Image = ((System.Drawing.Image)(resources.GetObject("button_play.Image")));
            this.button_play.Location = new System.Drawing.Point(308, 355);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(55, 45);
            this.button_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_play.TabIndex = 10;
            this.button_play.TabStop = false;
            this.toolTip1.SetToolTip(this.button_play, "Play");
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_musica_anterior
            // 
            this.button_musica_anterior.BackColor = System.Drawing.Color.Transparent;
            this.button_musica_anterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_musica_anterior.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_musica_anterior.Enabled = false;
            this.button_musica_anterior.Image = ((System.Drawing.Image)(resources.GetObject("button_musica_anterior.Image")));
            this.button_musica_anterior.Location = new System.Drawing.Point(247, 406);
            this.button_musica_anterior.Name = "button_musica_anterior";
            this.button_musica_anterior.Size = new System.Drawing.Size(55, 45);
            this.button_musica_anterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_musica_anterior.TabIndex = 11;
            this.button_musica_anterior.TabStop = false;
            this.toolTip1.SetToolTip(this.button_musica_anterior, "Música anterior");
            this.button_musica_anterior.Click += new System.EventHandler(this.button_musica_anterior_Click);
            // 
            // button_proxima_musica
            // 
            this.button_proxima_musica.BackColor = System.Drawing.Color.Transparent;
            this.button_proxima_musica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_proxima_musica.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_proxima_musica.Enabled = false;
            this.button_proxima_musica.Image = ((System.Drawing.Image)(resources.GetObject("button_proxima_musica.Image")));
            this.button_proxima_musica.Location = new System.Drawing.Point(370, 406);
            this.button_proxima_musica.Name = "button_proxima_musica";
            this.button_proxima_musica.Size = new System.Drawing.Size(55, 45);
            this.button_proxima_musica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_proxima_musica.TabIndex = 12;
            this.button_proxima_musica.TabStop = false;
            this.toolTip1.SetToolTip(this.button_proxima_musica, "Próxima música");
            this.button_proxima_musica.Click += new System.EventHandler(this.button_proxima_musica_Click);
            // 
            // button_pausa
            // 
            this.button_pausa.BackColor = System.Drawing.Color.Transparent;
            this.button_pausa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_pausa.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_pausa.Enabled = false;
            this.button_pausa.Image = ((System.Drawing.Image)(resources.GetObject("button_pausa.Image")));
            this.button_pausa.Location = new System.Drawing.Point(308, 457);
            this.button_pausa.Name = "button_pausa";
            this.button_pausa.Size = new System.Drawing.Size(55, 45);
            this.button_pausa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_pausa.TabIndex = 13;
            this.button_pausa.TabStop = false;
            this.toolTip1.SetToolTip(this.button_pausa, "Pausa");
            this.button_pausa.Click += new System.EventHandler(this.button_pausa_Click);
            // 
            // button_sair
            // 
            this.button_sair.BackColor = System.Drawing.Color.Transparent;
            this.button_sair.Image = ((System.Drawing.Image)(resources.GetObject("button_sair.Image")));
            this.button_sair.Location = new System.Drawing.Point(582, 469);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(75, 41);
            this.button_sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_sair.TabIndex = 16;
            this.button_sair.TabStop = false;
            this.toolTip1.SetToolTip(this.button_sair, "Sair do programa");
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // button_voltar
            // 
            this.button_voltar.BackColor = System.Drawing.Color.Transparent;
            this.button_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_voltar.Image = ((System.Drawing.Image)(resources.GetObject("button_voltar.Image")));
            this.button_voltar.Location = new System.Drawing.Point(12, 469);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(79, 41);
            this.button_voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_voltar.TabIndex = 17;
            this.button_voltar.TabStop = false;
            this.toolTip1.SetToolTip(this.button_voltar, "Voltar atrás");
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
            // 
            // player_musica
            // 
            this.player_musica.Enabled = true;
            this.player_musica.Location = new System.Drawing.Point(122, 257);
            this.player_musica.Name = "player_musica";
            this.player_musica.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player_musica.OcxState")));
            this.player_musica.Size = new System.Drawing.Size(433, 64);
            this.player_musica.TabIndex = 18;
            this.player_musica.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // lista_musicas
            // 
            this.lista_musicas.BackColor = System.Drawing.Color.Black;
            this.lista_musicas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lista_musicas.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_musicas.ForeColor = System.Drawing.Color.White;
            this.lista_musicas.FormattingEnabled = true;
            this.lista_musicas.ItemHeight = 15;
            this.lista_musicas.Location = new System.Drawing.Point(122, 67);
            this.lista_musicas.Name = "lista_musicas";
            this.lista_musicas.Size = new System.Drawing.Size(433, 195);
            this.lista_musicas.TabIndex = 19;
            this.lista_musicas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lista_musicas_MouseDoubleClick);
            // 
            // button_abrir
            // 
            this.button_abrir.BackColor = System.Drawing.Color.Transparent;
            this.button_abrir.Image = ((System.Drawing.Image)(resources.GetObject("button_abrir.Image")));
            this.button_abrir.Location = new System.Drawing.Point(19, 46);
            this.button_abrir.Name = "button_abrir";
            this.button_abrir.Size = new System.Drawing.Size(60, 51);
            this.button_abrir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_abrir.TabIndex = 20;
            this.button_abrir.TabStop = false;
            this.toolTip1.SetToolTip(this.button_abrir, "Abrir Musicas");
            this.button_abrir.Click += new System.EventHandler(this.button_abrir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Ficheiros MP3|*.mp3|Ficheiros WAV|*.wav";
            this.openFileDialog1.Multiselect = true;
            // 
            // button_stop
            // 
            this.button_stop.BackColor = System.Drawing.Color.Transparent;
            this.button_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_stop.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_stop.Enabled = false;
            this.button_stop.Image = ((System.Drawing.Image)(resources.GetObject("button_stop.Image")));
            this.button_stop.Location = new System.Drawing.Point(308, 406);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(55, 45);
            this.button_stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_stop.TabIndex = 21;
            this.button_stop.TabStop = false;
            this.toolTip1.SetToolTip(this.button_stop, "Stop");
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_mute
            // 
            this.button_mute.BackColor = System.Drawing.Color.Transparent;
            this.button_mute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_mute.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_mute.Image = ((System.Drawing.Image)(resources.GetObject("button_mute.Image")));
            this.button_mute.Location = new System.Drawing.Point(589, 274);
            this.button_mute.Name = "button_mute";
            this.button_mute.Size = new System.Drawing.Size(55, 45);
            this.button_mute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_mute.TabIndex = 22;
            this.button_mute.TabStop = false;
            this.toolTip1.SetToolTip(this.button_mute, "Remover som");
            this.button_mute.Click += new System.EventHandler(this.button_mute_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_limpar_tudo
            // 
            this.button_limpar_tudo.BackColor = System.Drawing.Color.Transparent;
            this.button_limpar_tudo.Image = ((System.Drawing.Image)(resources.GetObject("button_limpar_tudo.Image")));
            this.button_limpar_tudo.Location = new System.Drawing.Point(19, 222);
            this.button_limpar_tudo.Name = "button_limpar_tudo";
            this.button_limpar_tudo.Size = new System.Drawing.Size(60, 50);
            this.button_limpar_tudo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_limpar_tudo.TabIndex = 24;
            this.button_limpar_tudo.TabStop = false;
            this.toolTip1.SetToolTip(this.button_limpar_tudo, "Limpar lista completa");
            this.button_limpar_tudo.Visible = false;
            this.button_limpar_tudo.Click += new System.EventHandler(this.button_limpar_tudo_Click);
            // 
            // trackBar_volume
            // 
            this.trackBar_volume.AutoSize = false;
            this.trackBar_volume.BackColor = System.Drawing.Color.Black;
            this.trackBar_volume.Location = new System.Drawing.Point(606, 99);
            this.trackBar_volume.Maximum = 100;
            this.trackBar_volume.Name = "trackBar_volume";
            this.trackBar_volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_volume.Size = new System.Drawing.Size(27, 139);
            this.trackBar_volume.TabIndex = 26;
            this.trackBar_volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_volume.Value = 50;
            this.trackBar_volume.ValueChanged += new System.EventHandler(this.trackBar_volume_ValueChanged);
            // 
            // label_volume
            // 
            this.label_volume.AutoSize = true;
            this.label_volume.BackColor = System.Drawing.Color.Transparent;
            this.label_volume.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_volume.ForeColor = System.Drawing.Color.White;
            this.label_volume.Location = new System.Drawing.Point(603, 241);
            this.label_volume.Name = "label_volume";
            this.label_volume.Size = new System.Drawing.Size(30, 15);
            this.label_volume.TabIndex = 27;
            this.label_volume.Text = "50%";
            // 
            // trackBar_musica
            // 
            this.trackBar_musica.AutoSize = false;
            this.trackBar_musica.BackColor = System.Drawing.Color.Black;
            this.trackBar_musica.Location = new System.Drawing.Point(122, 311);
            this.trackBar_musica.Maximum = 100;
            this.trackBar_musica.Name = "trackBar_musica";
            this.trackBar_musica.Size = new System.Drawing.Size(433, 22);
            this.trackBar_musica.TabIndex = 28;
            this.trackBar_musica.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_musica.Scroll += new System.EventHandler(this.trackBar_musica_Scroll);
            // 
            // label_duracao
            // 
            this.label_duracao.AutoSize = true;
            this.label_duracao.BackColor = System.Drawing.Color.Transparent;
            this.label_duracao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_duracao.ForeColor = System.Drawing.Color.White;
            this.label_duracao.Location = new System.Drawing.Point(510, 336);
            this.label_duracao.Name = "label_duracao";
            this.label_duracao.Size = new System.Drawing.Size(0, 19);
            this.label_duracao.TabIndex = 29;
            this.label_duracao.Visible = false;
            // 
            // label_tempo
            // 
            this.label_tempo.AutoSize = true;
            this.label_tempo.BackColor = System.Drawing.Color.Transparent;
            this.label_tempo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tempo.ForeColor = System.Drawing.Color.White;
            this.label_tempo.Location = new System.Drawing.Point(443, 336);
            this.label_tempo.Name = "label_tempo";
            this.label_tempo.Size = new System.Drawing.Size(0, 19);
            this.label_tempo.TabIndex = 30;
            this.label_tempo.Visible = false;
            // 
            // label_separador
            // 
            this.label_separador.BackColor = System.Drawing.Color.Transparent;
            this.label_separador.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_separador.ForeColor = System.Drawing.Color.White;
            this.label_separador.Location = new System.Drawing.Point(494, 336);
            this.label_separador.Name = "label_separador";
            this.label_separador.Size = new System.Drawing.Size(16, 19);
            this.label_separador.TabIndex = 31;
            this.label_separador.Text = "/";
            this.label_separador.Visible = false;
            // 
            // button_limpar_selecionado
            // 
            this.button_limpar_selecionado.BackColor = System.Drawing.Color.Transparent;
            this.button_limpar_selecionado.Image = ((System.Drawing.Image)(resources.GetObject("button_limpar_selecionado.Image")));
            this.button_limpar_selecionado.Location = new System.Drawing.Point(19, 139);
            this.button_limpar_selecionado.Name = "button_limpar_selecionado";
            this.button_limpar_selecionado.Size = new System.Drawing.Size(60, 56);
            this.button_limpar_selecionado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_limpar_selecionado.TabIndex = 32;
            this.button_limpar_selecionado.TabStop = false;
            this.toolTip1.SetToolTip(this.button_limpar_selecionado, "Remover musica selecionada");
            this.button_limpar_selecionado.Visible = false;
            this.button_limpar_selecionado.Click += new System.EventHandler(this.button_limpar_selecionado_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(-8, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(691, 28);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // fechar
            // 
            this.fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.fechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fechar.BackgroundImage")));
            this.fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fechar.Location = new System.Drawing.Point(631, 0);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(26, 28);
            this.fechar.TabIndex = 34;
            this.fechar.UseVisualStyleBackColor = false;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // minimizar
            // 
            this.minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizar.BackgroundImage")));
            this.minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.minimizar.Location = new System.Drawing.Point(599, 0);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(26, 28);
            this.minimizar.TabIndex = 35;
            this.minimizar.UseVisualStyleBackColor = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(42, 7);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(97, 15);
            this.label.TabIndex = 41;
            this.label.Text = "Leitor de Música";
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("icon.BackgroundImage")));
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icon.Cursor = System.Windows.Forms.Cursors.Default;
            this.icon.Location = new System.Drawing.Point(12, 7);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(23, 15);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 40;
            this.icon.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 48);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Leitor de Música";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // Leitor_Musica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(669, 522);
            this.Controls.Add(this.label);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.minimizar);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_limpar_selecionado);
            this.Controls.Add(this.label_separador);
            this.Controls.Add(this.label_tempo);
            this.Controls.Add(this.label_duracao);
            this.Controls.Add(this.trackBar_musica);
            this.Controls.Add(this.label_volume);
            this.Controls.Add(this.trackBar_volume);
            this.Controls.Add(this.button_limpar_tudo);
            this.Controls.Add(this.button_mute);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_abrir);
            this.Controls.Add(this.lista_musicas);
            this.Controls.Add(this.player_musica);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.button_pausa);
            this.Controls.Add(this.button_proxima_musica);
            this.Controls.Add(this.button_musica_anterior);
            this.Controls.Add(this.button_play);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Leitor_Musica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leitor de Música";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Leitor_Musica_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.button_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_musica_anterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_proxima_musica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_pausa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_sair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_voltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_musica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_abrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_mute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_limpar_tudo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_musica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_limpar_selecionado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox button_play;
        private System.Windows.Forms.PictureBox button_musica_anterior;
        private System.Windows.Forms.PictureBox button_proxima_musica;
        private System.Windows.Forms.PictureBox button_pausa;
        private System.Windows.Forms.PictureBox button_sair;
        private System.Windows.Forms.PictureBox button_voltar;
        private AxWMPLib.AxWindowsMediaPlayer player_musica;
        private System.Windows.Forms.ListBox lista_musicas;
        private System.Windows.Forms.PictureBox button_abrir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox button_stop;
        private System.Windows.Forms.PictureBox button_mute;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox button_limpar_tudo;
        private System.Windows.Forms.TrackBar trackBar_volume;
        private System.Windows.Forms.Label label_volume;
        private System.Windows.Forms.TrackBar trackBar_musica;
        private System.Windows.Forms.Label label_duracao;
        private System.Windows.Forms.Label label_tempo;
        private System.Windows.Forms.Label label_separador;
        private System.Windows.Forms.PictureBox button_limpar_selecionado;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button fechar;
        private System.Windows.Forms.Button minimizar;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}