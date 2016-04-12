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
    public partial class Leitor_Musica : Form
    {
        public Leitor_Musica()
        {
            InitializeComponent();
            player_musica.uiMode = "none";
        }

        string[] files;
        List<string> path = new List<string>();
        int vol;

        private void button_abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog1.SafeFileNames;
                foreach (string s in openFileDialog1.FileNames)
                {
                    path.Add(s);
                }

                for (int i = 0; i < files.Length; i++)
                {
                    lista_musicas.Items.Add(files[i]);
                }
            }
        }

        private void lista_musicas_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            timer1.Start();
            player_musica.URL = path[lista_musicas.SelectedIndex];

            button_stop.Image = Properties.Resources.but_stop_verde;
            button_stop.Enabled = true;

            label_duracao.Visible = true;
            label_separador.Visible = true;
            label_tempo.Visible = true;

        }

        private void button_play_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Start();
                player_musica.Ctlcontrols.play();
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione uma música");
            }
            button_play.Image = Properties.Resources.but_play_verde_oculto;
            button_pausa.Image = Properties.Resources.but_pausa_verde;
            button_stop.Image = Properties.Resources.but_stop_verde;
            button_stop.Enabled = true;
            button_pausa.Enabled = true;
            button_play.Enabled = false;
        }

        private void button_pausa_Click(object sender, EventArgs e)
        {
            player_musica.Ctlcontrols.pause();
            timer1.Stop();

            button_pausa.Image = Properties.Resources.but_pausa_verde_oculto;
            button_play.Image = Properties.Resources.but_play_verde;
            button_stop.Image = Properties.Resources.but_stop_verde;
            button_stop.Enabled = true;
            button_play.Enabled = true;
            button_pausa.Enabled = false;

        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            player_musica.Ctlcontrols.stop();
            timer1.Stop();
            trackBar_musica.Value = 0;
            label_tempo.Text = "00:00";

            button_play.Image = Properties.Resources.but_play_verde;
            button_pausa.Image = Properties.Resources.but_pausa_verde;
            button_stop.Image = Properties.Resources.but_stop_verde_oculto;
            button_stop.Enabled = false;
            button_pausa.Enabled = true;
            button_play.Enabled = true;


        }

        private void button_proxima_musica_Click(object sender, EventArgs e)
        {
            if (lista_musicas.SelectedIndex < lista_musicas.Items.Count - 1)
            {
                player_musica.Ctlcontrols.next();

                lista_musicas.SelectedIndex = lista_musicas.SelectedIndex + 1;

                player_musica.URL = path[lista_musicas.SelectedIndex];

            }
        }

        private void button_musica_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                player_musica.Ctlcontrols.previous();

                lista_musicas.SelectedIndex = lista_musicas.SelectedIndex - 1;

                player_musica.URL = path[lista_musicas.SelectedIndex];
            }
            catch (Exception)
            {

            }
        }

        private void trackBar_volume_ValueChanged(object sender, EventArgs e)
        {
            label_volume.Text = trackBar_volume.Value.ToString() + "%";

            if (player_musica != null && trackBar_volume != null)
                player_musica.settings.volume = trackBar_volume.Value * 1;

            if (trackBar_volume.Value == 0)
                button_mute.Image = Properties.Resources.but_mute_verde;

            if (trackBar_volume.Value >= 1 && trackBar_volume.Value < 33)
                button_mute.Image = Properties.Resources.but_som_verde_1;

            if (trackBar_volume.Value >= 33 && trackBar_volume.Value < 66)
                button_mute.Image = Properties.Resources.but_som_verde_2;

            if (trackBar_volume.Value >= 66)
                button_mute.Image = Properties.Resources.but_som_verde_3;
        }

        private void button_mute_Click(object sender, EventArgs e)
        {
            if (vol == 0)
            {
                player_musica.settings.mute = true;
                vol = 1;
                button_mute.Image = Properties.Resources.but_mute_red;
            }
            else if (vol == 1)
            {
                player_musica.settings.mute = false;
                vol = 0;

                if (trackBar_volume.Value >= 1 && trackBar_volume.Value < 33)
                    button_mute.Image = Properties.Resources.but_som_verde_1;

                if (trackBar_volume.Value >= 33 && trackBar_volume.Value < 66)
                    button_mute.Image = Properties.Resources.but_som_verde_2;

                if (trackBar_volume.Value >= 66)
                    button_mute.Image = Properties.Resources.but_som_verde_3;

            }

        }

        private void button_limpar_selecionado_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    path.RemoveAt(lista_musicas.SelectedIndex);
                    lista_musicas.Items.Remove(lista_musicas.SelectedItem);

                    player_musica.Ctlcontrols.stop();
                }

                catch (Exception)
                {
                    MessageBox.Show("Selecione a música que pretende eliminar");
                }
            }
        }

        private void button_limpar_tudo_Click(object sender, EventArgs e)
        {
            player_musica.Ctlcontrols.stop();
            lista_musicas.Items.Clear();
            path.Clear();

            button_pausa.Image = Properties.Resources.but_pausa_verde_oculto;
            button_proxima_musica.Image = Properties.Resources.but_proximo_verde_oculto;
            button_musica_anterior.Image = Properties.Resources.but_anterior_oculto;
            button_stop.Image = Properties.Resources.but_stop_verde_oculto;

            button_pausa.Enabled = false;
            button_proxima_musica.Enabled = false;
            button_musica_anterior.Enabled = false;
            button_stop.Enabled = false;

            button_limpar_selecionado.Visible = false;
            button_limpar_tudo.Visible = false;
            label_duracao.Visible = false;
            label_separador.Visible = false;
            label_tempo.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (player_musica.playState == WMPLib.WMPPlayState.wmppsStopped)

                    if (lista_musicas.SelectedIndex < lista_musicas.Items.Count - 1)
                    {
                        lista_musicas.SelectedIndex = lista_musicas.SelectedIndex + 1;

                        player_musica.URL = path[lista_musicas.SelectedIndex];
                    }

                    else
                    {

                        lista_musicas.SelectedIndex = lista_musicas.SelectedIndex = -1;

                    }

                label_tempo.Text = player_musica.Ctlcontrols.currentPositionString;
                label_duracao.Text = player_musica.currentMedia.durationString;

                trackBar_musica.Value = (int)player_musica.Ctlcontrols.currentPosition;

            }
            catch (Exception)
            {

            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 3)

            {
                trackBar_musica.Maximum = (int)player_musica.currentMedia.duration;
                double dur = player_musica.currentMedia.duration;

                button_pausa.Image = Properties.Resources.but_pausa_verde;
                button_proxima_musica.Image = Properties.Resources.but_proximo_verde;
                button_musica_anterior.Image = Properties.Resources.but_anterior_verde;

                button_pausa.Enabled = true;
                button_proxima_musica.Enabled = true;
                button_musica_anterior.Enabled = true;

                button_limpar_selecionado.Visible = true;
                button_limpar_tudo.Visible = true;

            }
        }

        private void trackBar_musica_Scroll(object sender, EventArgs e)
        {
            try
            {
                double duration = double.Parse(trackBar_musica.Value.ToString()) / double.Parse(trackBar_musica.Maximum.ToString());
                player_musica.Ctlcontrols.currentPosition = player_musica.currentMedia.duration * duration;
            }
            catch (Exception)
            {

            }
        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
            player_musica.Ctlcontrols.stop();
            timer1.Stop();

        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Leitor_Musica_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
