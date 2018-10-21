namespace manutVeiculo
{
    partial class Form2
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
            this.gpbInfoPessoal = new System.Windows.Forms.GroupBox();
            this.rbtnMasc = new System.Windows.Forms.RadioButton();
            this.rbtnFem = new System.Windows.Forms.RadioButton();
            this.lbSexo = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbNovoCpf = new System.Windows.Forms.Label();
            this.lbNovoNome = new System.Windows.Forms.Label();
            this.gpbEndereco = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lbTel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCel = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbRua = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancelarAdd = new System.Windows.Forms.Button();
            this.gpbInfoPessoal.SuspendLayout();
            this.gpbEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbInfoPessoal
            // 
            this.gpbInfoPessoal.Controls.Add(this.rbtnMasc);
            this.gpbInfoPessoal.Controls.Add(this.rbtnFem);
            this.gpbInfoPessoal.Controls.Add(this.lbSexo);
            this.gpbInfoPessoal.Controls.Add(this.textBox2);
            this.gpbInfoPessoal.Controls.Add(this.textBox1);
            this.gpbInfoPessoal.Controls.Add(this.lbNovoCpf);
            this.gpbInfoPessoal.Controls.Add(this.lbNovoNome);
            this.gpbInfoPessoal.Location = new System.Drawing.Point(12, 16);
            this.gpbInfoPessoal.Name = "gpbInfoPessoal";
            this.gpbInfoPessoal.Size = new System.Drawing.Size(588, 104);
            this.gpbInfoPessoal.TabIndex = 0;
            this.gpbInfoPessoal.TabStop = false;
            this.gpbInfoPessoal.Text = "Informações Pessoais";
            // 
            // rbtnMasc
            // 
            this.rbtnMasc.AutoSize = true;
            this.rbtnMasc.Location = new System.Drawing.Point(433, 65);
            this.rbtnMasc.Name = "rbtnMasc";
            this.rbtnMasc.Size = new System.Drawing.Size(73, 17);
            this.rbtnMasc.TabIndex = 9;
            this.rbtnMasc.TabStop = true;
            this.rbtnMasc.Text = "Masculino";
            this.rbtnMasc.UseVisualStyleBackColor = true;
            // 
            // rbtnFem
            // 
            this.rbtnFem.AutoSize = true;
            this.rbtnFem.Location = new System.Drawing.Point(330, 65);
            this.rbtnFem.Name = "rbtnFem";
            this.rbtnFem.Size = new System.Drawing.Size(67, 17);
            this.rbtnFem.TabIndex = 8;
            this.rbtnFem.TabStop = true;
            this.rbtnFem.Text = "Feminino";
            this.rbtnFem.UseVisualStyleBackColor = true;
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Location = new System.Drawing.Point(263, 67);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(37, 13);
            this.lbSexo.TabIndex = 7;
            this.lbSexo.Text = "Sexo: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(53, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(517, 20);
            this.textBox1.TabIndex = 5;
            // 
            // lbNovoCpf
            // 
            this.lbNovoCpf.AutoSize = true;
            this.lbNovoCpf.Location = new System.Drawing.Point(6, 67);
            this.lbNovoCpf.Name = "lbNovoCpf";
            this.lbNovoCpf.Size = new System.Drawing.Size(33, 13);
            this.lbNovoCpf.TabIndex = 1;
            this.lbNovoCpf.Text = "CPF: ";
            // 
            // lbNovoNome
            // 
            this.lbNovoNome.AutoSize = true;
            this.lbNovoNome.Location = new System.Drawing.Point(6, 32);
            this.lbNovoNome.Name = "lbNovoNome";
            this.lbNovoNome.Size = new System.Drawing.Size(41, 13);
            this.lbNovoNome.TabIndex = 0;
            this.lbNovoNome.Text = "Nome: ";
            // 
            // gpbEndereco
            // 
            this.gpbEndereco.Controls.Add(this.textBox7);
            this.gpbEndereco.Controls.Add(this.textBox6);
            this.gpbEndereco.Controls.Add(this.txtCep);
            this.gpbEndereco.Controls.Add(this.txtBairro);
            this.gpbEndereco.Controls.Add(this.txtRua);
            this.gpbEndereco.Controls.Add(this.lbTel);
            this.gpbEndereco.Controls.Add(this.label3);
            this.gpbEndereco.Controls.Add(this.lbCel);
            this.gpbEndereco.Controls.Add(this.lbBairro);
            this.gpbEndereco.Controls.Add(this.lbRua);
            this.gpbEndereco.Location = new System.Drawing.Point(12, 126);
            this.gpbEndereco.Name = "gpbEndereco";
            this.gpbEndereco.Size = new System.Drawing.Size(588, 134);
            this.gpbEndereco.TabIndex = 7;
            this.gpbEndereco.TabStop = false;
            this.gpbEndereco.Text = "Endereço";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(285, 90);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(122, 20);
            this.textBox7.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(68, 90);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(131, 20);
            this.textBox6.TabIndex = 8;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(433, 56);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(137, 20);
            this.txtCep.TabIndex = 7;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(68, 56);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(318, 20);
            this.txtBairro.TabIndex = 6;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(68, 19);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(502, 20);
            this.txtRua.TabIndex = 5;
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Location = new System.Drawing.Point(12, 96);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(52, 13);
            this.lbTel.TabIndex = 3;
            this.lbTel.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CEP:";
            // 
            // lbCel
            // 
            this.lbCel.AutoSize = true;
            this.lbCel.Location = new System.Drawing.Point(240, 95);
            this.lbCel.Name = "lbCel";
            this.lbCel.Size = new System.Drawing.Size(42, 13);
            this.lbCel.TabIndex = 4;
            this.lbCel.Text = "Celular:";
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(12, 61);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(40, 13);
            this.lbBairro.TabIndex = 1;
            this.lbBairro.Text = "Bairro: ";
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Location = new System.Drawing.Point(12, 26);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(30, 13);
            this.lbRua.TabIndex = 0;
            this.lbRua.Text = "Rua:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(180, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancelarAdd
            // 
            this.btnCancelarAdd.Location = new System.Drawing.Point(334, 280);
            this.btnCancelarAdd.Name = "btnCancelarAdd";
            this.btnCancelarAdd.Size = new System.Drawing.Size(75, 33);
            this.btnCancelarAdd.TabIndex = 9;
            this.btnCancelarAdd.Text = "Cancelar";
            this.btnCancelarAdd.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 325);
            this.Controls.Add(this.btnCancelarAdd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gpbEndereco);
            this.Controls.Add(this.gpbInfoPessoal);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.gpbInfoPessoal.ResumeLayout(false);
            this.gpbInfoPessoal.PerformLayout();
            this.gpbEndereco.ResumeLayout(false);
            this.gpbEndereco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInfoPessoal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbNovoCpf;
        private System.Windows.Forms.Label lbNovoNome;
        private System.Windows.Forms.GroupBox gpbEndereco;
        private System.Windows.Forms.RadioButton rbtnMasc;
        private System.Windows.Forms.RadioButton rbtnFem;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCel;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancelarAdd;
    }
}