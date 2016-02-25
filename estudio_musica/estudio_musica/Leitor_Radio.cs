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

        private void Leitor_Radio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
