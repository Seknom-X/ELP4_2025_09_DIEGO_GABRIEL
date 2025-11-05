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
        public override string Excluir(object obj)
        {
            return aDaoEstados.Excluir(obj);
        }
        public override List<Estados> Listar()
        {
            return aDaoEstados.Listar();
        }
        public override Object CarregaObj(int chave)
        {
            return aDaoEstados.CarregaObj(chave);
        }
        public override List<Estados> Pesquisar(string chave)
        {
            return aDaoEstados.Pesquisar(chave);
        }
    }
}

