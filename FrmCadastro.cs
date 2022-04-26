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
            maskedtxtTel.Clear();
            txtEmail.Clear();
            txtEnder.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void limparCampos()
        {
            txtNome.Clear();
            maskedtxtTel.Clear();
            txtEmail.Clear();
            txtEnder.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNome.Text) & !string.IsNullOrEmpty(maskedtxtTel.Text) & !string.IsNullOrEmpty(txtEmail.Text) & !string.IsNullOrEmpty(txtEnder.Text))
            {
                listCliente.Items.Add(txtNome.Text + ", " + maskedtxtTel.Text + ", " + txtEmail.Text + ", " + txtEnder.Text);
                limparCampos();
            }
            else { }
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            if (listCliente.SelectedIndex != -1)
            {
                listCliente.Items.RemoveAt(listCliente.SelectedIndex);
            }
            else { }
        }
    }
}
