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


        //configurar o caminho para a base de dados
        private OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=estudi_musica.accdb;
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

            Application.Exit();            
        }



        private void button_inserir_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("insert into artista values(@ID_artista, @nome, @genero, @data_carreira)", connection);
            cmd.Connection = connection;

            connection.Open();

                try
            {

                cmd.Parameters.AddWithValue("@ID_artista", OleDbType.VarChar).Value = textBox_id.Text.ToString();
                cmd.Parameters.AddWithValue("@nome", OleDbType.VarChar).Value = textBox_nome.Text.ToString();
                cmd.Parameters.AddWithValue("@genero", OleDbType.VarChar).Value = textBox_genero.Text.ToString();
                cmd.Parameters.AddWithValue("@data_carreira", OleDbType.VarChar).Value = textBox_carreira.Text.ToString();


                cmd.ExecuteNonQuery();
                connection.Close();

                    MessageBox.Show("Dados inseridos com Sucesso!");

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
                MessageBox.Show("Artista apagado com sucesso!");

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

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connection;

                // 	oleDbCommand update = new oleDbCommand("UPDATE contactList  SET fname = '" + fnameTextBox.Text + "', lname = '" + lnameTextBox.Text + "', <and so on...> WHERE id = '" + recordnumb + "', oleDbConnection);

                OleDbCommand update = new OleDbCommand("UPDATE artista  SET nome = '" + textBox_nome.Text + "' ,genero = '" + textBox_genero.Text + "' ,data_carreira= '" +textBox_carreira.Text+ "'  WHERE ID_artista = " + textBox_id.Text+ "" ,connection);

                connection.Open();
                update.ExecuteNonQuery();
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

















