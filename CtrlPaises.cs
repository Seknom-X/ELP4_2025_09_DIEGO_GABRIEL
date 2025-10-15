using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PaisEstadoCidade
{
    internal class CtrlPaises : Controller<Paises>
    {
        ColecoesPaises aColPaises;
        DaoPaises aDaoPaises;
        public CtrlPaises()
        {
            aColPaises = new ColecoesPaises();
            aDaoPaises = new DaoPaises();
        }
        public override string Salvar(object obj)
        {
            //base.Salvar(obj);
            return aDaoPaises.Salvar(obj);
            
        }
    }
}