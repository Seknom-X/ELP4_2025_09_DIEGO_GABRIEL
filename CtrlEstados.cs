using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisEstadoCidade
{
    internal class CtrlEstados : Controller
    {
        ColecoesEstados aColEstados;
    public CtrlEstados()
        {
            aColEstados = new ColecoesEstados();
        }
        public override void Salvar(object obj)
        {
            //base.Salvar(obj);
            Estados oEstado = (Estados)obj;
            if (oEstado.Codigo == 0)
                aColEstados.Inserir((Estados)obj);
            else
            {

            }
        }
    }
}
