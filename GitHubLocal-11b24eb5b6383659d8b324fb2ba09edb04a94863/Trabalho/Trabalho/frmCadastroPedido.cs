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
    public partial class frmCadastroPedido : Form
    {
        public frmCadastroPedido()
        {
            InitializeComponent();
        }

        private void frmCadastroPedido_Load(object sender, EventArgs e)
        {
            if (cbBoxTipo.SelectedIndex == 0)
            {
                lbNomeRS.Text = "Nome";
                lbDoc.Text = "CPF";            
            }
            else
            {
                lbNomeRS.Text = "Razão Social";
                lbDoc.Text = "CNPJ";               
            }
        }


        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private int RandomId()
        {
            Random random = new Random();
            return random.Next(100);
        }
       

        private void LimparCampo()
        {
            cbBoxMaterial.SelectedIndex = -1;
            cbBoxCor.SelectedIndex = -1;
            nUdQtd.TabIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             string id = RandomId().ToString();
           
           /* DataColumn clnID = new DataColumn();
            clnID.DataType = System.Type.GetType("System.Int32");
            clnID.AutoIncrement = true;
            clnID.AutoIncrementSeed = 1000;
            clnID.AutoIncrementStep = 10;
            
            DataTable table = new DataTable("table");
            table.Columns.Add(clnID);
            */
            
            dgvPedido.Rows.Add(id, cbBoxMaterial.Text, cbBoxCor.Text, nUdQtd.Text);
            LimparCampo();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastroClientes frmNC = new frmCadastroClientes();
            frmNC.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultaCliente frmCC = new frmConsultaCliente();
            frmCC.Show();
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            gpBoxPedido.Visible = true;
        }
    }
}
