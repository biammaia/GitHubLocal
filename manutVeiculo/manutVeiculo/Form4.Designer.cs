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
            this.lvHistCliente = new System.Windows.Forms.ListView();
            this.columnNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVeiculo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPlaca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.txtCpfHistorico = new System.Windows.Forms.TextBox();
            this.lbCpfHistorico = new System.Windows.Forms.Label();
            this.gpbHistCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbHistCliente
            // 
            this.gpbHistCliente.Controls.Add(this.lvHistCliente);
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
            // lvHistCliente
            // 
            this.lvHistCliente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNome,
            this.columnVeiculo,
            this.columnPlaca,
            this.columnKm,
            this.columnData});
            this.lvHistCliente.Location = new System.Drawing.Point(22, 120);
            this.lvHistCliente.Name = "lvHistCliente";
            this.lvHistCliente.Size = new System.Drawing.Size(478, 158);
            this.lvHistCliente.TabIndex = 6;
            this.lvHistCliente.UseCompatibleStateImageBehavior = false;
            this.lvHistCliente.View = System.Windows.Forms.View.Details;
            // 
            // columnNome
            // 
            this.columnNome.Text = "Nome";
            this.columnNome.Width = 189;
            // 
            // columnVeiculo
            // 
            this.columnVeiculo.Text = "Veiculo";
            this.columnVeiculo.Width = 84;
            // 
            // columnPlaca
            // 
            this.columnPlaca.Text = "Placa";
            this.columnPlaca.Width = 81;
            // 
            // columnKm
            // 
            this.columnKm.Text = "Km";
            // 
            // columnData
            // 
            this.columnData.Text = "Data";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(374, 81);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(70, 81);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(75, 23);
            this.btnConfirma.TabIndex = 4;
            this.btnConfirma.Text = "Confirmar";
            this.btnConfirma.UseVisualStyleBackColor = true;
            // 
            // txtCpfHistorico
            // 
            this.txtCpfHistorico.Location = new System.Drawing.Point(213, 41);
            this.txtCpfHistorico.Name = "txtCpfHistorico";
            this.txtCpfHistorico.Size = new System.Drawing.Size(100, 20);
            this.txtCpfHistorico.TabIndex = 3;
            // 
            // lbCpfHistorico
            // 
            this.lbCpfHistorico.AutoSize = true;
            this.lbCpfHistorico.Location = new System.Drawing.Point(249, 25);
            this.lbCpfHistorico.Name = "lbCpfHistorico";
            this.lbCpfHistorico.Size = new System.Drawing.Size(27, 13);
            this.lbCpfHistorico.TabIndex = 0;
            this.lbCpfHistorico.Text = "CPF";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 323);
            this.Controls.Add(this.gpbHistCliente);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.ListView lvHistCliente;
        private System.Windows.Forms.ColumnHeader columnNome;
        private System.Windows.Forms.ColumnHeader columnVeiculo;
        private System.Windows.Forms.ColumnHeader columnPlaca;
        private System.Windows.Forms.ColumnHeader columnKm;
        private System.Windows.Forms.ColumnHeader columnData;
    }
}