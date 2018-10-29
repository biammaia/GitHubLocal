namespace Trabalho
{
    partial class frmConsultaPedido
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
            this.lblBuscarPedido = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.txtBoxPedido = new System.Windows.Forms.TextBox();
            this.gpBoxPedido = new System.Windows.Forms.GroupBox();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gpBoxPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarPedido
            // 
            this.lblBuscarPedido.AutoSize = true;
            this.lblBuscarPedido.Location = new System.Drawing.Point(22, 30);
            this.lblBuscarPedido.Name = "lblBuscarPedido";
            this.lblBuscarPedido.Size = new System.Drawing.Size(43, 13);
            this.lblBuscarPedido.TabIndex = 0;
            this.lblBuscarPedido.Text = "Buscar:";
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(489, 23);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 27);
            this.btnConsulta.TabIndex = 1;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            // 
            // txtBoxPedido
            // 
            this.txtBoxPedido.Location = new System.Drawing.Point(71, 27);
            this.txtBoxPedido.Name = "txtBoxPedido";
            this.txtBoxPedido.Size = new System.Drawing.Size(390, 20);
            this.txtBoxPedido.TabIndex = 2;
            // 
            // gpBoxPedido
            // 
            this.gpBoxPedido.Controls.Add(this.dgvPedido);
            this.gpBoxPedido.Location = new System.Drawing.Point(4, 69);
            this.gpBoxPedido.Name = "gpBoxPedido";
            this.gpBoxPedido.Size = new System.Drawing.Size(571, 405);
            this.gpBoxPedido.TabIndex = 3;
            this.gpBoxPedido.TabStop = false;
            this.gpBoxPedido.Text = "Pedidos";
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AllowUserToDeleteRows = false;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(7, 29);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.Size = new System.Drawing.Size(557, 369);
            this.dgvPedido.TabIndex = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(234, 494);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(123, 43);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // frmConsultaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gpBoxPedido);
            this.Controls.Add(this.txtBoxPedido);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.lblBuscarPedido);
            this.Name = "frmConsultaPedido";
            this.Text = ".::MZ Sistemas::.                                    Consulta Pedido";
            this.gpBoxPedido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarPedido;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.TextBox txtBoxPedido;
        private System.Windows.Forms.GroupBox gpBoxPedido;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button btnEditar;
    }
}