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

        private void Leitor_video_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_metalica_Click(object sender, EventArgs e)
        {
            youtube_player.Movie = "https://www.youtube.com/v/Tj75Arhq5ho&list=RDEMAkKpoB62G5Wmtp0nQxfrDg";
        }

        private void button_richie_campbell_Click(object sender, EventArgs e)
        {
            youtube_player.Movie = "https://www.youtube.com/v/pRmQyN8CU8Q&list=RDEM_ieGoko8ewCal5_Og5B-OA";
        }

        private void button_ed_sheeran_Click(object sender, EventArgs e)
        {
            youtube_player.Movie = "https://www.youtube.com/v/lp-EO5I60KA&list=RDEM_Ktu-TilkxtLvmc9wX1MLQ";
        }

        private void button_arctic_monkeys_Click(object sender, EventArgs e)
        {
            youtube_player.Movie = "https://www.youtube.com/v/bpOSxM0rNPM&list=RDEMThYJ2VcXXNp3GM7AwT24UQ";
        }

        private void button_ice_cube_Click(object sender, EventArgs e)
        {
            youtube_player.Movie = "https://www.youtube.com/v/8CPlF-IEkXQ&list=RDEMU8O1ngHTam_RPtve_gY5fA";
        }

        private void button_red_hot_chili_peppers_Click(object sender, EventArgs e)
        {
            youtube_player.Movie = "https://www.youtube.com/v/YlUKcNNmywk&list=RDEMf5I_WGknwqULRz9t7aGnjw";
        }
    }
}
