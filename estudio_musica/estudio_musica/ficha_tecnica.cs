using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace estudio_musica
{
    public partial class ficha_tecnica : Form
    {
        public ficha_tecnica()
        {
            InitializeComponent();
        }

        private void ficha_tecnica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estudi_musicaDataSet.musica' table. You can move, or remove it, as needed.
            this.musicaTableAdapter.Fill(this.estudi_musicaDataSet.musica);
            // TODO: This line of code loads data into the 'estudi_musicaDataSet.genero' table. You can move, or remove it, as needed.
            this.generoTableAdapter.Fill(this.estudi_musicaDataSet.genero);
            // TODO: This line of code loads data into the 'estudi_musicaDataSet.artista' table. You can move, or remove it, as needed.
            this.artistaTableAdapter.Fill(this.estudi_musicaDataSet.artista);
            // TODO: This line of code loads data into the 'estudi_musicaDataSet.album' table. You can move, or remove it, as needed.
            this.albumTableAdapter.Fill(this.estudi_musicaDataSet.album);



        }


        private void ficha_tecnica_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }


        }



    

