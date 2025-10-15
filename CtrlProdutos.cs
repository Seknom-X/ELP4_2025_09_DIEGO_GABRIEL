using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisEstadoCidade
{
    internal class CtrlProdutos : Controller<Produtos>
    {
        ColecoesProdutos aColProdutos;
        public CtrlProdutos()
        {
            aColProdutos = new ColecoesProdutos();
        }
    }
}
