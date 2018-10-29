using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    class ClassFornecedor
    {
        private int tipofornecedor;       
        private string razaosocial;
        private string nomefantasia;
        private int cnpj;       
        private string endereco;
        private int numero;
        private string bairro;
        private string complemento;        
        private string uf;
        private string cep;
        private int telefone;
        private string email;
        private string materiaprima;

        public int Tipofornecedor
        {
            get
            {
                return tipofornecedor;
            }

            set
            {
                tipofornecedor = value;
            }
        }

        public string Razaosocial
        {
            get
            {
                return razaosocial;
            }

            set
            {
                razaosocial = value;
            }
        }

        public string Nomefantasia
        {
            get
            {
                return nomefantasia;
            }

            set
            {
                nomefantasia = value;
            }
        }

        public int Cnpj
        {
            get
            {
                return cnpj;
            }

            set
            {
                cnpj = value;
            }
        }

        public string Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public string Bairro
        {
            get
            {
                return bairro;
            }

            set
            {
                bairro = value;
            }
        }

        public string Complemento
        {
            get
            {
                return complemento;
            }

            set
            {
                complemento = value;
            }
        }

        public string Uf
        {
            get
            {
                return uf;
            }

            set
            {
                uf = value;
            }
        }

        public string Cep
        {
            get
            {
                return cep;
            }

            set
            {
                cep = value;
            }
        }

        public int Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Materiaprima
        {
            get
            {
                return materiaprima;
            }

            set
            {
                materiaprima = value;
            }
        }
    }
}
