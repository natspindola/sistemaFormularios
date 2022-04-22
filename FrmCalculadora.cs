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
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora(string nome)
        {
            InitializeComponent();

            lblNome.Text = nome.ToUpper();
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
