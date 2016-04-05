﻿using System;
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


        //configurar o caminho para a base de dados
        private OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\20253\Desktop\estudio_musica_3\estudio_musica\estudi_musica.accdb;
            Persist Security Info=False;");
        OleDbDataAdapter ad = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        public ficha_tecnica()
        {
            InitializeComponent();
        }


        private void ficha_tecnica_Load(object sender, EventArgs e)
        {

            //testar conexão
            label_verificarbd.Text = "Conectado com Base de Dados";

        }



        private void ficha_tecnica_FormClosing(object sender, FormClosingEventArgs e)
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

        private void ficha_tecnica_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_inserir_Click(object sender, EventArgs e)
        {
            ad.InsertCommand = new OleDbCommand("insert into artista values(@ID_artista, @nome, @genero, @data_carreira)", connection);

            try
            {

                ad.InsertCommand.Parameters.Add("@ID_artista", OleDbType.VarChar).Value = textBox_id.Text.ToString();
                ad.InsertCommand.Parameters.Add("@nome", OleDbType.VarChar).Value = textBox_nome.Text.ToString();
                ad.InsertCommand.Parameters.Add("@genero", OleDbType.VarChar).Value = textBox_genero.Text.ToString();
                ad.InsertCommand.Parameters.Add("@data_carreira", OleDbType.VarChar).Value = textBox_carreira.Text.ToString();

                connection.Open();
                ad.InsertCommand.ExecuteNonQuery();
                connection.Close();

                textBox_id.Clear();
                textBox_nome.Clear();
                textBox_genero.Clear();
                textBox_carreira.Clear();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

            finally
            {
                connection.Close();
            }

        }

        private void button_mostrar_Click(object sender, EventArgs e)
        {

            try
            {

                ad.SelectCommand = new OleDbCommand("select* from artista", connection);

                ds.Clear();
                ad.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                connection.Open();
                ad.SelectCommand.ExecuteNonQuery();
                connection.Close();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

            finally
            {
                connection.Close();
            }
        }

        private void Button_apagar_Click(object sender, EventArgs e)
        {

            try
            {

                ad.DeleteCommand = new OleDbCommand("delete from artista where (ID_artista= " + textBox_id.Text + ")", connection);

                connection.Open();
                ad.DeleteCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Artista apagado com sucesso");

                textBox_id.Clear();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

            finally
            {
                connection.Close();
            }
        }

        private void button_editar_Click(object sender, EventArgs e)
        {

            
                try
                {

                connection.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connection;
                string query ="update artista set nome = nome.text= '"+textBox_nome.Text+"'genero='" +textBox_genero+ "'data_carreira= '" +textBox_carreira+ "'where ID_artista= "  +textBox_id.Text+ "";
                MessageBox.Show(query);
                cmd.CommandText = query;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Informação alterada com sucesso");
                connection.Close();
                

                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

                finally
                {
                    connection.Close();
                }


        }
    }
}

















