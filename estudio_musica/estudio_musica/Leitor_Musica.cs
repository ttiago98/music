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
        }

        string[] files, path;
        int vol;

        private void button_importar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog1.SafeFileNames;
                path = openFileDialog1.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    lista_musicas.Items.Add(files[i]);
                }
            }
        }

        private void lista_musicas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                axWindowsMediaPlayer1.URL = path[lista_musicas.SelectedIndex];
            }
            catch (Exception)
            {
                MessageBox.Show("Introduza / Selecione uma musica");
            }
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            button_pausa.Image = Properties.Resources.pausa_green;
            timer1.Start();
        }

        private void button_pausa_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            button_pausa.Image = Properties.Resources.pausa_red;
            timer1.Stop();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            timer1.Stop();
            trackBar_musica.Value = 0;
            label_tempo.Text = "00:00"; 

        }

        private void button_proxima_musica_Click(object sender, EventArgs e)
        {
            if (lista_musicas.SelectedIndex < lista_musicas.Items.Count - 1)
            {
                axWindowsMediaPlayer1.Ctlcontrols.next();

                lista_musicas.SelectedIndex = lista_musicas.SelectedIndex + 1;

                axWindowsMediaPlayer1.URL = path[lista_musicas.SelectedIndex];

            }
        }

        private void button_musica_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer1.Ctlcontrols.previous();

                lista_musicas.SelectedIndex = lista_musicas.SelectedIndex - 1;

                axWindowsMediaPlayer1.URL = path[lista_musicas.SelectedIndex];
            }
            catch (Exception)
            {

            }
        }

        private void trackBar_volume_ValueChanged(object sender, EventArgs e)
        {
            label_volume.Text = trackBar_volume.Value.ToString() + "%";

            if (axWindowsMediaPlayer1 != null && trackBar_volume != null)
                axWindowsMediaPlayer1.settings.volume = trackBar_volume.Value * 1;
        }

        private void button_mute_Click(object sender, EventArgs e)
        {
            if (vol == 0)
            {
                axWindowsMediaPlayer1.settings.mute = true;
                vol = 1;
                button_mute.Image = Properties.Resources.mute;
            }
            else if (vol == 1)
            {
                axWindowsMediaPlayer1.settings.mute = false;
                vol = 0;
                button_mute.Image = Properties.Resources.sound;

            }

        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            lista_musicas.Items.Remove(lista_musicas.SelectedItem);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            try
            {
                if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)

                if (lista_musicas.SelectedIndex < lista_musicas.Items.Count - 1)
                {
                    lista_musicas.SelectedIndex = lista_musicas.SelectedIndex + 1;

                    axWindowsMediaPlayer1.URL = path[lista_musicas.SelectedIndex];
                }

                else
                {

                lista_musicas.SelectedIndex = lista_musicas.SelectedIndex = -1; 

                }

                label_tempo.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString();

                label_duracao.Text = axWindowsMediaPlayer1.currentMedia.durationString;

                trackBar_musica.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

            }
            catch (Exception)
            {

            }
        }

        private void checkBox_reproduzir_tudo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_reproduzir_tudo.Checked == true)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 3)

            {
                trackBar_musica.Maximum = (int)axWindowsMediaPlayer1.currentMedia.duration;
                double dur = axWindowsMediaPlayer1.currentMedia.duration;

                try
                {

                    trackBar_volume.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                }
                catch (Exception)
                {

                }

            }
        }

        private void trackBar_musica_Scroll(object sender, EventArgs e)
        {
        try {
            double duration = double.Parse(trackBar_musica.Value.ToString()) / double.Parse(trackBar_musica.Maximum.ToString());
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = axWindowsMediaPlayer1.currentMedia.duration * duration;
            }
        catch(Exception)
            {
    
            }
        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
            axWindowsMediaPlayer1.Ctlcontrols.stop();

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
