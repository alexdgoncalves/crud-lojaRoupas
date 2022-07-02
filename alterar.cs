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
    public partial class alterar : Form
    {
        public alterar()
        {
            InitializeComponent();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox1.Text);

            alterarRoupa confirmar = new alterarRoupa(codigo);
            confirmar.Show();
        }
    }
}
