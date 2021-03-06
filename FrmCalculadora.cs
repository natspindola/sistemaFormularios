using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaFormularios
{
    public partial class FrmCalculadora : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            txtOperacao.Clear();
            lblOperacao.Text = "";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                string Apagar = txtResultado.Text;

                Apagar = Apagar.Remove(Apagar.Length - 1);

                txtResultado.Text = Apagar;
                txtOperacao.Text = Apagar;
            }
            catch (Exception)
            {

            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
            txtOperacao.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
            txtOperacao.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
            txtOperacao.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
            txtOperacao.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
            txtOperacao.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
            txtOperacao.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
            txtOperacao.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
            txtOperacao.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
            txtOperacao.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
            txtOperacao.Text += "9";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
            txtOperacao.Text += ".";
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "+";
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperacao1.Text = "+";
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "-";
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUBTRACAO";
                lblOperacao1.Text = "-";
            }
        }

        private void btnMultip_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "*";
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULTIPLICACAO";
                lblOperacao1.Text = "*";
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "/";
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIVISAO";
                lblOperacao1.Text = "/";
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "=";
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            lblOperacao1.Text = "";

            if (operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUBTRACAO")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULTIPLICACAO")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIVISAO")
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
            else if (operacao == "PORCENTAGEM")
            {
                txtResultado.Text = Convert.ToString(valor1 % valor2);
            }

            txtOperacao.Text += txtResultado.Text;
        }
    }
}
