
namespace sistemaFormularios
{
    partial class FrmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.boxClientes = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnClean2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtCodigoPesq = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNomePesq = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Underline);
            this.label1.Location = new System.Drawing.Point(171, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes cadastrados";
            // 
            // boxClientes
            // 
            this.boxClientes.BackColor = System.Drawing.SystemColors.Control;
            this.boxClientes.FormattingEnabled = true;
            this.boxClientes.Location = new System.Drawing.Point(36, 94);
            this.boxClientes.Name = "boxClientes";
            this.boxClientes.Size = new System.Drawing.Size(617, 173);
            this.boxClientes.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Adicionar novo cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Tomato;
            this.button3.Location = new System.Drawing.Point(572, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 31);
            this.button3.TabIndex = 17;
            this.button3.Text = "Voltar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnClean2
            // 
            this.btnClean2.Location = new System.Drawing.Point(357, 390);
            this.btnClean2.Name = "btnClean2";
            this.btnClean2.Size = new System.Drawing.Size(75, 23);
            this.btnClean2.TabIndex = 25;
            this.btnClean2.Text = "Limpar";
            this.btnClean2.UseVisualStyleBackColor = true;
            this.btnClean2.Click += new System.EventHandler(this.btnClean2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(159, 390);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Pesquisar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtCodigoPesq
            // 
            this.txtCodigoPesq.Location = new System.Drawing.Point(159, 352);
            this.txtCodigoPesq.Name = "txtCodigoPesq";
            this.txtCodigoPesq.Size = new System.Drawing.Size(273, 20);
            this.txtCodigoPesq.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Código do cliente:";
            // 
            // txtNomePesq
            // 
            this.txtNomePesq.Location = new System.Drawing.Point(159, 326);
            this.txtNomePesq.Name = "txtNomePesq";
            this.txtNomePesq.Size = new System.Drawing.Size(273, 20);
            this.txtNomePesq.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "PESQUISAR CLIENTE";
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.Location = new System.Drawing.Point(556, 355);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(97, 46);
            this.btnExcluirCliente.TabIndex = 26;
            this.btnExcluirCliente.Text = "Excluir cliente";
            this.btnExcluirCliente.UseVisualStyleBackColor = true;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.btnExcluirCliente);
            this.Controls.Add(this.btnClean2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtCodigoPesq);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNomePesq);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boxClientes);
            this.Controls.Add(this.label1);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox boxClientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnClean2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtCodigoPesq;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNomePesq;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExcluirCliente;
    }
}