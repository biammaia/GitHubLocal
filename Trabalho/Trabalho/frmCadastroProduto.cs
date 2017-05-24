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
    public partial class frmCadastroProduto : Form
    {
        public frmCadastroProduto()
        {
            InitializeComponent();
        }

        private void LimparCampo()
        {
            txtNomeModelo.Text = "";
            cbBoxMaterial.SelectedIndex = -1;
            cbBoxCor.SelectedIndex = -1;
            tctQtidade.Text = "";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            dgvProduto.Rows.Add(txtNomeModelo.Text, cbBoxMaterial.Text, cbBoxCor.Text, tctQtidade.Text);            
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            dgvProduto.Rows.RemoveAt(dgvProduto.CurrentRow.Index);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampo();
        }
    }
}
