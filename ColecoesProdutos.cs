using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisEstadoCidade
{
    internal class ColecoesProdutos : Colecoes<Produtos>
    {
        public Produtos BuscarPorCodigoBarras(string codigo)
        {
            foreach (var oProduto in aLista)
            {
                // Convert oProduto.CodigoBarras to string for comparison
                if (oProduto.CodigoBarras.ToString().Equals(codigo, StringComparison.OrdinalIgnoreCase))
                {
                    return oProduto;
                }
            }
            return null;
        }
        public Produtos BuscarPorUnidade(string unidade)
        {
            foreach (var oProduto in aLista)
            {
                if (oProduto.Unidade.ToString().Equals(unidade, StringComparison.OrdinalIgnoreCase))
                {
                    return oProduto;
                }
            }
            return null;
        }
        public Produtos BuscarPorGrupo(string grupo)
        {
            foreach (var oProduto in aLista)
            {
                if (oProduto.Grupo.Equals(grupo, StringComparison.OrdinalIgnoreCase))
                {
                    return oProduto;
                }
            }
            return null;
        }
        public Produtos BuscarPorReferencia(string referencia)
        {
            foreach (var oProduto in aLista)
            {
                if (oProduto.Referencia.ToString().Equals(referencia, StringComparison.OrdinalIgnoreCase))
                {
                    return oProduto;
                }
            }
            return null;
        }
        public Produtos BuscarPorProduto(string produto)
        {
            foreach (var oProduto in aLista)
            {
                if (oProduto.Produto.Equals(produto, StringComparison.OrdinalIgnoreCase))
                {
                    return oProduto;
                }
            }
            return null;
        }
        public override void Imprimir()
        {
            foreach (var oProduto in aLista)
            {
                Console.WriteLine($"Codigo : {oProduto.CodigoBarras}");
                Console.WriteLine($"Descricao : {oProduto.Unidade}");
                Console.WriteLine($"Grupo: {oProduto.Grupo}");
                Console.WriteLine($"Referencia  : {oProduto.Referencia}");
                Console.WriteLine($"Produto  : {oProduto.Produto}");
                Console.WriteLine($"Fornecedor  : {oProduto.OFornecedor?.RazaoSocial}");
            }
        }
    }
}
