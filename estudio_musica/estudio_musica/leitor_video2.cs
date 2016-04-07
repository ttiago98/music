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
    public partial class leitor_video : Form
    {
        public leitor_video()
        {
            InitializeComponent();
        }

        private void button_arctic_monkeys_Click(object sender, EventArgs e)
        {
            youtube_player.Movie = "https://www.youtube.com/v/bpOSxM0rNPM&list=PL3s4G5l5nwI99ZyY19i2yFbb7SrM_0yIa";
            youtube_player.Play();
        }

        private void button_metalica_Click(object sender, EventArgs e)
        {
            youtube_player.Movie = "https://www.youtube.com/v/7iOmo0ZuyNk&list=PL92485BFE5A6F278A";
            youtube_player.Play();
        }

        private void button_richie_campbell_Click(object sender, EventArgs e)
        {
            youtube_player.Movie = "https://www.youtube.com/v/QnV8yPkaJAk&list=PLFEFDDEC79CFD99BB&index=1";
            youtube_player.Play();
        }

        private void button_pesquisar_Click(object sender, EventArgs e)
        {
            youtube_player.Movie = textBox_pesquisa.Text;
            youtube_player.Play();
        }

        private void button_video_player_Click(object sender, EventArgs e)
        {
            youtube_player.Visible = false;
            button_arctic_monkeys.Visible = false;
            button_metalica.Visible = false;
            button_richie_campbell.Visible = false;
            button_pesquisar.Visible = false;
            textBox_pesquisa.Visible = false;
            video_player.Visible = true;
            trackBar_volume.Visible = true;

            video_player.Visible = true;

            button_video_player.Enabled = false;
            button_youtube_player.Enabled = true;

            button_youtube_player.Image = Properties.Resources.but_youtube;
            button_video_player.Image = Properties.Resources.but_video_player_oculto;
        }

        private void button_youtube_player_Click(object sender, EventArgs e)
        {
            youtube_player.Visible = true;
            button_arctic_monkeys.Visible = true;
            button_metalica.Visible = true;
            button_richie_campbell.Visible = true;
            button_pesquisar.Visible = true;
            textBox_pesquisa.Visible = true;
            video_player.Visible = false;
            trackBar_volume.Visible = false;

            button_youtube_player.Enabled = false;
            button_video_player.Enabled = true;

            button_video_player.Image = Properties.Resources.but_video_player;
            button_youtube_player.Image = Properties.Resources.but_youtube_oculto;

        }

        private void button_voltar_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void leitor_video2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void trackBar_volume_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar_volume_ValueChanged(object sender, EventArgs e)
        {
            label_volume.Text = trackBar_volume.Value.ToString() + "%";


        }
    }
}
