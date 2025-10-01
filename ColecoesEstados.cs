using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisEstadoCidade
{
    internal class ColecoesEstados : Colecoes<Estados>
    {
        public Estados BuscarPorUf(string uf)
        {
            foreach (var oEstado in aLista)
            {
                if (oEstado.Uf.Equals(uf, StringComparison.OrdinalIgnoreCase))
                {
                    return oEstado;
                }
            }
            return null;
        }
        public Estados BuscarPorEstado(string estado)
        {
            foreach (var oEstado in aLista)
            {
                if (oEstado.Estado.Equals(estado, StringComparison.OrdinalIgnoreCase))
                {
                    return oEstado;
                }
            }
            return null;
        }
        public Estados BuscarPorPais(string pais)
        {
            foreach (var oEstado in aLista)
            {
                if (oEstado.OPais != null && oEstado.OPais.Pais.Equals(pais, StringComparison.OrdinalIgnoreCase))
                {
                    return oEstado;
                }
            }
            return null;
        }
        public override void Imprimir()
        {
            foreach (var oEstado in aLista)
            {
                Console.WriteLine($"Codigo : {oEstado.Codigo}");
                Console.WriteLine($"Estado : {oEstado.Estado}");
                Console.WriteLine($"Uf: {oEstado.Uf}");
                Console.WriteLine($"Pais  : {oEstado.OPais}");
                
            }
        }
    }
}
