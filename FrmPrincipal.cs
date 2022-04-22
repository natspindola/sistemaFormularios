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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            FrmCalculadora frm = new FrmCalculadora();
            frm.Show();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            FrmCadastro frm = new FrmCadastro();
            frm.Show();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            FrmProduto frm = new FrmProduto();
            frm.Show();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            FrmVendas frm = new FrmVendas();
            frm.Show();
        }

        private void MenuCadastro_Click(object sender, EventArgs e)
        {
            FrmCadastro frm = new FrmCadastro();
            frm.Show();
        }

        private void MenuCalc_Click_1(object sender, EventArgs e)
        {
            FrmCalculadora frm = new FrmCalculadora();
            frm.Show();
        }

        // menu vendas e produtos foi instanciado no design -> click

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
