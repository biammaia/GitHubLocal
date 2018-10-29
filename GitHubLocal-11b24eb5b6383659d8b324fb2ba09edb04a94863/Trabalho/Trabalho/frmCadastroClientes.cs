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
    public partial class frmCadastroClientes : Form
    {
        public frmCadastroClientes()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTel.Text != "")
            {
                 for (int iContador = 0; iContador < listBoxTel.Items.Count; iContador++)
                 {
                     if (listBoxTel.Items[iContador].ToString() == txtTel.Text)
                     {
                         MessageBox.Show("Telefone já inserido");
                         return;
                     }
                 }
                listBoxTel.Items.Add(txtTel.Text);
                 txtTel.Text = "";   
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listBoxTel.Items.Count >= 1)
            {
                if (listBoxTel.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione um telefone para excluir.");
                    return;
                }
                listBoxTel.Items.RemoveAt(listBoxTel.SelectedIndex);
            }
        }

        private void cmBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmBoxTipo.SelectedIndex == 0)
            {
                lbNomeRS.Text = "Nome";
                lbDoc.Text = "CPF";
                txtRG.Enabled = true;
                txtDataNasc.Enabled = true;
                cbBoxSexo.Enabled = true;
                txtNF.Enabled = false;
            }
            else
            {
                lbNomeRS.Text = "Razão Social";
                lbDoc.Text = "CNPJ";
                txtRG.Enabled = false;
                txtDataNasc.Enabled = false;
                cbBoxSexo.Enabled = false;
                txtNF.Enabled = true;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ClassClientes cliente = new ClassClientes();
            cliente.Nome = txtNomeRS.Text;

            if (cliente.Tipocliente == false)
            {
                cliente.Cpf = txtDoc.Text;
                cliente.Rg = txtRG.Text;
            }

            else
            {
                cliente.Cnpj = Convert.ToInt16(txtDoc.Text);               
            }

            cliente.Endereco = txtEndereco.Text;
            cliente.Numero = Convert.ToInt16(txtNumero.Text);
            cliente.Complemento = txtComplemto.Text;
            cliente.Cep = Convert.ToInt16(txtCEP.Text);
            cliente.Bairro = txtBairro.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Uf = cbBoxUF.Text;
            cliente.Telefone = Convert.ToInt32(txtTel.Text);
            cliente.Email = txtEmail.Text;
            cliente.Datanasc = Convert.ToDateTime(txtDataNasc.Text);
            cliente.Outros = txtOutros.Text;

            //Criar conexão com o banco e salvar:
            //cliente.Salvar();
            this.Close(); // Como não há conexão com o banco, o programa é encerrado.
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
