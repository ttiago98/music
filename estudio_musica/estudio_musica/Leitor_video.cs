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
    }
}
