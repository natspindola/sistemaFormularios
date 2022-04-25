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
    public partial class FrmProduto : Form
    {
        public object ListBoxVendas { get; private set; }

        public FrmProduto()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVendas2_Click(object sender, EventArgs e)
        {
            FrmVendas frm = new FrmVendas();
            frm.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtValor.Clear();
            txtCodigo.Clear();
            txtObs.Clear();
        }
    }
}
