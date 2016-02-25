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
            this.button_sair = new System.Windows.Forms.Button();
            this.button_voltar = new System.Windows.Forms.Button();
            this.button_play = new System.Windows.Forms.Button();
            this.button_pausa = new System.Windows.Forms.Button();
            this.button__mais_volume = new System.Windows.Forms.Button();
            this.button_menos_volume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_sair
            // 
            this.button_sair.Location = new System.Drawing.Point(393, 330);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(75, 23);
            this.button_sair.TabIndex = 0;
            this.button_sair.Text = "Sair";
            this.button_sair.UseVisualStyleBackColor = true;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // button_voltar
            // 
            this.button_voltar.Location = new System.Drawing.Point(12, 330);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(75, 23);
            this.button_voltar.TabIndex = 1;
            this.button_voltar.Text = "Voltar Atrás";
            this.button_voltar.UseVisualStyleBackColor = true;
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(70, 273);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(75, 23);
            this.button_play.TabIndex = 2;
            this.button_play.Text = "button1";
            this.button_play.UseVisualStyleBackColor = true;
            // 
            // button_pausa
            // 
            this.button_pausa.Location = new System.Drawing.Point(151, 273);
            this.button_pausa.Name = "button_pausa";
            this.button_pausa.Size = new System.Drawing.Size(75, 23);
            this.button_pausa.TabIndex = 3;
            this.button_pausa.Text = "button2";
            this.button_pausa.UseVisualStyleBackColor = true;
            // 
            // button__mais_volume
            // 
            this.button__mais_volume.Location = new System.Drawing.Point(250, 273);
            this.button__mais_volume.Name = "button__mais_volume";
            this.button__mais_volume.Size = new System.Drawing.Size(75, 23);
            this.button__mais_volume.TabIndex = 4;
            this.button__mais_volume.Text = "button3";
            this.button__mais_volume.UseVisualStyleBackColor = true;
            // 
            // button_menos_volume
            // 
            this.button_menos_volume.Location = new System.Drawing.Point(331, 273);
            this.button_menos_volume.Name = "button_menos_volume";
            this.button_menos_volume.Size = new System.Drawing.Size(75, 23);
            this.button_menos_volume.TabIndex = 5;
            this.button_menos_volume.Text = "button4";
            this.button_menos_volume.UseVisualStyleBackColor = true;
            // 
            // Leitor_Radio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 365);
            this.Controls.Add(this.button_menos_volume);
            this.Controls.Add(this.button__mais_volume);
            this.Controls.Add(this.button_pausa);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.button_sair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Leitor_Radio";
            this.Text = "Leitor de Rádio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Button button_voltar;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_pausa;
        private System.Windows.Forms.Button button__mais_volume;
        private System.Windows.Forms.Button button_menos_volume;
    }
}