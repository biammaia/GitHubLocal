namespace manutVeiculo
{
    partial class Form3
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
            this.lbCombustivel = new System.Windows.Forms.Label();
            this.lbCor = new System.Windows.Forms.Label();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.lbAno = new System.Windows.Forms.Label();
            this.lbModelo = new System.Windows.Forms.Label();
            this.gpbVeiculo = new System.Windows.Forms.GroupBox();
            this.txtKmRodado = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lbKm = new System.Windows.Forms.Label();
            this.dudCombustivel = new System.Windows.Forms.DomainUpDown();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelarCad = new System.Windows.Forms.Button();
            this.gpbVeiculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCombustivel
            // 
            this.lbCombustivel.AutoSize = true;
            this.lbCombustivel.Location = new System.Drawing.Point(20, 79);
            this.lbCombustivel.Name = "lbCombustivel";
            this.lbCombustivel.Size = new System.Drawing.Size(69, 13);
            this.lbCombustivel.TabIndex = 4;
            this.lbCombustivel.Text = "Combustível:";
            // 
            // lbCor
            // 
            this.lbCor.AutoSize = true;
            this.lbCor.Location = new System.Drawing.Point(63, 131);
            this.lbCor.Name = "lbCor";
            this.lbCor.Size = new System.Drawing.Size(26, 13);
            this.lbCor.TabIndex = 3;
            this.lbCor.Text = "Cor:";
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Location = new System.Drawing.Point(320, 79);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(37, 13);
            this.lbPlaca.TabIndex = 2;
            this.lbPlaca.Text = "Placa:";
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Location = new System.Drawing.Point(328, 31);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(29, 13);
            this.lbAno.TabIndex = 1;
            this.lbAno.Text = "Ano:";
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(9, 31);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(80, 13);
            this.lbModelo.TabIndex = 0;
            this.lbModelo.Text = "Marca/Modelo:";
            // 
            // gpbVeiculo
            // 
            this.gpbVeiculo.Controls.Add(this.dudCombustivel);
            this.gpbVeiculo.Controls.Add(this.txtKmRodado);
            this.gpbVeiculo.Controls.Add(this.txtPlaca);
            this.gpbVeiculo.Controls.Add(this.txtCor);
            this.gpbVeiculo.Controls.Add(this.txtAno);
            this.gpbVeiculo.Controls.Add(this.txtMarca);
            this.gpbVeiculo.Controls.Add(this.lbKm);
            this.gpbVeiculo.Controls.Add(this.lbCombustivel);
            this.gpbVeiculo.Controls.Add(this.lbCor);
            this.gpbVeiculo.Controls.Add(this.lbPlaca);
            this.gpbVeiculo.Controls.Add(this.lbAno);
            this.gpbVeiculo.Controls.Add(this.lbModelo);
            this.gpbVeiculo.Location = new System.Drawing.Point(12, 12);
            this.gpbVeiculo.Name = "gpbVeiculo";
            this.gpbVeiculo.Size = new System.Drawing.Size(513, 169);
            this.gpbVeiculo.TabIndex = 9;
            this.gpbVeiculo.TabStop = false;
            this.gpbVeiculo.Text = "Informações do Veículo";
            // 
            // txtKmRodado
            // 
            this.txtKmRodado.Location = new System.Drawing.Point(363, 126);
            this.txtKmRodado.Name = "txtKmRodado";
            this.txtKmRodado.Size = new System.Drawing.Size(133, 20);
            this.txtKmRodado.TabIndex = 15;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(363, 72);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(133, 20);
            this.txtPlaca.TabIndex = 14;
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(95, 126);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(187, 20);
            this.txtCor.TabIndex = 12;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(363, 27);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(133, 20);
            this.txtAno.TabIndex = 11;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(95, 24);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(187, 20);
            this.txtMarca.TabIndex = 10;
            // 
            // lbKm
            // 
            this.lbKm.AutoSize = true;
            this.lbKm.Location = new System.Drawing.Point(294, 133);
            this.lbKm.Name = "lbKm";
            this.lbKm.Size = new System.Drawing.Size(63, 13);
            this.lbKm.TabIndex = 5;
            this.lbKm.Text = "Km/rodado:";
            // 
            // dudCombustivel
            // 
            this.dudCombustivel.Items.Add("");
            this.dudCombustivel.Items.Add("Gasolina");
            this.dudCombustivel.Items.Add("Etanol");
            this.dudCombustivel.Items.Add("Flex");
            this.dudCombustivel.Items.Add("Diesel");
            this.dudCombustivel.Location = new System.Drawing.Point(95, 72);
            this.dudCombustivel.Name = "dudCombustivel";
            this.dudCombustivel.Size = new System.Drawing.Size(187, 20);
            this.dudCombustivel.TabIndex = 16;
            this.dudCombustivel.Text = "Selecione...";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(156, 200);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 33);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCad
            // 
            this.btnCancelarCad.Location = new System.Drawing.Point(343, 200);
            this.btnCancelarCad.Name = "btnCancelarCad";
            this.btnCancelarCad.Size = new System.Drawing.Size(75, 33);
            this.btnCancelarCad.TabIndex = 11;
            this.btnCancelarCad.Text = "Cancelar";
            this.btnCancelarCad.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 244);
            this.Controls.Add(this.btnCancelarCad);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.gpbVeiculo);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Form3";
            this.gpbVeiculo.ResumeLayout(false);
            this.gpbVeiculo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbCombustivel;
        private System.Windows.Forms.Label lbCor;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.GroupBox gpbVeiculo;
        private System.Windows.Forms.TextBox txtKmRodado;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lbKm;
        private System.Windows.Forms.DomainUpDown dudCombustivel;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelarCad;
    }
}