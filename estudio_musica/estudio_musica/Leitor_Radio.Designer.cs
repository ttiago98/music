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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leitor_Radio));
            this.lista_radios = new System.Windows.Forms.ListBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.button_sair = new System.Windows.Forms.PictureBox();
            this.button_play = new System.Windows.Forms.PictureBox();
            this.button_pausa = new System.Windows.Forms.PictureBox();
            this.button_mais_volume = new System.Windows.Forms.PictureBox();
            this.button_menos_volume = new System.Windows.Forms.PictureBox();
            this.button_voltar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_sair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_pausa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_mais_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_menos_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_voltar)).BeginInit();
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
            this.lista_radios.Size = new System.Drawing.Size(456, 154);
            this.lista_radios.TabIndex = 6;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(318, 172);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(150, 51);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            // 
            // button_sair
            // 
            this.button_sair.BackColor = System.Drawing.Color.Transparent;
            this.button_sair.Image = ((System.Drawing.Image)(resources.GetObject("button_sair.Image")));
            this.button_sair.Location = new System.Drawing.Point(393, 312);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(75, 41);
            this.button_sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_sair.TabIndex = 8;
            this.button_sair.TabStop = false;
            this.button_sair.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_play
            // 
            this.button_play.BackColor = System.Drawing.Color.Transparent;
            this.button_play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_play.BackgroundImage")));
            this.button_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_play.Location = new System.Drawing.Point(204, 219);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(55, 45);
            this.button_play.TabIndex = 9;
            this.button_play.TabStop = false;
            // 
            // button_pausa
            // 
            this.button_pausa.BackColor = System.Drawing.Color.Transparent;
            this.button_pausa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_pausa.BackgroundImage")));
            this.button_pausa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_pausa.Location = new System.Drawing.Point(204, 308);
            this.button_pausa.Name = "button_pausa";
            this.button_pausa.Size = new System.Drawing.Size(55, 45);
            this.button_pausa.TabIndex = 10;
            this.button_pausa.TabStop = false;
            // 
            // button_mais_volume
            // 
            this.button_mais_volume.BackColor = System.Drawing.Color.Transparent;
            this.button_mais_volume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_mais_volume.Image = ((System.Drawing.Image)(resources.GetObject("button_mais_volume.Image")));
            this.button_mais_volume.Location = new System.Drawing.Point(265, 262);
            this.button_mais_volume.Name = "button_mais_volume";
            this.button_mais_volume.Size = new System.Drawing.Size(55, 45);
            this.button_mais_volume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_mais_volume.TabIndex = 11;
            this.button_mais_volume.TabStop = false;
            // 
            // button_menos_volume
            // 
            this.button_menos_volume.BackColor = System.Drawing.Color.Transparent;
            this.button_menos_volume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_menos_volume.Image = ((System.Drawing.Image)(resources.GetObject("button_menos_volume.Image")));
            this.button_menos_volume.Location = new System.Drawing.Point(143, 262);
            this.button_menos_volume.Name = "button_menos_volume";
            this.button_menos_volume.Size = new System.Drawing.Size(55, 45);
            this.button_menos_volume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_menos_volume.TabIndex = 12;
            this.button_menos_volume.TabStop = false;
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
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
            // 
            // Leitor_Radio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(480, 365);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.button_menos_volume);
            this.Controls.Add(this.button_mais_volume);
            this.Controls.Add(this.button_pausa);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.lista_radios);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Leitor_Radio";
            this.Text = "Leitor de Rádio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Leitor_Radio_FormClosing);
            this.Load += new System.EventHandler(this.Leitor_Radio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_sair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_pausa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_mais_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_menos_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_voltar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lista_radios;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox button_sair;
        private System.Windows.Forms.PictureBox button_play;
        private System.Windows.Forms.PictureBox button_pausa;
        private System.Windows.Forms.PictureBox button_mais_volume;
        private System.Windows.Forms.PictureBox button_menos_volume;
        private System.Windows.Forms.PictureBox button_voltar;
    }
}