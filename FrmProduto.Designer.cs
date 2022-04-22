
namespace sistemaFormularios
{
    partial class FrmProduto
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
            this.btnVendas2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVendas2
            // 
            this.btnVendas2.Location = new System.Drawing.Point(675, 365);
            this.btnVendas2.Name = "btnVendas2";
            this.btnVendas2.Size = new System.Drawing.Size(75, 23);
            this.btnVendas2.TabIndex = 0;
            this.btnVendas2.Text = "Vendas";
            this.btnVendas2.UseVisualStyleBackColor = true;
            this.btnVendas2.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVendas2);
            this.Name = "FrmProduto";
            this.Text = "Vendas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVendas2;
    }
}