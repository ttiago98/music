namespace estudio_musica
{
    partial class Leitor_Radio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leitor_Radio));
            this.lista_radios = new System.Windows.Forms.ListBox();
            this.radio_player = new AxWMPLib.AxWindowsMediaPlayer();
            this.button_sair = new System.Windows.Forms.PictureBox();
            this.button_play = new System.Windows.Forms.PictureBox();
            this.button_stop = new System.Windows.Forms.PictureBox();
            this.button_voltar = new System.Windows.Forms.PictureBox();
            this.button_mute = new System.Windows.Forms.PictureBox();
            this.trackBar_volume = new System.Windows.Forms.TrackBar();
            this.label_volume = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.Button();
            this.fechar = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirAplicaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.icon = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radio_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_sair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_mute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // lista_radios
            // 
            this.lista_radios.BackColor = System.Drawing.Color.Black;
            this.lista_radios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lista_radios.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_radios.ForeColor = System.Drawing.Color.White;
            this.lista_radios.FormattingEnabled = true;
            this.lista_radios.ItemHeight = 15;
            this.lista_radios.Location = new System.Drawing.Point(12, 44);
            this.lista_radios.Name = "lista_radios";
            this.lista_radios.Size = new System.Drawing.Size(556, 150);
            this.lista_radios.TabIndex = 6;
            // 
            // radio_player
            // 
            this.radio_player.Enabled = true;
            this.radio_player.Location = new System.Drawing.Point(12, 183);
            this.radio_player.Name = "radio_player";
            this.radio_player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("radio_player.OcxState")));
            this.radio_player.Size = new System.Drawing.Size(556, 68);
            this.radio_player.TabIndex = 7;
            // 
            // button_sair
            // 
            this.button_sair.BackColor = System.Drawing.Color.Transparent;
            this.button_sair.Image = ((System.Drawing.Image)(resources.GetObject("button_sair.Image")));
            this.button_sair.Location = new System.Drawing.Point(493, 355);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(75, 41);
            this.button_sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_sair.TabIndex = 8;
            this.button_sair.TabStop = false;
            this.toolTip1.SetToolTip(this.button_sair, "Sair do programa");
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // button_play
            // 
            this.button_play.BackColor = System.Drawing.Color.Transparent;
            this.button_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_play.Image = ((System.Drawing.Image)(resources.GetObject("button_play.Image")));
            this.button_play.Location = new System.Drawing.Point(120, 288);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(100, 89);
            this.button_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_play.TabIndex = 9;
            this.button_play.TabStop = false;
            this.toolTip1.SetToolTip(this.button_play, "Play");
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_stop
            // 
            this.button_stop.BackColor = System.Drawing.Color.Transparent;
            this.button_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_stop.Enabled = false;
            this.button_stop.Image = ((System.Drawing.Image)(resources.GetObject("button_stop.Image")));
            this.button_stop.Location = new System.Drawing.Point(236, 310);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(67, 54);
            this.button_stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_stop.TabIndex = 10;
            this.button_stop.TabStop = false;
            this.toolTip1.SetToolTip(this.button_stop, "Stop");
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_voltar
            // 
            this.button_voltar.BackColor = System.Drawing.Color.Transparent;
            this.button_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_voltar.Image = ((System.Drawing.Image)(resources.GetObject("button_voltar.Image")));
            this.button_voltar.Location = new System.Drawing.Point(12, 355);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(65, 41);
            this.button_voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_voltar.TabIndex = 13;
            this.button_voltar.TabStop = false;
            this.toolTip1.SetToolTip(this.button_voltar, "Voltar atrás");
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
            // 
            // button_mute
            // 
            this.button_mute.BackColor = System.Drawing.Color.Transparent;
            this.button_mute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_mute.Image = ((System.Drawing.Image)(resources.GetObject("button_mute.Image")));
            this.button_mute.Location = new System.Drawing.Point(369, 271);
            this.button_mute.Name = "button_mute";
            this.button_mute.Size = new System.Drawing.Size(55, 45);
            this.button_mute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_mute.TabIndex = 14;
            this.button_mute.TabStop = false;
            this.toolTip1.SetToolTip(this.button_mute, "Remover som");
            this.button_mute.Click += new System.EventHandler(this.button_mute_Click);
            // 
            // trackBar_volume
            // 
            this.trackBar_volume.AutoSize = false;
            this.trackBar_volume.BackColor = System.Drawing.Color.Black;
            this.trackBar_volume.Location = new System.Drawing.Point(430, 282);
            this.trackBar_volume.Maximum = 100;
            this.trackBar_volume.Name = "trackBar_volume";
            this.trackBar_volume.Size = new System.Drawing.Size(138, 25);
            this.trackBar_volume.TabIndex = 15;
            this.trackBar_volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_volume.Value = 50;
            this.trackBar_volume.Scroll += new System.EventHandler(this.trackBar_volume_Scroll);
            this.trackBar_volume.ValueChanged += new System.EventHandler(this.trackBar_volume_ValueChanged);
            // 
            // label_volume
            // 
            this.label_volume.AutoSize = true;
            this.label_volume.BackColor = System.Drawing.Color.Transparent;
            this.label_volume.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_volume.ForeColor = System.Drawing.Color.White;
            this.label_volume.Location = new System.Drawing.Point(490, 310);
            this.label_volume.Name = "label_volume";
            this.label_volume.Size = new System.Drawing.Size(30, 15);
            this.label_volume.TabIndex = 16;
            this.label_volume.Text = "50%";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(-51, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(657, 28);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // minimizar
            // 
            this.minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizar.BackgroundImage")));
            this.minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.minimizar.Location = new System.Drawing.Point(510, -1);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(26, 28);
            this.minimizar.TabIndex = 37;
            this.minimizar.UseVisualStyleBackColor = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // fechar
            // 
            this.fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fechar.BackgroundImage")));
            this.fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fechar.Location = new System.Drawing.Point(542, -1);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(26, 28);
            this.fechar.TabIndex = 36;
            this.fechar.UseVisualStyleBackColor = false;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Leitor de Rádio";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirAplicaçãoToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 48);
            // 
            // abrirAplicaçãoToolStripMenuItem
            // 
            this.abrirAplicaçãoToolStripMenuItem.Name = "abrirAplicaçãoToolStripMenuItem";
            this.abrirAplicaçãoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.abrirAplicaçãoToolStripMenuItem.Text = "Abrir";
            this.abrirAplicaçãoToolStripMenuItem.Click += new System.EventHandler(this.abrirAplicaçãoToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("icon.BackgroundImage")));
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icon.Cursor = System.Windows.Forms.Cursors.Default;
            this.icon.Location = new System.Drawing.Point(11, 6);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(23, 15);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 38;
            this.icon.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(40, 6);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(90, 15);
            this.label.TabIndex = 39;
            this.label.Text = "Leitor de Rádio";
            // 
            // Leitor_Radio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 408);
            this.Controls.Add(this.label);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.minimizar);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_volume);
            this.Controls.Add(this.trackBar_volume);
            this.Controls.Add(this.button_mute);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.radio_player);
            this.Controls.Add(this.lista_radios);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Leitor_Radio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leitor de Rádio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Leitor_Radio_FormClosing);
            this.Load += new System.EventHandler(this.Leitor_Radio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radio_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_sair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_voltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_mute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lista_radios;
        private AxWMPLib.AxWindowsMediaPlayer radio_player;
        private System.Windows.Forms.PictureBox button_sair;
        private System.Windows.Forms.PictureBox button_play;
        private System.Windows.Forms.PictureBox button_stop;
        private System.Windows.Forms.PictureBox button_voltar;
        private System.Windows.Forms.PictureBox button_mute;
        private System.Windows.Forms.TrackBar trackBar_volume;
        private System.Windows.Forms.Label label_volume;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button minimizar;
        private System.Windows.Forms.Button fechar;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirAplicaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label label;
    }
}