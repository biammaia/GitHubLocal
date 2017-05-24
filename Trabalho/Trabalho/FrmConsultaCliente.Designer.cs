namespace Trabalho
{
    partial class frmConsultaCliente
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
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.lblBuscarCliente = new System.Windows.Forms.Label();
            this.gpBoxCliente = new System.Windows.Forms.GroupBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.txtBoxCliente = new System.Windows.Forms.TextBox();
            this.gpBoxCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Location = new System.Drawing.Point(489, 23);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(75, 27);
            this.btnConsultarCliente.TabIndex = 0;
            this.btnConsultarCliente.Text = "Consultar";
            this.btnConsultarCliente.UseVisualStyleBackColor = true;
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Location = new System.Drawing.Point(234, 494);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(85, 43);
            this.btnEditarCliente.TabIndex = 1;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            // 
            // lblBuscarCliente
            // 
            this.lblBuscarCliente.AutoSize = true;
            this.lblBuscarCliente.Location = new System.Drawing.Point(22, 30);
            this.lblBuscarCliente.Name = "lblBuscarCliente";
            this.lblBuscarCliente.Size = new System.Drawing.Size(43, 13);
            this.lblBuscarCliente.TabIndex = 3;
            this.lblBuscarCliente.Text = "Buscar:";
            // 
            // gpBoxCliente
            // 
            this.gpBoxCliente.Controls.Add(this.dgvCliente);
            this.gpBoxCliente.Location = new System.Drawing.Point(4, 69);
            this.gpBoxCliente.Name = "gpBoxCliente";
            this.gpBoxCliente.Size = new System.Drawing.Size(571, 405);
            this.gpBoxCliente.TabIndex = 4;
            this.gpBoxCliente.TabStop = false;
            this.gpBoxCliente.Text = "Clientes";
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(7, 29);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.Size = new System.Drawing.Size(557, 369);
            this.dgvCliente.TabIndex = 0;
            // 
            // txtBoxCliente
            // 
            this.txtBoxCliente.Location = new System.Drawing.Point(71, 27);
            this.txtBoxCliente.Name = "txtBoxCliente";
            this.txtBoxCliente.Size = new System.Drawing.Size(390, 20);
            this.txtBoxCliente.TabIndex = 5;
            // 
            // frmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.txtBoxCliente);
            this.Controls.Add(this.gpBoxCliente);
            this.Controls.Add(this.lblBuscarCliente);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnConsultarCliente);
            this.Name = "frmConsultaCliente";
            this.Text = ".::MZ Sistemas::.                                          Consulta Cliente";
            this.gpBoxCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarCliente;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Label lblBuscarCliente;
        private System.Windows.Forms.GroupBox gpBoxCliente;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.TextBox txtBoxCliente;
    }
}