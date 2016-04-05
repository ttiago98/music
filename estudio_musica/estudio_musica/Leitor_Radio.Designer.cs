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
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.button_sair = new System.Windows.Forms.PictureBox();
            this.button_play = new System.Windows.Forms.PictureBox();
            this.button_pausa = new System.Windows.Forms.PictureBox();
            this.button_voltar = new System.Windows.Forms.PictureBox();
            this.button_mute = new System.Windows.Forms.PictureBox();
            this.trackBar_volume = new System.Windows.Forms.TrackBar();
            this.label_volume = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_sair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_pausa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_mute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).BeginInit();
            this.SuspendLayout();
            // 
            // lista_radios
            // 
            this.lista_radios.BackColor = System.Drawing.Color.Black;
            this.lista_radios.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_radios.ForeColor = System.Drawing.Color.White;
            this.lista_radios.FormattingEnabled = true;
            this.lista_radios.ItemHeight = 15;
            this.lista_radios.Location = new System.Drawing.Point(12, 12);
            this.lista_radios.Name = "lista_radios";
            this.lista_radios.Size = new System.Drawing.Size(556, 154);
            this.lista_radios.TabIndex = 6;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 172);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(556, 28);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // button_sair
            // 
            this.button_sair.BackColor = System.Drawing.Color.Transparent;
            this.button_sair.Image = ((System.Drawing.Image)(resources.GetObject("button_sair.Image")));
            this.button_sair.Location = new System.Drawing.Point(493, 312);
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
            this.button_play.Location = new System.Drawing.Point(120, 245);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(100, 89);
            this.button_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_play.TabIndex = 9;
            this.button_play.TabStop = false;
            this.toolTip1.SetToolTip(this.button_play, "Play");
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_pausa
            // 
            this.button_pausa.BackColor = System.Drawing.Color.Transparent;
            this.button_pausa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_pausa.Image = ((System.Drawing.Image)(resources.GetObject("button_pausa.Image")));
            this.button_pausa.Location = new System.Drawing.Point(236, 267);
            this.button_pausa.Name = "button_pausa";
            this.button_pausa.Size = new System.Drawing.Size(67, 54);
            this.button_pausa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_pausa.TabIndex = 10;
            this.button_pausa.TabStop = false;
            this.toolTip1.SetToolTip(this.button_pausa, "Stop");
            this.button_pausa.Click += new System.EventHandler(this.button_pausa_Click);
            // 
            // button_voltar
            // 
            this.button_voltar.BackColor = System.Drawing.Color.Transparent;
            this.button_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_voltar.Image = ((System.Drawing.Image)(resources.GetObject("button_voltar.Image")));
            this.button_voltar.Location = new System.Drawing.Point(12, 312);
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
            this.button_mute.Location = new System.Drawing.Point(369, 206);
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
            this.trackBar_volume.Location = new System.Drawing.Point(430, 215);
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
            this.label_volume.Location = new System.Drawing.Point(490, 243);
            this.label_volume.Name = "label_volume";
            this.label_volume.Size = new System.Drawing.Size(30, 15);
            this.label_volume.TabIndex = 16;
            this.label_volume.Text = "50%";
            // 
            // Leitor_Radio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 365);
            this.Controls.Add(this.label_volume);
            this.Controls.Add(this.trackBar_volume);
            this.Controls.Add(this.button_mute);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.button_pausa);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.lista_radios);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Leitor_Radio";
            this.Text = "Leitor de Rádio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Leitor_Radio_FormClosing);
            this.Load += new System.EventHandler(this.Leitor_Radio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_sair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_pausa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_voltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_mute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lista_radios;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox button_sair;
        private System.Windows.Forms.PictureBox button_play;
        private System.Windows.Forms.PictureBox button_pausa;
        private System.Windows.Forms.PictureBox button_voltar;
        private System.Windows.Forms.PictureBox button_mute;
        private System.Windows.Forms.TrackBar trackBar_volume;
        private System.Windows.Forms.Label label_volume;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}