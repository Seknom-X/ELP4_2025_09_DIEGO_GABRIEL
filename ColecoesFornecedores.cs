using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisEstadoCidade
{
    internal class ColecoesFornecedores : Colecoes<Fornecedores>
    {
        public Fornecedores BuscarPorCnpj(string cnpj)
        {
            foreach (var oFornecedor in aLista)
            {
                if (oFornecedor.Cnpj.Equals(cnpj, StringComparison.OrdinalIgnoreCase))
                {
                    return oFornecedor;
                }
            }
            return null;
        }
        public Fornecedores BuscarPorRazaoSocial(string razaoSocial)
        {
            foreach (var oFornecedor in aLista)
            {
                if (oFornecedor.RazaoSocial.Equals(razaoSocial, StringComparison.OrdinalIgnoreCase))
                {
                    return oFornecedor;
                }
            }
            return null;
        }
        public Fornecedores BuscarPorEmail(string email)
        {
            foreach (var oFornecedor in aLista)
            {
                if (oFornecedor.Email != null && oFornecedor.Email.Equals(email, StringComparison.OrdinalIgnoreCase))
                {
                    return oFornecedor;
                }
            }
            return null;
        }
        public Fornecedores BuscarPorTelefone(string telefone)
        {
            foreach (var oFornecedor in aLista)
            {
                if (oFornecedor.Telefone != null && oFornecedor.Telefone.Equals(telefone, StringComparison.OrdinalIgnoreCase))
                {
                    return oFornecedor;
                }
            }
            return null;
        }
        public Fornecedores BuscarPorEndereco(string endereco)
        {
            foreach (var oFornecedor in aLista)
            {
                if (oFornecedor.Endereco != null && oFornecedor.Endereco.Equals(endereco, StringComparison.OrdinalIgnoreCase))
                {
                    return oFornecedor;
                }
            }
            return null;
        }
        public Fornecedores BuscarPorProduto(string produto)
        {
            foreach (var oFornecedor in aLista)
            {
                if (oFornecedor.OProduto != null && oFornecedor.OProduto.Produto.Equals(produto, StringComparison.OrdinalIgnoreCase))
                {
                    return oFornecedor;
                }
            }
            return null;
        }   
        public Fornecedores BuscarPorContato(string contato)
        {
            foreach (var oFornecedor in aLista)
            {
                if (oFornecedor.Contato != null && oFornecedor.Contato.Equals(contato, StringComparison.OrdinalIgnoreCase))
                {
                    return oFornecedor;
                }
            }
            return null;
        }
        public override void Imprimir()
        {
            foreach (var oFornecedor in aLista)
            {
                Console.WriteLine($"CNPJ : {oFornecedor.Cnpj}");
                Console.WriteLine($"Razao Social : {oFornecedor.RazaoSocial}");
            }
        }
    }
}
