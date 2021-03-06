﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_leitor_musica_Click(object sender, EventArgs e)
        {
            this.Hide();
            Leitor_Musica frm = new Leitor_Musica();
            frm.Show();
        }

        private void button_leitor_radio_Click(object sender, EventArgs e)
        {
            this.Hide();
            Leitor_Radio frm = new Leitor_Radio();
            frm.Show();
        }

        private void button_leitor_video_Click(object sender, EventArgs e)
        {
            this.Hide();
            leitor_video frm = new leitor_video();
            frm.Show();
        }

        private void button_artistas_Click(object sender, EventArgs e)
        {
            this.Hide();
            ficha_tecnica frm = new ficha_tecnica();
            frm.Show();
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
