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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ficha_tecnica));
            this.label_verificarbd = new System.Windows.Forms.Label();
            this.button_sair = new System.Windows.Forms.PictureBox();
            this.button_voltar = new System.Windows.Forms.PictureBox();
            this.estudi_musicaDataSet = new estudio_musica.estudi_musicaDataSet();
            this.artistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artistaTableAdapter = new estudio_musica.estudi_musicaDataSetTableAdapters.artistaTableAdapter();
            this.tableAdapterManager = new estudio_musica.estudi_musicaDataSetTableAdapters.TableAdapterManager();
            this.generoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generoTableAdapter = new estudio_musica.estudi_musicaDataSetTableAdapters.generoTableAdapter();
            this.generoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_id = new System.Windows.Forms.Label();
            this.label_genero = new System.Windows.Forms.Label();
            this.label_carreira = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_genero = new System.Windows.Forms.TextBox();
            this.textBox_carreira = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.button_sair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudi_musicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label_verificarbd
            // 
            this.label_verificarbd.AutoSize = true;
            this.label_verificarbd.BackColor = System.Drawing.Color.Transparent;
            this.label_verificarbd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_verificarbd.Location = new System.Drawing.Point(10, 11);
            this.label_verificarbd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_verificarbd.Name = "label_verificarbd";
            this.label_verificarbd.Size = new System.Drawing.Size(0, 13);
            this.label_verificarbd.TabIndex = 0;
            // 
            // button_sair
            // 
            this.button_sair.BackColor = System.Drawing.Color.Transparent;
            this.button_sair.Image = ((System.Drawing.Image)(resources.GetObject("button_sair.Image")));
            this.button_sair.Location = new System.Drawing.Point(708, 317);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(75, 41);
            this.button_sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_sair.TabIndex = 9;
            this.button_sair.TabStop = false;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // button_voltar
            // 
            this.button_voltar.BackColor = System.Drawing.Color.Transparent;
            this.button_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_voltar.Image = ((System.Drawing.Image)(resources.GetObject("button_voltar.Image")));
            this.button_voltar.Location = new System.Drawing.Point(12, 317);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(65, 41);
            this.button_voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_voltar.TabIndex = 24;
            this.button_voltar.TabStop = false;
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
            // 
            // estudi_musicaDataSet
            // 
            this.estudi_musicaDataSet.DataSetName = "estudi_musicaDataSet";
            this.estudi_musicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artistaBindingSource
            // 
            this.artistaBindingSource.DataMember = "artista";
            this.artistaBindingSource.DataSource = this.estudi_musicaDataSet;
            // 
            // artistaTableAdapter
            // 
            this.artistaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.albumTableAdapter = null;
            this.tableAdapterManager.artistaTableAdapter = this.artistaTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.generoTableAdapter = null;
            this.tableAdapterManager.musicaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = estudio_musica.estudi_musicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // generoBindingSource
            // 
            this.generoBindingSource.DataMember = "genero";
            this.generoBindingSource.DataSource = this.estudi_musicaDataSet;
            // 
            // generoTableAdapter
            // 
            this.generoTableAdapter.ClearBeforeFill = true;
            // 
            // generoDataGridView
            // 
            this.generoDataGridView.AutoGenerateColumns = false;
            this.generoDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.generoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.generoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.generoDataGridView.DataSource = this.generoBindingSource;
            this.generoDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.generoDataGridView.Location = new System.Drawing.Point(520, 48);
            this.generoDataGridView.Name = "generoDataGridView";
            this.generoDataGridView.Size = new System.Drawing.Size(245, 220);
            this.generoDataGridView.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID_genero";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID_genero";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "tipo";
            this.dataGridViewTextBoxColumn6.HeaderText = "tipo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(180, 71);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(53, 13);
            this.label_id.TabIndex = 25;
            this.label_id.Text = "ID Artista:";
            // 
            // label_genero
            // 
            this.label_genero.AutoSize = true;
            this.label_genero.Location = new System.Drawing.Point(180, 116);
            this.label_genero.Name = "label_genero";
            this.label_genero.Size = new System.Drawing.Size(45, 13);
            this.label_genero.TabIndex = 26;
            this.label_genero.Text = "Género:";
            // 
            // label_carreira
            // 
            this.label_carreira.AutoSize = true;
            this.label_carreira.Location = new System.Drawing.Point(180, 162);
            this.label_carreira.Name = "label_carreira";
            this.label_carreira.Size = new System.Drawing.Size(89, 13);
            this.label_carreira.TabIndex = 27;
            this.label_carreira.Text = "Ínicio de Carreira:";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(281, 64);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 28;
            // 
            // textBox_genero
            // 
            this.textBox_genero.Location = new System.Drawing.Point(281, 113);
            this.textBox_genero.Name = "textBox_genero";
            this.textBox_genero.Size = new System.Drawing.Size(100, 20);
            this.textBox_genero.TabIndex = 29;
            // 
            // textBox_carreira
            // 
            this.textBox_carreira.Location = new System.Drawing.Point(281, 162);
            this.textBox_carreira.Name = "textBox_carreira";
            this.textBox_carreira.Size = new System.Drawing.Size(100, 20);
            this.textBox_carreira.TabIndex = 30;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ficha_tecnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 386);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox_carreira);
            this.Controls.Add(this.textBox_genero);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_carreira);
            this.Controls.Add(this.label_genero);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.generoDataGridView);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.label_verificarbd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ficha_tecnica";
            this.Text = "Ficha Tecnica";
            this.Load += new System.EventHandler(this.ficha_tecnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.button_sair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_voltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudi_musicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_verificarbd;
        private System.Windows.Forms.PictureBox button_sair;
        private System.Windows.Forms.PictureBox button_voltar;
        private estudi_musicaDataSet estudi_musicaDataSet;
        private System.Windows.Forms.BindingSource artistaBindingSource;
        private estudi_musicaDataSetTableAdapters.artistaTableAdapter artistaTableAdapter;
        private estudi_musicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource generoBindingSource;
        private estudi_musicaDataSetTableAdapters.generoTableAdapter generoTableAdapter;
        private System.Windows.Forms.DataGridView generoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_genero;
        private System.Windows.Forms.Label label_carreira;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_genero;
        private System.Windows.Forms.TextBox textBox_carreira;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}