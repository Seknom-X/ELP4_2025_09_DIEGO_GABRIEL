using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisEstadoCidade
{
    internal class ColecoesPaises :Colecoes<Paises>
    {
        public Paises BuscarPorSigla(string sigla)
        {
            foreach(var oPais in aLista)
            {
                if(oPais.Sigla.Equals(sigla, StringComparison.OrdinalIgnoreCase)){
                    return oPais;
                }
            }
            return null;
        }
        public Paises BuscarPorPais(string pais)
        {
            foreach (var oPais in aLista)
            {
                if (oPais.Pais.Equals(pais, StringComparison.OrdinalIgnoreCase))
                {
                    return oPais;
                }
            }
            return null;
        }
        public Paises BuscarPorDdi(string ddi)
        {
            foreach (var oPais in aLista)
            {
                if (oPais.Ddi.Equals(ddi, StringComparison.OrdinalIgnoreCase))
                {
                    return oPais;
                }
            }
            return null;
        }
        public Paises BuscarPorMoeda(string moeda)
        {
            foreach (var oPais in aLista)
            {
                if (oPais.Moeda.Equals(moeda, StringComparison.OrdinalIgnoreCase))
                {
                    return oPais;
                }
            }
            return null;
        }
        public override void Imprimir()
        {
            foreach (var oPais in aLista)
            {
                Console.WriteLine($"Codigo : {oPais.Codigo}");
                Console.WriteLine($"Pais : {oPais.Pais}");
                Console.WriteLine($"Sigla: {oPais.Sigla}");
                Console.WriteLine($"DDI  : {oPais.Ddi}");
                Console.WriteLine($"Moeda: {oPais.Moeda}");

            }            
        }
    }
}
