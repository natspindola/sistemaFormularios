using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;
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
            limparCampos();
        }

        private void limparCampos()
        {
            txtNome.Clear();
            txtValor.Clear();
            txtObs.Clear();
            txtQuant.Clear();
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNome.Text) & !string.IsNullOrEmpty(txtValor.Text) & !string.IsNullOrEmpty(txtQuant.Text))
            {
                ObjectCache cache = MemoryCache.Default;
                CacheItemPolicy policy = new CacheItemPolicy();
                listProduto.Items.Add(txtNome.Text + ", " + txtValor.Text + ", " + txtObs.Text + ", " + txtQuant.Text);

                cache.Set(new CacheItem("lista", listProduto), policy);

                var retorno = cache.Get("lista");

                limparCampos();
            }
            else { }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (listProduto.SelectedIndex != -1)
            {
                listProduto.Items.RemoveAt(listProduto.SelectedIndex);
            }
            else { }
        }

        private void listProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
