using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisEstadoCidade
{
    internal class Produtos
    {
        protected int unidade;
        protected string grupo;
        protected double codigoBarras;
        protected double referencia;
        protected string produto;
        protected Fornecedores oFornecedor;

        public Produtos()
        {
            unidade = 0;
            grupo = string.Empty;
            codigoBarras = 0.0;
            referencia = 0.0;
            produto = string.Empty;
        }
        public Produtos(int unidade, string grupo, double codigoBarras, double referencia, string produto)
        {
            this.unidade = unidade;
            this.grupo = grupo;
            this.codigoBarras = codigoBarras;
            this.referencia = referencia;
            this.produto = produto;
        }
        public int Unidade
        {
            get => unidade;
            set => unidade = value;
        }
        public string Grupo
        {
            get => grupo;
            set => grupo = value;
        }
        public double CodigoBarras
        {
            get => codigoBarras;
            set => codigoBarras = value;
        }
        public double Referencia
        {
            get => referencia;
            set => referencia = value;
        }
        public string Produto
        {
            get => produto;
            set => produto = value;
        }
        public Fornecedores OFornecedor
        {
            get => oFornecedor;
            set => oFornecedor = value;
        }
        public Produtos Clone()
        {
            return new Produtos(this.unidade, this.grupo, this.codigoBarras, this.referencia, this.produto);
        }   
    }
}
