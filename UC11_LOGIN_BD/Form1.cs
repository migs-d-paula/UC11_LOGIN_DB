using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UC11_LOGIN_BD
{
    public partial class Form1 : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        public Form1()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=login_db;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
        }

        private void buttonENTRAR_Click(object sender, EventArgs e)
        {

        }

        private void buttonCADASTRAR_Click(object sender, EventArgs e)
        {
            conexao.Open();
            comando.CommandText = "INSERT INTO tbl_usuarios(usuario, senha) VALUES ('" + textBoxUSUARIO.Text + "', '" + textBoxSENHA.Text + "');" ;

            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {

            }
        }
    }
}
