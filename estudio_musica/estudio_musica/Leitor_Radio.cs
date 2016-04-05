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
    public partial class Leitor_Radio : Form
    {
        public Leitor_Radio()
        {
            InitializeComponent();
        }

        int vol;

        private void Leitor_Radio_Load(object sender, EventArgs e)
        {
            lista_radios.Items.Add("RFM");
            lista_radios.Items.Add("Rádio ComercialX");
            lista_radios.Items.Add("M80X");
            lista_radios.Items.Add("Cidade FMX");
            lista_radios.Items.Add("Antena 1");
            lista_radios.Items.Add("Rádio Gilão");
            lista_radios.Items.Add("Total FM");
            lista_radios.Items.Add("Mega HitsX");
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            string URL = string.Empty;
            switch (lista_radios.SelectedIndex)
            {
                case 0:
                    URL = "http://rfm.sapo.pt/live/stream_rfm_stw.asx";
                    break;
                case 1:
                    URL = "";
                    break;
                case 2:
                    URL = "";
                    break;
                case 3:
                    URL = "";
                    break;
                case 4:
                    URL = "mms://rdp.oninet.pt/antena1";
                    break;
                case 5:
                    URL = "http://centova.radios.pt:9440/stream";
                    break;
                case 6:
                    URL = "http://www.totalfm.pt:8000/";
                    break;
                case 7:
                    URL = "http://www.megahits.fm/emissao_online_fl.aspx";
                    break;
                default:
                    MessageBox.Show("Selecione um rádio da lista e clique no botão \"Play\".");
                    break;
            }
            if (!URL.Equals("")) axWindowsMediaPlayer1.URL = URL;
        }

        private void button_pausa_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void trackBar_volume_Scroll(object sender, EventArgs e)
        {
            label_volume.Text = trackBar_volume.Value.ToString() + "%";

            if (axWindowsMediaPlayer1 != null && trackBar_volume != null)
                axWindowsMediaPlayer1.settings.volume = trackBar_volume.Value * 1;
        }

        private void trackBar_volume_ValueChanged(object sender, EventArgs e)
        {
            label_volume.Text = trackBar_volume.Value.ToString() + "%";

            if (axWindowsMediaPlayer1 != null && trackBar_volume != null)
                axWindowsMediaPlayer1.settings.volume = trackBar_volume.Value * 1;

            if (trackBar_volume.Value == 0)
                button_mute.Image = Properties.Resources.but_mute_red;

            if (trackBar_volume.Value >= 1 && trackBar_volume.Value < 33)
                button_mute.Image = Properties.Resources.but_som_red_1;

            if (trackBar_volume.Value >= 33 && trackBar_volume.Value < 66)
                button_mute.Image = Properties.Resources.but_som_red_2;

            if (trackBar_volume.Value >= 66)
                button_mute.Image = Properties.Resources.but_som_red_3;

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
                    button_mute.Image = Properties.Resources.but_som_red_1;

                if (trackBar_volume.Value >= 33 && trackBar_volume.Value < 66)
                    button_mute.Image = Properties.Resources.but_som_red_2;

                if (trackBar_volume.Value >= 66)
                    button_mute.Image = Properties.Resources.but_som_red_3;
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

        private void Leitor_Radio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
