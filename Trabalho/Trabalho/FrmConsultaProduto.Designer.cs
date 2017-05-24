namespace Trabalho
{
    partial class frmConsultaProduto
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
            this.txtBoxConsultaProd = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.gpBoxProduto = new System.Windows.Forms.GroupBox();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.btnConsultarProd = new System.Windows.Forms.Button();
            this.btnEditarProd = new System.Windows.Forms.Button();
            this.gpBoxProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxConsultaProd
            // 
            this.txtBoxConsultaProd.Location = new System.Drawing.Point(71, 27);
            this.txtBoxConsultaProd.Name = "txtBoxConsultaProd";
            this.txtBoxConsultaProd.Size = new System.Drawing.Size(390, 20);
            this.txtBoxConsultaProd.TabIndex = 0;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(22, 30);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(43, 13);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Buscar:";
            // 
            // gpBoxProduto
            // 
            this.gpBoxProduto.Controls.Add(this.dgvProduto);
            this.gpBoxProduto.Location = new System.Drawing.Point(4, 69);
            this.gpBoxProduto.Name = "gpBoxProduto";
            this.gpBoxProduto.Size = new System.Drawing.Size(571, 405);
            this.gpBoxProduto.TabIndex = 2;
            this.gpBoxProduto.TabStop = false;
            this.gpBoxProduto.Text = "Produtos";
            // 
            // dgvProduto
            // 
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(7, 29);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.Size = new System.Drawing.Size(557, 369);
            this.dgvProduto.TabIndex = 0;
            // 
            // btnConsultarProd
            // 
            this.btnConsultarProd.Location = new System.Drawing.Point(489, 23);
            this.btnConsultarProd.Name = "btnConsultarProd";
            this.btnConsultarProd.Size = new System.Drawing.Size(75, 27);
            this.btnConsultarProd.TabIndex = 3;
            this.btnConsultarProd.Text = "Consultar";
            this.btnConsultarProd.UseVisualStyleBackColor = true;
            // 
            // btnEditarProd
            // 
            this.btnEditarProd.Location = new System.Drawing.Point(234, 494);
            this.btnEditarProd.Name = "btnEditarProd";
            this.btnEditarProd.Size = new System.Drawing.Size(123, 43);
            this.btnEditarProd.TabIndex = 4;
            this.btnEditarProd.Text = "Editar";
            this.btnEditarProd.UseVisualStyleBackColor = true;
            // 
            // frmConsultaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btnEditarProd);
            this.Controls.Add(this.btnConsultarProd);
            this.Controls.Add(this.gpBoxProduto);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBoxConsultaProd);
            this.Name = "frmConsultaProduto";
            this.Text = ".::MZ Sistemas::.                                      Consulta Produto";
            this.gpBoxProduto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxConsultaProd;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.GroupBox gpBoxProduto;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.Button btnConsultarProd;
        private System.Windows.Forms.Button btnEditarProd;
    }
}