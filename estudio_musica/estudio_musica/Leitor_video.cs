using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudio_musica
{
    public partial class Leitor_video : Form
    {
        public Leitor_video()
        {
            InitializeComponent();
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Leitor_video_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_metalica_Click(object sender, EventArgs e)
        {
            youtube_player.Movie = "https://www.youtube.com/v/7iOmo0ZuyNk&list=PL92485BFE5A6F278A";
        }

        private void button_richie_campbell_Click(object sender, EventArgs e)
        {
            youtube_player.Movie = "https://www.youtube.com/v/QnV8yPkaJAk&list=PLFEFDDEC79CFD99BB&index=1";
        }

        private void button_arctic_monkeys_Click(object sender, EventArgs e)
        {
            youtube_player.Movie = "https://www.youtube.com/v/bpOSxM0rNPM&list=PL3s4G5l5nwI99ZyY19i2yFbb7SrM_0yIa";
        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            youtube_player.Movie = textBox_search.Text;
        }
    }
}
