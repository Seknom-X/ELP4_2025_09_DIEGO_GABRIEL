using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisEstadoCidade
{
    internal class ColecoesCidades : Colecoes<Cidades>
    {
        public Cidades BuscarPorCidade(string cidade)
        {
            foreach (var aCidade in aLista)
            {
                if (aCidade.Cidade.Equals(cidade, StringComparison.OrdinalIgnoreCase))
                {
                    return aCidade;
                }
            }
            return null;
        }
        public Cidades BuscarPorDDD(string ddd)
        {
            foreach (var aCidade in aLista)
            {
                if (aCidade.Ddd.Equals(ddd, StringComparison.OrdinalIgnoreCase))
                {
                    return aCidade;
                }
            }
            return null;
        }
        public Cidades BuscarPorEstado(string estado)
        {
            foreach (var aCidade in aLista)
            {
                if (aCidade.OEstado != null && aCidade.OEstado.Estado.Equals(estado, StringComparison.OrdinalIgnoreCase))
                {
                    return aCidade;
                }
            }
            return null;
        }
        public override void Imprimir()
        {
            foreach (var aCidade in aLista)
            {
                Console.WriteLine($"Cidade : {aCidade.Cidade}");
                Console.WriteLine($"DDD: {aCidade.Ddd}");
                Console.WriteLine($"Estado  : {aCidade.OEstado?.Estado}");
            }
        }
    }
}
