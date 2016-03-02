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
        public ficha_tecnica()
        {
            InitializeComponent();
        }

        private void ficha_tecnica_Load(object sender, EventArgs e)
        {

            // criar conexão com a base de dados
            OleDbConnection connection = new OleDbConnection ();
            //configurar o caminho para a base de dados
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\;
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
    }


        }



    

