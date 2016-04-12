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
            radio_player.uiMode = "none";
        }

        int vol;

        private void Leitor_Radio_Load(object sender, EventArgs e)
        {
            lista_radios.Items.Add("RFM");
            lista_radios.Items.Add("Antena 1");
            lista_radios.Items.Add("Rádio Gilão");
            lista_radios.Items.Add("Total FM");
            lista_radios.Items.Add("Antena 3");
            lista_radios.Items.Add("Rádoio BBC");

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
                    URL = "mms://rdp.oninet.pt/antena1";
                    break;
                case 2:
                    URL = "http://centova.radios.pt:9440/stream";
                    break;
                case 3:
                    URL = "http://www.totalfm.pt:8000/";
                    break;
                case 4:
                    URL = "http://www.bbc.co.uk/1xtra/realmedia/1xtra.asx";
                    break;
                case 5:
                    URL = "mms://rdp.oninet.pt/antena3";
                    break;
                default:
                    MessageBox.Show("Selecione um rádio da lista antes de clicar no botão \"Play\".");
                    break;
            }
            if (!URL.Equals("")) radio_player.URL = URL;

            button_stop.Image = Properties.Resources.but_stop_red;
            button_stop.Enabled = true;
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            radio_player.Ctlcontrols.stop();
            button_stop.Image = Properties.Resources.but_stop_red_oculto;
            button_stop.Enabled = false;
        }

        private void trackBar_volume_Scroll(object sender, EventArgs e)
        {
            label_volume.Text = trackBar_volume.Value.ToString() + "%";

            if (radio_player != null && trackBar_volume != null)
                radio_player.settings.volume = trackBar_volume.Value * 1;
        }

        private void trackBar_volume_ValueChanged(object sender, EventArgs e)
        {
            label_volume.Text = trackBar_volume.Value.ToString() + "%";

            if (radio_player != null && trackBar_volume != null)
                radio_player.settings.volume = trackBar_volume.Value * 1;

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
                radio_player.settings.mute = true;
                vol = 1;
                button_mute.Image = Properties.Resources.but_mute_red;
            }
            else if (vol == 1)
            {
                radio_player.settings.mute = false;
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
            radio_player.Ctlcontrols.stop();
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
