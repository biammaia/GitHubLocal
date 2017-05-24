namespace Trabalho
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.btnConsultaCliente = new System.Windows.Forms.Button();
            this.btnNewCliente = new System.Windows.Forms.Button();
            this.pnlFornecedor = new System.Windows.Forms.Panel();
            this.btnConsultaFornecedor = new System.Windows.Forms.Button();
            this.btnNewFornecedor = new System.Windows.Forms.Button();
            this.pnlPedidos = new System.Windows.Forms.Panel();
            this.btnConsultaPedido = new System.Windows.Forms.Button();
            this.btnNewPedido = new System.Windows.Forms.Button();
            this.pnlProdutos = new System.Windows.Forms.Panel();
            this.btnConsultaProduto = new System.Windows.Forms.Button();
            this.btnCadastraProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlCliente.SuspendLayout();
            this.pnlFornecedor.SuspendLayout();
            this.pnlPedidos.SuspendLayout();
            this.pnlProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnClientes
            // 
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(95, 126);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(200, 90);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedores.Location = new System.Drawing.Point(95, 233);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(200, 90);
            this.btnFornecedores.TabIndex = 1;
            this.btnFornecedores.Text = "Fornecedores";
            this.btnFornecedores.UseVisualStyleBackColor = true;
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.Location = new System.Drawing.Point(95, 344);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(200, 90);
            this.btnPedidos.TabIndex = 2;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.Location = new System.Drawing.Point(95, 449);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(200, 90);
            this.btnProdutos.TabIndex = 3;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.btnConsultaCliente);
            this.pnlCliente.Controls.Add(this.btnNewCliente);
            this.pnlCliente.Location = new System.Drawing.Point(367, 126);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(200, 90);
            this.pnlCliente.TabIndex = 6;
            this.pnlCliente.Visible = false;
            // 
            // btnConsultaCliente
            // 
            this.btnConsultaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaCliente.Location = new System.Drawing.Point(0, 47);
            this.btnConsultaCliente.Name = "btnConsultaCliente";
            this.btnConsultaCliente.Size = new System.Drawing.Size(200, 43);
            this.btnConsultaCliente.TabIndex = 1;
            this.btnConsultaCliente.Text = "Consultar Cliente";
            this.btnConsultaCliente.UseVisualStyleBackColor = true;
            this.btnConsultaCliente.Visible = false;
            this.btnConsultaCliente.Click += new System.EventHandler(this.btnConsultaCliente_Click);
            // 
            // btnNewCliente
            // 
            this.btnNewCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCliente.Location = new System.Drawing.Point(0, 0);
            this.btnNewCliente.Name = "btnNewCliente";
            this.btnNewCliente.Size = new System.Drawing.Size(200, 43);
            this.btnNewCliente.TabIndex = 0;
            this.btnNewCliente.Text = "Novo Cliente";
            this.btnNewCliente.UseVisualStyleBackColor = true;
            this.btnNewCliente.Visible = false;
            this.btnNewCliente.Click += new System.EventHandler(this.btnNewCliente_Click);
            // 
            // pnlFornecedor
            // 
            this.pnlFornecedor.Controls.Add(this.btnConsultaFornecedor);
            this.pnlFornecedor.Controls.Add(this.btnNewFornecedor);
            this.pnlFornecedor.Location = new System.Drawing.Point(367, 233);
            this.pnlFornecedor.Name = "pnlFornecedor";
            this.pnlFornecedor.Size = new System.Drawing.Size(200, 90);
            this.pnlFornecedor.TabIndex = 7;
            this.pnlFornecedor.Visible = false;
            // 
            // btnConsultaFornecedor
            // 
            this.btnConsultaFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaFornecedor.Location = new System.Drawing.Point(0, 47);
            this.btnConsultaFornecedor.Name = "btnConsultaFornecedor";
            this.btnConsultaFornecedor.Size = new System.Drawing.Size(200, 43);
            this.btnConsultaFornecedor.TabIndex = 1;
            this.btnConsultaFornecedor.Text = "Consultar Fornecedor";
            this.btnConsultaFornecedor.UseVisualStyleBackColor = true;
            this.btnConsultaFornecedor.Visible = false;
            this.btnConsultaFornecedor.Click += new System.EventHandler(this.btnConsultaFornecedor_Click);
            // 
            // btnNewFornecedor
            // 
            this.btnNewFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewFornecedor.Location = new System.Drawing.Point(0, 0);
            this.btnNewFornecedor.Name = "btnNewFornecedor";
            this.btnNewFornecedor.Size = new System.Drawing.Size(200, 43);
            this.btnNewFornecedor.TabIndex = 0;
            this.btnNewFornecedor.Text = "Novo Fornecedor";
            this.btnNewFornecedor.UseVisualStyleBackColor = true;
            this.btnNewFornecedor.Visible = false;
            this.btnNewFornecedor.Click += new System.EventHandler(this.btnNewFornecedor_Click);
            // 
            // pnlPedidos
            // 
            this.pnlPedidos.Controls.Add(this.btnConsultaPedido);
            this.pnlPedidos.Controls.Add(this.btnNewPedido);
            this.pnlPedidos.Location = new System.Drawing.Point(367, 344);
            this.pnlPedidos.Name = "pnlPedidos";
            this.pnlPedidos.Size = new System.Drawing.Size(200, 90);
            this.pnlPedidos.TabIndex = 8;
            this.pnlPedidos.Visible = false;
            // 
            // btnConsultaPedido
            // 
            this.btnConsultaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaPedido.Location = new System.Drawing.Point(0, 47);
            this.btnConsultaPedido.Name = "btnConsultaPedido";
            this.btnConsultaPedido.Size = new System.Drawing.Size(200, 43);
            this.btnConsultaPedido.TabIndex = 1;
            this.btnConsultaPedido.Text = "Consultar Pedido";
            this.btnConsultaPedido.UseVisualStyleBackColor = true;
            this.btnConsultaPedido.Visible = false;
            this.btnConsultaPedido.Click += new System.EventHandler(this.btnConsultaPedido_Click);
            // 
            // btnNewPedido
            // 
            this.btnNewPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPedido.Location = new System.Drawing.Point(0, 0);
            this.btnNewPedido.Name = "btnNewPedido";
            this.btnNewPedido.Size = new System.Drawing.Size(200, 43);
            this.btnNewPedido.TabIndex = 0;
            this.btnNewPedido.Text = "Novo Pedido";
            this.btnNewPedido.UseVisualStyleBackColor = true;
            this.btnNewPedido.Visible = false;
            this.btnNewPedido.Click += new System.EventHandler(this.btnNewPedido_Click);
            // 
            // pnlProdutos
            // 
            this.pnlProdutos.Controls.Add(this.btnConsultaProduto);
            this.pnlProdutos.Controls.Add(this.btnCadastraProduto);
            this.pnlProdutos.Location = new System.Drawing.Point(368, 449);
            this.pnlProdutos.Name = "pnlProdutos";
            this.pnlProdutos.Size = new System.Drawing.Size(200, 90);
            this.pnlProdutos.TabIndex = 9;
            this.pnlProdutos.Visible = false;
            // 
            // btnConsultaProduto
            // 
            this.btnConsultaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaProduto.Location = new System.Drawing.Point(0, 47);
            this.btnConsultaProduto.Name = "btnConsultaProduto";
            this.btnConsultaProduto.Size = new System.Drawing.Size(200, 43);
            this.btnConsultaProduto.TabIndex = 1;
            this.btnConsultaProduto.Text = "Consultar Produto";
            this.btnConsultaProduto.UseVisualStyleBackColor = true;
            this.btnConsultaProduto.Visible = false;
            this.btnConsultaProduto.Click += new System.EventHandler(this.btnConsultaProduto_Click);
            // 
            // btnCadastraProduto
            // 
            this.btnCadastraProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastraProduto.Location = new System.Drawing.Point(0, 0);
            this.btnCadastraProduto.Name = "btnCadastraProduto";
            this.btnCadastraProduto.Size = new System.Drawing.Size(200, 43);
            this.btnCadastraProduto.TabIndex = 0;
            this.btnCadastraProduto.Text = "Cadastrar Produto";
            this.btnCadastraProduto.UseVisualStyleBackColor = true;
            this.btnCadastraProduto.Visible = false;
            this.btnCadastraProduto.Click += new System.EventHandler(this.btnCadastraProduto_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 562);
            this.Controls.Add(this.pnlProdutos);
            this.Controls.Add(this.pnlPedidos);
            this.Controls.Add(this.pnlFornecedor);
            this.Controls.Add(this.pnlCliente);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnFornecedores);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPrincipal";
            this.Text = ".::MZ Sistemas::.                                                               M" +
    "enu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlCliente.ResumeLayout(false);
            this.pnlFornecedor.ResumeLayout(false);
            this.pnlPedidos.ResumeLayout(false);
            this.pnlProdutos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnFornecedores;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Panel pnlFornecedor;
        private System.Windows.Forms.Panel pnlPedidos;
        private System.Windows.Forms.Panel pnlProdutos;
        private System.Windows.Forms.Button btnConsultaCliente;
        private System.Windows.Forms.Button btnNewCliente;
        private System.Windows.Forms.Button btnConsultaFornecedor;
        private System.Windows.Forms.Button btnNewFornecedor;
        private System.Windows.Forms.Button btnConsultaPedido;
        private System.Windows.Forms.Button btnNewPedido;
        private System.Windows.Forms.Button btnConsultaProduto;
        private System.Windows.Forms.Button btnCadastraProduto;
    }
}