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
    public partial class FrmFim : Form
    {
        public FrmFim()
        {
            InitializeComponent();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            FrmVendas frmvendas = new FrmVendas();
            frmvendas.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmprincipal = new FrmPrincipal();
            frmprincipal.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
