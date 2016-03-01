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
            this.button_voltar = new System.Windows.Forms.Button();
            this.button_sair = new System.Windows.Forms.Button();
            this.youtube_player = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.button_imagine_dragons = new System.Windows.Forms.Button();
            this.button_ed = new System.Windows.Forms.Button();
            this.button_eminem = new System.Windows.Forms.Button();
            this.button_richie = new System.Windows.Forms.Button();
            this.button_metalica = new System.Windows.Forms.Button();
            this.button_rihanna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.youtube_player)).BeginInit();
            this.SuspendLayout();
            // 
            // button_voltar
            // 
            this.button_voltar.BackColor = System.Drawing.Color.Transparent;
            this.button_voltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_voltar.BackgroundImage")));
            this.button_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_voltar.Location = new System.Drawing.Point(12, 358);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(70, 41);
            this.button_voltar.TabIndex = 3;
            this.button_voltar.UseVisualStyleBackColor = false;
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click_1);
            // 
            // button_sair
            // 
            this.button_sair.BackColor = System.Drawing.Color.Transparent;
            this.button_sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_sair.BackgroundImage")));
            this.button_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_sair.Location = new System.Drawing.Point(563, 358);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(75, 41);
            this.button_sair.TabIndex = 4;
            this.button_sair.UseVisualStyleBackColor = false;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click_1);
            // 
            // youtube_player
            // 
            this.youtube_player.Enabled = true;
            this.youtube_player.Location = new System.Drawing.Point(124, 33);
            this.youtube_player.Name = "youtube_player";
            this.youtube_player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("youtube_player.OcxState")));
            this.youtube_player.Size = new System.Drawing.Size(490, 289);
            this.youtube_player.TabIndex = 5;
            // 
            // button_imagine_dragons
            // 
            this.button_imagine_dragons.Location = new System.Drawing.Point(12, 207);
            this.button_imagine_dragons.Name = "button_imagine_dragons";
            this.button_imagine_dragons.Size = new System.Drawing.Size(106, 23);
            this.button_imagine_dragons.TabIndex = 17;
            this.button_imagine_dragons.Text = "Imagine Dragons";
            this.button_imagine_dragons.UseVisualStyleBackColor = true;
            // 
            // button_ed
            // 
            this.button_ed.Location = new System.Drawing.Point(12, 169);
            this.button_ed.Name = "button_ed";
            this.button_ed.Size = new System.Drawing.Size(106, 23);
            this.button_ed.TabIndex = 16;
            this.button_ed.Text = "Ed Sheeran";
            this.button_ed.UseVisualStyleBackColor = true;
            // 
            // button_eminem
            // 
            this.button_eminem.Location = new System.Drawing.Point(12, 128);
            this.button_eminem.Name = "button_eminem";
            this.button_eminem.Size = new System.Drawing.Size(106, 23);
            this.button_eminem.TabIndex = 15;
            this.button_eminem.Text = "Eminem";
            this.button_eminem.UseVisualStyleBackColor = true;
            // 
            // button_richie
            // 
            this.button_richie.Location = new System.Drawing.Point(12, 88);
            this.button_richie.Name = "button_richie";
            this.button_richie.Size = new System.Drawing.Size(106, 23);
            this.button_richie.TabIndex = 14;
            this.button_richie.Text = "Richie Campbell";
            this.button_richie.UseVisualStyleBackColor = true;
            this.button_richie.Click += new System.EventHandler(this.button_richie_Click);
            // 
            // button_metalica
            // 
            this.button_metalica.Location = new System.Drawing.Point(12, 50);
            this.button_metalica.Name = "button_metalica";
            this.button_metalica.Size = new System.Drawing.Size(106, 23);
            this.button_metalica.TabIndex = 13;
            this.button_metalica.Text = "Metálica";
            this.button_metalica.UseVisualStyleBackColor = true;
            this.button_metalica.Click += new System.EventHandler(this.button_metalica_Click);
            // 
            // button_rihanna
            // 
            this.button_rihanna.Location = new System.Drawing.Point(12, 12);
            this.button_rihanna.Name = "button_rihanna";
            this.button_rihanna.Size = new System.Drawing.Size(106, 23);
            this.button_rihanna.TabIndex = 12;
            this.button_rihanna.Text = "Rihanna";
            this.button_rihanna.UseVisualStyleBackColor = true;
            this.button_rihanna.Click += new System.EventHandler(this.button_rihanna_Click);
            // 
            // Leitor_video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 411);
            this.Controls.Add(this.button_imagine_dragons);
            this.Controls.Add(this.button_ed);
            this.Controls.Add(this.button_eminem);
            this.Controls.Add(this.button_richie);
            this.Controls.Add(this.button_metalica);
            this.Controls.Add(this.button_rihanna);
            this.Controls.Add(this.youtube_player);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.button_voltar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Leitor_video";
            this.Text = "Leitor de video";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Leitor_video_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.youtube_player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_voltar;
        private System.Windows.Forms.Button button_sair;
        private AxShockwaveFlashObjects.AxShockwaveFlash youtube_player;
        private System.Windows.Forms.Button button_imagine_dragons;
        private System.Windows.Forms.Button button_ed;
        private System.Windows.Forms.Button button_eminem;
        private System.Windows.Forms.Button button_richie;
        private System.Windows.Forms.Button button_metalica;
        private System.Windows.Forms.Button button_rihanna;
    }
}