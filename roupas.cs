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
    public partial class roupas : Form
    {
        public roupas()
        {
            InitializeComponent();
            MySqlConnection conectar = new MySqlConnection("SERVER = localhost; DATABASE=clothes_store; UID=root; PASSWORD=");
            conectar.Open();

            MySqlCommand Consulta = new MySqlCommand();

            Consulta.Connection = conectar;

            Consulta.CommandText = "SELECT * FROM cadastro";

            dataGridView1.Rows.Clear();

            MySqlDataReader Resultado = Consulta.ExecuteReader();

            if (Resultado.HasRows)
            {
                while (Resultado.Read())
                {
                    dataGridView1.Rows.Add(
                    Resultado["nome"].ToString(),
                    Resultado["tipo"].ToString(),
                    Resultado["preco"].ToString()
                    );
                }
            }
            else
            {
                MessageBox.Show("Nenhum Registro Foi encontrado");
            }

        }

        private void roupas_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
