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

        string[] files;
        List <string> path = new List <string> ();
        int vol;

        private void button_importar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog1.SafeFileNames;
                //path = openFileDialog1.FileNames;
                foreach  (string s in openFileDialog1.FileNames) {
                    path.Add(s);
                }

               
                for (int i = 0; i < files.Length; i++)
                {
                    lista_musicas.Items.Add(files[i]);
                }
            }

            button_pausa.Image = Properties.Resources.but_pausa_verde;
            button_play.Image = Properties.Resources.but_play_verde;
            button_proxima_musica.Image = Properties.Resources.but_proximo_verde;
            button_musica_anterior.Image = Properties.Resources.but_anterior_verde;
            button_stop.Image = Properties.Resources.but_stop_verde;

            button_pausa.Enabled = true;
            button_play.Enabled = true;
            button_proxima_musica.Enabled = true;
            button_musica_anterior.Enabled = true;
            button_stop.Enabled = true;

            button_limpar_selecionado.Visible = true;
            button_limpar_tudo.Visible = true;
        }

        private void lista_musicas_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            timer1.Start();
            axWindowsMediaPlayer1.URL = path[lista_musicas.SelectedIndex];
            label_duracao.Visible = true;
            label_separador.Visible = true;
            label_tempo.Visible = true;

        }

        private void button_play_Click(object sender, EventArgs e)
        {
            try {
                timer1.Start();
                label_duracao.Visible = true;
                label_separador.Visible = true;
                label_tempo.Visible = true;
                
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione uma música");
            }

            axWindowsMediaPlayer1.Ctlcontrols.play();
            button_pausa.Image = Properties.Resources.but_pausa_verde;
            
        }

        private void button_pausa_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            button_pausa.Image = Properties.Resources.but_pausa_red;
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
                axWindowsMediaPlayer1.settings.mute = true;
                vol = 1;
                button_mute.Image = Properties.Resources.but_mute_red;
            }
            else if (vol == 1)
            {
                axWindowsMediaPlayer1.settings.mute = false;
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
                   
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                }

                catch (Exception)
                {
                    MessageBox.Show("Selecione a música que pretende eliminar");
                }
            }
        }

        private void button_limpar_tudo_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            lista_musicas.Items.Clear();
            path.Clear();
            label_duracao.Visible = false;
            label_separador.Visible = false;
            label_tempo.Visible = false;
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

                label_tempo.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                label_duracao.Text = axWindowsMediaPlayer1.currentMedia.durationString;

                trackBar_musica.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

            }
            catch (Exception)
            {

            }
        }

        private void checkBox_reproduzir_tudo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_reproduzir_tudo.Checked == false)
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
