using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    class ClassPedido
    {
        private bool tipocliente;
        private string cpf;
        private string nome;
        private string material;
        private string cor;
        private int quantidade;
        private int valor;
        private int formapagamento;
        private int parcelas;

        public bool Tipocliente
        {
            get
            {
                return tipocliente;
            }

            set
            {
                tipocliente = value;
            }
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Material
        {
            get
            {
                return material;
            }

            set
            {
                material = value;
            }
        }

        public string Cor
        {
            get
            {
                return cor;
            }

            set
            {
                cor = value;
            }
        }

        public int Quantidade
        {
            get
            {
                return quantidade;
            }

            set
            {
                quantidade = value;
            }
        }

        public int Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public int Formapagamento
        {
            get
            {
                return formapagamento;
            }

            set
            {
                formapagamento = value;
            }
        }

        public int Parcelas
        {
            get
            {
                return parcelas;
            }

            set
            {
                parcelas = value;
            }
        }
    }
}
