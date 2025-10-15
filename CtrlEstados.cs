using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisEstadoCidade
{
    internal class CtrlEstados : Controller<Estados>
    {
        DaoEstados aDaoEstados;
        ColecoesEstados aColEstados;
    public CtrlEstados()
        {
            aColEstados = new ColecoesEstados();
            aDaoEstados = new DaoEstados();
        }
        public override string Salvar(object obj)
        {
            return aDaoEstados.Salvar(obj);
        }
    }
}
