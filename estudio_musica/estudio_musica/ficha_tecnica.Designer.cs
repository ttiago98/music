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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.estudi_musicaDataSet = new estudio_musica.estudi_musicaDataSet();
            this.estudimusicaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumTableAdapter = new estudio_musica.estudi_musicaDataSetTableAdapters.albumTableAdapter();
            this.iDalbumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datalancDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musicasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artistaTableAdapter = new estudio_musica.estudi_musicaDataSetTableAdapters.artistaTableAdapter();
            this.iDartistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacarreiraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.generoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generoTableAdapter = new estudio_musica.estudi_musicaDataSetTableAdapters.generoTableAdapter();
            this.iDgeneroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicaTableAdapter = new estudio_musica.estudi_musicaDataSetTableAdapters.musicaTableAdapter();
            this.iDmusicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datalancDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudi_musicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudimusicaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDalbumDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.artistaDataGridViewTextBoxColumn,
            this.datalancDataGridViewTextBoxColumn,
            this.musicasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.albumBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 84);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDmusicaDataGridViewTextBoxColumn,
            this.artistaDataGridViewTextBoxColumn1,
            this.nomeDataGridViewTextBoxColumn2,
            this.albumDataGridViewTextBoxColumn,
            this.datalancDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.musicaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(9, 287);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(549, 71);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDgeneroDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.generoBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 206);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(245, 75);
            this.dataGridView3.TabIndex = 2;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDartistaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn1,
            this.generoDataGridViewTextBoxColumn,
            this.datacarreiraDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.artistaBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(12, 23);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(444, 74);
            this.dataGridView4.TabIndex = 3;
            // 
            // estudi_musicaDataSet
            // 
            this.estudi_musicaDataSet.DataSetName = "estudi_musicaDataSet";
            this.estudi_musicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estudimusicaDataSetBindingSource
            // 
            this.estudimusicaDataSetBindingSource.DataSource = this.estudi_musicaDataSet;
            this.estudimusicaDataSetBindingSource.Position = 0;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataMember = "album";
            this.albumBindingSource.DataSource = this.estudimusicaDataSetBindingSource;
            // 
            // albumTableAdapter
            // 
            this.albumTableAdapter.ClearBeforeFill = true;
            // 
            // iDalbumDataGridViewTextBoxColumn
            // 
            this.iDalbumDataGridViewTextBoxColumn.DataPropertyName = "ID_album";
            this.iDalbumDataGridViewTextBoxColumn.HeaderText = "ID_album";
            this.iDalbumDataGridViewTextBoxColumn.Name = "iDalbumDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // artistaDataGridViewTextBoxColumn
            // 
            this.artistaDataGridViewTextBoxColumn.DataPropertyName = "artista";
            this.artistaDataGridViewTextBoxColumn.HeaderText = "artista";
            this.artistaDataGridViewTextBoxColumn.Name = "artistaDataGridViewTextBoxColumn";
            // 
            // datalancDataGridViewTextBoxColumn
            // 
            this.datalancDataGridViewTextBoxColumn.DataPropertyName = "data_lanc";
            this.datalancDataGridViewTextBoxColumn.HeaderText = "data_lanc";
            this.datalancDataGridViewTextBoxColumn.Name = "datalancDataGridViewTextBoxColumn";
            // 
            // musicasDataGridViewTextBoxColumn
            // 
            this.musicasDataGridViewTextBoxColumn.DataPropertyName = "musicas";
            this.musicasDataGridViewTextBoxColumn.HeaderText = "musicas";
            this.musicasDataGridViewTextBoxColumn.Name = "musicasDataGridViewTextBoxColumn";
            // 
            // artistaBindingSource
            // 
            this.artistaBindingSource.DataMember = "artista";
            this.artistaBindingSource.DataSource = this.estudimusicaDataSetBindingSource;
            // 
            // artistaTableAdapter
            // 
            this.artistaTableAdapter.ClearBeforeFill = true;
            // 
            // iDartistaDataGridViewTextBoxColumn
            // 
            this.iDartistaDataGridViewTextBoxColumn.DataPropertyName = "ID_artista";
            this.iDartistaDataGridViewTextBoxColumn.HeaderText = "ID_artista";
            this.iDartistaDataGridViewTextBoxColumn.Name = "iDartistaDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "genero";
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            // 
            // datacarreiraDataGridViewTextBoxColumn
            // 
            this.datacarreiraDataGridViewTextBoxColumn.DataPropertyName = "data_carreira";
            this.datacarreiraDataGridViewTextBoxColumn.HeaderText = "data_carreira";
            this.datacarreiraDataGridViewTextBoxColumn.Name = "datacarreiraDataGridViewTextBoxColumn";
            // 
            // albumBindingSource1
            // 
            this.albumBindingSource1.DataMember = "album";
            this.albumBindingSource1.DataSource = this.estudimusicaDataSetBindingSource;
            // 
            // generoBindingSource
            // 
            this.generoBindingSource.DataMember = "genero";
            this.generoBindingSource.DataSource = this.estudimusicaDataSetBindingSource;
            // 
            // generoTableAdapter
            // 
            this.generoTableAdapter.ClearBeforeFill = true;
            // 
            // iDgeneroDataGridViewTextBoxColumn
            // 
            this.iDgeneroDataGridViewTextBoxColumn.DataPropertyName = "ID_genero";
            this.iDgeneroDataGridViewTextBoxColumn.HeaderText = "ID_genero";
            this.iDgeneroDataGridViewTextBoxColumn.Name = "iDgeneroDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // musicaBindingSource
            // 
            this.musicaBindingSource.DataMember = "musica";
            this.musicaBindingSource.DataSource = this.estudimusicaDataSetBindingSource;
            // 
            // musicaTableAdapter
            // 
            this.musicaTableAdapter.ClearBeforeFill = true;
            // 
            // iDmusicaDataGridViewTextBoxColumn
            // 
            this.iDmusicaDataGridViewTextBoxColumn.DataPropertyName = "ID_musica";
            this.iDmusicaDataGridViewTextBoxColumn.HeaderText = "ID_musica";
            this.iDmusicaDataGridViewTextBoxColumn.Name = "iDmusicaDataGridViewTextBoxColumn";
            // 
            // artistaDataGridViewTextBoxColumn1
            // 
            this.artistaDataGridViewTextBoxColumn1.DataPropertyName = "artista";
            this.artistaDataGridViewTextBoxColumn1.HeaderText = "artista";
            this.artistaDataGridViewTextBoxColumn1.Name = "artistaDataGridViewTextBoxColumn1";
            // 
            // nomeDataGridViewTextBoxColumn2
            // 
            this.nomeDataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn2.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn2.Name = "nomeDataGridViewTextBoxColumn2";
            // 
            // albumDataGridViewTextBoxColumn
            // 
            this.albumDataGridViewTextBoxColumn.DataPropertyName = "album";
            this.albumDataGridViewTextBoxColumn.HeaderText = "album";
            this.albumDataGridViewTextBoxColumn.Name = "albumDataGridViewTextBoxColumn";
            // 
            // datalancDataGridViewTextBoxColumn1
            // 
            this.datalancDataGridViewTextBoxColumn1.DataPropertyName = "data_lanc";
            this.datalancDataGridViewTextBoxColumn1.HeaderText = "data_lanc";
            this.datalancDataGridViewTextBoxColumn1.Name = "datalancDataGridViewTextBoxColumn1";
            // 
            // ficha_tecnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 370);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ficha_tecnica";
            this.Text = "ficha_tecnica";
            this.Load += new System.EventHandler(this.ficha_tecnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudi_musicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudimusicaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource estudimusicaDataSetBindingSource;
        private estudi_musicaDataSet estudi_musicaDataSet;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private estudi_musicaDataSetTableAdapters.albumTableAdapter albumTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDalbumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datalancDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musicasDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource artistaBindingSource;
        private estudi_musicaDataSetTableAdapters.artistaTableAdapter artistaTableAdapter;
        private System.Windows.Forms.BindingSource albumBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDartistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacarreiraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource generoBindingSource;
        private estudi_musicaDataSetTableAdapters.generoTableAdapter generoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDgeneroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource musicaBindingSource;
        private estudi_musicaDataSetTableAdapters.musicaTableAdapter musicaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDmusicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datalancDataGridViewTextBoxColumn1;
    }
}