using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaFormularios
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtTel.Clear();
            TxtEmail.Clear();
            txtEnder.Clear();
        }

        private void btnClean2_Click(object sender, EventArgs e)
        {
            txtNomePesq.Clear();
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
