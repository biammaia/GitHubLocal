namespace Trabalho
{
    partial class frmConsultaFornecedor
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
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gpBoxFornec = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblBuscaFornc = new System.Windows.Forms.Label();
            this.txtBoxFornc = new System.Windows.Forms.TextBox();
            this.gpBoxFornec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(489, 23);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 27);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(234, 494);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(123, 43);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // gpBoxFornec
            // 
            this.gpBoxFornec.Controls.Add(this.dataGridView1);
            this.gpBoxFornec.Location = new System.Drawing.Point(4, 69);
            this.gpBoxFornec.Name = "gpBoxFornec";
            this.gpBoxFornec.Size = new System.Drawing.Size(571, 405);
            this.gpBoxFornec.TabIndex = 3;
            this.gpBoxFornec.TabStop = false;
            this.gpBoxFornec.Text = "Fornecedores";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(557, 369);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblBuscaFornc
            // 
            this.lblBuscaFornc.AutoSize = true;
            this.lblBuscaFornc.Location = new System.Drawing.Point(22, 30);
            this.lblBuscaFornc.Name = "lblBuscaFornc";
            this.lblBuscaFornc.Size = new System.Drawing.Size(43, 13);
            this.lblBuscaFornc.TabIndex = 4;
            this.lblBuscaFornc.Text = "Buscar:";
            // 
            // txtBoxFornc
            // 
            this.txtBoxFornc.Location = new System.Drawing.Point(71, 27);
            this.txtBoxFornc.Name = "txtBoxFornc";
            this.txtBoxFornc.Size = new System.Drawing.Size(388, 20);
            this.txtBoxFornc.TabIndex = 5;
            // 
            // frmConsultaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.txtBoxFornc);
            this.Controls.Add(this.lblBuscaFornc);
            this.Controls.Add(this.gpBoxFornec);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnConsulta);
            this.Name = "frmConsultaFornecedor";
            this.Text = ".::MZ Sistemas::.                                    Consulta Fornecedor";
            this.gpBoxFornec.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox gpBoxFornec;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblBuscaFornc;
        private System.Windows.Forms.TextBox txtBoxFornc;
    }
}