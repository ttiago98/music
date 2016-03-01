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

        private void Leitor_video_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button_rihanna_Click(object sender, EventArgs e)
        {
            youtube_player.Movie = "https://www.youtube.com/v/pa14VNsdSYM&list=RDEMaFGiAZ4Nb5ktVatP3wi-Dw&index=1";
        }

        private void button_metalica_Click(object sender, EventArgs e)
        {
            youtube_player.Movie = "https://www.youtube.com/v/Tj75Arhq5ho&list=RDEMAkKpoB62G5Wmtp0nQxfrDg";
        }

        private void button_richie_Click(object sender, EventArgs e)
        {
            youtube_player.Movie = "https://www.youtube.com/v/pRmQyN8CU8Q&list=RDEM_ieGoko8ewCal5_Og5B-OA";
        }

    }
}
