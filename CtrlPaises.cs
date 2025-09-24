using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PaisEstadoCidade
{
    internal class CtrlPaises : Controller
    {
        ColecoesPaises aColPaises;
        public CtrlPaises()
        {
            aColPaises = new ColecoesPaises();
        }
        public override void Salvar(object obj)
        {
            //base.Salvar(obj);
            Paises oPais = (Paises)obj;
            if(oPais.Codigo == 0)
                aColPaises.Inserir((Paises)obj);
            else
            {

            }
        }
    }
}