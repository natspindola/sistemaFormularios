﻿using System;
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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCadastro frm = new FrmCadastro();
            frm.Show();
        }

        private void btnClean2_Click(object sender, EventArgs e)
        {
            txtNomePesq.Clear();
            txtCodigoPesq.Clear();
        }
    }
}
