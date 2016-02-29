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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_leitor_musica = new System.Windows.Forms.Button();
            this.button_leitor_radio = new System.Windows.Forms.Button();
            this.button_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_leitor_musica
            // 
            this.button_leitor_musica.Location = new System.Drawing.Point(186, 110);
            this.button_leitor_musica.Name = "button_leitor_musica";
            this.button_leitor_musica.Size = new System.Drawing.Size(177, 85);
            this.button_leitor_musica.TabIndex = 0;
            this.button_leitor_musica.Text = "Leitor de Música";
            this.button_leitor_musica.UseVisualStyleBackColor = true;
            this.button_leitor_musica.Click += new System.EventHandler(this.button_leitor_musica_Click);
            // 
            // button_leitor_radio
            // 
            this.button_leitor_radio.Location = new System.Drawing.Point(186, 263);
            this.button_leitor_radio.Name = "button_leitor_radio";
            this.button_leitor_radio.Size = new System.Drawing.Size(177, 85);
            this.button_leitor_radio.TabIndex = 1;
            this.button_leitor_radio.Text = "Leitor de Rádio";
            this.button_leitor_radio.UseVisualStyleBackColor = true;
            this.button_leitor_radio.Click += new System.EventHandler(this.button_leitor_radio_Click);
            // 
            // button_sair
            // 
            this.button_sair.Location = new System.Drawing.Point(461, 396);
            this.button_sair.Name = "button_sair";
            this.button_sair.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_sair.Size = new System.Drawing.Size(75, 23);
            this.button_sair.TabIndex = 2;
            this.button_sair.Text = "Sair";
            this.button_sair.UseVisualStyleBackColor = false;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(548, 431);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.button_leitor_radio);
            this.Controls.Add(this.button_leitor_musica);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Estúdio Música";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_leitor_musica;
        private System.Windows.Forms.Button button_leitor_radio;
        private System.Windows.Forms.Button button_sair;
    }
}

