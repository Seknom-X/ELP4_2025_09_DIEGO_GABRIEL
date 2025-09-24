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
                if(oPais.Sigla.Equals(sigla, StringComparison.OrdinalIgnoreCase){
                    return oPais;
                }
            }
            return null;
        }
        public override void Imprimir()
        {
            
        }
    }
}
