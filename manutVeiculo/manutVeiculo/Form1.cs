﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manutVeiculo
{
    public partial class formPesquisar : Form
    {
        public formPesquisar()
        {
            InitializeComponent();
        }

        private void formPesquisar_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
        }
    }
}
