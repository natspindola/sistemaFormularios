using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaFormularios
{
    public partial class FrmVendas : Form
    {
        public FrmVendas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCalculadora frmCalculadora = new FrmCalculadora();
            frmCalculadora.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            ObjectCache cache = MemoryCache.Default;
            CacheItemPolicy policy = new CacheItemPolicy();
            var retorno =(CheckedListBox) cache.Get("lista");
            if(retorno != null)
            {
                foreach (var item in retorno.Items)
                {
                    ListBoxVendas.Items.Add(item);
                }
            }
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            FrmFim frmfim = new FrmFim();
            frmfim.Show();
            Close();
        }
    }
}
