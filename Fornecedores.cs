using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisEstadoCidade
{
    internal class Fornecedores
    {
        protected string cnpj;
        protected string razaoSocial;
        protected string endereco;
        protected string telefone;
        protected string email;
        protected string contato;
        protected Produtos oProduto;

        public string Cnpj
        {
            get => cnpj;
            set => cnpj = value;
        }
        public string RazaoSocial
        {
            get => razaoSocial;
            set => razaoSocial = value;
        }
        public string Endereco
        {
            get => endereco;
            set => endereco = value;
        }
        public string Telefone
        {
            get => telefone;
            set => telefone = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public string Contato
        {
            get => contato;
            set => contato = value;
        }
        public Produtos OProduto
        {
            get => oProduto;
            set => oProduto = value;
        }
        public Fornecedores()
        {
            cnpj = string.Empty;
            razaoSocial = string.Empty;
            endereco = string.Empty;
            telefone = string.Empty;
            email = string.Empty;
            contato = string.Empty;
            oProduto = new Produtos();  
        }
        public Fornecedores(string cnpj, string razaoSocial, string endereco,string telefone, string email, string contato, Fornecedores fornecedores, Produtos oProduto)
        {
            this.cnpj = cnpj;
            this.razaoSocial = razaoSocial;
            this.endereco = string.Empty;
            this.telefone = string.Empty;
            this.email = string.Empty;
            this.contato = string.Empty;
            this.oProduto = new Produtos();
        }
        public Fornecedores Clone()
        {
            return new Fornecedores(this.cnpj, this.razaoSocial, this.endereco, this.telefone, this.email, this.contato, this,oProduto);
        }
    }
}
