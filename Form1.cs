using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clothes_store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroDosLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastro cadastro = new cadastro();
            cadastro.Show();
        }

        private void pesquisarUmLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            roupas roupas = new roupas();
            roupas.Show();
        }

        private void editarUmLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alterar alterar = new alterar();
            alterar.Show();
        }

        private void excluirUmLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            excluir excluir = new excluir();
            excluir.Show();
        }
    }
}
