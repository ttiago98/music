﻿using System;
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
            video_player.uiMode = "none";
        }

        int vol;

        // Youtube Player

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

        //Botões de Acesso

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
            label_volume.Visible = true;

            video_player.Visible = true;

            button_video_player.Enabled = false;
            button_youtube_player.Enabled = true;

            button_youtube_player.Image = Properties.Resources.but_youtube;
            button_video_player.Image = Properties.Resources.but_video_player_oculto;

            video_player.Ctlenabled = false;
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
            label_volume.Visible = false;

            button_youtube_player.Enabled = false;
            button_video_player.Enabled = true;

            button_video_player.Image = Properties.Resources.but_video_player;
            button_youtube_player.Image = Properties.Resources.but_youtube_oculto;

        }

        // Video Player

        private void button_abrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            video_player.URL = openFileDialog1.FileName;

            timer1.Start();

            button_pausa.Image = Properties.Resources.but_pausa_azul;
            button_play.Image = Properties.Resources.but_play_azul;
            button_avancar.Image = Properties.Resources.but_proximo_azul;
            button_recuar.Image = Properties.Resources.but_anterior_azul;

            button_pausa.Enabled = true;
            button_play.Enabled = true;
            button_avancar.Enabled = true;
            button_recuar.Enabled = true;

            label_duracao.Visible = true;
            label_separador.Visible = true;
            label_tempo.Visible = true;
        }

        private void button_pausa_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            video_player.Ctlcontrols.pause();

            button_play.Enabled = true;
            button_pausa.Enabled = false;

            button_play.Visible = true;
            button_pausa.Visible = false;
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            timer1.Start();
            video_player.Ctlcontrols.play();

            button_pausa.Enabled = true;
            button_play.Enabled = false;

            button_pausa.Visible = true;
            button_play.Visible = false;
        }

        private void button_avancar_Click(object sender, EventArgs e)
        {

        }
        private void button_recuar_Click(object sender, EventArgs e)
        {

        }

        private void trackBar_volume_ValueChanged(object sender, EventArgs e)
        {
            label_volume.Text = trackBar_volume.Value.ToString() + "%";

            if (video_player != null && trackBar_volume != null)
                video_player.settings.volume = trackBar_volume.Value * 1;

            if (trackBar_volume.Value == 0)
                button_mute.Image = Properties.Resources.but_mute_azul;

            if (trackBar_volume.Value >= 1 && trackBar_volume.Value < 33)
                button_mute.Image = Properties.Resources.but_som_azul_1;

            if (trackBar_volume.Value >= 33 && trackBar_volume.Value < 66)
                button_mute.Image = Properties.Resources.but_som_azul_2;

            if (trackBar_volume.Value >= 66)
                button_mute.Image = Properties.Resources.but_som_azul_3;
        }

        private void button_mute_Click(object sender, EventArgs e)
        {
            if (vol == 0)
            {
                video_player.settings.mute = true;
                vol = 1;
                button_mute.Image = Properties.Resources.but_mute_red;
            }
            else if (vol == 1)
            {
                video_player.settings.mute = false;
                vol = 0;

                if (trackBar_volume.Value >= 1 && trackBar_volume.Value < 33)
                    button_mute.Image = Properties.Resources.but_som_azul_1;

                if (trackBar_volume.Value >= 33 && trackBar_volume.Value < 66)
                    button_mute.Image = Properties.Resources.but_som_azul_2;

                if (trackBar_volume.Value >= 66)
                    button_mute.Image = Properties.Resources.but_som_azul_3;
            }
        }

        private void trackBar_video_Scroll(object sender, EventArgs e)
        {
            try
            {
                double duration = double.Parse(trackBar_video.Value.ToString()) / double.Parse(trackBar_video.Maximum.ToString());
                video_player.Ctlcontrols.currentPosition = video_player.currentMedia.duration * duration;
            }
            catch (Exception)
            {

            }
        }

        private void video_player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 3)

            {
                trackBar_video.Maximum = (int)video_player.currentMedia.duration;
                double dur = video_player.currentMedia.duration;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_tempo.Text = video_player.Ctlcontrols.currentPositionString;
            label_duracao.Text = video_player.currentMedia.durationString;

            trackBar_video.Value = (int)video_player.Ctlcontrols.currentPosition;
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
    }
}
