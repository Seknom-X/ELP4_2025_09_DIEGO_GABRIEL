using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisEstadoCidade
{
    internal class CtrlCidades : Controller<Cidades>
    {
        ColecoesCidades aColCidades;
        DaoCidades aDaoCidades;
        public CtrlCidades()
        {
            aColCidades = new ColecoesCidades();
            aDaoCidades = new DaoCidades();
        }
        public override string Salvar(object obj)
        {
            //base.Salvar(obj);
            Cidades aCidade = (Cidades)obj;
            if (aCidade.Codigo == 0)
                aColCidades.Inserir((Cidades)obj);
            else
            {

            }
            return null;
        }
    }
}
