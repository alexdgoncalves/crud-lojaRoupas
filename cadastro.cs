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


namespace clothes_store
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string tipo = textBox2.Text;
            string preco = textBox3.Text;

            MySqlConnection conexao = new MySqlConnection();

            conexao.ConnectionString = ("SERVER=127.0.0.1; DATABASE=clothes_store; UID=root; PASSWORD=;");
            conexao.Open();

            string inserir = "INSERT INTO cadastro (nome, tipo, preco ) VALUES ('" + nome + "', '" + tipo + "', '" + preco + "')";

            MySqlCommand comandos = new MySqlCommand(inserir, conexao);

            comandos.ExecuteNonQuery();

            conexao.Close();

            MessageBox.Show("Dados cadastrados com sucesso!!!");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";


            conexao.Close();
        }
    }
}
