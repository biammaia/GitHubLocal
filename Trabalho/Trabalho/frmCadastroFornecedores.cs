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
    public partial class frmCadastroFornecedores : Form
    {
        public frmCadastroFornecedores()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTel.Text != "")
            {
                for (int iContador = 0; iContador < listBoxTel2.Items.Count; iContador++)
                {
                    if (listBoxTel2.Items[iContador].ToString() == txtTel.Text)
                    {
                        MessageBox.Show("Telefone já inserido");
                        return;
                    }
                }
                listBoxTel2.Items.Add(txtTel.Text);
                txtTel.Text = "";
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listBoxTel2.Items.Count >= 1)
            {
                if (listBoxTel2.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione um telefone para excluir.");
                    return;
                }
                listBoxTel2.Items.RemoveAt(listBoxTel2.SelectedIndex);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (cbBoxMP.Text != "")
            {
                for (int iContador = 0; iContador < listBoxMP.Items.Count; iContador++)
                {
                    if (listBoxMP.Items[iContador].ToString() == cbBoxMP.Text)
                    {
                        MessageBox.Show("Material já inserido");
                        return;
                    }
                }
                listBoxMP.Items.Add(cbBoxMP.Text);
                cbBoxMP.Text = "";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBoxMP.Items.Count >= 1)
            {
                if (listBoxMP.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione um material para ser excluido.");
                    return;
                }
                listBoxMP.Items.RemoveAt(listBoxMP.SelectedIndex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
