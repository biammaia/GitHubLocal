namespace Trabalho
{
    partial class frmCadastroProduto
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
            this.cbBoxCor = new System.Windows.Forms.ComboBox();
            this.cbBoxMaterial = new System.Windows.Forms.ComboBox();
            this.txtNomeModelo = new System.Windows.Forms.TextBox();
            this.tctQtidade = new System.Windows.Forms.TextBox();
            this.lbNomeModelo = new System.Windows.Forms.Label();
            this.lbMaterial = new System.Windows.Forms.Label();
            this.lbCor = new System.Windows.Forms.Label();
            this.lbQtidade = new System.Windows.Forms.Label();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.ClnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbBoxCor
            // 
            this.cbBoxCor.FormattingEnabled = true;
            this.cbBoxCor.Items.AddRange(new object[] {
            "Amarelo",
            "Ankara",
            "Areia",
            "Avelã",
            "Azul",
            "Azul Bage",
            "Azul Royal",
            "Bege",
            "Branco",
            "Cacau",
            "Café",
            "Caramelo",
            "Castanho",
            "Cipria",
            "Jambo",
            "Laranja",
            "Lavanda",
            "Lilás",
            "Onça",
            "Onça prata",
            "Pinhão",
            "Pink",
            "Prata",
            "Preto",
            "Rosa Bebê",
            "Saara",
            "Verde",
            "Verde Claro",
            "Verde Limão",
            "Vermelho",
            "Vermelho Brahma",
            "Zebra"});
            this.cbBoxCor.Location = new System.Drawing.Point(264, 111);
            this.cbBoxCor.Name = "cbBoxCor";
            this.cbBoxCor.Size = new System.Drawing.Size(148, 21);
            this.cbBoxCor.TabIndex = 0;
            // 
            // cbBoxMaterial
            // 
            this.cbBoxMaterial.FormattingEnabled = true;
            this.cbBoxMaterial.Items.AddRange(new object[] {
            "Couro",
            "Corino",
            "Tecido"});
            this.cbBoxMaterial.Location = new System.Drawing.Point(82, 111);
            this.cbBoxMaterial.Name = "cbBoxMaterial";
            this.cbBoxMaterial.Size = new System.Drawing.Size(159, 21);
            this.cbBoxMaterial.TabIndex = 2;
            // 
            // txtNomeModelo
            // 
            this.txtNomeModelo.Location = new System.Drawing.Point(25, 53);
            this.txtNomeModelo.Name = "txtNomeModelo";
            this.txtNomeModelo.Size = new System.Drawing.Size(629, 20);
            this.txtNomeModelo.TabIndex = 4;
            // 
            // tctQtidade
            // 
            this.tctQtidade.Location = new System.Drawing.Point(434, 112);
            this.tctQtidade.Name = "tctQtidade";
            this.tctQtidade.Size = new System.Drawing.Size(143, 20);
            this.tctQtidade.TabIndex = 5;
            // 
            // lbNomeModelo
            // 
            this.lbNomeModelo.AutoSize = true;
            this.lbNomeModelo.Location = new System.Drawing.Point(22, 37);
            this.lbNomeModelo.Name = "lbNomeModelo";
            this.lbNomeModelo.Size = new System.Drawing.Size(81, 13);
            this.lbNomeModelo.TabIndex = 7;
            this.lbNomeModelo.Text = "Nome / Modelo";
            // 
            // lbMaterial
            // 
            this.lbMaterial.AutoSize = true;
            this.lbMaterial.Location = new System.Drawing.Point(79, 95);
            this.lbMaterial.Name = "lbMaterial";
            this.lbMaterial.Size = new System.Drawing.Size(44, 13);
            this.lbMaterial.TabIndex = 9;
            this.lbMaterial.Text = "Material";
            // 
            // lbCor
            // 
            this.lbCor.AutoSize = true;
            this.lbCor.Location = new System.Drawing.Point(263, 95);
            this.lbCor.Name = "lbCor";
            this.lbCor.Size = new System.Drawing.Size(23, 13);
            this.lbCor.TabIndex = 10;
            this.lbCor.Text = "Cor";
            // 
            // lbQtidade
            // 
            this.lbQtidade.AutoSize = true;
            this.lbQtidade.Location = new System.Drawing.Point(432, 96);
            this.lbQtidade.Name = "lbQtidade";
            this.lbQtidade.Size = new System.Drawing.Size(62, 13);
            this.lbQtidade.TabIndex = 11;
            this.lbQtidade.Text = "Quantidade";
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnNome,
            this.ClnMaterial,
            this.ClnCor,
            this.ClnQtd});
            this.dgvProduto.Location = new System.Drawing.Point(9, 22);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.Size = new System.Drawing.Size(641, 290);
            this.dgvProduto.TabIndex = 12;
            // 
            // ClnNome
            // 
            this.ClnNome.HeaderText = "Nome/Modelo";
            this.ClnNome.Name = "ClnNome";
            this.ClnNome.ReadOnly = true;
            this.ClnNome.Width = 200;
            // 
            // ClnMaterial
            // 
            this.ClnMaterial.HeaderText = "Material";
            this.ClnMaterial.Name = "ClnMaterial";
            this.ClnMaterial.ReadOnly = true;
            this.ClnMaterial.Width = 150;
            // 
            // ClnCor
            // 
            this.ClnCor.HeaderText = "Cor";
            this.ClnCor.Name = "ClnCor";
            this.ClnCor.ReadOnly = true;
            this.ClnCor.Width = 150;
            // 
            // ClnQtd
            // 
            this.ClnQtd.HeaderText = "Quantidade";
            this.ClnQtd.Name = "ClnQtd";
            this.ClnQtd.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProduto);
            this.groupBox1.Location = new System.Drawing.Point(12, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 324);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(134, 170);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(85, 35);
            this.btnAdicionar.TabIndex = 14;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(289, 170);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(85, 35);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(446, 170);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(85, 35);
            this.btnRemover.TabIndex = 16;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 562);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbQtidade);
            this.Controls.Add(this.lbCor);
            this.Controls.Add(this.lbMaterial);
            this.Controls.Add(this.lbNomeModelo);
            this.Controls.Add(this.tctQtidade);
            this.Controls.Add(this.txtNomeModelo);
            this.Controls.Add(this.cbBoxMaterial);
            this.Controls.Add(this.cbBoxCor);
            this.Name = "frmCadastroProduto";
            this.Text = ".::MZ Sistemas::.                                                        Cadastro" +
    " de Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBoxCor;
        private System.Windows.Forms.ComboBox cbBoxMaterial;
        private System.Windows.Forms.TextBox txtNomeModelo;
        private System.Windows.Forms.TextBox tctQtidade;
        private System.Windows.Forms.Label lbNomeModelo;
        private System.Windows.Forms.Label lbMaterial;
        private System.Windows.Forms.Label lbCor;
        private System.Windows.Forms.Label lbQtidade;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnQtd;
    }
}