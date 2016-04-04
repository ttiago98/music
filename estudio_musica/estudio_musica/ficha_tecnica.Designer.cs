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
            System.Windows.Forms.Label iD_artistaLabel;
            System.Windows.Forms.Label data_carreiraLabel;
            System.Windows.Forms.Label generoLabel;
            System.Windows.Forms.Label nomeLabel;
            this.label_verificarbd = new System.Windows.Forms.Label();
            this.button_sair = new System.Windows.Forms.PictureBox();
            this.button_voltar = new System.Windows.Forms.PictureBox();
            this.estudi_musicaDataSet = new estudio_musica.estudi_musicaDataSet();
            this.artistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artistaTableAdapter = new estudio_musica.estudi_musicaDataSetTableAdapters.artistaTableAdapter();
            this.tableAdapterManager = new estudio_musica.estudi_musicaDataSetTableAdapters.TableAdapterManager();
            this.generoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generoTableAdapter = new estudio_musica.estudi_musicaDataSetTableAdapters.generoTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Button_apagar = new System.Windows.Forms.Button();
            this.button_inserir = new System.Windows.Forms.Button();
            this.textBox_carreira = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_genero = new System.Windows.Forms.TextBox();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_mostrar = new System.Windows.Forms.Button();
            iD_artistaLabel = new System.Windows.Forms.Label();
            data_carreiraLabel = new System.Windows.Forms.Label();
            generoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.button_sair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudi_musicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(iD_artistaLabel);
            this.groupBox1.Controls.Add(this.Button_apagar);
            this.groupBox1.Controls.Add(data_carreiraLabel);
            this.groupBox1.Controls.Add(generoLabel);
            this.groupBox1.Controls.Add(nomeLabel);
            this.groupBox1.Controls.Add(this.button_inserir);
            this.groupBox1.Controls.Add(this.textBox_carreira);
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Controls.Add(this.textBox_genero);
            this.groupBox1.Controls.Add(this.textBox_nome);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(30, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 196);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informação";
            // 
            // iD_artistaLabel
            // 
            iD_artistaLabel.AutoSize = true;
            iD_artistaLabel.BackColor = System.Drawing.Color.White;
            iD_artistaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            iD_artistaLabel.Location = new System.Drawing.Point(18, 16);
            iD_artistaLabel.Name = "iD_artistaLabel";
            iD_artistaLabel.Size = new System.Drawing.Size(52, 13);
            iD_artistaLabel.TabIndex = 24;
            iD_artistaLabel.Text = "ID artista:";
            // 
            // Button_apagar
            // 
            this.Button_apagar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_apagar.Location = new System.Drawing.Point(21, 160);
            this.Button_apagar.Name = "Button_apagar";
            this.Button_apagar.Size = new System.Drawing.Size(172, 25);
            this.Button_apagar.TabIndex = 39;
            this.Button_apagar.Text = "Apagar";
            this.Button_apagar.UseVisualStyleBackColor = true;
            this.Button_apagar.Click += new System.EventHandler(this.Button_apagar_Click);
            // 
            // data_carreiraLabel
            // 
            data_carreiraLabel.AutoSize = true;
            data_carreiraLabel.BackColor = System.Drawing.Color.White;
            data_carreiraLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            data_carreiraLabel.Location = new System.Drawing.Point(18, 94);
            data_carreiraLabel.Name = "data_carreiraLabel";
            data_carreiraLabel.Size = new System.Drawing.Size(69, 13);
            data_carreiraLabel.TabIndex = 30;
            data_carreiraLabel.Text = "data carreira:";
            // 
            // generoLabel
            // 
            generoLabel.AutoSize = true;
            generoLabel.BackColor = System.Drawing.Color.White;
            generoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            generoLabel.Location = new System.Drawing.Point(18, 68);
            generoLabel.Name = "generoLabel";
            generoLabel.Size = new System.Drawing.Size(43, 13);
            generoLabel.TabIndex = 28;
            generoLabel.Text = "genero:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.BackColor = System.Drawing.Color.White;
            nomeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            nomeLabel.Location = new System.Drawing.Point(18, 42);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(36, 13);
            nomeLabel.TabIndex = 26;
            nomeLabel.Text = "nome:";
            // 
            // button_inserir
            // 
            this.button_inserir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_inserir.Location = new System.Drawing.Point(21, 131);
            this.button_inserir.Name = "button_inserir";
            this.button_inserir.Size = new System.Drawing.Size(172, 25);
            this.button_inserir.TabIndex = 32;
            this.button_inserir.Text = "Inserir";
            this.button_inserir.UseVisualStyleBackColor = true;
            this.button_inserir.Click += new System.EventHandler(this.button_inserir_Click);
            // 
            // textBox_carreira
            // 
            this.textBox_carreira.Location = new System.Drawing.Point(93, 87);
            this.textBox_carreira.Name = "textBox_carreira";
            this.textBox_carreira.Size = new System.Drawing.Size(100, 20);
            this.textBox_carreira.TabIndex = 36;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(93, 9);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 33;
            // 
            // textBox_genero
            // 
            this.textBox_genero.Location = new System.Drawing.Point(93, 61);
            this.textBox_genero.Name = "textBox_genero";
            this.textBox_genero.Size = new System.Drawing.Size(100, 20);
            this.textBox_genero.TabIndex = 35;
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(93, 35);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(100, 20);
            this.textBox_nome.TabIndex = 34;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(310, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 190);
            this.dataGridView1.TabIndex = 42;
            // 
            // button_mostrar
            // 
            this.button_mostrar.Location = new System.Drawing.Point(392, 263);
            this.button_mostrar.Name = "button_mostrar";
            this.button_mostrar.Size = new System.Drawing.Size(284, 43);
            this.button_mostrar.TabIndex = 41;
            this.button_mostrar.Text = "Mostrar/Atualizar Tabela";
            this.button_mostrar.UseVisualStyleBackColor = true;
            this.button_mostrar.Click += new System.EventHandler(this.button_mostrar_Click);
            // 
            // ficha_tecnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 386);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_mostrar);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Button_apagar;
        private System.Windows.Forms.Button button_inserir;
        private System.Windows.Forms.TextBox textBox_carreira;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_genero;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_mostrar;
    }
}