using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (pnlCliente.Visible == false)
            {
                pnlCliente.Visible = true;
                btnNewCliente.Visible = true;
                btnConsultaCliente.Visible = true;
                pnlFornecedor.Visible = false;
                btnNewFornecedor.Visible = false;
                btnConsultaFornecedor.Visible = false;
                pnlPedidos.Visible = false;
                btnNewPedido.Visible = false;
                btnConsultaPedido.Visible = false;
                pnlProdutos.Visible = false;
                btnCadastraProduto.Visible = false;
                btnConsultaProduto.Visible = false;
            }

            else
            {
                pnlCliente.Visible = false;
                btnNewCliente.Visible = false;
                btnConsultaCliente.Visible = false;
            }
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            if (pnlFornecedor.Visible == false)
            {
                pnlCliente.Visible = false;
                btnNewCliente.Visible = false;
                btnConsultaCliente.Visible = false;
                pnlFornecedor.Visible = true;
                btnNewFornecedor.Visible = true;
                btnConsultaFornecedor.Visible = true;
                pnlPedidos.Visible = false;
                btnNewPedido.Visible = false;
                btnConsultaPedido.Visible = false;
                pnlProdutos.Visible = false;
                btnCadastraProduto.Visible = false;
                btnConsultaProduto.Visible = false;
            }

            else
            {
                pnlFornecedor.Visible = false;
                btnNewFornecedor.Visible = false;
                btnConsultaFornecedor.Visible = false;
            }

        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            if (pnlPedidos.Visible == false)
            {
                pnlCliente.Visible = false;
                btnNewCliente.Visible = false;
                btnConsultaCliente.Visible = false;
                pnlFornecedor.Visible = false;
                btnNewFornecedor.Visible = false;
                btnConsultaFornecedor.Visible = false;
                pnlPedidos.Visible = true;
                btnNewPedido.Visible = true;
                btnConsultaPedido.Visible = true;
                pnlProdutos.Visible = false;
                btnCadastraProduto.Visible = false;
                btnConsultaProduto.Visible = false;
            }

            else
            {
                pnlPedidos.Visible = false;
                btnNewPedido.Visible = false;
                btnConsultaPedido.Visible = false;
            }

        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            if (pnlProdutos.Visible == false)
            {
                pnlCliente.Visible = false;
                btnNewCliente.Visible = false;
                btnConsultaCliente.Visible = false;
                pnlFornecedor.Visible = false;
                btnNewFornecedor.Visible = false;
                btnConsultaFornecedor.Visible = false;
                pnlPedidos.Visible = false;
                btnNewPedido.Visible = false;
                btnConsultaPedido.Visible = false;
                pnlProdutos.Visible = true;
                btnCadastraProduto.Visible = true;
                btnConsultaProduto.Visible = true;
            }

            else
            {
                pnlProdutos.Visible = false;
                btnCadastraProduto.Visible = false;
                btnConsultaProduto.Visible = false;
            }
        }

        private void btnNewCliente_Click(object sender, EventArgs e)
        {
            frmCadastroClientes frmNC = new frmCadastroClientes();
            frmNC.Show();
        }

        private void btnConsultaCliente_Click(object sender, EventArgs e)
        {
            frmConsultaCliente frmCC = new frmConsultaCliente();
            frmCC.Show();
        }

        private void btnNewFornecedor_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedores frmNF = new frmCadastroFornecedores();
            frmNF.Show();
        }

        private void btnConsultaFornecedor_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor frmCF = new frmConsultaFornecedor();
            frmCF.Show();
        }

        private void btnNewPedido_Click(object sender, EventArgs e)
        {
            frmCadastroPedido frmNP = new frmCadastroPedido();
            frmNP.Show();
        }

        private void btnConsultaPedido_Click(object sender, EventArgs e)
        {
            frmConsultaPedido frmCP = new frmConsultaPedido();
            frmCP.Show();
        }

        private void btnCadastraProduto_Click(object sender, EventArgs e)
        {
            frmCadastroProduto frmCPT = new frmCadastroProduto();
            frmCPT.Show();
        }

        private void btnConsultaProduto_Click(object sender, EventArgs e)
        {
            frmConsultaProduto frmCSPT = new frmConsultaProduto();
            frmCSPT.Show();
        }
    }
}
