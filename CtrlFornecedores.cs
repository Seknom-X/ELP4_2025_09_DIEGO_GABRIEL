using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisEstadoCidade
{
    internal class CtrlFornecedores : Controller<Fornecedores>
    {
        ColecoesFornecedores aColFornecedores;
        public CtrlFornecedores()
        {
            aColFornecedores = new ColecoesFornecedores();
        }

    }
}
