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
    public partial class leitor_video2 : Form
    {
        public leitor_video2()
        {
            InitializeComponent();
        }

        private void leitor_video2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
    }
}
