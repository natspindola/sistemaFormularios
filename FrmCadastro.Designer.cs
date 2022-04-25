
namespace sistemaFormularios
{
    partial class FrmCadastro
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.txtEnder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRAR NOVO CLIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-mail:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(117, 93);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(315, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(117, 120);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(315, 20);
            this.txtTel.TabIndex = 5;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(117, 146);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(315, 20);
            this.TxtEmail.TabIndex = 6;
            // 
            // txtEnder
            // 
            this.txtEnder.Location = new System.Drawing.Point(117, 172);
            this.txtEnder.Name = "txtEnder";
            this.txtEnder.Size = new System.Drawing.Size(315, 20);
            this.txtEnder.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Endereço:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(315, 217);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(117, 23);
            this.btnClean.TabIndex = 11;
            this.btnClean.Text = "Limpar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Tomato;
            this.button3.Location = new System.Drawing.Point(441, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Voltar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(166, 264);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(213, 23);
            this.btnClientes.TabIndex = 17;
            this.btnClientes.Text = "Clientes cadastrados";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 349);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEnder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox txtEnder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnClientes;
    }
}