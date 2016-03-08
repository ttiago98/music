using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace estudio_musica
{
    public partial class ficha_tecnica : Form
    {

        private OleDbConnection connection = new OleDbConnection() ;

        public ficha_tecnica()
        {
            InitializeComponent();
        }

        private void ficha_tecnica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estudi_musicaDataSet.genero' table. You can move, or remove it, as needed.
            this.generoTableAdapter.Fill(this.estudi_musicaDataSet.genero);
            //configurar o caminho para a base de dados
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Z:\2ºAno\PSI\Módulo XI - Programação Orientada a Objectos Avançada\Trabalho gestao estudio musica\estudio_musica\estudi_musica.accdb;
            Persist Security Info=False;";
            //abrir conexão
            connection.Open();
            label_verificarbd.Text = "Conectado com Base de Dados";
            connection.Close();



        }


        private void ficha_tecnica_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_inserir_Click(object sender, EventArgs e)
        {



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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT nome * FROM estudi_musica = '" + comboBox1.Items + "'", connection); 
             

        }
    }
}
    


    

