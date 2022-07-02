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
    public partial class alterarRoupa : Form
    {
        public int ID;

        public alterarRoupa(int code)
        {
            InitializeComponent();

            ID = Convert.ToInt32(code);

            MySqlConnection conectar = new MySqlConnection("SERVER = localhost; DATABASE=clothes_store; UID=root; PASSWORD=");
            conectar.Open();

            MySqlCommand Consulta = new MySqlCommand();

            Consulta.Connection = conectar;

            Consulta.CommandText = "SELECT * FROM cadastro WHERE id = " + ID;

            MySqlDataReader Resultado = Consulta.ExecuteReader();

            if (Resultado.Read())
            {
               textBox1.Text = Convert.ToString(Resultado["nome"]);
               textBox2.Text = Convert.ToString(Resultado["tipo"]);
               textBox3.Text = Convert.ToString(Resultado["preco"]);

            }
            else
            {
                MessageBox.Show("Nenhum Registro Foi encontrado");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = Convert.ToString(textBox1.Text);
            string tipo = Convert.ToString(textBox2.Text);
            string preco = Convert.ToString(textBox3.Text);
      

            MySqlConnection conectar = new MySqlConnection("SERVER = localhost; DATABASE=clothes_store; UID=root; PASSWORD=");
            conectar.Open();

            MySqlCommand alterar = new MySqlCommand();

            alterar.Connection = conectar;

            string inserir = "UPDATE `cadastro` SET `nome`= '" + nome + "',`tipo`= '" + tipo + "',`preco`= '" + preco + "' WHERE id = '" + ID + "'";

            MySqlCommand comandos = new MySqlCommand(inserir, conectar);
            comandos.ExecuteNonQuery();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            MessageBox.Show("Dados Alterados com Sucesso!!!");
            conectar.Close();
        }
    }
}
