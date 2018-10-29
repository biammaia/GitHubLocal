namespace manutVeiculo
{
    partial class Form4
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
            this.gpbHistCliente = new System.Windows.Forms.GroupBox();
            this.lbCpfHistorico = new System.Windows.Forms.Label();
            this.txtCpfHistorico = new System.Windows.Forms.TextBox();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.listHistCliente = new System.Windows.Forms.ListBox();
            this.gpbHistCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbHistCliente
            // 
            this.gpbHistCliente.Controls.Add(this.listHistCliente);
            this.gpbHistCliente.Controls.Add(this.btnCancelar);
            this.gpbHistCliente.Controls.Add(this.btnConfirma);
            this.gpbHistCliente.Controls.Add(this.txtCpfHistorico);
            this.gpbHistCliente.Controls.Add(this.lbCpfHistorico);
            this.gpbHistCliente.Location = new System.Drawing.Point(14, 15);
            this.gpbHistCliente.Name = "gpbHistCliente";
            this.gpbHistCliente.Size = new System.Drawing.Size(522, 296);
            this.gpbHistCliente.TabIndex = 0;
            this.gpbHistCliente.TabStop = false;
            this.gpbHistCliente.Text = "Histórico Cliente";
            // 
            // lbCpfHistorico
            // 
            this.lbCpfHistorico.AutoSize = true;
            this.lbCpfHistorico.Location = new System.Drawing.Point(227, 25);
            this.lbCpfHistorico.Name = "lbCpfHistorico";
            this.lbCpfHistorico.Size = new System.Drawing.Size(27, 13);
            this.lbCpfHistorico.TabIndex = 0;
            this.lbCpfHistorico.Text = "CPF";
            // 
            // txtCpfHistorico
            // 
            this.txtCpfHistorico.Location = new System.Drawing.Point(198, 41);
            this.txtCpfHistorico.Name = "txtCpfHistorico";
            this.txtCpfHistorico.Size = new System.Drawing.Size(100, 20);
            this.txtCpfHistorico.TabIndex = 3;
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(56, 81);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(75, 23);
            this.btnConfirma.TabIndex = 4;
            this.btnConfirma.Text = "Confirmar";
            this.btnConfirma.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(349, 81);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // listHistCliente
            // 
            this.listHistCliente.FormattingEnabled = true;
            this.listHistCliente.Location = new System.Drawing.Point(27, 120);
            this.listHistCliente.Name = "listHistCliente";
            this.listHistCliente.Size = new System.Drawing.Size(455, 160);
            this.listHistCliente.TabIndex = 6;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 323);
            this.Controls.Add(this.gpbHistCliente);
            this.Name = "Form4";
            this.Text = "Form4";
            this.gpbHistCliente.ResumeLayout(false);
            this.gpbHistCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbHistCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.TextBox txtCpfHistorico;
        private System.Windows.Forms.Label lbCpfHistorico;
        private System.Windows.Forms.ListBox listHistCliente;
    }
}