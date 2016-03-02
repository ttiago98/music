namespace estudio_musica
{
    partial class ficha_tecnica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ficha_tecnica));
            this.label_verificarbd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_verificarbd
            // 
            this.label_verificarbd.AutoSize = true;
            this.label_verificarbd.BackColor = System.Drawing.Color.Transparent;
            this.label_verificarbd.ForeColor = System.Drawing.Color.White;
            this.label_verificarbd.Location = new System.Drawing.Point(13, 13);
            this.label_verificarbd.Name = "label_verificarbd";
            this.label_verificarbd.Size = new System.Drawing.Size(0, 17);
            this.label_verificarbd.TabIndex = 0;
            // 
            // ficha_tecnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1089, 455);
            this.Controls.Add(this.label_verificarbd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ficha_tecnica";
            this.Text = "ficha_tecnica";
            this.Load += new System.EventHandler(this.ficha_tecnica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_verificarbd;
    }
}