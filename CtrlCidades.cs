using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisEstadoCidade
{
    internal class CtrlCidades : Controller
    {
        ColecoesCidades aColCidades;
        public CtrlCidades()
        {
            aColCidades = new ColecoesCidades();
        }
        public override void Salvar(object obj)
        {
            //base.Salvar(obj);
            Cidades aCidade = (Cidades)obj;
            if (aCidade.Codigo == 0)
                aColCidades.Inserir((Cidades)obj);
            else
            {

            }
        }
    }
}
