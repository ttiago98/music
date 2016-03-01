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

        private void Leitor_Radio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }

        private void Leitor_Radio_Load(object sender, EventArgs e)
        {
            lista_radios.Items.Add("RFM");
            lista_radios.Items.Add("Rádio Comercial");
            lista_radios.Items.Add("M80");
            lista_radios.Items.Add("Cidade FM");
            lista_radios.Items.Add("Antena 1");
            lista_radios.Items.Add("Rádio Renascença");
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            string URL = string.Empty;
            switch (lista_radios.SelectedIndex)
            {
                case 0:
                    URL = "mms://195.23.102.196/cidadecbr48 ";
                    break;
                case 1:
                    URL = "http://centova.radios.pt:9440/stream";
                    break;
                case 2:
                    URL = "http://www.totalfm.pt:8000/";
                    break;
                case 3:
                    URL = "mms://195.23.102.196/";
                    break;
                case 4:
                    URL = "mms://195.245.168.21/antena1";
                    break;
                case 5:
                    URL = "";
                    break;
                default:
                    MessageBox.Show("Selecione um rádio da lista e clique no botão \"Play\".");
                    break;
            }
            if (!URL.Equals("")) axWindowsMediaPlayer1.URL = URL;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
