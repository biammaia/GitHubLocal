namespace Trabalho
{
    partial class frmCadastroPedido
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
            this.gpBoxCliente = new System.Windows.Forms.GroupBox();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbBoxTipo = new System.Windows.Forms.ComboBox();
            this.lbNomeRS = new System.Windows.Forms.Label();
            this.lbDoc = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.gpBoxPedido = new System.Windows.Forms.GroupBox();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.clnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnVU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUdQtd = new System.Windows.Forms.NumericUpDown();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbParcelas = new System.Windows.Forms.Label();
            this.lbFormaPgto = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.cbBoxParcelas = new System.Windows.Forms.ComboBox();
            this.cbBoxFormaPgto = new System.Windows.Forms.ComboBox();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.lbCor = new System.Windows.Forms.Label();
            this.lbMaterial = new System.Windows.Forms.Label();
            this.cbBoxCor = new System.Windows.Forms.ComboBox();
            this.cbBoxMaterial = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gpBoxCliente.SuspendLayout();
            this.gpBoxPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUdQtd)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpBoxCliente
            // 
            this.gpBoxCliente.Controls.Add(this.btnNovoPedido);
            this.gpBoxCliente.Controls.Add(this.btnCadastrar);
            this.gpBoxCliente.Controls.Add(this.btnConsultar);
            this.gpBoxCliente.Controls.Add(this.txtDoc);
            this.gpBoxCliente.Controls.Add(this.txtNome);
            this.gpBoxCliente.Controls.Add(this.cbBoxTipo);
            this.gpBoxCliente.Controls.Add(this.lbNomeRS);
            this.gpBoxCliente.Controls.Add(this.lbDoc);
            this.gpBoxCliente.Controls.Add(this.lbTipo);
            this.gpBoxCliente.Location = new System.Drawing.Point(3, 3);
            this.gpBoxCliente.Name = "gpBoxCliente";
            this.gpBoxCliente.Size = new System.Drawing.Size(645, 162);
            this.gpBoxCliente.TabIndex = 0;
            this.gpBoxCliente.TabStop = false;
            this.gpBoxCliente.Text = "Cliente";
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoPedido.Location = new System.Drawing.Point(522, 115);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(96, 31);
            this.btnNovoPedido.TabIndex = 11;
            this.btnNovoPedido.Text = "Novo Pedido";
            this.btnNovoPedido.UseVisualStyleBackColor = true;
            this.btnNovoPedido.Click += new System.EventHandler(this.btnNovoPedido_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.Location = new System.Drawing.Point(522, 67);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(96, 31);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Location = new System.Drawing.Point(522, 19);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConsultar.Size = new System.Drawing.Size(96, 31);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(133, 51);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(246, 20);
            this.txtDoc.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(6, 115);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(399, 20);
            this.txtNome.TabIndex = 6;
            // 
            // cbBoxTipo
            // 
            this.cbBoxTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBoxTipo.FormattingEnabled = true;
            this.cbBoxTipo.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.cbBoxTipo.Location = new System.Drawing.Point(6, 50);
            this.cbBoxTipo.Name = "cbBoxTipo";
            this.cbBoxTipo.Size = new System.Drawing.Size(110, 21);
            this.cbBoxTipo.TabIndex = 4;
            this.cbBoxTipo.SelectedIndexChanged += new System.EventHandler(this.frmCadastroPedido_Load);
            // 
            // lbNomeRS
            // 
            this.lbNomeRS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNomeRS.AutoSize = true;
            this.lbNomeRS.Location = new System.Drawing.Point(6, 99);
            this.lbNomeRS.Name = "lbNomeRS";
            this.lbNomeRS.Size = new System.Drawing.Size(35, 13);
            this.lbNomeRS.TabIndex = 3;
            this.lbNomeRS.Text = "Nome";
            // 
            // lbDoc
            // 
            this.lbDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDoc.AutoSize = true;
            this.lbDoc.Location = new System.Drawing.Point(130, 34);
            this.lbDoc.Name = "lbDoc";
            this.lbDoc.Size = new System.Drawing.Size(27, 13);
            this.lbDoc.TabIndex = 2;
            this.lbDoc.Text = "CPF";
            // 
            // lbTipo
            // 
            this.lbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(6, 34);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(28, 13);
            this.lbTipo.TabIndex = 0;
            this.lbTipo.Text = "Tipo";
            // 
            // gpBoxPedido
            // 
            this.gpBoxPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpBoxPedido.Controls.Add(this.dgvPedido);
            this.gpBoxPedido.Controls.Add(this.nUdQtd);
            this.gpBoxPedido.Controls.Add(this.btnRemover);
            this.gpBoxPedido.Controls.Add(this.btnAdd);
            this.gpBoxPedido.Controls.Add(this.lbParcelas);
            this.gpBoxPedido.Controls.Add(this.lbFormaPgto);
            this.gpBoxPedido.Controls.Add(this.label11);
            this.gpBoxPedido.Controls.Add(this.btnCancelar);
            this.gpBoxPedido.Controls.Add(this.btnFinalizar);
            this.gpBoxPedido.Controls.Add(this.cbBoxParcelas);
            this.gpBoxPedido.Controls.Add(this.cbBoxFormaPgto);
            this.gpBoxPedido.Controls.Add(this.lbQuantidade);
            this.gpBoxPedido.Controls.Add(this.lbCor);
            this.gpBoxPedido.Controls.Add(this.lbMaterial);
            this.gpBoxPedido.Controls.Add(this.cbBoxCor);
            this.gpBoxPedido.Controls.Add(this.cbBoxMaterial);
            this.gpBoxPedido.Location = new System.Drawing.Point(21, 195);
            this.gpBoxPedido.Name = "gpBoxPedido";
            this.gpBoxPedido.Size = new System.Drawing.Size(645, 355);
            this.gpBoxPedido.TabIndex = 1;
            this.gpBoxPedido.TabStop = false;
            this.gpBoxPedido.Text = "Pedido";
            this.gpBoxPedido.Visible = false;
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AllowUserToDeleteRows = false;
            this.dgvPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnID,
            this.clnMaterial,
            this.clnCor,
            this.clnEstoque,
            this.clnQtd,
            this.clnVU,
            this.clnVT});
            this.dgvPedido.Location = new System.Drawing.Point(6, 107);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.Size = new System.Drawing.Size(633, 127);
            this.dgvPedido.TabIndex = 31;
            // 
            // clnID
            // 
            this.clnID.HeaderText = "ID";
            this.clnID.Name = "clnID";
            this.clnID.ReadOnly = true;
            this.clnID.Width = 37;
            // 
            // clnMaterial
            // 
            this.clnMaterial.HeaderText = "Material";
            this.clnMaterial.Name = "clnMaterial";
            this.clnMaterial.ReadOnly = true;
            this.clnMaterial.Width = 105;
            // 
            // clnCor
            // 
            this.clnCor.HeaderText = "Cor";
            this.clnCor.Name = "clnCor";
            this.clnCor.ReadOnly = true;
            this.clnCor.Width = 105;
            // 
            // clnEstoque
            // 
            this.clnEstoque.HeaderText = "Estoque";
            this.clnEstoque.Name = "clnEstoque";
            this.clnEstoque.ReadOnly = true;
            this.clnEstoque.Width = 80;
            // 
            // clnQtd
            // 
            this.clnQtd.HeaderText = "Quantidade";
            this.clnQtd.Name = "clnQtd";
            this.clnQtd.ReadOnly = true;
            this.clnQtd.Width = 75;
            // 
            // clnVU
            // 
            this.clnVU.HeaderText = "Valor Unitário";
            this.clnVU.Name = "clnVU";
            this.clnVU.ReadOnly = true;
            this.clnVU.Width = 95;
            // 
            // clnVT
            // 
            this.clnVT.HeaderText = "Valor Total";
            this.clnVT.Name = "clnVT";
            this.clnVT.ReadOnly = true;
            this.clnVT.Width = 90;
            // 
            // nUdQtd
            // 
            this.nUdQtd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nUdQtd.Location = new System.Drawing.Point(532, 29);
            this.nUdQtd.Name = "nUdQtd";
            this.nUdQtd.Size = new System.Drawing.Size(58, 20);
            this.nUdQtd.TabIndex = 30;
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.Location = new System.Drawing.Point(336, 71);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(104, 23);
            this.btnRemover.TabIndex = 28;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(183, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 23);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbParcelas
            // 
            this.lbParcelas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbParcelas.AutoSize = true;
            this.lbParcelas.Location = new System.Drawing.Point(477, 251);
            this.lbParcelas.Name = "lbParcelas";
            this.lbParcelas.Size = new System.Drawing.Size(48, 13);
            this.lbParcelas.TabIndex = 25;
            this.lbParcelas.Text = "Parcelas";
            // 
            // lbFormaPgto
            // 
            this.lbFormaPgto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFormaPgto.AutoSize = true;
            this.lbFormaPgto.Location = new System.Drawing.Point(310, 251);
            this.lbFormaPgto.Name = "lbFormaPgto";
            this.lbFormaPgto.Size = new System.Drawing.Size(108, 13);
            this.lbFormaPgto.TabIndex = 24;
            this.lbFormaPgto.Text = "Forma de Pagamento";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(130, 270);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Total:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(336, 310);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 35);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizar.Location = new System.Drawing.Point(183, 310);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(104, 35);
            this.btnFinalizar.TabIndex = 20;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // cbBoxParcelas
            // 
            this.cbBoxParcelas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBoxParcelas.FormattingEnabled = true;
            this.cbBoxParcelas.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbBoxParcelas.Location = new System.Drawing.Point(480, 267);
            this.cbBoxParcelas.Name = "cbBoxParcelas";
            this.cbBoxParcelas.Size = new System.Drawing.Size(118, 21);
            this.cbBoxParcelas.TabIndex = 19;
            // 
            // cbBoxFormaPgto
            // 
            this.cbBoxFormaPgto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBoxFormaPgto.FormattingEnabled = true;
            this.cbBoxFormaPgto.Items.AddRange(new object[] {
            "",
            "Dinheiro",
            "Cartão de Débito",
            "Cartão de Credito",
            "Cheque"});
            this.cbBoxFormaPgto.Location = new System.Drawing.Point(313, 267);
            this.cbBoxFormaPgto.Name = "cbBoxFormaPgto";
            this.cbBoxFormaPgto.Size = new System.Drawing.Size(143, 21);
            this.cbBoxFormaPgto.TabIndex = 18;
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(461, 34);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lbQuantidade.TabIndex = 16;
            this.lbQuantidade.Text = "Quantidade:";
            // 
            // lbCor
            // 
            this.lbCor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCor.AutoSize = true;
            this.lbCor.Location = new System.Drawing.Point(247, 34);
            this.lbCor.Name = "lbCor";
            this.lbCor.Size = new System.Drawing.Size(26, 13);
            this.lbCor.TabIndex = 15;
            this.lbCor.Text = "Cor:";
            // 
            // lbMaterial
            // 
            this.lbMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMaterial.AutoSize = true;
            this.lbMaterial.Location = new System.Drawing.Point(8, 34);
            this.lbMaterial.Name = "lbMaterial";
            this.lbMaterial.Size = new System.Drawing.Size(47, 13);
            this.lbMaterial.TabIndex = 14;
            this.lbMaterial.Text = "Material:";
            // 
            // cbBoxCor
            // 
            this.cbBoxCor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.cbBoxCor.Location = new System.Drawing.Point(279, 28);
            this.cbBoxCor.Name = "cbBoxCor";
            this.cbBoxCor.Size = new System.Drawing.Size(161, 21);
            this.cbBoxCor.TabIndex = 10;
            // 
            // cbBoxMaterial
            // 
            this.cbBoxMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBoxMaterial.FormattingEnabled = true;
            this.cbBoxMaterial.Items.AddRange(new object[] {
            "Couro",
            "Corino",
            "Tecido"});
            this.cbBoxMaterial.Location = new System.Drawing.Point(61, 28);
            this.cbBoxMaterial.Name = "cbBoxMaterial";
            this.cbBoxMaterial.Size = new System.Drawing.Size(161, 21);
            this.cbBoxMaterial.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.gpBoxCliente);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(666, 177);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // frmCadastroPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 562);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gpBoxPedido);
            this.Name = "frmCadastroPedido";
            this.Text = ".::MZ Sistemas::.                                                       Cadastro " +
    "de Pedido";
            this.Load += new System.EventHandler(this.frmCadastroPedido_Load);
            this.gpBoxCliente.ResumeLayout(false);
            this.gpBoxCliente.PerformLayout();
            this.gpBoxPedido.ResumeLayout(false);
            this.gpBoxPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUdQtd)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpBoxCliente;
        private System.Windows.Forms.GroupBox gpBoxPedido;
        private System.Windows.Forms.Button btnNovoPedido;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbBoxTipo;
        private System.Windows.Forms.Label lbNomeRS;
        private System.Windows.Forms.Label lbDoc;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.ComboBox cbBoxParcelas;
        private System.Windows.Forms.ComboBox cbBoxFormaPgto;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.Label lbCor;
        private System.Windows.Forms.Label lbMaterial;
        private System.Windows.Forms.ComboBox cbBoxCor;
        private System.Windows.Forms.ComboBox cbBoxMaterial;
        private System.Windows.Forms.Label lbParcelas;
        private System.Windows.Forms.Label lbFormaPgto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.NumericUpDown nUdQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnVU;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnVT;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}